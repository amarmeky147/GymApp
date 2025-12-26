using System.Drawing;
using System.Windows.Forms;

namespace GymApp.Forms
{
    partial class FrmAddMember
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
            cardMember = new Panel();
            lblCardTitle = new Label();
            lblName = new Label();
            txtName = new TextBox();
            lblPhone = new Label();
            txtPhone = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            btnAdd = new Button();
            dataGridView1 = new DataGridView();
            panelHeader.SuspendLayout();
            panelContent.SuspendLayout();
            cardMember.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            lblTitle.Size = new Size(204, 41);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Add Member";
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
            panelContent.Controls.Add(cardMember);
            panelContent.Controls.Add(dataGridView1);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(0, 65);
            panelContent.Name = "panelContent";
            panelContent.Padding = new Padding(25);
            panelContent.Size = new Size(282, 188);
            panelContent.TabIndex = 0;
            // 
            // cardMember
            // 
            cardMember.BackColor = Color.White;
            cardMember.BorderStyle = BorderStyle.FixedSingle;
            cardMember.Controls.Add(lblCardTitle);
            cardMember.Controls.Add(lblName);
            cardMember.Controls.Add(txtName);
            cardMember.Controls.Add(lblPhone);
            cardMember.Controls.Add(txtPhone);
            cardMember.Controls.Add(lblEmail);
            cardMember.Controls.Add(txtEmail);
            cardMember.Controls.Add(btnAdd);
            cardMember.Location = new Point(25, 25);
            cardMember.Name = "cardMember";
            cardMember.Size = new Size(380, 310);
            cardMember.TabIndex = 0;
            cardMember.Paint += cardMember_Paint;
            // 
            // lblCardTitle
            // 
            lblCardTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblCardTitle.Location = new Point(15, 15);
            lblCardTitle.Name = "lblCardTitle";
            lblCardTitle.Size = new Size(100, 23);
            lblCardTitle.TabIndex = 0;
            lblCardTitle.Text = "Member Information";
            // 
            // lblName
            // 
            lblName.ForeColor = Color.FromArgb(55, 55, 55);
            lblName.Location = new Point(20, 60);
            lblName.Name = "lblName";
            lblName.Size = new Size(100, 23);
            lblName.TabIndex = 1;
            lblName.Text = "Name";
            // 
            // txtName
            // 
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.Font = new Font("Segoe UI", 10F);
            txtName.Location = new Point(130, 57);
            txtName.Name = "txtName";
            txtName.Size = new Size(220, 30);
            txtName.TabIndex = 2;
            // 
            // lblPhone
            // 
            lblPhone.ForeColor = Color.FromArgb(55, 55, 55);
            lblPhone.Location = new Point(20, 115);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(100, 23);
            lblPhone.TabIndex = 3;
            lblPhone.Text = "Phone";
            // 
            // txtPhone
            // 
            txtPhone.BorderStyle = BorderStyle.FixedSingle;
            txtPhone.Font = new Font("Segoe UI", 10F);
            txtPhone.Location = new Point(130, 112);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(220, 30);
            txtPhone.TabIndex = 4;
            // 
            // lblEmail
            // 
            lblEmail.ForeColor = Color.FromArgb(55, 55, 55);
            lblEmail.Location = new Point(20, 170);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(100, 23);
            lblEmail.TabIndex = 5;
            lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Font = new Font("Segoe UI", 10F);
            txtEmail.Location = new Point(130, 167);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(220, 30);
            txtEmail.TabIndex = 6;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(0, 180, 216);
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(130, 225);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(220, 42);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Add Member";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(245, 245, 245);
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(28, 28, 28);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(28, 28, 28);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeight = 29;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(0, 180, 216);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.Dock = DockStyle.Right;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(-543, 25);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 32;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(800, 138);
            dataGridView1.TabIndex = 1;
            // 
            // FrmAddMember
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(282, 253);
            Controls.Add(panelContent);
            Controls.Add(panelHeader);
            Name = "FrmAddMember";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Member";
            WindowState = FormWindowState.Maximized;
            Load += FrmAddMember_Load;
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelContent.ResumeLayout(false);
            cardMember.ResumeLayout(false);
            cardMember.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        private Panel panelHeader;
        private Panel headerLine;
        private Panel panelContent;

        private Label lblTitle;

        private Panel cardMember;
        private Label lblCardTitle;

        private Label lblName;
        private TextBox txtName;
        private Label lblPhone;
        private TextBox txtPhone;
        private Label lblEmail;
        private TextBox txtEmail;
        private Button btnAdd;

        private DataGridView dataGridView1;
    }
}
