namespace TCP_Client
{
    partial class client
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnsend = new System.Windows.Forms.Button();
            this.MessageTextBox = new System.Windows.Forms.TextBox();
            this.btnconect = new System.Windows.Forms.Button();
            this.ReceivedMessagesListBox = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(163, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 16);
            this.label4.TabIndex = 25;
            this.label4.Text = "CLIENT";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 24;
            this.label3.Text = "Message";
            // 
            // btnsend
            // 
            this.btnsend.Location = new System.Drawing.Point(445, 322);
            this.btnsend.Name = "btnsend";
            this.btnsend.Size = new System.Drawing.Size(69, 42);
            this.btnsend.TabIndex = 23;
            this.btnsend.Text = "Send";
            this.btnsend.UseVisualStyleBackColor = true;
            this.btnsend.Click += new System.EventHandler(this.btnsend_Click);
            // 
            // MessageTextBox
            // 
            this.MessageTextBox.Location = new System.Drawing.Point(166, 280);
            this.MessageTextBox.Name = "MessageTextBox";
            this.MessageTextBox.Size = new System.Drawing.Size(348, 22);
            this.MessageTextBox.TabIndex = 28;
            // 
            // btnconect
            // 
            this.btnconect.Location = new System.Drawing.Point(349, 322);
            this.btnconect.Name = "btnconect";
            this.btnconect.Size = new System.Drawing.Size(82, 42);
            this.btnconect.TabIndex = 29;
            this.btnconect.Text = "Conect";
            this.btnconect.UseVisualStyleBackColor = true;
            this.btnconect.Click += new System.EventHandler(this.btnconect_Click);
            // 
            // ReceivedMessagesListBox
            // 
            this.ReceivedMessagesListBox.FormattingEnabled = true;
            this.ReceivedMessagesListBox.ItemHeight = 16;
            this.ReceivedMessagesListBox.Location = new System.Drawing.Point(166, 60);
            this.ReceivedMessagesListBox.Name = "ReceivedMessagesListBox";
            this.ReceivedMessagesListBox.Size = new System.Drawing.Size(348, 212);
            this.ReceivedMessagesListBox.TabIndex = 30;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(601, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 39);
            this.button1.TabIndex = 31;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ReceivedMessagesListBox);
            this.Controls.Add(this.btnconect);
            this.Controls.Add(this.MessageTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnsend);
            this.Name = "client";
            this.Text = "Client";
            this.Load += new System.EventHandler(this.client_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnsend;
        private System.Windows.Forms.TextBox MessageTextBox;
        private System.Windows.Forms.Button btnconect;
        private System.Windows.Forms.ListBox ReceivedMessagesListBox;
        private System.Windows.Forms.Button button1;
    }
}

