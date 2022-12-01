namespace appTeach_ICTU.Views
{
    partial class QLiPhongHoc
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
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label ten_phong_hocLabel;
            System.Windows.Forms.Label trang_thaiLabel;
            System.Windows.Forms.Label nguoi_taoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QLiPhongHoc));
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.phong_hocDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phong_hocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teachICTUDataSet1 = new appTeach_ICTU.TeachICTUDataSet1();
            this.idTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ten_phong_hocTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.trang_thaiCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.nguoi_taoTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.phong_hocTableAdapter = new appTeach_ICTU.TeachICTUDataSet1TableAdapters.phong_hocTableAdapter();
            this.tableAdapterManager = new appTeach_ICTU.TeachICTUDataSet1TableAdapters.TableAdapterManager();
            idLabel = new System.Windows.Forms.Label();
            ten_phong_hocLabel = new System.Windows.Forms.Label();
            trang_thaiLabel = new System.Windows.Forms.Label();
            nguoi_taoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phong_hocDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phong_hocBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachICTUDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ten_phong_hocTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trang_thaiCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nguoi_taoTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(125, 182);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(21, 16);
            idLabel.TabIndex = 10;
            idLabel.Text = "id:";
            // 
            // ten_phong_hocLabel
            // 
            ten_phong_hocLabel.AutoSize = true;
            ten_phong_hocLabel.Location = new System.Drawing.Point(125, 210);
            ten_phong_hocLabel.Name = "ten_phong_hocLabel";
            ten_phong_hocLabel.Size = new System.Drawing.Size(94, 16);
            ten_phong_hocLabel.TabIndex = 12;
            ten_phong_hocLabel.Text = "ten phong hoc:";
            // 
            // trang_thaiLabel
            // 
            trang_thaiLabel.AutoSize = true;
            trang_thaiLabel.Location = new System.Drawing.Point(125, 238);
            trang_thaiLabel.Name = "trang_thaiLabel";
            trang_thaiLabel.Size = new System.Drawing.Size(64, 16);
            trang_thaiLabel.TabIndex = 14;
            trang_thaiLabel.Text = "trang thai:";
            // 
            // nguoi_taoLabel
            // 
            nguoi_taoLabel.AutoSize = true;
            nguoi_taoLabel.Location = new System.Drawing.Point(125, 268);
            nguoi_taoLabel.Name = "nguoi_taoLabel";
            nguoi_taoLabel.Size = new System.Drawing.Size(65, 16);
            nguoi_taoLabel.TabIndex = 16;
            nguoi_taoLabel.Text = "nguoi tao:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 27);
            this.label1.TabIndex = 7;
            this.label1.Text = "Quản lí phòng học";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(12, 77);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.phong_hocDataGridView);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.Controls.Add(idLabel);
            this.splitContainer1.Panel2.Controls.Add(this.idTextEdit);
            this.splitContainer1.Panel2.Controls.Add(ten_phong_hocLabel);
            this.splitContainer1.Panel2.Controls.Add(this.ten_phong_hocTextEdit);
            this.splitContainer1.Panel2.Controls.Add(trang_thaiLabel);
            this.splitContainer1.Panel2.Controls.Add(this.trang_thaiCheckEdit);
            this.splitContainer1.Panel2.Controls.Add(nguoi_taoLabel);
            this.splitContainer1.Panel2.Controls.Add(this.nguoi_taoTextEdit);
            this.splitContainer1.Panel2.Controls.Add(this.btnDelete);
            this.splitContainer1.Panel2.Controls.Add(this.btnUpdate);
            this.splitContainer1.Panel2.Controls.Add(this.btnAdd);
            this.splitContainer1.Size = new System.Drawing.Size(1465, 619);
            this.splitContainer1.SplitterDistance = 942;
            this.splitContainer1.TabIndex = 8;
            // 
            // phong_hocDataGridView
            // 
            this.phong_hocDataGridView.AutoGenerateColumns = false;
            this.phong_hocDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.phong_hocDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn3});
            this.phong_hocDataGridView.DataSource = this.phong_hocBindingSource;
            this.phong_hocDataGridView.Location = new System.Drawing.Point(17, 25);
            this.phong_hocDataGridView.Name = "phong_hocDataGridView";
            this.phong_hocDataGridView.RowHeadersWidth = 51;
            this.phong_hocDataGridView.RowTemplate.Height = 24;
            this.phong_hocDataGridView.Size = new System.Drawing.Size(908, 576);
            this.phong_hocDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ten_phong_hoc";
            this.dataGridViewTextBoxColumn2.HeaderText = "ten_phong_hoc";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "trang_thai";
            this.dataGridViewCheckBoxColumn1.HeaderText = "trang_thai";
            this.dataGridViewCheckBoxColumn1.MinimumWidth = 6;
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "nguoi_tao";
            this.dataGridViewTextBoxColumn3.HeaderText = "nguoi_tao";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // phong_hocBindingSource
            // 
            this.phong_hocBindingSource.DataMember = "phong_hoc";
            this.phong_hocBindingSource.DataSource = this.teachICTUDataSet1;
            // 
            // teachICTUDataSet1
            // 
            this.teachICTUDataSet1.DataSetName = "TeachICTUDataSet1";
            this.teachICTUDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // idTextEdit
            // 
            this.idTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.phong_hocBindingSource, "id", true));
            this.idTextEdit.Location = new System.Drawing.Point(225, 179);
            this.idTextEdit.Name = "idTextEdit";
            this.idTextEdit.Size = new System.Drawing.Size(125, 22);
            this.idTextEdit.TabIndex = 11;
            // 
            // ten_phong_hocTextEdit
            // 
            this.ten_phong_hocTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.phong_hocBindingSource, "ten_phong_hoc", true));
            this.ten_phong_hocTextEdit.Location = new System.Drawing.Point(225, 207);
            this.ten_phong_hocTextEdit.Name = "ten_phong_hocTextEdit";
            this.ten_phong_hocTextEdit.Size = new System.Drawing.Size(125, 22);
            this.ten_phong_hocTextEdit.TabIndex = 13;
            // 
            // trang_thaiCheckEdit
            // 
            this.trang_thaiCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.phong_hocBindingSource, "trang_thai", true));
            this.trang_thaiCheckEdit.Location = new System.Drawing.Point(225, 235);
            this.trang_thaiCheckEdit.Name = "trang_thaiCheckEdit";
            this.trang_thaiCheckEdit.Properties.Caption = "checkEdit1";
            this.trang_thaiCheckEdit.Size = new System.Drawing.Size(125, 24);
            this.trang_thaiCheckEdit.TabIndex = 15;
            // 
            // nguoi_taoTextEdit
            // 
            this.nguoi_taoTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.phong_hocBindingSource, "nguoi_tao", true));
            this.nguoi_taoTextEdit.Location = new System.Drawing.Point(225, 265);
            this.nguoi_taoTextEdit.Name = "nguoi_taoTextEdit";
            this.nguoi_taoTextEdit.Size = new System.Drawing.Size(125, 22);
            this.nguoi_taoTextEdit.TabIndex = 17;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(409, 578);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(256, 578);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(113, 578);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // phong_hocTableAdapter
            // 
            this.phong_hocTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.khoa_hocTableAdapter = null;
            this.tableAdapterManager.loginTableAdapter = null;
            this.tableAdapterManager.monhocTableAdapter = null;
            this.tableAdapterManager.phong_hocTableAdapter = this.phong_hocTableAdapter;
            this.tableAdapterManager.studentTableAdapter = null;
            this.tableAdapterManager.teacherTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = appTeach_ICTU.TeachICTUDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usersTableAdapter = null;
            // 
            // QLiPhongHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1485, 703);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.label1);
            this.Name = "QLiPhongHoc";
            this.Text = "QLiPhongHoc";
            this.Load += new System.EventHandler(this.QLiPhongHoc_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.phong_hocDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phong_hocBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachICTUDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ten_phong_hocTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trang_thaiCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nguoi_taoTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private TeachICTUDataSet1 teachICTUDataSet1;
        private System.Windows.Forms.BindingSource phong_hocBindingSource;
        private TeachICTUDataSet1TableAdapters.phong_hocTableAdapter phong_hocTableAdapter;
        private TeachICTUDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView phong_hocDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DevExpress.XtraEditors.TextEdit idTextEdit;
        private DevExpress.XtraEditors.TextEdit ten_phong_hocTextEdit;
        private DevExpress.XtraEditors.CheckEdit trang_thaiCheckEdit;
        private DevExpress.XtraEditors.TextEdit nguoi_taoTextEdit;
    }
}