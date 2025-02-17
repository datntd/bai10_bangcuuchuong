namespace bai10_bangcuuchuong
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
            this.txtso = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTInhTong = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lsbBcc = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "nhap so";
            // 
            // txtso
            // 
            this.txtso.Location = new System.Drawing.Point(243, 113);
            this.txtso.Name = "txtso";
            this.txtso.Size = new System.Drawing.Size(100, 20);
            this.txtso.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "bang cuu chuong";
            // 
            // btnTInhTong
            // 
            this.btnTInhTong.Location = new System.Drawing.Point(453, 199);
            this.btnTInhTong.Name = "btnTInhTong";
            this.btnTInhTong.Size = new System.Drawing.Size(75, 23);
            this.btnTInhTong.TabIndex = 4;
            this.btnTInhTong.Text = "tinh tong";
            this.btnTInhTong.UseVisualStyleBackColor = true;
            this.btnTInhTong.Click += new System.EventHandler(this.btnTInhTong_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(454, 277);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // lsbBcc
            // 
            this.lsbBcc.FormattingEnabled = true;
            this.lsbBcc.Location = new System.Drawing.Point(84, 180);
            this.lsbBcc.Name = "lsbBcc";
            this.lsbBcc.Size = new System.Drawing.Size(283, 251);
            this.lsbBcc.TabIndex = 5;

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lsbBcc);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnTInhTong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtso);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTInhTong;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox lsbBcc;
    }
}

