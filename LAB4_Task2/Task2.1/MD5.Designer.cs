﻿namespace Task2._1
{
    partial class MD5
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            message1_txt = new TextBox();
            message2_txt = new TextBox();
            panel1 = new Panel();
            md5_2_txt = new TextBox();
            md5_1_txt = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            md5_btn = new Button();
            label7 = new Label();
            filePath_txt = new TextBox();
            browser_btn = new Button();
            md5_2_btn = new Button();
            label8 = new Label();
            md5_program_txt = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(129, 38);
            label1.TabIndex = 0;
            label1.Text = "Message";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 57);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 1;
            label2.Text = "Message 1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 88);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 2;
            label3.Text = "Message 2";
            // 
            // message1_txt
            // 
            message1_txt.Location = new Point(97, 50);
            message1_txt.Name = "message1_txt";
            message1_txt.Size = new Size(691, 27);
            message1_txt.TabIndex = 3;
            // 
            // message2_txt
            // 
            message2_txt.Location = new Point(97, 81);
            message2_txt.Name = "message2_txt";
            message2_txt.Size = new Size(691, 27);
            message2_txt.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(md5_2_txt);
            panel1.Controls.Add(md5_1_txt);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(12, 153);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 113);
            panel1.TabIndex = 5;
            // 
            // md5_2_txt
            // 
            md5_2_txt.Location = new Point(75, 65);
            md5_2_txt.Name = "md5_2_txt";
            md5_2_txt.Size = new Size(629, 27);
            md5_2_txt.TabIndex = 5;
            // 
            // md5_1_txt
            // 
            md5_1_txt.Location = new Point(75, 32);
            md5_1_txt.Name = "md5_1_txt";
            md5_1_txt.Size = new Size(629, 27);
            md5_1_txt.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(13, 72);
            label6.Name = "label6";
            label6.Size = new Size(56, 20);
            label6.TabIndex = 2;
            label6.Text = "MD5 2:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 39);
            label5.Name = "label5";
            label5.Size = new Size(56, 20);
            label5.TabIndex = 1;
            label5.Text = "MD5 1:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(13, 10);
            label4.Name = "label4";
            label4.Size = new Size(67, 20);
            label4.TabIndex = 0;
            label4.Text = "Kết quả:";
            // 
            // md5_btn
            // 
            md5_btn.Location = new Point(12, 118);
            md5_btn.Name = "md5_btn";
            md5_btn.Size = new Size(94, 29);
            md5_btn.TabIndex = 6;
            md5_btn.Text = "MD5";
            md5_btn.UseVisualStyleBackColor = true;
            md5_btn.Click += md5_btn_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.Location = new Point(12, 293);
            label7.Name = "label7";
            label7.Size = new Size(133, 38);
            label7.TabIndex = 7;
            label7.Text = "Program";
            // 
            // filePath_txt
            // 
            filePath_txt.Location = new Point(12, 334);
            filePath_txt.Name = "filePath_txt";
            filePath_txt.Size = new Size(776, 27);
            filePath_txt.TabIndex = 8;
            // 
            // browser_btn
            // 
            browser_btn.Location = new Point(12, 367);
            browser_btn.Name = "browser_btn";
            browser_btn.Size = new Size(94, 29);
            browser_btn.TabIndex = 9;
            browser_btn.Text = "Browser";
            browser_btn.UseVisualStyleBackColor = true;
            browser_btn.Click += browser_btn_Click;
            // 
            // md5_2_btn
            // 
            md5_2_btn.Location = new Point(112, 367);
            md5_2_btn.Name = "md5_2_btn";
            md5_2_btn.Size = new Size(94, 29);
            md5_2_btn.TabIndex = 10;
            md5_2_btn.Text = "MD5";
            md5_2_btn.UseVisualStyleBackColor = true;
            md5_2_btn.Click += md5_2_btn_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 416);
            label8.Name = "label8";
            label8.Size = new Size(44, 20);
            label8.TabIndex = 6;
            label8.Text = "MD5:";
            // 
            // md5_program_txt
            // 
            md5_program_txt.Location = new Point(62, 409);
            md5_program_txt.Name = "md5_program_txt";
            md5_program_txt.Size = new Size(726, 27);
            md5_program_txt.TabIndex = 11;
            // 
            // MD5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 476);
            Controls.Add(md5_program_txt);
            Controls.Add(label8);
            Controls.Add(md5_2_btn);
            Controls.Add(browser_btn);
            Controls.Add(filePath_txt);
            Controls.Add(label7);
            Controls.Add(md5_btn);
            Controls.Add(panel1);
            Controls.Add(message2_txt);
            Controls.Add(message1_txt);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "MD5";
            Text = "MD5";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox message1_txt;
        private TextBox message2_txt;
        private Panel panel1;
        private TextBox md5_2_txt;
        private TextBox md5_1_txt;
        private Label label6;
        private Label label5;
        private Label label4;
        private Button md5_btn;
        private Label label7;
        private TextBox filePath_txt;
        private Button browser_btn;
        private Button md5_2_btn;
        private Label label8;
        private TextBox md5_program_txt;
    }
}