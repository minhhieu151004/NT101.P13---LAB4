namespace Task2._1
{
    partial class Task2_1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            message1_txt = new TextBox();
            message2_txt = new TextBox();
            label2 = new Label();
            label3 = new Label();
            compare_btn = new Button();
            label4 = new Label();
            result_txt = new TextBox();
            md5_btn = new Button();
            sha1_btn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(276, 9);
            label1.Name = "label1";
            label1.Size = new Size(284, 81);
            label1.TabIndex = 0;
            label1.Text = "TASK 2.1";
            // 
            // message1_txt
            // 
            message1_txt.Location = new Point(102, 99);
            message1_txt.Name = "message1_txt";
            message1_txt.Size = new Size(707, 27);
            message1_txt.TabIndex = 1;
            // 
            // message2_txt
            // 
            message2_txt.Location = new Point(102, 141);
            message2_txt.Name = "message2_txt";
            message2_txt.Size = new Size(707, 27);
            message2_txt.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 106);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 3;
            label2.Text = "Message 1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 148);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 4;
            label3.Text = "Message 2";
            // 
            // compare_btn
            // 
            compare_btn.Location = new Point(12, 189);
            compare_btn.Name = "compare_btn";
            compare_btn.Size = new Size(223, 43);
            compare_btn.TabIndex = 5;
            compare_btn.Text = "Số byte khác nhau";
            compare_btn.UseVisualStyleBackColor = true;
            compare_btn.Click += compare_btn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(255, 200);
            label4.Name = "label4";
            label4.Size = new Size(67, 20);
            label4.TabIndex = 6;
            label4.Text = "Kết quả: ";
            // 
            // result_txt
            // 
            result_txt.Location = new Point(328, 197);
            result_txt.Name = "result_txt";
            result_txt.Size = new Size(53, 27);
            result_txt.TabIndex = 7;
            // 
            // md5_btn
            // 
            md5_btn.Location = new Point(12, 238);
            md5_btn.Name = "md5_btn";
            md5_btn.Size = new Size(223, 47);
            md5_btn.TabIndex = 8;
            md5_btn.Text = "MD5";
            md5_btn.UseVisualStyleBackColor = true;
            md5_btn.Click += md5_btn_Click;
            // 
            // sha1_btn
            // 
            sha1_btn.Location = new Point(12, 291);
            sha1_btn.Name = "sha1_btn";
            sha1_btn.Size = new Size(223, 47);
            sha1_btn.TabIndex = 9;
            sha1_btn.Text = "SHA-1";
            sha1_btn.UseVisualStyleBackColor = true;
            sha1_btn.Click += sha1_btn_Click;
            // 
            // Task2_1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(821, 385);
            Controls.Add(sha1_btn);
            Controls.Add(md5_btn);
            Controls.Add(result_txt);
            Controls.Add(label4);
            Controls.Add(compare_btn);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(message2_txt);
            Controls.Add(message1_txt);
            Controls.Add(label1);
            Name = "Task2_1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox message1_txt;
        private TextBox message2_txt;
        private Label label2;
        private Label label3;
        private Button compare_btn;
        private Label label4;
        private TextBox result_txt;
        private Button md5_btn;
        private Button sha1_btn;
    }
}
