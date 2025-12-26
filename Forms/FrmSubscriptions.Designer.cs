using System.Drawing;
using System.Windows.Forms;

namespace GymApp.Forms
{
    partial class FrmSubscriptions
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private Panel panelHeader;
        private Label lblTitle;
        private Panel headerLine;

        private Panel panelContent;
        private Panel cardSubscription;

        private Label lblMember;
        private Label lblType;
        private Label lblStartDate;

        private ComboBox cbMembers;
        private ComboBox cbTypes;
        private DateTimePicker dtStart;

        private Button btnSave;

        private void InitializeComponent()
        {
            panelHeader = new Panel();
            lblTitle = new Label();
            headerLine = new Panel();

            panelContent = new Panel();
            cardSubscription = new Panel();

            lblMember = new Label();
            lblType = new Label();
            lblStartDate = new Label();

            cbMembers = new ComboBox();
            cbTypes = new ComboBox();
            dtStart = new DateTimePicker();

            btnSave = new Button();

            panelHeader.SuspendLayout();
            panelContent.SuspendLayout();
            cardSubscription.SuspendLayout();
            SuspendLayout();

            // ================= HEADER =================
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Height = 65;
            panelHeader.BackColor = Color.FromArgb(20, 20, 20);
            panelHeader.Controls.Add(lblTitle);
            panelHeader.Controls.Add(headerLine);

            lblTitle.AutoSize = true;
            lblTitle.Text = "Subscriptions";
            lblTitle.ForeColor = Color.White;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.Location = new Point(25, 18);

            headerLine.Dock = DockStyle.Bottom;
            headerLine.Height = 1;
            headerLine.BackColor = Color.FromArgb(60, 60, 60);

            // ================= CONTENT =================
            panelContent.Dock = DockStyle.Fill;
            panelContent.BackColor = Color.Transparent;
            panelContent.Padding = new Padding(30);
            panelContent.Controls.Add(cardSubscription);

            // ================= CARD =================
            cardSubscription.Size = new Size(420, 330);
            cardSubscription.Location = new Point(40, 40);
            cardSubscription.BackColor = Color.White;
            cardSubscription.BorderStyle = BorderStyle.FixedSingle;
            cardSubscription.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            // Member
            lblMember.Text = "Member";
            lblMember.Location = new Point(25, 30);
            lblMember.Font = new Font("Segoe UI", 10F);
            lblMember.ForeColor = Color.FromArgb(55, 55, 55);

            cbMembers.DropDownStyle = ComboBoxStyle.DropDownList;
            cbMembers.Location = new Point(25, 55);
            cbMembers.Size = new Size(360, 28);

            // Type
            lblType.Text = "Membership Type";
            lblType.Location = new Point(25, 105);
            lblType.Font = new Font("Segoe UI", 10F);
            lblType.ForeColor = Color.FromArgb(55, 55, 55);

            cbTypes.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTypes.Location = new Point(25, 130);
            cbTypes.Size = new Size(360, 28);

            // Start Date
            lblStartDate.Text = "Start Date";
            lblStartDate.Location = new Point(25, 180);
            lblStartDate.Font = new Font("Segoe UI", 10F);
            lblStartDate.ForeColor = Color.FromArgb(55, 55, 55);

            dtStart.Location = new Point(25, 205);
            dtStart.Size = new Size(360, 27);

            // Button
            btnSave.Text = "Create Subscription";
            btnSave.Size = new Size(360, 42);
            btnSave.Location = new Point(25, 260);
            btnSave.BackColor = Color.FromArgb(0, 180, 216);
            btnSave.ForeColor = Color.White;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSave.Cursor = Cursors.Hand;
            btnSave.Click += btnSave_Click;

            btnSave.MouseEnter += (s, e) =>
                btnSave.BackColor = Color.FromArgb(0, 150, 200);

            btnSave.MouseLeave += (s, e) =>
                btnSave.BackColor = Color.FromArgb(0, 180, 216);

            // Add controls to card
            cardSubscription.Controls.Add(lblMember);
            cardSubscription.Controls.Add(cbMembers);
            cardSubscription.Controls.Add(lblType);
            cardSubscription.Controls.Add(cbTypes);
            cardSubscription.Controls.Add(lblStartDate);
            cardSubscription.Controls.Add(dtStart);
            cardSubscription.Controls.Add(btnSave);

            // ================= FORM =================
            AutoScaleMode = AutoScaleMode.Font;
            WindowState = FormWindowState.Maximized;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Subscriptions";

            Controls.Add(panelContent);
            Controls.Add(panelHeader);

            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelContent.ResumeLayout(false);
            cardSubscription.ResumeLayout(false);
            cardSubscription.PerformLayout();
            ResumeLayout(false);
        }
    }
}
