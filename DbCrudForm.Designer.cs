namespace CSHARP25040903
{
    partial class DbCrudForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dgvPeople = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            txtSearchFilter = new TextBox();
            btnAddPerson = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPeople).BeginInit();
            SuspendLayout();
            // 
            // dgvPeople
            // 
            dgvPeople.AllowUserToAddRows = false;
            dgvPeople.AllowUserToDeleteRows = false;
            dgvPeople.AllowUserToResizeColumns = false;
            dgvPeople.AllowUserToResizeRows = false;
            dgvPeople.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvPeople.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPeople.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvPeople.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvPeople.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPeople.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dgvPeople.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvPeople.Location = new Point(12, 108);
            dgvPeople.MultiSelect = false;
            dgvPeople.Name = "dgvPeople";
            dgvPeople.RowHeadersVisible = false;
            dgvPeople.RowHeadersWidth = 62;
            dgvPeople.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPeople.Size = new Size(604, 324);
            dgvPeople.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.FillWeight = 1F;
            Column1.HeaderText = "id";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.Visible = false;
            // 
            // Column2
            // 
            Column2.FillWeight = 4F;
            Column2.HeaderText = "name";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.FillWeight = 3F;
            Column3.HeaderText = "birth date";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.FillWeight = 2F;
            Column4.HeaderText = "sex";
            Column4.MinimumWidth = 8;
            Column4.Name = "Column4";
            // 
            // txtSearchFilter
            // 
            txtSearchFilter.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtSearchFilter.Font = new Font("Segoe UI", 12F);
            txtSearchFilter.Location = new Point(12, 63);
            txtSearchFilter.Name = "txtSearchFilter";
            txtSearchFilter.PlaceholderText = "to filter names type here...";
            txtSearchFilter.Size = new Size(604, 39);
            txtSearchFilter.TabIndex = 1;
            // 
            // btnAddPerson
            // 
            btnAddPerson.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAddPerson.Location = new Point(12, 12);
            btnAddPerson.Name = "btnAddPerson";
            btnAddPerson.Size = new Size(236, 45);
            btnAddPerson.TabIndex = 2;
            btnAddPerson.Text = "add new people";
            btnAddPerson.UseVisualStyleBackColor = true;
            // 
            // DbCrudForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(628, 444);
            Controls.Add(btnAddPerson);
            Controls.Add(txtSearchFilter);
            Controls.Add(dgvPeople);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "DbCrudForm";
            Text = "People Listing";
            ((System.ComponentModel.ISupportInitialize)dgvPeople).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvPeople;
        private TextBox txtSearchFilter;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private Button btnAddPerson;
    }
}
