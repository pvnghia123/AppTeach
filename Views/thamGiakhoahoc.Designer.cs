namespace appTeach_ICTU.Views
{
    partial class thamGiakhoahoc
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
            this.btnThamgia = new System.Windows.Forms.Button();
            this.txtlink = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.khoahocResponseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.khoahocResponseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThamgia
            // 
            this.btnThamgia.Location = new System.Drawing.Point(271, 161);
            this.btnThamgia.Name = "btnThamgia";
            this.btnThamgia.Size = new System.Drawing.Size(75, 33);
            this.btnThamgia.TabIndex = 0;
            this.btnThamgia.Text = "Tham gia";
            this.btnThamgia.UseVisualStyleBackColor = true;
            this.btnThamgia.Click += new System.EventHandler(this.btnThamgia_Click);
            // 
            // txtlink
            // 
            this.txtlink.Location = new System.Drawing.Point(148, 109);
            this.txtlink.Name = "txtlink";
            this.txtlink.Size = new System.Drawing.Size(240, 22);
            this.txtlink.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "linkHoc";
            // 
            // khoahocResponseBindingSource
            // 
            this.khoahocResponseBindingSource.DataSource = typeof(Model.model.khoahocResponse);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(165, 166);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // thamGiakhoahoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 234);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtlink);
            this.Controls.Add(this.btnThamgia);
            this.Name = "thamGiakhoahoc";
            this.Text = "thamGiakhoahoc";
            ((System.ComponentModel.ISupportInitialize)(this.khoahocResponseBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource khoahocResponseBindingSource;
        private System.Windows.Forms.Button btnThamgia;
        private System.Windows.Forms.TextBox txtlink;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}