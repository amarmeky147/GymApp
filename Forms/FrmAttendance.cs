using System;
using System.ComponentModel;
using System.Windows.Forms;
using GymApp.Helpers_1;

namespace GymApp.Forms
{
    public partial class FrmAttendance : Form
    {
        GymRepository repo = new GymRepository();

        public FrmAttendance()
        {
            InitializeComponent();
        }

       
        private void FrmAttendance_Load(object sender, EventArgs e)
        {
            dgvAttendance.DataSource = null;
        }

        
        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            int memberId;

            if (!int.TryParse(txtMemberID.Text, out memberId))
            {
                MessageBox.Show("Please enter a valid Member ID");
                return;
            }

            bool success = repo.CheckInMember(memberId);

            if (success)
            {
                MessageBox.Show("Attendance recorded successfully");
                LoadAttendance(memberId);
            }
            else
            {
                MessageBox.Show("Member has no active subscription or is inactive");
            }
        }

        
        private void LoadAttendance(int memberId)
        {
           
            dgvAttendance.DataSource = repo.GetAttendanceByMember(memberId);

            
            if (dgvAttendance.Columns.Contains("AttendanceID"))
            {
                dgvAttendance.Sort(
                    dgvAttendance.Columns["AttendanceID"],
                    ListSortDirection.Ascending
                );
            }

            
            foreach (DataGridViewColumn col in dgvAttendance.Columns)
            {
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

           
            dgvAttendance.ClearSelection();
        }

        
        private void dgvAttendance_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void pnlHeader_Paint(object sender, PaintEventArgs e)
        {
        }

        private void pnlContent_Paint(object sender, PaintEventArgs e)
        {
        }

        private void panelContent_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}
