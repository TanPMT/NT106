namespace TCP_Server
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnstart = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.ReceivedMessagesListBox = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 45;
            this.label3.Text = "SERVER";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 16);
            this.label2.TabIndex = 44;
            this.label2.Text = "Received Message";
            // 
            // btnstart
            // 
            this.btnstart.Location = new System.Drawing.Point(447, 353);
            this.btnstart.Name = "btnstart";
            this.btnstart.Size = new System.Drawing.Size(93, 49);
            this.btnstart.TabIndex = 42;
            this.btnstart.Text = "Start";
            this.btnstart.UseVisualStyleBackColor = true;
            this.btnstart.Click += new System.EventHandler(this.btnstart_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(468, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 16);
            this.label5.TabIndex = 49;
            // 
            // ReceivedMessagesListBox
            // 
            this.ReceivedMessagesListBox.FormattingEnabled = true;
            this.ReceivedMessagesListBox.ItemHeight = 16;
            this.ReceivedMessagesListBox.Location = new System.Drawing.Point(55, 112);
            this.ReceivedMessagesListBox.Name = "ReceivedMessagesListBox";
            this.ReceivedMessagesListBox.Size = new System.Drawing.Size(620, 212);
            this.ReceivedMessagesListBox.TabIndex = 51;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(584, 353);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 49);
            this.button1.TabIndex = 52;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ReceivedMessagesListBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnstart);
            this.Name = "Form1";
            this.Text = "Server";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnstart;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox ReceivedMessagesListBox;
        private System.Windows.Forms.Button button1;
    }
}

