using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using GymApp.Models;

namespace GymApp.Forms
{
    public partial class FrmSubscriptions : Form
    {
        
        private readonly string _connectionString =
            "Server=.;Database=GymDB;Trusted_Connection=True;TrustServerCertificate=True";

        public FrmSubscriptions()
        {
            InitializeComponent();
            LoadMembers();
            LoadTypes();
        }

        private SqlConnection GetConnection()
        {
            return new SqlConnection(_connectionString);
        }
        private void LoadMembers()
        {
            cbMembers.Items.Clear();

            using (SqlConnection con = GetConnection())
            using (SqlCommand cmd = new SqlCommand(
                "SELECT MemberID, 'ID ' + CAST(MemberID AS varchar) + ': ' + FullName AS DisplayName FROM Members WHERE IsActive = 1",
                con))
            {
                con.Open();
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        cbMembers.Items.Add(
                            new ComboBoxItem(
                                dr["DisplayName"].ToString(),   
                                Convert.ToInt32(dr["MemberID"]) 
                            )
                        );
                    }
                }
            }
        }

        private void LoadTypes()
        {
            cbTypes.Items.Clear();

            using (SqlConnection con = GetConnection())
            using (SqlCommand cmd =
                new SqlCommand("SELECT TypeID, Name FROM MembershipTypes", con))
            {
                con.Open();
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        cbTypes.Items.Add(
                            new ComboBoxItem(
                                dr["Name"].ToString(),
                                Convert.ToInt32(dr["TypeID"])
                            )
                        );
                    }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cbMembers.SelectedItem == null || cbTypes.SelectedItem == null)
            {
                MessageBox.Show("Please select member and subscription type");
                return;
            }

            int memberId = ((ComboBoxItem)cbMembers.SelectedItem).Value;
            int typeId = ((ComboBoxItem)cbTypes.SelectedItem).Value;

            using (SqlConnection con = GetConnection())
            using (SqlCommand cmd = new SqlCommand("sp_CreateSubscription", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@MemberID", memberId);
                cmd.Parameters.AddWithValue("@TypeID", typeId);
                cmd.Parameters.AddWithValue("@StartDate", dtStart.Value.Date);

                SqlParameter outId = new SqlParameter("@NewSubscriptionID", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output
                };
                cmd.Parameters.Add(outId);

                con.Open();
                cmd.ExecuteNonQuery();

                int newSubId = Convert.ToInt32(outId.Value);

                MessageBox.Show(
                    newSubId > 0
                        ? "Subscription created successfully ✔"
                        : "Failed to create subscription ❌"
                );
            }
        }
    }
}
