using System;
using System.Drawing;
using System.Windows.Forms;

namespace GymApp.Forms
{
    public partial class FrmDashboard : Form
    {
        public FrmDashboard()
        {
            InitializeComponent();
            BuildMenu();
        }

        private void BuildMenu()
        {
            AddMenuButton("Members", BtnMembers_Click);
            AddMenuButton("Subscriptions", BtnSubscriptions_Click);
            AddMenuButton("Payments", BtnPayments_Click);
            AddMenuButton("Attendance", BtnAttendance_Click);
            AddMenuButton("Reports", BtnReports_Click);
        }

        private void AddMenuButton(string text, EventHandler click)
        {
            Button btn = new Button();
            btn.Text = text;
            btn.Dock = DockStyle.Top;
            btn.Height = 50;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            btn.ForeColor = Color.White;
            btn.BackColor = Color.FromArgb(52, 58, 64);
            btn.TextAlign = ContentAlignment.MiddleLeft;
            btn.Padding = new Padding(20, 0, 0, 0);

            btn.MouseEnter += (s, e) =>
                btn.BackColor = Color.FromArgb(73, 80, 87);

            btn.MouseLeave += (s, e) =>
                btn.BackColor = Color.FromArgb(52, 58, 64);

            btn.Click += click;
            panelMenu.Controls.Add(btn);
        }

        private void OpenForm(Form frm)
        {
            panelMain.Controls.Clear();
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            panelMain.Controls.Add(frm);
            frm.Show();
        }

        private void BtnMembers_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Members";
            OpenForm(new FrmAddMember());
        }

        private void BtnSubscriptions_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Subscriptions";
            OpenForm(new FrmSubscriptions());
        }

        private void BtnPayments_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Payments";
            OpenForm(new PaymentForm());
        }

        private void BtnAttendance_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Attendance";
            OpenForm(new FrmAttendance());
        }

        private void BtnReports_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Reports";
            OpenForm(new FrmReports());
        }
    }
}
