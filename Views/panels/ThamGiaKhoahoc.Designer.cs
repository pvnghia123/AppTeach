namespace appTeach_ICTU.Views.panels
{
    partial class ThamGiaKhoahoc
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
            this.btnthamgia = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnthamgia
            // 
            this.btnthamgia.BackColor = System.Drawing.Color.Lime;
            this.btnthamgia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthamgia.Location = new System.Drawing.Point(187, 284);
            this.btnthamgia.Name = "btnthamgia";
            this.btnthamgia.Size = new System.Drawing.Size(191, 49);
            this.btnthamgia.TabIndex = 0;
            this.btnthamgia.Text = "Tham Gia";
            this.btnthamgia.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhập link";
            // 
            // ThamGiaKhoahoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 398);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnthamgia);
            this.Name = "ThamGiaKhoahoc";
            this.Text = "ThamGiaKhoahoc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnthamgia;
        private System.Windows.Forms.Label label1;
    }
}