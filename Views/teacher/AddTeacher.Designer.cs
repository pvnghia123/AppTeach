namespace appTeach_ICTU.Views.teacher
{
    partial class AddTeacher
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
            System.Windows.Forms.Label bo_phanLabel;
            System.Windows.Forms.Label cCCD_CMTLabel;
            System.Windows.Forms.Label chuyenh_nganhLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label place_of_birthLabel;
            this.birthdayDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.bo_phanTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.cCCD_CMTTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.chuyenh_nganhTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.emailTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.nameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.phoneTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.place_of_birthTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.teacherResponseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BtnAdd = new System.Windows.Forms.Button();
            birthdayLabel = new System.Windows.Forms.Label();
            bo_phanLabel = new System.Windows.Forms.Label();
            cCCD_CMTLabel = new System.Windows.Forms.Label();
            chuyenh_nganhLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            place_of_birthLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.birthdayDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.birthdayDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bo_phanTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cCCD_CMTTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chuyenh_nganhTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.place_of_birthTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherResponseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // birthdayLabel
            // 
            birthdayLabel.AutoSize = true;
            birthdayLabel.Location = new System.Drawing.Point(207, 121);
            birthdayLabel.Name = "birthdayLabel";
            birthdayLabel.Size = new System.Drawing.Size(58, 16);
            birthdayLabel.TabIndex = 1;
            birthdayLabel.Text = "birthday:";
            // 
            // birthdayDateEdit
            // 
            this.birthdayDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.teacherResponseBindingSource, "birthday", true));
            this.birthdayDateEdit.EditValue = null;
            this.birthdayDateEdit.Location = new System.Drawing.Point(313, 118);
            this.birthdayDateEdit.Name = "birthdayDateEdit";
            this.birthdayDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.birthdayDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.birthdayDateEdit.Size = new System.Drawing.Size(125, 22);
            this.birthdayDateEdit.TabIndex = 2;
            // 
            // bo_phanLabel
            // 
            bo_phanLabel.AutoSize = true;
            bo_phanLabel.Location = new System.Drawing.Point(207, 149);
            bo_phanLabel.Name = "bo_phanLabel";
            bo_phanLabel.Size = new System.Drawing.Size(59, 16);
            bo_phanLabel.TabIndex = 3;
            bo_phanLabel.Text = "bo phan:";
            // 
            // bo_phanTextEdit
            // 
            this.bo_phanTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.teacherResponseBindingSource, "bo_phan", true));
            this.bo_phanTextEdit.Location = new System.Drawing.Point(313, 146);
            this.bo_phanTextEdit.Name = "bo_phanTextEdit";
            this.bo_phanTextEdit.Size = new System.Drawing.Size(125, 22);
            this.bo_phanTextEdit.TabIndex = 4;
            // 
            // cCCD_CMTLabel
            // 
            cCCD_CMTLabel.AutoSize = true;
            cCCD_CMTLabel.Location = new System.Drawing.Point(207, 177);
            cCCD_CMTLabel.Name = "cCCD_CMTLabel";
            cCCD_CMTLabel.Size = new System.Drawing.Size(79, 16);
            cCCD_CMTLabel.TabIndex = 5;
            cCCD_CMTLabel.Text = "CCCD CMT:";
            // 
            // cCCD_CMTTextEdit
            // 
            this.cCCD_CMTTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.teacherResponseBindingSource, "CCCD_CMT", true));
            this.cCCD_CMTTextEdit.Location = new System.Drawing.Point(313, 174);
            this.cCCD_CMTTextEdit.Name = "cCCD_CMTTextEdit";
            this.cCCD_CMTTextEdit.Size = new System.Drawing.Size(125, 22);
            this.cCCD_CMTTextEdit.TabIndex = 6;
            // 
            // chuyenh_nganhLabel
            // 
            chuyenh_nganhLabel.AutoSize = true;
            chuyenh_nganhLabel.Location = new System.Drawing.Point(207, 205);
            chuyenh_nganhLabel.Name = "chuyenh_nganhLabel";
            chuyenh_nganhLabel.Size = new System.Drawing.Size(100, 16);
            chuyenh_nganhLabel.TabIndex = 7;
            chuyenh_nganhLabel.Text = "chuyenh nganh:";
            // 
            // chuyenh_nganhTextEdit
            // 
            this.chuyenh_nganhTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.teacherResponseBindingSource, "chuyenh_nganh", true));
            this.chuyenh_nganhTextEdit.Location = new System.Drawing.Point(313, 202);
            this.chuyenh_nganhTextEdit.Name = "chuyenh_nganhTextEdit";
            this.chuyenh_nganhTextEdit.Size = new System.Drawing.Size(125, 22);
            this.chuyenh_nganhTextEdit.TabIndex = 8;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(207, 233);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(43, 16);
            emailLabel.TabIndex = 9;
            emailLabel.Text = "email:";
            // 
            // emailTextEdit
            // 
            this.emailTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.teacherResponseBindingSource, "email", true));
            this.emailTextEdit.Location = new System.Drawing.Point(313, 230);
            this.emailTextEdit.Name = "emailTextEdit";
            this.emailTextEdit.Size = new System.Drawing.Size(125, 22);
            this.emailTextEdit.TabIndex = 10;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(207, 261);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(44, 16);
            nameLabel.TabIndex = 11;
            nameLabel.Text = "name:";
            // 
            // nameTextEdit
            // 
            this.nameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.teacherResponseBindingSource, "name", true));
            this.nameTextEdit.Location = new System.Drawing.Point(313, 258);
            this.nameTextEdit.Name = "nameTextEdit";
            this.nameTextEdit.Size = new System.Drawing.Size(125, 22);
            this.nameTextEdit.TabIndex = 12;
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new System.Drawing.Point(207, 289);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(48, 16);
            phoneLabel.TabIndex = 13;
            phoneLabel.Text = "phone:";
            // 
            // phoneTextEdit
            // 
            this.phoneTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.teacherResponseBindingSource, "phone", true));
            this.phoneTextEdit.Location = new System.Drawing.Point(313, 286);
            this.phoneTextEdit.Name = "phoneTextEdit";
            this.phoneTextEdit.Size = new System.Drawing.Size(125, 22);
            this.phoneTextEdit.TabIndex = 14;
            // 
            // place_of_birthLabel
            // 
            place_of_birthLabel.AutoSize = true;
            place_of_birthLabel.Location = new System.Drawing.Point(207, 317);
            place_of_birthLabel.Name = "place_of_birthLabel";
            place_of_birthLabel.Size = new System.Drawing.Size(86, 16);
            place_of_birthLabel.TabIndex = 15;
            place_of_birthLabel.Text = "place of birth:";
            // 
            // place_of_birthTextEdit
            // 
            this.place_of_birthTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.teacherResponseBindingSource, "place_of_birth", true));
            this.place_of_birthTextEdit.Location = new System.Drawing.Point(313, 314);
            this.place_of_birthTextEdit.Name = "place_of_birthTextEdit";
            this.place_of_birthTextEdit.Size = new System.Drawing.Size(125, 22);
            this.place_of_birthTextEdit.TabIndex = 16;
            // 
            // teacherResponseBindingSource
            // 
            this.teacherResponseBindingSource.DataSource = typeof(Model.model.TeacherResponse);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(306, 426);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(75, 23);
            this.BtnAdd.TabIndex = 17;
            this.BtnAdd.Text = "btnAdd";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // AddTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 567);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(birthdayLabel);
            this.Controls.Add(this.birthdayDateEdit);
            this.Controls.Add(bo_phanLabel);
            this.Controls.Add(this.bo_phanTextEdit);
            this.Controls.Add(cCCD_CMTLabel);
            this.Controls.Add(this.cCCD_CMTTextEdit);
            this.Controls.Add(chuyenh_nganhLabel);
            this.Controls.Add(this.chuyenh_nganhTextEdit);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextEdit);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextEdit);
            this.Controls.Add(phoneLabel);
            this.Controls.Add(this.phoneTextEdit);
            this.Controls.Add(place_of_birthLabel);
            this.Controls.Add(this.place_of_birthTextEdit);
            this.Name = "AddTeacher";
            this.Text = "AddTeacher";
            ((System.ComponentModel.ISupportInitialize)(this.birthdayDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.birthdayDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bo_phanTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cCCD_CMTTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chuyenh_nganhTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.place_of_birthTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherResponseBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource teacherResponseBindingSource;
        private DevExpress.XtraEditors.DateEdit birthdayDateEdit;
        private DevExpress.XtraEditors.TextEdit bo_phanTextEdit;
        private DevExpress.XtraEditors.TextEdit cCCD_CMTTextEdit;
        private DevExpress.XtraEditors.TextEdit chuyenh_nganhTextEdit;
        private DevExpress.XtraEditors.TextEdit emailTextEdit;
        private DevExpress.XtraEditors.TextEdit nameTextEdit;
        private DevExpress.XtraEditors.TextEdit phoneTextEdit;
        private DevExpress.XtraEditors.TextEdit place_of_birthTextEdit;
        private System.Windows.Forms.Button BtnAdd;
    }
}