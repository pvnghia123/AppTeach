namespace appTeach_ICTU.Views.login
{
    partial class dangki
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label birthdayLabel;
            System.Windows.Forms.Label cCCD_CMTLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label place_of_birthLabel;
            System.Windows.Forms.Label create_byLabel;
            System.Windows.Forms.Label create_timeLabel;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label6;
            this.teachICTUDataSet1 = new appTeach_ICTU.TeachICTUDataSet1();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new appTeach_ICTU.TeachICTUDataSet1TableAdapters.usersTableAdapter();
            this.tableAdapterManager = new appTeach_ICTU.TeachICTUDataSet1TableAdapters.TableAdapterManager();
            this.nameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.emailTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.birthdayDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.cCCD_CMTTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.phoneTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.place_of_birthTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDangki = new System.Windows.Forms.Button();
            this.txtMk = new System.Windows.Forms.TextBox();
            this.txtmk2 = new System.Windows.Forms.TextBox();
            this.cbbType_user = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panelStudent = new System.Windows.Forms.Panel();
            this.txtKhoa_hoc = new System.Windows.Forms.TextBox();
            this.txtHe_dao_tao = new System.Windows.Forms.TextBox();
            this.txtClassname = new System.Windows.Forms.TextBox();
            this.panelTeacher = new System.Windows.Forms.Panel();
            this.txtChuyen_nganh = new System.Windows.Forms.TextBox();
            this.txtBo_Phan = new System.Windows.Forms.TextBox();
            nameLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            birthdayLabel = new System.Windows.Forms.Label();
            cCCD_CMTLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            place_of_birthLabel = new System.Windows.Forms.Label();
            create_byLabel = new System.Windows.Forms.Label();
            create_timeLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.teachICTUDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.birthdayDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.birthdayDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cCCD_CMTTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.place_of_birthTextEdit.Properties)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.panelStudent.SuspendLayout();
            this.panelTeacher.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nameLabel.Location = new System.Drawing.Point(70, 147);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(91, 20);
            nameLabel.TabIndex = 3;
            nameLabel.Text = "Họ và Tên:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            emailLabel.Location = new System.Drawing.Point(70, 184);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(56, 20);
            emailLabel.TabIndex = 5;
            emailLabel.Text = "Email:";
            // 
            // birthdayLabel
            // 
            birthdayLabel.AutoSize = true;
            birthdayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            birthdayLabel.Location = new System.Drawing.Point(70, 224);
            birthdayLabel.Name = "birthdayLabel";
            birthdayLabel.Size = new System.Drawing.Size(88, 20);
            birthdayLabel.TabIndex = 7;
            birthdayLabel.Text = "Ngày sinh:";
            // 
            // cCCD_CMTLabel
            // 
            cCCD_CMTLabel.AutoSize = true;
            cCCD_CMTLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cCCD_CMTLabel.Location = new System.Drawing.Point(70, 263);
            cCCD_CMTLabel.Name = "cCCD_CMTLabel";
            cCCD_CMTLabel.Size = new System.Drawing.Size(104, 20);
            cCCD_CMTLabel.TabIndex = 9;
            cCCD_CMTLabel.Text = "CCCD/CMT:";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            phoneLabel.Location = new System.Drawing.Point(70, 301);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(48, 20);
            phoneLabel.TabIndex = 11;
            phoneLabel.Text = "SDT:";
            // 
            // place_of_birthLabel
            // 
            place_of_birthLabel.AutoSize = true;
            place_of_birthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            place_of_birthLabel.Location = new System.Drawing.Point(70, 349);
            place_of_birthLabel.Name = "place_of_birthLabel";
            place_of_birthLabel.Size = new System.Drawing.Size(75, 20);
            place_of_birthLabel.TabIndex = 13;
            place_of_birthLabel.Text = "Nơi sinh:";
            // 
            // create_byLabel
            // 
            create_byLabel.AutoSize = true;
            create_byLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            create_byLabel.Location = new System.Drawing.Point(70, 385);
            create_byLabel.Name = "create_byLabel";
            create_byLabel.Size = new System.Drawing.Size(82, 20);
            create_byLabel.TabIndex = 15;
            create_byLabel.Text = "Mật khẩu:";
            // 
            // create_timeLabel
            // 
            create_timeLabel.AutoSize = true;
            create_timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            create_timeLabel.Location = new System.Drawing.Point(70, 429);
            create_timeLabel.Name = "create_timeLabel";
            create_timeLabel.Size = new System.Drawing.Size(157, 20);
            create_timeLabel.TabIndex = 17;
            create_timeLabel.Text = "Xác nhận mật khẩu:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(2, 15);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(69, 20);
            label2.TabIndex = 24;
            label2.Text = "Tên lớp:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new System.Drawing.Point(2, 52);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(96, 20);
            label3.TabIndex = 26;
            label3.Text = "Hệ đào tạo:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.Location = new System.Drawing.Point(2, 93);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(88, 20);
            label4.TabIndex = 28;
            label4.Text = "Khóa Học:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label5.Location = new System.Drawing.Point(2, 57);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(120, 20);
            label5.TabIndex = 32;
            label5.Text = "Chuyên ngành:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label6.Location = new System.Drawing.Point(2, 16);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(78, 20);
            label6.TabIndex = 30;
            label6.Text = "Bộ Phận:";
            // 
            // teachICTUDataSet1
            // 
            this.teachICTUDataSet1.DataSetName = "TeachICTUDataSet1";
            this.teachICTUDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "users";
            this.usersBindingSource.DataSource = this.teachICTUDataSet1;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.khoa_hocTableAdapter = null;
            this.tableAdapterManager.loginTableAdapter = null;
            this.tableAdapterManager.monhocTableAdapter = null;
            this.tableAdapterManager.phong_hocTableAdapter = null;
            this.tableAdapterManager.studentTableAdapter = null;
            this.tableAdapterManager.teacherTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = appTeach_ICTU.TeachICTUDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usersTableAdapter = this.usersTableAdapter;
            // 
            // nameTextEdit
            // 
            this.nameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.usersBindingSource, "name", true));
            this.nameTextEdit.Location = new System.Drawing.Point(254, 145);
            this.nameTextEdit.Name = "nameTextEdit";
            this.nameTextEdit.Size = new System.Drawing.Size(258, 22);
            this.nameTextEdit.TabIndex = 4;
            // 
            // emailTextEdit
            // 
            this.emailTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.usersBindingSource, "email", true));
            this.emailTextEdit.Location = new System.Drawing.Point(254, 182);
            this.emailTextEdit.Name = "emailTextEdit";
            this.emailTextEdit.Size = new System.Drawing.Size(258, 22);
            this.emailTextEdit.TabIndex = 6;
            // 
            // birthdayDateEdit
            // 
            this.birthdayDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.usersBindingSource, "birthday", true));
            this.birthdayDateEdit.EditValue = new System.DateTime(2022, 11, 29, 14, 50, 10, 0);
            this.birthdayDateEdit.Location = new System.Drawing.Point(254, 222);
            this.birthdayDateEdit.Name = "birthdayDateEdit";
            this.birthdayDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.birthdayDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.birthdayDateEdit.Size = new System.Drawing.Size(258, 22);
            this.birthdayDateEdit.TabIndex = 8;
            // 
            // cCCD_CMTTextEdit
            // 
            this.cCCD_CMTTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.usersBindingSource, "CCCD_CMT", true));
            this.cCCD_CMTTextEdit.Location = new System.Drawing.Point(254, 263);
            this.cCCD_CMTTextEdit.Name = "cCCD_CMTTextEdit";
            this.cCCD_CMTTextEdit.Size = new System.Drawing.Size(258, 22);
            this.cCCD_CMTTextEdit.TabIndex = 10;
            // 
            // phoneTextEdit
            // 
            this.phoneTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.usersBindingSource, "phone", true));
            this.phoneTextEdit.Location = new System.Drawing.Point(254, 301);
            this.phoneTextEdit.Name = "phoneTextEdit";
            this.phoneTextEdit.Size = new System.Drawing.Size(258, 22);
            this.phoneTextEdit.TabIndex = 12;
            // 
            // place_of_birthTextEdit
            // 
            this.place_of_birthTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.usersBindingSource, "place_of_birth", true));
            this.place_of_birthTextEdit.Location = new System.Drawing.Point(254, 347);
            this.place_of_birthTextEdit.Name = "place_of_birthTextEdit";
            this.place_of_birthTextEdit.Size = new System.Drawing.Size(258, 22);
            this.place_of_birthTextEdit.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(179, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 26);
            this.label1.TabIndex = 21;
            this.label1.Text = "Vui lòng nhập đầy đủ thông tin";
            this.label1.UseCompatibleTextRendering = true;
            // 
            // btnDangki
            // 
            this.btnDangki.BackColor = System.Drawing.Color.Lime;
            this.btnDangki.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangki.Location = new System.Drawing.Point(231, 772);
            this.btnDangki.Margin = new System.Windows.Forms.Padding(200, 10, 3, 3);
            this.btnDangki.Name = "btnDangki";
            this.btnDangki.Size = new System.Drawing.Size(125, 47);
            this.btnDangki.TabIndex = 22;
            this.btnDangki.Text = "Đăng kí";
            this.btnDangki.UseVisualStyleBackColor = false;
            this.btnDangki.Click += new System.EventHandler(this.btnDangki_Click);
            // 
            // txtMk
            // 
            this.txtMk.Location = new System.Drawing.Point(254, 385);
            this.txtMk.Name = "txtMk";
            this.txtMk.PasswordChar = '*';
            this.txtMk.Size = new System.Drawing.Size(258, 22);
            this.txtMk.TabIndex = 23;
            // 
            // txtmk2
            // 
            this.txtmk2.Location = new System.Drawing.Point(254, 427);
            this.txtmk2.Name = "txtmk2";
            this.txtmk2.PasswordChar = '*';
            this.txtmk2.Size = new System.Drawing.Size(258, 22);
            this.txtmk2.TabIndex = 24;
            // 
            // cbbType_user
            // 
            this.cbbType_user.FormattingEnabled = true;
            this.cbbType_user.Items.AddRange(new object[] {
            "Sinh Viên",
            "Giáo Viên"});
            this.cbbType_user.Location = new System.Drawing.Point(254, 474);
            this.cbbType_user.Name = "cbbType_user";
            this.cbbType_user.Size = new System.Drawing.Size(179, 24);
            this.cbbType_user.TabIndex = 25;
            this.cbbType_user.SelectedIndexChanged += new System.EventHandler(this.cbbType_user_SelectedIndexChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.panelStudent);
            this.flowLayoutPanel1.Controls.Add(this.panelTeacher);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(61, 504);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(482, 252);
            this.flowLayoutPanel1.TabIndex = 26;
            // 
            // panelStudent
            // 
            this.panelStudent.Controls.Add(this.txtKhoa_hoc);
            this.panelStudent.Controls.Add(label4);
            this.panelStudent.Controls.Add(this.txtHe_dao_tao);
            this.panelStudent.Controls.Add(label3);
            this.panelStudent.Controls.Add(this.txtClassname);
            this.panelStudent.Controls.Add(label2);
            this.panelStudent.Location = new System.Drawing.Point(3, 3);
            this.panelStudent.Name = "panelStudent";
            this.panelStudent.Size = new System.Drawing.Size(479, 130);
            this.panelStudent.TabIndex = 0;
            // 
            // txtKhoa_hoc
            // 
            this.txtKhoa_hoc.Location = new System.Drawing.Point(186, 93);
            this.txtKhoa_hoc.Name = "txtKhoa_hoc";
            this.txtKhoa_hoc.Size = new System.Drawing.Size(258, 22);
            this.txtKhoa_hoc.TabIndex = 29;
            // 
            // txtHe_dao_tao
            // 
            this.txtHe_dao_tao.Location = new System.Drawing.Point(186, 52);
            this.txtHe_dao_tao.Name = "txtHe_dao_tao";
            this.txtHe_dao_tao.Size = new System.Drawing.Size(258, 22);
            this.txtHe_dao_tao.TabIndex = 27;
            // 
            // txtClassname
            // 
            this.txtClassname.Location = new System.Drawing.Point(186, 15);
            this.txtClassname.Name = "txtClassname";
            this.txtClassname.Size = new System.Drawing.Size(258, 22);
            this.txtClassname.TabIndex = 25;
            // 
            // panelTeacher
            // 
            this.panelTeacher.Controls.Add(this.txtChuyen_nganh);
            this.panelTeacher.Controls.Add(this.txtBo_Phan);
            this.panelTeacher.Controls.Add(label5);
            this.panelTeacher.Controls.Add(label6);
            this.panelTeacher.Location = new System.Drawing.Point(3, 139);
            this.panelTeacher.Name = "panelTeacher";
            this.panelTeacher.Size = new System.Drawing.Size(479, 100);
            this.panelTeacher.TabIndex = 1;
            // 
            // txtChuyen_nganh
            // 
            this.txtChuyen_nganh.Location = new System.Drawing.Point(186, 57);
            this.txtChuyen_nganh.Name = "txtChuyen_nganh";
            this.txtChuyen_nganh.Size = new System.Drawing.Size(258, 22);
            this.txtChuyen_nganh.TabIndex = 33;
            // 
            // txtBo_Phan
            // 
            this.txtBo_Phan.Location = new System.Drawing.Point(186, 16);
            this.txtBo_Phan.Name = "txtBo_Phan";
            this.txtBo_Phan.Size = new System.Drawing.Size(258, 22);
            this.txtBo_Phan.TabIndex = 31;
            // 
            // dangki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 831);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.cbbType_user);
            this.Controls.Add(this.btnDangki);
            this.Controls.Add(this.txtmk2);
            this.Controls.Add(this.txtMk);
            this.Controls.Add(this.label1);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextEdit);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextEdit);
            this.Controls.Add(birthdayLabel);
            this.Controls.Add(this.birthdayDateEdit);
            this.Controls.Add(cCCD_CMTLabel);
            this.Controls.Add(this.cCCD_CMTTextEdit);
            this.Controls.Add(phoneLabel);
            this.Controls.Add(this.phoneTextEdit);
            this.Controls.Add(place_of_birthLabel);
            this.Controls.Add(this.place_of_birthTextEdit);
            this.Controls.Add(create_byLabel);
            this.Controls.Add(create_timeLabel);
            this.Name = "dangki";
            this.Text = "dangki";
            ((System.ComponentModel.ISupportInitialize)(this.teachICTUDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.birthdayDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.birthdayDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cCCD_CMTTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.place_of_birthTextEdit.Properties)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panelStudent.ResumeLayout(false);
            this.panelStudent.PerformLayout();
            this.panelTeacher.ResumeLayout(false);
            this.panelTeacher.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TeachICTUDataSet1 teachICTUDataSet1;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private TeachICTUDataSet1TableAdapters.usersTableAdapter usersTableAdapter;
        private TeachICTUDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.TextEdit nameTextEdit;
        private DevExpress.XtraEditors.TextEdit emailTextEdit;
        private DevExpress.XtraEditors.DateEdit birthdayDateEdit;
        private DevExpress.XtraEditors.TextEdit cCCD_CMTTextEdit;
        private DevExpress.XtraEditors.TextEdit phoneTextEdit;
        private DevExpress.XtraEditors.TextEdit place_of_birthTextEdit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDangki;
        private System.Windows.Forms.TextBox txtMk;
        private System.Windows.Forms.TextBox txtmk2;
        private System.Windows.Forms.ComboBox cbbType_user;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panelStudent;
        private System.Windows.Forms.TextBox txtKhoa_hoc;
        private System.Windows.Forms.TextBox txtHe_dao_tao;
        private System.Windows.Forms.TextBox txtClassname;
        private System.Windows.Forms.Panel panelTeacher;
        private System.Windows.Forms.TextBox txtChuyen_nganh;
        private System.Windows.Forms.TextBox txtBo_Phan;
    }
}