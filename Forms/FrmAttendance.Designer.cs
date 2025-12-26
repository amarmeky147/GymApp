using System.Drawing;
using System.Windows.Forms;

namespace GymApp.Forms
{
    partial class FrmAttendance
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panelHeader = new Panel();
            lblTitle = new Label();
            headerLine = new Panel();
            panelContent = new Panel();
            cardAttendance = new Panel();
            lblCardTitle = new Label();
            lblMemberID = new Label();
            txtMemberID = new TextBox();
            btnCheckIn = new Button();
            dgvAttendance = new DataGridView();
            panelHeader.SuspendLayout();
            panelContent.SuspendLayout();
            cardAttendance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAttendance).BeginInit();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(20, 20, 20);
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Controls.Add(headerLine);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(282, 65);
            panelHeader.TabIndex = 1;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(25, 18);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(179, 41);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Attendance";
            // 
            // headerLine
            // 
            headerLine.BackColor = Color.FromArgb(60, 60, 60);
            headerLine.Dock = DockStyle.Bottom;
            headerLine.Location = new Point(0, 64);
            headerLine.Name = "headerLine";
            headerLine.Size = new Size(282, 1);
            headerLine.TabIndex = 1;
            // 
            // panelContent
            // 
            panelContent.BackColor = Color.Transparent;
            panelContent.Controls.Add(cardAttendance);
            panelContent.Controls.Add(dgvAttendance);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(0, 65);
            panelContent.Name = "panelContent";
            panelContent.Padding = new Padding(25);
            panelContent.Size = new Size(282, 188);
            panelContent.TabIndex = 0;
            panelContent.Paint += panelContent_Paint;
            // 
            // cardAttendance
            // 
            cardAttendance.BackColor = Color.White;
            cardAttendance.BorderStyle = BorderStyle.FixedSingle;
            cardAttendance.Controls.Add(lblCardTitle);
            cardAttendance.Controls.Add(lblMemberID);
            cardAttendance.Controls.Add(txtMemberID);
            cardAttendance.Controls.Add(btnCheckIn);
            cardAttendance.Location = new Point(25, 25);
            cardAttendance.Name = "cardAttendance";
            cardAttendance.Size = new Size(380, 220);
            cardAttendance.TabIndex = 0;
            // 
            // lblCardTitle
            // 
            lblCardTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblCardTitle.Location = new Point(15, 15);
            lblCardTitle.Name = "lblCardTitle";
            lblCardTitle.Size = new Size(100, 23);
            lblCardTitle.TabIndex = 0;
            lblCardTitle.Text = "Check In Member";
            // 
            // lblMemberID
            // 
            lblMemberID.Font = new Font("Segoe UI", 10F);
            lblMemberID.ForeColor = Color.FromArgb(55, 55, 55);
            lblMemberID.Location = new Point(20, 65);
            lblMemberID.Name = "lblMemberID";
            lblMemberID.Size = new Size(100, 23);
            lblMemberID.TabIndex = 1;
            lblMemberID.Text = "Member ID";
            // 
            // txtMemberID
            // 
            txtMemberID.BorderStyle = BorderStyle.FixedSingle;
            txtMemberID.Font = new Font("Segoe UI", 10F);
            txtMemberID.Location = new Point(120, 62);
            txtMemberID.Name = "txtMemberID";
            txtMemberID.Size = new Size(220, 30);
            txtMemberID.TabIndex = 2;
            // 
            // btnCheckIn
            // 
            btnCheckIn.BackColor = Color.FromArgb(0, 180, 216);
            btnCheckIn.Cursor = Cursors.Hand;
            btnCheckIn.FlatAppearance.BorderSize = 0;
            btnCheckIn.FlatStyle = FlatStyle.Flat;
            btnCheckIn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCheckIn.ForeColor = Color.White;
            btnCheckIn.Location = new Point(120, 115);
            btnCheckIn.Name = "btnCheckIn";
            btnCheckIn.Size = new Size(220, 40);
            btnCheckIn.TabIndex = 3;
            btnCheckIn.Text = "Check In";
            btnCheckIn.UseVisualStyleBackColor = false;
            btnCheckIn.Click += btnCheckIn_Click;
            // 
            // dgvAttendance
            // 
            dgvAttendance.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(245, 245, 245);
            dgvAttendance.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvAttendance.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAttendance.BackgroundColor = Color.White;
            dgvAttendance.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(28, 28, 28);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(28, 28, 28);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvAttendance.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvAttendance.ColumnHeadersHeight = 29;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(0, 180, 216);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvAttendance.DefaultCellStyle = dataGridViewCellStyle3;
            dgvAttendance.Dock = DockStyle.Right;
            dgvAttendance.EnableHeadersVisualStyles = false;
            dgvAttendance.Location = new Point(-543, 25);
            dgvAttendance.Name = "dgvAttendance";
            dgvAttendance.ReadOnly = true;
            dgvAttendance.RowHeadersVisible = false;
            dgvAttendance.RowHeadersWidth = 51;
            dgvAttendance.RowTemplate.Height = 32;
            dgvAttendance.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAttendance.Size = new Size(800, 138);
            dgvAttendance.TabIndex = 1;
            // 
            // FrmAttendance
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(282, 253);
            Controls.Add(panelContent);
            Controls.Add(panelHeader);
            Name = "FrmAttendance";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Attendance";
            WindowState = FormWindowState.Maximized;
            Load += FrmAttendance_Load;
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelContent.ResumeLayout(false);
            cardAttendance.ResumeLayout(false);
            cardAttendance.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAttendance).EndInit();
            ResumeLayout(false);
        }

        private Panel panelHeader;
        private Panel headerLine;
        private Panel panelContent;

        private Panel cardAttendance;
        private Label lblCardTitle;
        private Label lblMemberID;
        private TextBox txtMemberID;
        private Button btnCheckIn;

        private Label lblTitle;
        private DataGridView dgvAttendance;
    }
}
