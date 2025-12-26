using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using GymApp.Helpers_1;

namespace GymApp.Forms
{
    public partial class PaymentForm : Form
    {
        public PaymentForm()
        {
            InitializeComponent();
            this.Load += PaymentForm_Load;
            btnPay.Click += btnPay_Click;
            btnClear.Click += btnClear_Click;
        }

        private void PaymentForm_Load(object sender, EventArgs e)
        {
            LoadMembers();
            LoadPayments();
        }

        private void LoadMembers()
        {
            using (SqlConnection con = new SqlConnection(DbConfig.Conn))
            {
                SqlDataAdapter da = new SqlDataAdapter(
                    "SELECT MemberID, 'ID ' +CAST(MemberID AS varchar) + ': ' + FullName AS DisplayName FROM Members",
                    con
                );

                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbMember.DataSource = dt;
                cmbMember.DisplayMember = "DisplayName";
                cmbMember.ValueMember = "MemberID";
                cmbMember.SelectedIndex = -1;
            }
        }


        private void LoadPayments()
        {
            using (SqlConnection con = new SqlConnection(DbConfig.Conn))
            {
                SqlDataAdapter da = new SqlDataAdapter(
                    @"SELECT 
                p.PaymentID,
                m.FullName AS Member,
                p.Amount,
                p.PaymentMethod,
                p.PaymentDate
              FROM Payments p
              INNER JOIN Members m 
                ON p.MemberID = m.MemberID
              ORDER BY p.PaymentID ASC", con);

                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvPayments.DataSource = dt;
            }

            
            foreach (DataGridViewColumn col in dgvPayments.Columns)
            {
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
            }


            dgvPayments.ClearSelection();
        }


        private void btnPay_Click(object sender, EventArgs e)
        {
            if (cmbMember.SelectedIndex == -1 ||
                string.IsNullOrWhiteSpace(txtAmount.Text) ||
                cmbPaymentMethod.SelectedIndex == -1)
            {
                MessageBox.Show("Please complete all fields");
                return;
            }

            if (!decimal.TryParse(txtAmount.Text, out decimal amount))
            {
                MessageBox.Show("Amount must be numeric");
                return;
            }

            using (SqlConnection con = new SqlConnection(DbConfig.Conn))
            {
                SqlCommand cmd = new SqlCommand(
                    @"INSERT INTO Payments (MemberID, Amount, PaymentMethod, PaymentDate)
                      VALUES (@member, @amount, @method, @date)", con);

                cmd.Parameters.AddWithValue("@member", cmbMember.SelectedValue);
                cmd.Parameters.AddWithValue("@amount", amount);
                cmd.Parameters.AddWithValue("@method", cmbPaymentMethod.Text);
                cmd.Parameters.AddWithValue("@date", dateTimePicker1.Value);

                con.Open();
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Payment added successfully ✅");
            LoadPayments();
            ClearFields();
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            cmbMember.SelectedIndex = -1;
            txtAmount.Clear();
            cmbPaymentMethod.SelectedIndex = -1;
            dateTimePicker1.Value = DateTime.Now;
        }

        private void panelContent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cardPayment_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
