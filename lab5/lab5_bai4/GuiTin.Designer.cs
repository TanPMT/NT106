namespace lab5_bai4
{
    partial class GuiTin
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
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_send = new System.Windows.Forms.Button();
            this.tbBody = new System.Windows.Forms.RichTextBox();
            this.tbSubject = new System.Windows.Forms.MaskedTextBox();
            this.tbTo = new System.Windows.Forms.MaskedTextBox();
            this.btn_file = new System.Windows.Forms.Button();
            this.tbLink = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(132, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 16);
            this.label5.TabIndex = 21;
            this.label5.Text = "To:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(132, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "Subject:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "Body:";
            // 
            // btn_send
            // 
            this.btn_send.Location = new System.Drawing.Point(878, 17);
            this.btn_send.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(140, 112);
            this.btn_send.TabIndex = 16;
            this.btn_send.Text = "Send";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // tbBody
            // 
            this.tbBody.Location = new System.Drawing.Point(218, 186);
            this.tbBody.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbBody.Name = "tbBody";
            this.tbBody.Size = new System.Drawing.Size(469, 138);
            this.tbBody.TabIndex = 15;
            this.tbBody.Text = "";
            // 
            // tbSubject
            // 
            this.tbSubject.Location = new System.Drawing.Point(218, 108);
            this.tbSubject.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSubject.Name = "tbSubject";
            this.tbSubject.Size = new System.Drawing.Size(469, 22);
            this.tbSubject.TabIndex = 13;
            // 
            // tbTo
            // 
            this.tbTo.Location = new System.Drawing.Point(218, 17);
            this.tbTo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbTo.Name = "tbTo";
            this.tbTo.Size = new System.Drawing.Size(469, 22);
            this.tbTo.TabIndex = 12;
            this.tbTo.Text = "pmt@pmt.nt106";
            // 
            // btn_file
            // 
            this.btn_file.Location = new System.Drawing.Point(116, 362);
            this.btn_file.Name = "btn_file";
            this.btn_file.Size = new System.Drawing.Size(71, 41);
            this.btn_file.TabIndex = 22;
            this.btn_file.Text = "File";
            this.btn_file.UseVisualStyleBackColor = true;
            this.btn_file.Click += new System.EventHandler(this.btn_file_Click);
            // 
            // tbLink
            // 
            this.tbLink.Location = new System.Drawing.Point(218, 381);
            this.tbLink.Name = "tbLink";
            this.tbLink.Size = new System.Drawing.Size(469, 22);
            this.tbLink.TabIndex = 23;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(878, 318);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 85);
            this.button1.TabIndex = 24;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GuiTin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 625);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbLink);
            this.Controls.Add(this.btn_file);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.tbBody);
            this.Controls.Add(this.tbSubject);
            this.Controls.Add(this.tbTo);
            this.Name = "GuiTin";
            this.Text = "GuiMail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.RichTextBox tbBody;
        private System.Windows.Forms.MaskedTextBox tbSubject;
        private System.Windows.Forms.MaskedTextBox tbTo;
        private System.Windows.Forms.Button btn_file;
        private System.Windows.Forms.TextBox tbLink;
        private System.Windows.Forms.Button button1;
    }
}