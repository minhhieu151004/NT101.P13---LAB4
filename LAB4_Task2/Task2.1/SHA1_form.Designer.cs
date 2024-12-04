namespace Task2._1
{
    partial class SHA1_form
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
            filePath_txt = new TextBox();
            browser_btn = new Button();
            sha1_2_btn = new Button();
            label8 = new Label();
            sha1_txt = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(185, 38);
            label1.TabIndex = 1;
            label1.Text = "SHA-1 HASH";
            // 
            // filePath_txt
            // 
            filePath_txt.Location = new Point(12, 63);
            filePath_txt.Name = "filePath_txt";
            filePath_txt.Size = new Size(749, 27);
            filePath_txt.TabIndex = 9;
            // 
            // browser_btn
            // 
            browser_btn.Location = new Point(12, 96);
            browser_btn.Name = "browser_btn";
            browser_btn.Size = new Size(94, 29);
            browser_btn.TabIndex = 10;
            browser_btn.Text = "Browser";
            browser_btn.UseVisualStyleBackColor = true;
            browser_btn.Click += browser_btn_Click;
            // 
            // sha1_2_btn
            // 
            sha1_2_btn.Location = new Point(112, 96);
            sha1_2_btn.Name = "sha1_2_btn";
            sha1_2_btn.Size = new Size(94, 29);
            sha1_2_btn.TabIndex = 11;
            sha1_2_btn.Text = "SHA-1";
            sha1_2_btn.UseVisualStyleBackColor = true;
            sha1_2_btn.Click += sha1_2_btn_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 155);
            label8.Name = "label8";
            label8.Size = new Size(55, 20);
            label8.TabIndex = 12;
            label8.Text = "SHA-1:";
            // 
            // sha1_txt
            // 
            sha1_txt.Location = new Point(73, 148);
            sha1_txt.Name = "sha1_txt";
            sha1_txt.Size = new Size(688, 27);
            sha1_txt.TabIndex = 13;
            // 
            // SHA1_form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(773, 237);
            Controls.Add(sha1_txt);
            Controls.Add(label8);
            Controls.Add(sha1_2_btn);
            Controls.Add(browser_btn);
            Controls.Add(filePath_txt);
            Controls.Add(label1);
            Name = "SHA1_form";
            Text = "SHA1_form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox filePath_txt;
        private Button browser_btn;
        private Button sha1_2_btn;
        private Label label8;
        private TextBox sha1_txt;
    }
}