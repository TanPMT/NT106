namespace lab1
{
    partial class bai5
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
            dsDiem = new TextBox();
            bangDiem = new RichTextBox();
            btnXuat = new Button();
            diemTB = new TextBox();
            hocLucSinhVien = new TextBox();
            diemCaoNhat = new TextBox();
            diemThapNhat = new TextBox();
            soMonDau = new TextBox();
            soMonRot = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // dsDiem
            // 
            dsDiem.Location = new Point(219, 121);
            dsDiem.Name = "dsDiem";
            dsDiem.Size = new Size(377, 27);
            dsDiem.TabIndex = 0;
            // 
            // bangDiem
            // 
            bangDiem.Location = new Point(67, 227);
            bangDiem.Name = "bangDiem";
            bangDiem.Size = new Size(580, 127);
            bangDiem.TabIndex = 1;
            bangDiem.Text = "";
            // 
            // btnXuat
            // 
            btnXuat.Location = new Point(618, 117);
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(117, 35);
            btnXuat.TabIndex = 2;
            btnXuat.Text = "Xuất";
            btnXuat.UseVisualStyleBackColor = true;
            btnXuat.Click += btnXuat_Click;
            // 
            // diemTB
            // 
            diemTB.Location = new Point(280, 398);
            diemTB.Name = "diemTB";
            diemTB.Size = new Size(89, 27);
            diemTB.TabIndex = 3;
            // 
            // hocLucSinhVien
            // 
            hocLucSinhVien.Location = new Point(646, 395);
            hocLucSinhVien.Name = "hocLucSinhVien";
            hocLucSinhVien.Size = new Size(89, 27);
            hocLucSinhVien.TabIndex = 4;
            // 
            // diemCaoNhat
            // 
            diemCaoNhat.Location = new Point(280, 444);
            diemCaoNhat.Name = "diemCaoNhat";
            diemCaoNhat.Size = new Size(89, 27);
            diemCaoNhat.TabIndex = 5;
            // 
            // diemThapNhat
            // 
            diemThapNhat.Location = new Point(646, 447);
            diemThapNhat.Name = "diemThapNhat";
            diemThapNhat.Size = new Size(89, 27);
            diemThapNhat.TabIndex = 6;
            // 
            // soMonDau
            // 
            soMonDau.Location = new Point(280, 505);
            soMonDau.Name = "soMonDau";
            soMonDau.Size = new Size(89, 27);
            soMonDau.TabIndex = 7;
            // 
            // soMonRot
            // 
            soMonRot.Location = new Point(646, 498);
            soMonRot.Name = "soMonRot";
            soMonRot.Size = new Size(89, 27);
            soMonRot.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(67, 124);
            label1.Name = "label1";
            label1.Size = new Size(118, 20);
            label1.TabIndex = 9;
            label1.Text = "Danh sách điểm:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(62, 176);
            label2.Name = "label2";
            label2.Size = new Size(367, 39);
            label2.TabIndex = 10;
            label2.Text = "Danh sách môn học và bảng điểm:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(63, 398);
            label3.Name = "label3";
            label3.Size = new Size(120, 20);
            label3.TabIndex = 11;
            label3.Text = "Điểm trung bình:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(63, 454);
            label4.Name = "label4";
            label4.Size = new Size(161, 20);
            label4.TabIndex = 12;
            label4.Text = "Môn có điểm cao nhất:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(461, 451);
            label5.Name = "label5";
            label5.Size = new Size(167, 20);
            label5.TabIndex = 13;
            label5.Text = "Môn có điểm thấp nhất:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(63, 505);
            label6.Name = "label6";
            label6.Size = new Size(92, 20);
            label6.TabIndex = 14;
            label6.Text = "Số môn đậu:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(461, 398);
            label7.Name = "label7";
            label7.Size = new Size(119, 20);
            label7.TabIndex = 15;
            label7.Text = "Xếp loại học lực:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(461, 505);
            label8.Name = "label8";
            label8.Size = new Size(86, 20);
            label8.TabIndex = 16;
            label8.Text = "Số môn rớt:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(67, 24);
            label9.Name = "label9";
            label9.Size = new Size(416, 31);
            label9.TabIndex = 17;
            label9.Text = "Phần mềm quản lí điểm Sinh Viên";
            // 
            // button1
            // 
            button1.Location = new Point(618, 167);
            button1.Name = "button1";
            button1.Size = new Size(117, 32);
            button1.TabIndex = 18;
            button1.Text = "Xóa";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(618, 24);
            button2.Name = "button2";
            button2.Size = new Size(117, 31);
            button2.TabIndex = 19;
            button2.Text = "Thoát";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // bai5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(834, 581);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(soMonRot);
            Controls.Add(soMonDau);
            Controls.Add(diemThapNhat);
            Controls.Add(diemCaoNhat);
            Controls.Add(hocLucSinhVien);
            Controls.Add(diemTB);
            Controls.Add(btnXuat);
            Controls.Add(bangDiem);
            Controls.Add(dsDiem);
            Name = "bai5";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox dsDiem;
        private System.Windows.Forms.RichTextBox bangDiem;
        private System.Windows.Forms.Button btnXuat;
        private System.Windows.Forms.TextBox diemTB;
        private System.Windows.Forms.TextBox hocLucSinhVien;
        private System.Windows.Forms.TextBox diemCaoNhat;
        private System.Windows.Forms.TextBox diemThapNhat;
        private System.Windows.Forms.TextBox soMonDau;
        private System.Windows.Forms.TextBox soMonRot;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private Button button1;
        private Button button2;
    }
}

