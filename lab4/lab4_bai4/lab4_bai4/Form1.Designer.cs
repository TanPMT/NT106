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
            this.btnGo = new System.Windows.Forms.Button();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.btnDowHTML = new System.Windows.Forms.Button();
            this.btnViewSource = new System.Windows.Forms.Button();
            this.tbPath = new System.Windows.Forms.TextBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // btnGo
            // 
            this.btnGo.AutoSize = true;
            this.btnGo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnGo.Location = new System.Drawing.Point(1080, 38);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(274, 31);
            this.btnGo.TabIndex = 8;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = false;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(38, 38);
            this.tbAddress.Multiline = true;
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(1031, 31);
            this.tbAddress.TabIndex = 9;
            // 
            // btnDowHTML
            // 
            this.btnDowHTML.AutoSize = true;
            this.btnDowHTML.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDowHTML.Location = new System.Drawing.Point(1080, 76);
            this.btnDowHTML.Name = "btnDowHTML";
            this.btnDowHTML.Size = new System.Drawing.Size(141, 31);
            this.btnDowHTML.TabIndex = 10;
            this.btnDowHTML.Text = "Download HTML ";
            this.btnDowHTML.UseVisualStyleBackColor = false;
            this.btnDowHTML.Click += new System.EventHandler(this.btnDowHTML_Click);
            // 
            // btnViewSource
            // 
            this.btnViewSource.AutoSize = true;
            this.btnViewSource.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnViewSource.Location = new System.Drawing.Point(1232, 76);
            this.btnViewSource.Name = "btnViewSource";
            this.btnViewSource.Size = new System.Drawing.Size(123, 31);
            this.btnViewSource.TabIndex = 12;
            this.btnViewSource.Text = "ViewSource";
            this.btnViewSource.UseVisualStyleBackColor = false;
            this.btnViewSource.Click += new System.EventHandler(this.btnViewSource_Click);
            // 
            // tbPath
            // 
            this.tbPath.Location = new System.Drawing.Point(1360, 458);
            this.tbPath.Multiline = true;
            this.tbPath.Name = "tbPath";
            this.tbPath.Size = new System.Drawing.Size(10, 10);
            this.tbPath.TabIndex = 11;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(38, 130);
            this.webBrowser1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(18, 16);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1316, 382);
            this.webBrowser1.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1559, 466);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.btnDowHTML);
            this.Controls.Add(this.btnViewSource);
            this.Controls.Add(this.tbPath);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.Button btnDowHTML;
        private System.Windows.Forms.Button btnViewSource;
        private System.Windows.Forms.TextBox tbPath;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}

