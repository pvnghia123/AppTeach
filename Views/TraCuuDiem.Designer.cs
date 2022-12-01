namespace appTeach_ICTU.Views
{
    partial class TraCuuDiem
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monhocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.khoahocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemheso1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemheso2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemTbDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diemResponseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diemResponseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(473, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nội Dung";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(559, 47);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(205, 22);
            this.txtName.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(801, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Tìm kiếm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.monhocDataGridViewTextBoxColumn,
            this.khoahocDataGridViewTextBoxColumn,
            this.diemheso1DataGridViewTextBoxColumn,
            this.diemheso2DataGridViewTextBoxColumn,
            this.diemTbDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.diemResponseBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 93);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1461, 598);
            this.dataGridView1.TabIndex = 3;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // monhocDataGridViewTextBoxColumn
            // 
            this.monhocDataGridViewTextBoxColumn.DataPropertyName = "monhoc";
            this.monhocDataGridViewTextBoxColumn.HeaderText = "monhoc";
            this.monhocDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.monhocDataGridViewTextBoxColumn.Name = "monhocDataGridViewTextBoxColumn";
            this.monhocDataGridViewTextBoxColumn.Width = 125;
            // 
            // khoahocDataGridViewTextBoxColumn
            // 
            this.khoahocDataGridViewTextBoxColumn.DataPropertyName = "khoahoc";
            this.khoahocDataGridViewTextBoxColumn.HeaderText = "khoahoc";
            this.khoahocDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.khoahocDataGridViewTextBoxColumn.Name = "khoahocDataGridViewTextBoxColumn";
            this.khoahocDataGridViewTextBoxColumn.Width = 125;
            // 
            // diemheso1DataGridViewTextBoxColumn
            // 
            this.diemheso1DataGridViewTextBoxColumn.DataPropertyName = "diemheso1";
            this.diemheso1DataGridViewTextBoxColumn.HeaderText = "diemheso1";
            this.diemheso1DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.diemheso1DataGridViewTextBoxColumn.Name = "diemheso1DataGridViewTextBoxColumn";
            this.diemheso1DataGridViewTextBoxColumn.Width = 125;
            // 
            // diemheso2DataGridViewTextBoxColumn
            // 
            this.diemheso2DataGridViewTextBoxColumn.DataPropertyName = "diemheso2";
            this.diemheso2DataGridViewTextBoxColumn.HeaderText = "diemheso2";
            this.diemheso2DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.diemheso2DataGridViewTextBoxColumn.Name = "diemheso2DataGridViewTextBoxColumn";
            this.diemheso2DataGridViewTextBoxColumn.Width = 125;
            // 
            // diemTbDataGridViewTextBoxColumn
            // 
            this.diemTbDataGridViewTextBoxColumn.DataPropertyName = "diemTb";
            this.diemTbDataGridViewTextBoxColumn.HeaderText = "diemTb";
            this.diemTbDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.diemTbDataGridViewTextBoxColumn.Name = "diemTbDataGridViewTextBoxColumn";
            this.diemTbDataGridViewTextBoxColumn.Width = 125;
            // 
            // diemResponseBindingSource
            // 
            this.diemResponseBindingSource.DataSource = typeof(Model.model.diemResponse);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(927, 43);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // TraCuuDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1485, 703);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Name = "TraCuuDiem";
            this.Text = "TraCuuDiem";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diemResponseBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn monhocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn khoahocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemheso1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemheso2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diemTbDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource diemResponseBindingSource;
        private System.Windows.Forms.Button button2;
    }
}