namespace lab5_bai4
{
    partial class DangNhap_gmail
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
            this.btn_file = new System.Windows.Forms.Button();
            this.tbLink = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_send = new System.Windows.Forms.Button();
            this.tbBody = new System.Windows.Forms.RichTextBox();
            this.tbSubject = new System.Windows.Forms.MaskedTextBox();
            this.tbTo = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_file
            // 
            this.btn_file.Location = new System.Drawing.Point(48, 358);
            this.btn_file.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_file.Name = "btn_file";
            this.btn_file.Size = new System.Drawing.Size(82, 84);
            this.btn_file.TabIndex = 32;
            this.btn_file.Text = "File";
            this.btn_file.UseVisualStyleBackColor = true;
            this.btn_file.Click += new System.EventHandler(this.btn_file_Click);
            // 
            // tbLink
            // 
            this.tbLink.Location = new System.Drawing.Point(153, 358);
            this.tbLink.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbLink.Name = "tbLink";
            this.tbLink.Size = new System.Drawing.Size(430, 27);
            this.tbLink.TabIndex = 31;
            this.tbLink.Text = "";
            this.tbLink.TextChanged += new System.EventHandler(this.tbLink_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(70, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 16);
            this.label5.TabIndex = 30;
            this.label5.Text = "To:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 29;
            this.label3.Text = "Subject:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 28;
            this.label2.Text = "Body:";
            // 
            // btn_send
            // 
            this.btn_send.Location = new System.Drawing.Point(652, 358);
            this.btn_send.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(196, 84);
            this.btn_send.TabIndex = 27;
            this.btn_send.Text = "Send";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // tbBody
            // 
            this.tbBody.Location = new System.Drawing.Point(153, 107);
            this.tbBody.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbBody.Name = "tbBody";
            this.tbBody.Size = new System.Drawing.Size(695, 202);
            this.tbBody.TabIndex = 26;
            this.tbBody.Text = "";
            // 
            // tbSubject
            // 
            this.tbSubject.Location = new System.Drawing.Point(153, 69);
            this.tbSubject.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSubject.Name = "tbSubject";
            this.tbSubject.Size = new System.Drawing.Size(695, 22);
            this.tbSubject.TabIndex = 25;
            // 
            // tbTo
            // 
            this.tbTo.Location = new System.Drawing.Point(153, 17);
            this.tbTo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbTo.Name = "tbTo";
            this.tbTo.Size = new System.Drawing.Size(695, 22);
            this.tbTo.TabIndex = 24;
            this.tbTo.Text = "22521310@gm.uit.edu.vn";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(947, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 79);
            this.button1.TabIndex = 33;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DangNhap_gmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 609);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_file);
            this.Controls.Add(this.tbLink);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.tbBody);
            this.Controls.Add(this.tbSubject);
            this.Controls.Add(this.tbTo);
            this.Name = "DangNhap_gmail";
            this.Text = "ViaMail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_file;
        private System.Windows.Forms.RichTextBox tbLink;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.RichTextBox tbBody;
        private System.Windows.Forms.MaskedTextBox tbSubject;
        private System.Windows.Forms.MaskedTextBox tbTo;
        private System.Windows.Forms.Button button1;
    }
}