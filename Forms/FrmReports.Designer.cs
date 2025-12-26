using System;
using System.Drawing;
using System.Windows.Forms;

namespace GymApp.Forms
{
    partial class FrmReports
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Designer

        private Panel panelHeader;
        private Label lblTitle;
        private Panel headerLine;

        private TabControl tabControl1;
        private TabPage tpActiveMembers;
        private TabPage tpPayments;
        private TabPage tpAttendance;
        private TabPage tpExpiredSubscriptions;
        private TabPage tpRevenue;
        private TabPage tpStatistics;

        private DataGridView dgvActiveMembers;
        private DataGridView dgvPayments;
        private DataGridView dgvAttendance;
        private DataGridView dgvExpiredSubscriptions;
        private DataGridView dgvRevenue;
        private DataGridView dgvStatistics;

        private Button btnExportAll;
        private Button btnClose;

        private void InitializeComponent()
        {
            // ================= HEADER =================
            panelHeader = new Panel();
            lblTitle = new Label();
            headerLine = new Panel();

            panelHeader.Dock = DockStyle.Top;
            panelHeader.Height = 65;
            panelHeader.BackColor = Color.FromArgb(20, 20, 20);

            lblTitle.AutoSize = true;
            lblTitle.Text = "Reports";
            lblTitle.ForeColor = Color.White;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.Location = new Point(25, 18);

            headerLine.Dock = DockStyle.Bottom;
            headerLine.Height = 1;
            headerLine.BackColor = Color.FromArgb(60, 60, 60);

            panelHeader.Controls.Add(lblTitle);
            panelHeader.Controls.Add(headerLine);

            // ================= TAB CONTROL =================
            tabControl1 = new TabControl();
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);

            tpActiveMembers = new TabPage("Active Members");
            tpPayments = new TabPage("Payments");
            tpAttendance = new TabPage("Attendance");
            tpExpiredSubscriptions = new TabPage("Expired Subscriptions");
            tpRevenue = new TabPage("Revenue");
            tpStatistics = new TabPage("Statistics");

            tabControl1.Controls.AddRange(new TabPage[]
            {
                tpActiveMembers,
                tpPayments,
                tpAttendance,
                tpExpiredSubscriptions,
                tpRevenue,
                tpStatistics
            });

            dgvActiveMembers = CreateGrid();
            dgvPayments = CreateGrid();
            dgvAttendance = CreateGrid();
            dgvExpiredSubscriptions = CreateGrid();
            dgvRevenue = CreateGrid();
            dgvStatistics = CreateGrid();

            tpActiveMembers.Controls.Add(dgvActiveMembers);
            tpPayments.Controls.Add(dgvPayments);
            tpAttendance.Controls.Add(dgvAttendance);
            tpExpiredSubscriptions.Controls.Add(dgvExpiredSubscriptions);
            tpRevenue.Controls.Add(dgvRevenue);
            tpStatistics.Controls.Add(dgvStatistics);

            // ================= FOOTER BUTTONS =================
            btnExportAll = new Button();
            btnClose = new Button();

            btnExportAll.Text = "Export All";
            btnExportAll.Size = new Size(120, 35);
            btnExportAll.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnExportAll.Location = new Point(15, 680);

            btnClose.Text = "Close";
            btnClose.Size = new Size(120, 35);
            btnClose.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnClose.Location = new Point(1060, 680);

            // ================= FORM =================
            ClientSize = new Size(1200, 720);
            StartPosition = FormStartPosition.CenterScreen;
            WindowState = FormWindowState.Maximized;
            Text = "Gym Reports";

            Controls.Add(tabControl1);
            Controls.Add(panelHeader);
            Controls.Add(btnExportAll);
            Controls.Add(btnClose);

            Load += FrmReports_Load;
        }

        private DataGridView CreateGrid()
        {
            DataGridView dgv = new DataGridView();

            dgv.Dock = DockStyle.Fill;
            dgv.ReadOnly = true;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.AllowUserToOrderColumns = false;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.BackgroundColor = Color.White;
            dgv.BorderStyle = BorderStyle.None;
            dgv.EnableHeadersVisualStyles = false;
            dgv.RowHeadersVisible = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.RowTemplate.Height = 32;

            // ===== Header (زي Attendance) =====
            dgv.ColumnHeadersDefaultCellStyle.BackColor =
                Color.FromArgb(20, 20, 20);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 10F, FontStyle.Bold);

            // يمنع اللون الأزرق عند الضغط على العنوان
            dgv.ColumnHeadersDefaultCellStyle.SelectionBackColor =
                Color.FromArgb(20, 20, 20);
            dgv.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White;

            // ===== Rows =====
            dgv.DefaultCellStyle.Font =
                new Font("Segoe UI", 9F);

            dgv.DefaultCellStyle.SelectionBackColor =
                Color.FromArgb(0, 180, 216);
            dgv.DefaultCellStyle.SelectionForeColor = Color.White;

            dgv.AlternatingRowsDefaultCellStyle.BackColor =
                Color.FromArgb(245, 245, 245);

            return dgv;
        }

        #endregion
    }
}
