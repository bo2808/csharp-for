namespace csharp_for
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblgiaithua = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txtkq = new System.Windows.Forms.TextBox();
            this.btntinh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "nhập số";
            // 
            // lblgiaithua
            // 
            this.lblgiaithua.AutoSize = true;
            this.lblgiaithua.Location = new System.Drawing.Point(83, 149);
            this.lblgiaithua.Name = "lblgiaithua";
            this.lblgiaithua.Size = new System.Drawing.Size(47, 13);
            this.lblgiaithua.TabIndex = 1;
            this.lblgiaithua.Text = "giai thừa";
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(179, 83);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(100, 20);
            this.txt1.TabIndex = 2;
            // 
            // txtkq
            // 
            this.txtkq.Location = new System.Drawing.Point(179, 146);
            this.txtkq.Name = "txtkq";
            this.txtkq.Size = new System.Drawing.Size(100, 20);
            this.txtkq.TabIndex = 3;
            // 
            // btntinh
            // 
            this.btntinh.Location = new System.Drawing.Point(179, 202);
            this.btntinh.Name = "btntinh";
            this.btntinh.Size = new System.Drawing.Size(75, 23);
            this.btntinh.TabIndex = 4;
            this.btntinh.Text = "tính";
            this.btntinh.UseVisualStyleBackColor = true;
            this.btntinh.Click += new System.EventHandler(this.btntinh_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btntinh);
            this.Controls.Add(this.txtkq);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.lblgiaithua);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblgiaithua;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txtkq;
        private System.Windows.Forms.Button btntinh;
    }
}

