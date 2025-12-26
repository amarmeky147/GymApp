using GymApp.Helpers_1;
using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;
using System.Xml.Linq;

namespace GymApp.Forms
{
    public partial class FrmAddMember : Form
    {
        public FrmAddMember()
        {
            InitializeComponent();
        }

        private void FrmAddMember_Load(object sender, EventArgs e)
        {
            LoadMembers();
        }

     
        private void LoadMembers()
        {
            using (SqlConnection con = new SqlConnection(DbConfig.Conn))
            {
                SqlDataAdapter da = new SqlDataAdapter(
                    "SELECT MemberID, FullName, Phone, Email FROM Members", con);

                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
                dataGridView1.ReadOnly = true;
                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            
            if (dataGridView1.Columns.Contains("MemberID"))
            {
                dataGridView1.Sort(
                    dataGridView1.Columns["MemberID"],
                    System.ComponentModel.ListSortDirection.Ascending
                );
            }

            
            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            
            dataGridView1.ClearSelection();
        }
        





        // زر الإضافة
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtPhone.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Please enter Name, Phone and Email",
                    "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection con = new SqlConnection(DbConfig.Conn))
            {
                string query = @"
                    INSERT INTO Members (FullName, Phone, Email)
                    VALUES (@name, @phone, @email)";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@name", txtName.Text.Trim());
                cmd.Parameters.AddWithValue("@phone", txtPhone.Text.Trim());
                cmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim());

                con.Open();
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Member added successfully ✅",
                "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtName.Clear();
            txtPhone.Clear();
            txtEmail.Clear();

            LoadMembers();
        }

        private void cardMember_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
