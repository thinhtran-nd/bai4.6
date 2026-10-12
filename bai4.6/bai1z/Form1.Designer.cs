namespace bai1z
{
    partial class Form1
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dgvStudents = new DataGridView();
            grpInput = new GroupBox();
            btnChooseAvatar = new Button();
            picAvatar = new PictureBox();
            cboGender = new ComboBox();
            lblGender = new Label();
            txtAge = new TextBox();
            lblAge = new Label();
            txtFullName = new TextBox();
            lblFullName = new Label();
            txtStudentId = new TextBox();
            lblStudentId = new Label();
            grpFunctions = new GroupBox();
            btnExportCsv = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnAdd = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).BeginInit();
            grpInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picAvatar).BeginInit();
            grpFunctions.SuspendLayout();
            SuspendLayout();
            // 
            // dgvStudents
            // 
            dgvStudents.AllowUserToAddRows = false;
            dgvStudents.AllowUserToDeleteRows = false;
            dgvStudents.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudents.Location = new Point(12, 12);
            dgvStudents.MultiSelect = false;
            dgvStudents.Name = "dgvStudents";
            dgvStudents.ReadOnly = true;
            dgvStudents.RowHeadersWidth = 51;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dgvStudents.RowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStudents.Size = new Size(776, 240);
            dgvStudents.TabIndex = 0;
            // 
            // grpInput
            // 
            grpInput.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grpInput.Controls.Add(btnChooseAvatar);
            grpInput.Controls.Add(picAvatar);
            grpInput.Controls.Add(cboGender);
            grpInput.Controls.Add(lblGender);
            grpInput.Controls.Add(txtAge);
            grpInput.Controls.Add(lblAge);
            grpInput.Controls.Add(txtFullName);
            grpInput.Controls.Add(lblFullName);
            grpInput.Controls.Add(txtStudentId);
            grpInput.Controls.Add(lblStudentId);
            grpInput.Location = new Point(12, 258);
            grpInput.Name = "grpInput";
            grpInput.Size = new Size(776, 140);
            grpInput.TabIndex = 1;
            grpInput.TabStop = false;
            grpInput.Text = "Thông tin sinh viên";
            // 
            // btnChooseAvatar
            // 
            btnChooseAvatar.Location = new Point(630, 108);
            btnChooseAvatar.Name = "btnChooseAvatar";
            btnChooseAvatar.Size = new Size(130, 26);
            btnChooseAvatar.TabIndex = 9;
            btnChooseAvatar.Text = "Chọn ảnh...";
            btnChooseAvatar.UseVisualStyleBackColor = true;
            btnChooseAvatar.Click += btnChooseAvatar_Click;
            // 
            // picAvatar
            // 
            picAvatar.BorderStyle = BorderStyle.FixedSingle;
            picAvatar.Location = new Point(630, 22);
            picAvatar.Name = "picAvatar";
            picAvatar.Size = new Size(130, 80);
            picAvatar.SizeMode = PictureBoxSizeMode.Zoom;
            picAvatar.TabIndex = 8;
            picAvatar.TabStop = false;
            // 
            // cboGender
            // 
            cboGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cboGender.FormattingEnabled = true;
            cboGender.Items.AddRange(new object[] { "Nam", "Nữ" });
            cboGender.Location = new Point(400, 100);
            cboGender.Name = "cboGender";
            cboGender.Size = new Size(180, 28);
            cboGender.TabIndex = 7;
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Location = new Point(320, 103);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(68, 20);
            lblGender.TabIndex = 6;
            lblGender.Text = "Giới tính:";
            // 
            // txtAge
            // 
            txtAge.Location = new Point(110, 100);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(180, 27);
            txtAge.TabIndex = 5;
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Location = new Point(20, 103);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(41, 20);
            lblAge.TabIndex = 4;
            lblAge.Text = "Tuổi:";
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(110, 62);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(470, 27);
            txtFullName.TabIndex = 3;
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Location = new Point(20, 65);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(57, 20);
            lblFullName.TabIndex = 2;
            lblFullName.Text = "Họ tên:";
            // 
            // txtStudentId
            // 
            txtStudentId.Location = new Point(110, 25);
            txtStudentId.Name = "txtStudentId";
            txtStudentId.Size = new Size(470, 27);
            txtStudentId.TabIndex = 1;
            // 
            // lblStudentId
            // 
            lblStudentId.AutoSize = true;
            lblStudentId.Location = new Point(20, 28);
            lblStudentId.Name = "lblStudentId";
            lblStudentId.Size = new Size(54, 20);
            lblStudentId.TabIndex = 0;
            lblStudentId.Text = "Mã SV:";
            // 
            // grpFunctions
            // 
            grpFunctions.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grpFunctions.Controls.Add(btnExportCsv);
            grpFunctions.Controls.Add(btnUpdate);
            grpFunctions.Controls.Add(btnDelete);
            grpFunctions.Controls.Add(btnAdd);
            grpFunctions.Location = new Point(12, 404);
            grpFunctions.Name = "grpFunctions";
            grpFunctions.Size = new Size(776, 70);
            grpFunctions.TabIndex = 2;
            grpFunctions.TabStop = false;
            grpFunctions.Text = "Chức năng";
            // 
            // btnExportCsv
            // 
            btnExportCsv.Location = new Point(440, 26);
            btnExportCsv.Name = "btnExportCsv";
            btnExportCsv.Size = new Size(130, 30);
            btnExportCsv.TabIndex = 3;
            btnExportCsv.Text = "Xuất file CSV";
            btnExportCsv.UseVisualStyleBackColor = true;
            btnExportCsv.Click += btnExportCsv_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(300, 26);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(130, 30);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(160, 26);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(130, 30);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(20, 26);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(130, 30);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 486);
            Controls.Add(grpFunctions);
            Controls.Add(grpInput);
            Controls.Add(dgvStudents);
            MinimumSize = new Size(818, 533);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý Sinh viên - BindingSource & File";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvStudents).EndInit();
            grpInput.ResumeLayout(false);
            grpInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picAvatar).EndInit();
            grpFunctions.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvStudents;
        private GroupBox grpInput;
        private Label lblStudentId;
        private TextBox txtStudentId;
        private TextBox txtFullName;
        private Label lblFullName;
        private TextBox txtAge;
        private Label lblAge;
        private ComboBox cboGender;
        private Label lblGender;
        private PictureBox picAvatar;
        private Button btnChooseAvatar;
        private GroupBox grpFunctions;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnExportCsv;
    }
}
