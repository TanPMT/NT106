namespace lab4_bai4
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
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.btnDowHTML = new System.Windows.Forms.Button();
            this.tbPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(38, 38);
            this.tbAddress.Multiline = true;
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(1075, 31);
            this.tbAddress.TabIndex = 9;
            // 
            // btnDowHTML
            // 
            this.btnDowHTML.AutoSize = true;
            this.btnDowHTML.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDowHTML.Location = new System.Drawing.Point(1154, 38);
            this.btnDowHTML.Name = "btnDowHTML";
            this.btnDowHTML.Size = new System.Drawing.Size(141, 31);
            this.btnDowHTML.TabIndex = 10;
            this.btnDowHTML.Text = "Download HTML ";
            this.btnDowHTML.UseVisualStyleBackColor = false;
            this.btnDowHTML.Click += new System.EventHandler(this.btnDowHTML_Click);
            // 
            // tbPath
            // 
            this.tbPath.Location = new System.Drawing.Point(38, 76);
            this.tbPath.Multiline = true;
            this.tbPath.Name = "tbPath";
            this.tbPath.Size = new System.Drawing.Size(1075, 31);
            this.tbPath.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "https://www.facebook.com";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "C:\\Users\\Lenovo\\Desktop";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1559, 466);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.btnDowHTML);
            this.Controls.Add(this.tbPath);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.Button btnDowHTML;
        private System.Windows.Forms.TextBox tbPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

