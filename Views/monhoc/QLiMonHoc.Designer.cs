namespace appTeach_ICTU.Views
{
    partial class QLiMonHoc
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
            System.Windows.Forms.Label ma_mon_hocLabel;
            System.Windows.Forms.Label ten_mon_hocLabel;
            System.Windows.Forms.Label lop_hoc_phanLabel;
            System.Windows.Forms.Label so_tin_chiLabel;
            System.Windows.Forms.Label khoa_hocLabel;
            System.Windows.Forms.Label hoc_kiLabel;
            System.Windows.Forms.Label thoi_gian_dayLabel;
            System.Windows.Forms.Label trang_thaiLabel;
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.monhocDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.monhocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teachICTUDataSet1 = new appTeach_ICTU.TeachICTUDataSet1();
            this.idTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ma_mon_hocTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ten_mon_hocTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.lop_hoc_phanTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.so_tin_chiSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.khoa_hocTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.hoc_kiTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.thoi_gian_dayDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.trang_thaiCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.monhocTableAdapter = new appTeach_ICTU.TeachICTUDataSet1TableAdapters.monhocTableAdapter();
            this.tableAdapterManager = new appTeach_ICTU.TeachICTUDataSet1TableAdapters.TableAdapterManager();
            this.button1 = new System.Windows.Forms.Button();
            idLabel = new System.Windows.Forms.Label();
            ma_mon_hocLabel = new System.Windows.Forms.Label();
            ten_mon_hocLabel = new System.Windows.Forms.Label();
            lop_hoc_phanLabel = new System.Windows.Forms.Label();
            so_tin_chiLabel = new System.Windows.Forms.Label();
            khoa_hocLabel = new System.Windows.Forms.Label();
            hoc_kiLabel = new System.Windows.Forms.Label();
            thoi_gian_dayLabel = new System.Windows.Forms.Label();
            trang_thaiLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.monhocDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monhocBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachICTUDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ma_mon_hocTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ten_mon_hocTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lop_hoc_phanTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.so_tin_chiSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoa_hocTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoc_kiTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thoi_gian_dayDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thoi_gian_dayDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trang_thaiCheckEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(107, 89);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(21, 16);
            idLabel.TabIndex = 19;
            idLabel.Text = "id:";
            // 
            // ma_mon_hocLabel
            // 
            ma_mon_hocLabel.AutoSize = true;
            ma_mon_hocLabel.Location = new System.Drawing.Point(107, 117);
            ma_mon_hocLabel.Name = "ma_mon_hocLabel";
            ma_mon_hocLabel.Size = new System.Drawing.Size(83, 16);
            ma_mon_hocLabel.TabIndex = 21;
            ma_mon_hocLabel.Text = "ma mon hoc:";
            // 
            // ten_mon_hocLabel
            // 
            ten_mon_hocLabel.AutoSize = true;
            ten_mon_hocLabel.Location = new System.Drawing.Point(107, 145);
            ten_mon_hocLabel.Name = "ten_mon_hocLabel";
            ten_mon_hocLabel.Size = new System.Drawing.Size(82, 16);
            ten_mon_hocLabel.TabIndex = 23;
            ten_mon_hocLabel.Text = "ten mon hoc:";
            // 
            // lop_hoc_phanLabel
            // 
            lop_hoc_phanLabel.AutoSize = true;
            lop_hoc_phanLabel.Location = new System.Drawing.Point(107, 173);
            lop_hoc_phanLabel.Name = "lop_hoc_phanLabel";
            lop_hoc_phanLabel.Size = new System.Drawing.Size(87, 16);
            lop_hoc_phanLabel.TabIndex = 25;
            lop_hoc_phanLabel.Text = "lop hoc phan:";
            // 
            // so_tin_chiLabel
            // 
            so_tin_chiLabel.AutoSize = true;
            so_tin_chiLabel.Location = new System.Drawing.Point(107, 201);
            so_tin_chiLabel.Name = "so_tin_chiLabel";
            so_tin_chiLabel.Size = new System.Drawing.Size(61, 16);
            so_tin_chiLabel.TabIndex = 27;
            so_tin_chiLabel.Text = "so tin chi:";
            // 
            // khoa_hocLabel
            // 
            khoa_hocLabel.AutoSize = true;
            khoa_hocLabel.Location = new System.Drawing.Point(107, 231);
            khoa_hocLabel.Name = "khoa_hocLabel";
            khoa_hocLabel.Size = new System.Drawing.Size(65, 16);
            khoa_hocLabel.TabIndex = 29;
            khoa_hocLabel.Text = "khoa hoc:";
            // 
            // hoc_kiLabel
            // 
            hoc_kiLabel.AutoSize = true;
            hoc_kiLabel.Location = new System.Drawing.Point(107, 259);
            hoc_kiLabel.Name = "hoc_kiLabel";
            hoc_kiLabel.Size = new System.Drawing.Size(45, 16);
            hoc_kiLabel.TabIndex = 31;
            hoc_kiLabel.Text = "hoc ki:";
            // 
            // thoi_gian_dayLabel
            // 
            thoi_gian_dayLabel.AutoSize = true;
            thoi_gian_dayLabel.Location = new System.Drawing.Point(107, 287);
            thoi_gian_dayLabel.Name = "thoi_gian_dayLabel";
            thoi_gian_dayLabel.Size = new System.Drawing.Size(86, 16);
            thoi_gian_dayLabel.TabIndex = 33;
            thoi_gian_dayLabel.Text = "thoi gian day:";
            // 
            // trang_thaiLabel
            // 
            trang_thaiLabel.AutoSize = true;
            trang_thaiLabel.Location = new System.Drawing.Point(107, 343);
            trang_thaiLabel.Name = "trang_thaiLabel";
            trang_thaiLabel.Size = new System.Drawing.Size(64, 16);
            trang_thaiLabel.TabIndex = 37;
            trang_thaiLabel.Text = "trang thai:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(94, 532);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(324, 532);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 18;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(224, 532);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(75, 23);
            this.btnupdate.TabIndex = 19;
            this.btnupdate.Text = "Sửa";
            this.btnupdate.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(12, 85);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.monhocDataGridView);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.Controls.Add(idLabel);
            this.splitContainer1.Panel2.Controls.Add(this.idTextEdit);
            this.splitContainer1.Panel2.Controls.Add(ma_mon_hocLabel);
            this.splitContainer1.Panel2.Controls.Add(this.ma_mon_hocTextEdit);
            this.splitContainer1.Panel2.Controls.Add(ten_mon_hocLabel);
            this.splitContainer1.Panel2.Controls.Add(this.ten_mon_hocTextEdit);
            this.splitContainer1.Panel2.Controls.Add(lop_hoc_phanLabel);
            this.splitContainer1.Panel2.Controls.Add(this.lop_hoc_phanTextEdit);
            this.splitContainer1.Panel2.Controls.Add(so_tin_chiLabel);
            this.splitContainer1.Panel2.Controls.Add(this.so_tin_chiSpinEdit);
            this.splitContainer1.Panel2.Controls.Add(khoa_hocLabel);
            this.splitContainer1.Panel2.Controls.Add(this.khoa_hocTextEdit);
            this.splitContainer1.Panel2.Controls.Add(hoc_kiLabel);
            this.splitContainer1.Panel2.Controls.Add(this.hoc_kiTextEdit);
            this.splitContainer1.Panel2.Controls.Add(thoi_gian_dayLabel);
            this.splitContainer1.Panel2.Controls.Add(this.thoi_gian_dayDateEdit);
            this.splitContainer1.Panel2.Controls.Add(trang_thaiLabel);
            this.splitContainer1.Panel2.Controls.Add(this.trang_thaiCheckEdit);
            this.splitContainer1.Panel2.Controls.Add(this.btnAdd);
            this.splitContainer1.Panel2.Controls.Add(this.btnXoa);
            this.splitContainer1.Panel2.Controls.Add(this.btnupdate);
            this.splitContainer1.Size = new System.Drawing.Size(1461, 606);
            this.splitContainer1.SplitterDistance = 1006;
            this.splitContainer1.TabIndex = 20;
            // 
            // monhocDataGridView
            // 
            this.monhocDataGridView.AutoGenerateColumns = false;
            this.monhocDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.monhocDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewCheckBoxColumn1});
            this.monhocDataGridView.DataSource = this.monhocBindingSource;
            this.monhocDataGridView.Location = new System.Drawing.Point(12, 15);
            this.monhocDataGridView.Name = "monhocDataGridView";
            this.monhocDataGridView.RowHeadersWidth = 51;
            this.monhocDataGridView.RowTemplate.Height = 24;
            this.monhocDataGridView.Size = new System.Drawing.Size(991, 588);
            this.monhocDataGridView.TabIndex = 0;
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
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ma_mon_hoc";
            this.dataGridViewTextBoxColumn2.HeaderText = "ma_mon_hoc";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ten_mon_hoc";
            this.dataGridViewTextBoxColumn3.HeaderText = "ten_mon_hoc";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "lop_hoc_phan";
            this.dataGridViewTextBoxColumn4.HeaderText = "lop_hoc_phan";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "so_tin_chi";
            this.dataGridViewTextBoxColumn5.HeaderText = "so_tin_chi";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "khoa_hoc";
            this.dataGridViewTextBoxColumn6.HeaderText = "khoa_hoc";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "hoc_ki";
            this.dataGridViewTextBoxColumn7.HeaderText = "hoc_ki";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "thoi_gian_day";
            this.dataGridViewTextBoxColumn8.HeaderText = "thoi_gian_day";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "trang_thai";
            this.dataGridViewCheckBoxColumn1.HeaderText = "trang_thai";
            this.dataGridViewCheckBoxColumn1.MinimumWidth = 6;
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.Width = 125;
            // 
            // monhocBindingSource
            // 
            this.monhocBindingSource.DataMember = "monhoc";
            this.monhocBindingSource.DataSource = this.teachICTUDataSet1;
            // 
            // teachICTUDataSet1
            // 
            this.teachICTUDataSet1.DataSetName = "TeachICTUDataSet1";
            this.teachICTUDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // idTextEdit
            // 
            this.idTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.monhocBindingSource, "id", true));
            this.idTextEdit.Enabled = false;
            this.idTextEdit.Location = new System.Drawing.Point(200, 86);
            this.idTextEdit.Name = "idTextEdit";
            this.idTextEdit.Size = new System.Drawing.Size(125, 22);
            this.idTextEdit.TabIndex = 20;
            // 
            // ma_mon_hocTextEdit
            // 
            this.ma_mon_hocTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.monhocBindingSource, "ma_mon_hoc", true));
            this.ma_mon_hocTextEdit.Location = new System.Drawing.Point(200, 114);
            this.ma_mon_hocTextEdit.Name = "ma_mon_hocTextEdit";
            this.ma_mon_hocTextEdit.Size = new System.Drawing.Size(125, 22);
            this.ma_mon_hocTextEdit.TabIndex = 22;
            // 
            // ten_mon_hocTextEdit
            // 
            this.ten_mon_hocTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.monhocBindingSource, "ten_mon_hoc", true));
            this.ten_mon_hocTextEdit.Location = new System.Drawing.Point(200, 142);
            this.ten_mon_hocTextEdit.Name = "ten_mon_hocTextEdit";
            this.ten_mon_hocTextEdit.Size = new System.Drawing.Size(125, 22);
            this.ten_mon_hocTextEdit.TabIndex = 24;
            // 
            // lop_hoc_phanTextEdit
            // 
            this.lop_hoc_phanTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.monhocBindingSource, "lop_hoc_phan", true));
            this.lop_hoc_phanTextEdit.Location = new System.Drawing.Point(200, 170);
            this.lop_hoc_phanTextEdit.Name = "lop_hoc_phanTextEdit";
            this.lop_hoc_phanTextEdit.Size = new System.Drawing.Size(125, 22);
            this.lop_hoc_phanTextEdit.TabIndex = 26;
            // 
            // so_tin_chiSpinEdit
            // 
            this.so_tin_chiSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.monhocBindingSource, "so_tin_chi", true));
            this.so_tin_chiSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.so_tin_chiSpinEdit.Location = new System.Drawing.Point(200, 198);
            this.so_tin_chiSpinEdit.Name = "so_tin_chiSpinEdit";
            this.so_tin_chiSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.so_tin_chiSpinEdit.Size = new System.Drawing.Size(125, 24);
            this.so_tin_chiSpinEdit.TabIndex = 28;
            // 
            // khoa_hocTextEdit
            // 
            this.khoa_hocTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.monhocBindingSource, "khoa_hoc", true));
            this.khoa_hocTextEdit.Location = new System.Drawing.Point(200, 228);
            this.khoa_hocTextEdit.Name = "khoa_hocTextEdit";
            this.khoa_hocTextEdit.Size = new System.Drawing.Size(125, 22);
            this.khoa_hocTextEdit.TabIndex = 30;
            // 
            // hoc_kiTextEdit
            // 
            this.hoc_kiTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.monhocBindingSource, "hoc_ki", true));
            this.hoc_kiTextEdit.Location = new System.Drawing.Point(200, 256);
            this.hoc_kiTextEdit.Name = "hoc_kiTextEdit";
            this.hoc_kiTextEdit.Size = new System.Drawing.Size(125, 22);
            this.hoc_kiTextEdit.TabIndex = 32;
            // 
            // thoi_gian_dayDateEdit
            // 
            this.thoi_gian_dayDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.monhocBindingSource, "thoi_gian_day", true));
            this.thoi_gian_dayDateEdit.EditValue = null;
            this.thoi_gian_dayDateEdit.Location = new System.Drawing.Point(200, 284);
            this.thoi_gian_dayDateEdit.Name = "thoi_gian_dayDateEdit";
            this.thoi_gian_dayDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.thoi_gian_dayDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.thoi_gian_dayDateEdit.Size = new System.Drawing.Size(125, 22);
            this.thoi_gian_dayDateEdit.TabIndex = 34;
            // 
            // trang_thaiCheckEdit
            // 
            this.trang_thaiCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.monhocBindingSource, "trang_thai", true));
            this.trang_thaiCheckEdit.Location = new System.Drawing.Point(200, 340);
            this.trang_thaiCheckEdit.Name = "trang_thaiCheckEdit";
            this.trang_thaiCheckEdit.Properties.Caption = "checkEdit1";
            this.trang_thaiCheckEdit.Size = new System.Drawing.Size(125, 24);
            this.trang_thaiCheckEdit.TabIndex = 38;
            // 
            // monhocTableAdapter
            // 
            this.monhocTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.khoa_hocTableAdapter = null;
            this.tableAdapterManager.loginTableAdapter = null;
            this.tableAdapterManager.monhocTableAdapter = this.monhocTableAdapter;
            this.tableAdapterManager.phong_hocTableAdapter = null;
            this.tableAdapterManager.studentTableAdapter = null;
            this.tableAdapterManager.teacherTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = appTeach_ICTU.TeachICTUDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usersTableAdapter = null;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // QLiMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1485, 703);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.splitContainer1);
            this.Name = "QLiMonHoc";
            this.Text = "QLiMonHoc";
            this.Load += new System.EventHandler(this.QLiMonHoc_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.monhocDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monhocBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachICTUDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ma_mon_hocTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ten_mon_hocTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lop_hoc_phanTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.so_tin_chiSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoa_hocTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoc_kiTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thoi_gian_dayDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thoi_gian_dayDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trang_thaiCheckEdit.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private TeachICTUDataSet1 teachICTUDataSet1;
        private System.Windows.Forms.BindingSource monhocBindingSource;
        private TeachICTUDataSet1TableAdapters.monhocTableAdapter monhocTableAdapter;
        private TeachICTUDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView monhocDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private DevExpress.XtraEditors.TextEdit idTextEdit;
        private DevExpress.XtraEditors.TextEdit ma_mon_hocTextEdit;
        private DevExpress.XtraEditors.TextEdit ten_mon_hocTextEdit;
        private DevExpress.XtraEditors.TextEdit lop_hoc_phanTextEdit;
        private DevExpress.XtraEditors.SpinEdit so_tin_chiSpinEdit;
        private DevExpress.XtraEditors.TextEdit khoa_hocTextEdit;
        private DevExpress.XtraEditors.TextEdit hoc_kiTextEdit;
        private DevExpress.XtraEditors.DateEdit thoi_gian_dayDateEdit;
        private DevExpress.XtraEditors.CheckEdit trang_thaiCheckEdit;
        private System.Windows.Forms.Button button1;
    }
}