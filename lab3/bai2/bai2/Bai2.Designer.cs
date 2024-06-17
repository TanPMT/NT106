namespace thuchanhlab3
{
    partial class Bai2
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
            this.btn_listen = new System.Windows.Forms.Button();
            this.ListViewCommand = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_listen
            // 
            this.btn_listen.Location = new System.Drawing.Point(526, 59);
            this.btn_listen.Name = "btn_listen";
            this.btn_listen.Size = new System.Drawing.Size(88, 53);
            this.btn_listen.TabIndex = 0;
            this.btn_listen.Text = "Listen";
            this.btn_listen.UseVisualStyleBackColor = true;
            this.btn_listen.Click += new System.EventHandler(this.btn_listen_Click);
            // 
            // ListViewCommand
            // 
            this.ListViewCommand.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.ListViewCommand.HideSelection = false;
            this.ListViewCommand.Location = new System.Drawing.Point(104, 59);
            this.ListViewCommand.Name = "ListViewCommand";
            this.ListViewCommand.Size = new System.Drawing.Size(372, 260);
            this.ListViewCommand.TabIndex = 2;
            this.ListViewCommand.UseCompatibleStateImageBehavior = false;
            this.ListViewCommand.View = System.Windows.Forms.View.Tile;
            this.ListViewCommand.SelectedIndexChanged += new System.EventHandler(this.ListViewCommand_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(645, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 53);
            this.button1.TabIndex = 3;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Bai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ListViewCommand);
            this.Controls.Add(this.btn_listen);
            this.Name = "Bai2";
            this.Text = "Bai2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_listen;
        private System.Windows.Forms.ListView ListViewCommand;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button button1;
    }
}