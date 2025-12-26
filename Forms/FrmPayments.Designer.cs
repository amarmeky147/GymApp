using System.Drawing;
using System.Windows.Forms;

namespace GymApp.Forms
{
    partial class PaymentForm
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
            cardPayment = new Panel();
            lblCardTitle = new Label();
            lblMember = new Label();
            lblAmount = new Label();
            lblMethod = new Label();
            lblDate = new Label();
            cmbMember = new ComboBox();
            txtAmount = new TextBox();
            cmbPaymentMethod = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            btnPay = new Button();
            btnClear = new Button();
            dgvPayments = new DataGridView();
            panelHeader.SuspendLayout();
            panelContent.SuspendLayout();
            cardPayment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPayments).BeginInit();
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
            lblTitle.Size = new Size(153, 41);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Payments";
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
            panelContent.Controls.Add(cardPayment);
            panelContent.Controls.Add(dgvPayments);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(0, 65);
            panelContent.Name = "panelContent";
            panelContent.Padding = new Padding(25);
            panelContent.Size = new Size(282, 188);
            panelContent.TabIndex = 0;
            panelContent.Paint += panelContent_Paint;
            // 
            // cardPayment
            // 
            cardPayment.BackColor = Color.White;
            cardPayment.BorderStyle = BorderStyle.FixedSingle;
            cardPayment.Controls.Add(lblCardTitle);
            cardPayment.Controls.Add(lblMember);
            cardPayment.Controls.Add(lblAmount);
            cardPayment.Controls.Add(lblMethod);
            cardPayment.Controls.Add(lblDate);
            cardPayment.Controls.Add(cmbMember);
            cardPayment.Controls.Add(txtAmount);
            cardPayment.Controls.Add(cmbPaymentMethod);
            cardPayment.Controls.Add(dateTimePicker1);
            cardPayment.Controls.Add(btnPay);
            cardPayment.Controls.Add(btnClear);
            cardPayment.Location = new Point(25, 25);
            cardPayment.Name = "cardPayment";
            cardPayment.Size = new Size(450, 320);
            cardPayment.TabIndex = 0;
            cardPayment.Paint += cardPayment_Paint;
            // 
            // lblCardTitle
            // 
            lblCardTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblCardTitle.Location = new Point(15, 15);
            lblCardTitle.Name = "lblCardTitle";
            lblCardTitle.Size = new Size(100, 23);
            lblCardTitle.TabIndex = 0;
            lblCardTitle.Text = "Add Payment";
            // 
            // lblMember
            // 
            lblMember.Location = new Point(20, 60);
            lblMember.Name = "lblMember";
            lblMember.Size = new Size(100, 23);
            lblMember.TabIndex = 1;
            lblMember.Text = "Member";
            // 
            // lblAmount
            // 
            lblAmount.Location = new Point(20, 105);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(100, 23);
            lblAmount.TabIndex = 2;
            lblAmount.Text = "Amount";
            // 
            // lblMethod
            // 
            lblMethod.Location = new Point(20, 150);
            lblMethod.Name = "lblMethod";
            lblMethod.Size = new Size(100, 23);
            lblMethod.TabIndex = 3;
            lblMethod.Text = "Payment Method";
            // 
            // lblDate
            // 
            lblDate.Location = new Point(20, 195);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(100, 23);
            lblDate.TabIndex = 4;
            lblDate.Text = "Payment Date";
            // 
            // cmbMember
            // 
            cmbMember.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMember.Location = new Point(160, 57);
            cmbMember.Name = "cmbMember";
            cmbMember.Size = new Size(230, 28);
            cmbMember.TabIndex = 5;
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(160, 102);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(230, 27);
            txtAmount.TabIndex = 6;
            // 
            // cmbPaymentMethod
            // 
            cmbPaymentMethod.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPaymentMethod.Items.AddRange(new object[] { "Cash", "Visa", "Wallet" });
            cmbPaymentMethod.Location = new Point(160, 147);
            cmbPaymentMethod.Name = "cmbPaymentMethod";
            cmbPaymentMethod.Size = new Size(230, 28);
            cmbPaymentMethod.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(160, 192);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(230, 27);
            dateTimePicker1.TabIndex = 8;
            // 
            // btnPay
            // 
            btnPay.BackColor = Color.FromArgb(0, 180, 216);
            btnPay.FlatAppearance.BorderSize = 0;
            btnPay.FlatStyle = FlatStyle.Flat;
            btnPay.ForeColor = Color.White;
            btnPay.Location = new Point(160, 235);
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(110, 36);
            btnPay.TabIndex = 9;
            btnPay.Text = "Pay";
            btnPay.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(60, 60, 60);
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(280, 235);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(110, 36);
            btnClear.TabIndex = 10;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            // 
            // dgvPayments
            // 
            dgvPayments.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(245, 245, 245);
            dgvPayments.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvPayments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPayments.BackgroundColor = Color.White;
            dgvPayments.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(28, 28, 28);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(28, 28, 28);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvPayments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvPayments.ColumnHeadersHeight = 29;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(0, 180, 216);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvPayments.DefaultCellStyle = dataGridViewCellStyle3;
            dgvPayments.Dock = DockStyle.Right;
            dgvPayments.EnableHeadersVisualStyles = false;
            dgvPayments.Location = new Point(-563, 25);
            dgvPayments.Name = "dgvPayments";
            dgvPayments.ReadOnly = true;
            dgvPayments.RowHeadersVisible = false;
            dgvPayments.RowHeadersWidth = 51;
            dgvPayments.RowTemplate.Height = 32;
            dgvPayments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPayments.Size = new Size(820, 138);
            dgvPayments.TabIndex = 1;
            // 
            // PaymentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(282, 253);
            Controls.Add(panelContent);
            Controls.Add(panelHeader);
            Name = "PaymentForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Payments";
            WindowState = FormWindowState.Maximized;
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelContent.ResumeLayout(false);
            cardPayment.ResumeLayout(false);
            cardPayment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPayments).EndInit();
            ResumeLayout(false);
        }

        private Panel panelHeader;
        private Panel headerLine;
        private Panel panelContent;

        private Panel cardPayment;
        private Label lblCardTitle;

        private Label lblMember;
        private Label lblAmount;
        private Label lblMethod;
        private Label lblDate;

        private ComboBox cmbMember;
        private TextBox txtAmount;
        private ComboBox cmbPaymentMethod;
        private DateTimePicker dateTimePicker1;

        private Button btnPay;
        private Button btnClear;

        private Label lblTitle;
        private DataGridView dgvPayments;
    }
}
