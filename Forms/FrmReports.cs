using System;
using System.Data;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using GymApp.Helpers_1;

namespace GymApp.Forms
{
    public partial class FrmReports : Form
    {
        public FrmReports()
        {
            InitializeComponent();
        }

        private void FrmReports_Load(object sender, EventArgs e)
        {
            try
            {
                LoadAllReports();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }

       
        private void LoadAllReports()
        {
            LoadActiveMembers();
            LoadPayments();
            LoadAttendance();
            LoadExpiredSubscriptions();
            LoadRevenue();
            LoadStatistics();
        }

        
        private void LoadActiveMembers()
        {
            using (SqlConnection con = new SqlConnection(DbConfig.Conn))
            {
                SqlDataAdapter da = new SqlDataAdapter(
                    "SELECT MemberID, FullName, Phone, Email FROM Members WHERE IsActive = 1", con);

                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvActiveMembers.DataSource = dt;
            }

            dgvActiveMembers.ClearSelection();
        }

       
        private void LoadPayments()
        {
            using (SqlConnection con = new SqlConnection(DbConfig.Conn))
            {
                SqlDataAdapter da = new SqlDataAdapter(@"
                    SELECT 
                        p.PaymentID,
                        m.FullName AS Member,
                        p.Amount,
                        p.PaymentMethod,
                        p.PaymentDate
                    FROM Payments p
                    INNER JOIN Members m ON p.MemberID = m.MemberID", con);

                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvPayments.DataSource = dt;
            }

            dgvPayments.ClearSelection();
        }

        
        private void LoadAttendance()
        {
            using (SqlConnection con = new SqlConnection(DbConfig.Conn))
            {
                SqlDataAdapter da = new SqlDataAdapter(@"
                    SELECT 
                        a.AttendanceID,
                        m.FullName AS Member,
                        a.CheckInDate
                    FROM Attendance a
                    INNER JOIN Members m ON a.MemberID = m.MemberID", con);

                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvAttendance.DataSource = dt;
            }

            dgvAttendance.ClearSelection();
        }

        
        private void LoadExpiredSubscriptions()
        {
            using (SqlConnection con = new SqlConnection(DbConfig.Conn))
            {
                SqlDataAdapter da = new SqlDataAdapter(@"
                    SELECT 
                        s.SubscriptionID,
                        m.FullName AS Member,
                        s.StartDate,
                        s.EndDate
                    FROM Subscriptions s
                    INNER JOIN Members m ON s.MemberID = m.MemberID
                    WHERE s.EndDate < GETDATE()", con);

                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvExpiredSubscriptions.DataSource = dt;
            }

            dgvExpiredSubscriptions.ClearSelection();
        }

        
        private void LoadRevenue()
        {
            using (SqlConnection con = new SqlConnection(DbConfig.Conn))
            {
                SqlDataAdapter da = new SqlDataAdapter(@"
                    SELECT 
                        CAST(PaymentDate AS DATE) AS Date,
                        SUM(Amount) AS TotalRevenue
                    FROM Payments
                    GROUP BY CAST(PaymentDate AS DATE)
                    ORDER BY Date", con);

                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvRevenue.DataSource = dt;
            }

            dgvRevenue.ClearSelection();
        }

        
        private void LoadStatistics()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Metric");
            dt.Columns.Add("Value");

            using (SqlConnection con = new SqlConnection(DbConfig.Conn))
            {
                con.Open();

                dt.Rows.Add("Total Members",
                    ExecuteScalar(con, "SELECT COUNT(*) FROM Members"));

                dt.Rows.Add("Active Members",
                    ExecuteScalar(con, "SELECT COUNT(*) FROM Members WHERE IsActive = 1"));

                dt.Rows.Add("Total Payments",
                    ExecuteScalar(con, "SELECT COUNT(*) FROM Payments"));

                dt.Rows.Add("Total Revenue",
                    ExecuteScalar(con, "SELECT ISNULL(SUM(Amount),0) FROM Payments"));
            }

            dgvStatistics.DataSource = dt;
            dgvStatistics.ClearSelection();
        }

        private object ExecuteScalar(SqlConnection con, string query)
        {
            SqlCommand cmd = new SqlCommand(query, con);
            return cmd.ExecuteScalar();
        }

        
        private void btnExportAll_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "CSV Files (*.csv)|*.csv";
            sfd.FileName = "GymReports.csv";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                ExportGrid(dgvActiveMembers, sfd.FileName);
                MessageBox.Show("Exported successfully ✅");
            }
        }

        private void ExportGrid(DataGridView dgv, string path)
        {
            using (StreamWriter sw = new StreamWriter(path, false, Encoding.UTF8))
            {
                for (int i = 0; i < dgv.Columns.Count; i++)
                {
                    sw.Write(dgv.Columns[i].HeaderText);
                    if (i < dgv.Columns.Count - 1) sw.Write(",");
                }
                sw.WriteLine();

                foreach (DataGridViewRow row in dgv.Rows)
                {
                    if (row.IsNewRow) continue;
                    for (int i = 0; i < dgv.Columns.Count; i++)
                    {
                        sw.Write(row.Cells[i].Value?.ToString());
                        if (i < dgv.Columns.Count - 1) sw.Write(",");
                    }
                    sw.WriteLine();
                }
            }
        }

        
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
