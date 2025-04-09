namespace CSHARP25040903
{
    partial class PersonDetailsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblUI001 = new Label();
            dtpBirth = new DateTimePicker();
            txtName = new TextBox();
            rdoMale = new RadioButton();
            lblId = new Label();
            lblUI002 = new Label();
            lblUI003 = new Label();
            lblUI004 = new Label();
            rdoFemale = new RadioButton();
            btnCommit = new Button();
            btnDeletePerson = new Button();
            SuspendLayout();
            // 
            // lblUI001
            // 
            lblUI001.AutoSize = true;
            lblUI001.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblUI001.Location = new Point(35, 32);
            lblUI001.Name = "lblUI001";
            lblUI001.Size = new Size(36, 25);
            lblUI001.TabIndex = 0;
            lblUI001.Text = "ID:";
            // 
            // dtpBirth
            // 
            dtpBirth.Format = DateTimePickerFormat.Short;
            dtpBirth.Location = new Point(166, 193);
            dtpBirth.Name = "dtpBirth";
            dtpBirth.Size = new Size(171, 31);
            dtpBirth.TabIndex = 1;
            // 
            // txtName
            // 
            txtName.Location = new Point(162, 112);
            txtName.Name = "txtName";
            txtName.Size = new Size(175, 31);
            txtName.TabIndex = 0;
            // 
            // rdoMale
            // 
            rdoMale.AutoSize = true;
            rdoMale.Checked = true;
            rdoMale.Location = new Point(162, 279);
            rdoMale.Name = "rdoMale";
            rdoMale.Size = new Size(75, 29);
            rdoMale.TabIndex = 2;
            rdoMale.TabStop = true;
            rdoMale.Text = "male";
            rdoMale.UseVisualStyleBackColor = true;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(162, 32);
            lblId.Name = "lblId";
            lblId.Size = new Size(34, 25);
            lblId.TabIndex = 0;
            lblId.Text = "##";
            // 
            // lblUI002
            // 
            lblUI002.AutoSize = true;
            lblUI002.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblUI002.Location = new Point(35, 115);
            lblUI002.Name = "lblUI002";
            lblUI002.Size = new Size(64, 25);
            lblUI002.TabIndex = 0;
            lblUI002.Text = "name:";
            // 
            // lblUI003
            // 
            lblUI003.AutoSize = true;
            lblUI003.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblUI003.Location = new Point(35, 198);
            lblUI003.Name = "lblUI003";
            lblUI003.Size = new Size(125, 25);
            lblUI003.TabIndex = 0;
            lblUI003.Text = "date of birth:";
            // 
            // lblUI004
            // 
            lblUI004.AutoSize = true;
            lblUI004.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblUI004.Location = new Point(35, 281);
            lblUI004.Name = "lblUI004";
            lblUI004.Size = new Size(45, 25);
            lblUI004.TabIndex = 0;
            lblUI004.Text = "sex:";
            // 
            // rdoFemale
            // 
            rdoFemale.AutoSize = true;
            rdoFemale.Location = new Point(243, 279);
            rdoFemale.Name = "rdoFemale";
            rdoFemale.Size = new Size(90, 29);
            rdoFemale.TabIndex = 3;
            rdoFemale.Text = "female";
            rdoFemale.UseVisualStyleBackColor = true;
            // 
            // btnCommit
            // 
            btnCommit.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCommit.Location = new Point(193, 361);
            btnCommit.Name = "btnCommit";
            btnCommit.Size = new Size(173, 71);
            btnCommit.TabIndex = 4;
            btnCommit.Text = "##commit##";
            btnCommit.UseVisualStyleBackColor = true;
            // 
            // btnDeletePerson
            // 
            btnDeletePerson.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnDeletePerson.Location = new Point(12, 361);
            btnDeletePerson.Name = "btnDeletePerson";
            btnDeletePerson.Size = new Size(173, 71);
            btnDeletePerson.TabIndex = 4;
            btnDeletePerson.TabStop = false;
            btnDeletePerson.Text = "delete";
            btnDeletePerson.UseVisualStyleBackColor = true;
            btnDeletePerson.Visible = false;
            // 
            // PersonDetailsForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(378, 444);
            Controls.Add(btnDeletePerson);
            Controls.Add(btnCommit);
            Controls.Add(rdoFemale);
            Controls.Add(rdoMale);
            Controls.Add(txtName);
            Controls.Add(dtpBirth);
            Controls.Add(lblId);
            Controls.Add(lblUI004);
            Controls.Add(lblUI003);
            Controls.Add(lblUI002);
            Controls.Add(lblUI001);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "PersonDetailsForm";
            Text = "Person Details";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUI001;
        private DateTimePicker dtpBirth;
        private TextBox txtName;
        private RadioButton rdoMale;
        private Label lblId;
        private Label lblUI002;
        private Label lblUI003;
        private Label lblUI004;
        private RadioButton rdoFemale;
        private Button btnCommit;
        private Button btnDeletePerson;
    }
}