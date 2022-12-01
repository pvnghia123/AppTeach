namespace appTeach_ICTU.Views.diem
{
    partial class Adddiem
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
            System.Windows.Forms.Label diemheso1Label;
            System.Windows.Forms.Label diemheso2Label;
            System.Windows.Forms.Label khoahocLabel;
            System.Windows.Forms.Label monhocLabel;
            System.Windows.Forms.Label nameLabel;
            this.diemResponseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.diemheso1SpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.diemheso2SpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.khoahocTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.monhocTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.nameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.btnAdd = new System.Windows.Forms.Button();
            diemheso1Label = new System.Windows.Forms.Label();
            diemheso2Label = new System.Windows.Forms.Label();
            khoahocLabel = new System.Windows.Forms.Label();
            monhocLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.diemResponseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diemheso1SpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diemheso2SpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoahocTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monhocTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // diemResponseBindingSource
            // 
            this.diemResponseBindingSource.DataSource = typeof(Model.model.diemResponse);
            // 
            // diemheso1Label
            // 
            diemheso1Label.AutoSize = true;
            diemheso1Label.Location = new System.Drawing.Point(101, 212);
            diemheso1Label.Name = "diemheso1Label";
            diemheso1Label.Size = new System.Drawing.Size(77, 16);
            diemheso1Label.TabIndex = 1;
            diemheso1Label.Text = "diemheso1:";
            // 
            // diemheso1SpinEdit
            // 
            this.diemheso1SpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.diemResponseBindingSource, "diemheso1", true));
            this.diemheso1SpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.diemheso1SpinEdit.Location = new System.Drawing.Point(184, 209);
            this.diemheso1SpinEdit.Name = "diemheso1SpinEdit";
            this.diemheso1SpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.diemheso1SpinEdit.Size = new System.Drawing.Size(176, 24);
            this.diemheso1SpinEdit.TabIndex = 2;
            // 
            // diemheso2Label
            // 
            diemheso2Label.AutoSize = true;
            diemheso2Label.Location = new System.Drawing.Point(101, 242);
            diemheso2Label.Name = "diemheso2Label";
            diemheso2Label.Size = new System.Drawing.Size(77, 16);
            diemheso2Label.TabIndex = 3;
            diemheso2Label.Text = "diemheso2:";
            // 
            // diemheso2SpinEdit
            // 
            this.diemheso2SpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.diemResponseBindingSource, "diemheso2", true));
            this.diemheso2SpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.diemheso2SpinEdit.Location = new System.Drawing.Point(184, 239);
            this.diemheso2SpinEdit.Name = "diemheso2SpinEdit";
            this.diemheso2SpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.diemheso2SpinEdit.Size = new System.Drawing.Size(176, 24);
            this.diemheso2SpinEdit.TabIndex = 4;
            // 
            // khoahocLabel
            // 
            khoahocLabel.AutoSize = true;
            khoahocLabel.Location = new System.Drawing.Point(101, 150);
            khoahocLabel.Name = "khoahocLabel";
            khoahocLabel.Size = new System.Drawing.Size(62, 16);
            khoahocLabel.TabIndex = 9;
            khoahocLabel.Text = "khoahoc:";
            // 
            // khoahocTextEdit
            // 
            this.khoahocTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.diemResponseBindingSource, "khoahoc", true));
            this.khoahocTextEdit.Location = new System.Drawing.Point(184, 147);
            this.khoahocTextEdit.Name = "khoahocTextEdit";
            this.khoahocTextEdit.Size = new System.Drawing.Size(176, 22);
            this.khoahocTextEdit.TabIndex = 10;
            // 
            // monhocLabel
            // 
            monhocLabel.AutoSize = true;
            monhocLabel.Location = new System.Drawing.Point(101, 178);
            monhocLabel.Name = "monhocLabel";
            monhocLabel.Size = new System.Drawing.Size(58, 16);
            monhocLabel.TabIndex = 11;
            monhocLabel.Text = "monhoc:";
            // 
            // monhocTextEdit
            // 
            this.monhocTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.diemResponseBindingSource, "monhoc", true));
            this.monhocTextEdit.Location = new System.Drawing.Point(184, 175);
            this.monhocTextEdit.Name = "monhocTextEdit";
            this.monhocTextEdit.Size = new System.Drawing.Size(176, 22);
            this.monhocTextEdit.TabIndex = 12;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(101, 116);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(44, 16);
            nameLabel.TabIndex = 13;
            nameLabel.Text = "name:";
            // 
            // nameTextEdit
            // 
            this.nameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.diemResponseBindingSource, "name", true));
            this.nameTextEdit.Location = new System.Drawing.Point(184, 113);
            this.nameTextEdit.Name = "nameTextEdit";
            this.nameTextEdit.Size = new System.Drawing.Size(176, 22);
            this.nameTextEdit.TabIndex = 14;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(212, 306);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // Adddiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 372);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(diemheso1Label);
            this.Controls.Add(this.diemheso1SpinEdit);
            this.Controls.Add(diemheso2Label);
            this.Controls.Add(this.diemheso2SpinEdit);
            this.Controls.Add(khoahocLabel);
            this.Controls.Add(this.khoahocTextEdit);
            this.Controls.Add(monhocLabel);
            this.Controls.Add(this.monhocTextEdit);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextEdit);
            this.Name = "Adddiem";
            this.Text = "Adddiem";
            ((System.ComponentModel.ISupportInitialize)(this.diemResponseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diemheso1SpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diemheso2SpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoahocTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monhocTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource diemResponseBindingSource;
        private DevExpress.XtraEditors.SpinEdit diemheso1SpinEdit;
        private DevExpress.XtraEditors.SpinEdit diemheso2SpinEdit;
        private DevExpress.XtraEditors.TextEdit khoahocTextEdit;
        private DevExpress.XtraEditors.TextEdit monhocTextEdit;
        private DevExpress.XtraEditors.TextEdit nameTextEdit;
        private System.Windows.Forms.Button btnAdd;
    }
}