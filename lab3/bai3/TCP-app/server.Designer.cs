namespace TCP_app
{
    partial class server
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
            this.label1 = new System.Windows.Forms.Label();
            this.stop = new System.Windows.Forms.Button();
            this.listen = new System.Windows.Forms.Button();
            this.messageBox = new System.Windows.Forms.RichTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(345, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 38;
            this.label3.Text = "SERVER";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 16);
            this.label2.TabIndex = 37;
            this.label2.Text = "Received Message";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 16);
            this.label1.TabIndex = 36;
            this.label1.Text = "port";
            // 
            // stop
            // 
            this.stop.Location = new System.Drawing.Point(630, 120);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(75, 30);
            this.stop.TabIndex = 35;
            this.stop.Text = "stop";
            this.stop.UseVisualStyleBackColor = true;
            // 
            // listen
            // 
            this.listen.Location = new System.Drawing.Point(630, 83);
            this.listen.Name = "listen";
            this.listen.Size = new System.Drawing.Size(75, 31);
            this.listen.TabIndex = 34;
            this.listen.Text = "listen";
            this.listen.UseVisualStyleBackColor = true;
            this.listen.Click += new System.EventHandler(this.listen_Click);
            // 
            // messageBox
            // 
            this.messageBox.Location = new System.Drawing.Point(96, 192);
            this.messageBox.Name = "messageBox";
            this.messageBox.Size = new System.Drawing.Size(609, 223);
            this.messageBox.TabIndex = 33;
            this.messageBox.Text = "";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(132, 83);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 32;
            // 
            // server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.listen);
            this.Controls.Add(this.messageBox);
            this.Controls.Add(this.textBox1);
            this.Name = "server";
            this.Text = "server";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.Button listen;
        private System.Windows.Forms.RichTextBox messageBox;
        private System.Windows.Forms.TextBox textBox1;
    }
}