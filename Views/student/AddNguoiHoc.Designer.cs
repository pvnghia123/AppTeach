namespace appTeach_ICTU.Views.student
{
    partial class AddNguoiHoc
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
            System.Windows.Forms.Label birthdayLabel;
            System.Windows.Forms.Label cCCD_CMTLabel;
            System.Windows.Forms.Label class_nameLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label he_dao_taoLabel;
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label khoaLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label place_of_birthLabel;
            this.birthdayDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.cCCD_CMTTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.class_nameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.emailTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.he_dao_taoTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.idTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.khoaTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.nameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.phoneTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.place_of_birthTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.studentResponseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnAdd = new System.Windows.Forms.Button();
            birthdayLabel = new System.Windows.Forms.Label();
            cCCD_CMTLabel = new System.Windows.Forms.Label();
            class_nameLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            he_dao_taoLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            khoaLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            place_of_birthLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.birthdayDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.birthdayDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cCCD_CMTTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.class_nameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.he_dao_taoTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoaTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.place_of_birthTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentResponseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // birthdayLabel
            // 
            birthdayLabel.AutoSize = true;
            birthdayLabel.Location = new System.Drawing.Point(180, 97);
            birthdayLabel.Name = "birthdayLabel";
            birthdayLabel.Size = new System.Drawing.Size(58, 16);
            birthdayLabel.TabIndex = 1;
            birthdayLabel.Text = "birthday:";
            // 
            // birthdayDateEdit
            // 
            this.birthdayDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.studentResponseBindingSource, "birthday", true));
            this.birthdayDateEdit.EditValue = null;
            this.birthdayDateEdit.Location = new System.Drawing.Point(272, 94);
            this.birthdayDateEdit.Name = "birthdayDateEdit";
            this.birthdayDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.birthdayDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.birthdayDateEdit.Size = new System.Drawing.Size(125, 22);
            this.birthdayDateEdit.TabIndex = 2;
            // 
            // cCCD_CMTLabel
            // 
            cCCD_CMTLabel.AutoSize = true;
            cCCD_CMTLabel.Location = new System.Drawing.Point(180, 125);
            cCCD_CMTLabel.Name = "cCCD_CMTLabel";
            cCCD_CMTLabel.Size = new System.Drawing.Size(79, 16);
            cCCD_CMTLabel.TabIndex = 3;
            cCCD_CMTLabel.Text = "CCCD CMT:";
            // 
            // cCCD_CMTTextEdit
            // 
            this.cCCD_CMTTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.studentResponseBindingSource, "CCCD_CMT", true));
            this.cCCD_CMTTextEdit.Location = new System.Drawing.Point(272, 122);
            this.cCCD_CMTTextEdit.Name = "cCCD_CMTTextEdit";
            this.cCCD_CMTTextEdit.Size = new System.Drawing.Size(125, 22);
            this.cCCD_CMTTextEdit.TabIndex = 4;
            // 
            // class_nameLabel
            // 
            class_nameLabel.AutoSize = true;
            class_nameLabel.Location = new System.Drawing.Point(180, 153);
            class_nameLabel.Name = "class_nameLabel";
            class_nameLabel.Size = new System.Drawing.Size(79, 16);
            class_nameLabel.TabIndex = 5;
            class_nameLabel.Text = "class name:";
            // 
            // class_nameTextEdit
            // 
            this.class_nameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.studentResponseBindingSource, "class_name", true));
            this.class_nameTextEdit.Location = new System.Drawing.Point(272, 150);
            this.class_nameTextEdit.Name = "class_nameTextEdit";
            this.class_nameTextEdit.Size = new System.Drawing.Size(125, 22);
            this.class_nameTextEdit.TabIndex = 6;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(180, 181);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(43, 16);
            emailLabel.TabIndex = 7;
            emailLabel.Text = "email:";
            // 
            // emailTextEdit
            // 
            this.emailTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.studentResponseBindingSource, "email", true));
            this.emailTextEdit.Location = new System.Drawing.Point(272, 178);
            this.emailTextEdit.Name = "emailTextEdit";
            this.emailTextEdit.Size = new System.Drawing.Size(125, 22);
            this.emailTextEdit.TabIndex = 8;
            // 
            // he_dao_taoLabel
            // 
            he_dao_taoLabel.AutoSize = true;
            he_dao_taoLabel.Location = new System.Drawing.Point(180, 209);
            he_dao_taoLabel.Name = "he_dao_taoLabel";
            he_dao_taoLabel.Size = new System.Drawing.Size(74, 16);
            he_dao_taoLabel.TabIndex = 9;
            he_dao_taoLabel.Text = "he dao tao:";
            // 
            // he_dao_taoTextEdit
            // 
            this.he_dao_taoTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.studentResponseBindingSource, "he_dao_tao", true));
            this.he_dao_taoTextEdit.Location = new System.Drawing.Point(272, 206);
            this.he_dao_taoTextEdit.Name = "he_dao_taoTextEdit";
            this.he_dao_taoTextEdit.Size = new System.Drawing.Size(125, 22);
            this.he_dao_taoTextEdit.TabIndex = 10;
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(180, 237);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(21, 16);
            idLabel.TabIndex = 11;
            idLabel.Text = "id:";
            // 
            // idTextEdit
            // 
            this.idTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.studentResponseBindingSource, "id", true));
            this.idTextEdit.Location = new System.Drawing.Point(272, 234);
            this.idTextEdit.Name = "idTextEdit";
            this.idTextEdit.Size = new System.Drawing.Size(125, 22);
            this.idTextEdit.TabIndex = 12;
            // 
            // khoaLabel
            // 
            khoaLabel.AutoSize = true;
            khoaLabel.Location = new System.Drawing.Point(180, 265);
            khoaLabel.Name = "khoaLabel";
            khoaLabel.Size = new System.Drawing.Size(40, 16);
            khoaLabel.TabIndex = 13;
            khoaLabel.Text = "khoa:";
            // 
            // khoaTextEdit
            // 
            this.khoaTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.studentResponseBindingSource, "khoa", true));
            this.khoaTextEdit.Location = new System.Drawing.Point(272, 262);
            this.khoaTextEdit.Name = "khoaTextEdit";
            this.khoaTextEdit.Size = new System.Drawing.Size(125, 22);
            this.khoaTextEdit.TabIndex = 14;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(180, 293);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(44, 16);
            nameLabel.TabIndex = 15;
            nameLabel.Text = "name:";
            // 
            // nameTextEdit
            // 
            this.nameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.studentResponseBindingSource, "name", true));
            this.nameTextEdit.Location = new System.Drawing.Point(272, 290);
            this.nameTextEdit.Name = "nameTextEdit";
            this.nameTextEdit.Size = new System.Drawing.Size(125, 22);
            this.nameTextEdit.TabIndex = 16;
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new System.Drawing.Point(180, 321);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(48, 16);
            phoneLabel.TabIndex = 17;
            phoneLabel.Text = "phone:";
            // 
            // phoneTextEdit
            // 
            this.phoneTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.studentResponseBindingSource, "phone", true));
            this.phoneTextEdit.Location = new System.Drawing.Point(272, 318);
            this.phoneTextEdit.Name = "phoneTextEdit";
            this.phoneTextEdit.Size = new System.Drawing.Size(125, 22);
            this.phoneTextEdit.TabIndex = 18;
            // 
            // place_of_birthLabel
            // 
            place_of_birthLabel.AutoSize = true;
            place_of_birthLabel.Location = new System.Drawing.Point(180, 349);
            place_of_birthLabel.Name = "place_of_birthLabel";
            place_of_birthLabel.Size = new System.Drawing.Size(86, 16);
            place_of_birthLabel.TabIndex = 19;
            place_of_birthLabel.Text = "place of birth:";
            // 
            // place_of_birthTextEdit
            // 
            this.place_of_birthTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.studentResponseBindingSource, "place_of_birth", true));
            this.place_of_birthTextEdit.Location = new System.Drawing.Point(272, 346);
            this.place_of_birthTextEdit.Name = "place_of_birthTextEdit";
            this.place_of_birthTextEdit.Size = new System.Drawing.Size(125, 22);
            this.place_of_birthTextEdit.TabIndex = 20;
            // 
            // studentResponseBindingSource
            // 
            this.studentResponseBindingSource.DataSource = typeof(Model.model.studentResponse);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(261, 466);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 21;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // AddNguoiHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 576);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(birthdayLabel);
            this.Controls.Add(this.birthdayDateEdit);
            this.Controls.Add(cCCD_CMTLabel);
            this.Controls.Add(this.cCCD_CMTTextEdit);
            this.Controls.Add(class_nameLabel);
            this.Controls.Add(this.class_nameTextEdit);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextEdit);
            this.Controls.Add(he_dao_taoLabel);
            this.Controls.Add(this.he_dao_taoTextEdit);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextEdit);
            this.Controls.Add(khoaLabel);
            this.Controls.Add(this.khoaTextEdit);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextEdit);
            this.Controls.Add(phoneLabel);
            this.Controls.Add(this.phoneTextEdit);
            this.Controls.Add(place_of_birthLabel);
            this.Controls.Add(this.place_of_birthTextEdit);
            this.Name = "AddNguoiHoc";
            this.Text = "AddNguoiHoc";
            ((System.ComponentModel.ISupportInitialize)(this.birthdayDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.birthdayDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cCCD_CMTTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.class_nameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.he_dao_taoTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoaTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.place_of_birthTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentResponseBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource studentResponseBindingSource;
        private DevExpress.XtraEditors.DateEdit birthdayDateEdit;
        private DevExpress.XtraEditors.TextEdit cCCD_CMTTextEdit;
        private DevExpress.XtraEditors.TextEdit class_nameTextEdit;
        private DevExpress.XtraEditors.TextEdit emailTextEdit;
        private DevExpress.XtraEditors.TextEdit he_dao_taoTextEdit;
        private DevExpress.XtraEditors.TextEdit idTextEdit;
        private DevExpress.XtraEditors.TextEdit khoaTextEdit;
        private DevExpress.XtraEditors.TextEdit nameTextEdit;
        private DevExpress.XtraEditors.TextEdit phoneTextEdit;
        private DevExpress.XtraEditors.TextEdit place_of_birthTextEdit;
        private System.Windows.Forms.Button btnAdd;
    }
}