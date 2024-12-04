using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task2._1
{
    public partial class MD5 : Form
    {
        public MD5()
        {
            InitializeComponent();
        }

        private string GenerateMD5Hash(string input)
        {
            // Kiểm tra nếu input là null hoặc rỗng
            if (string.IsNullOrEmpty(input))
                return string.Empty;

            // Chuyển input thành byte array
            byte[] inputBytes = Encoding.UTF8.GetBytes(input);

            // Tạo một đối tượng MD5
            using (var md5 = System.Security.Cryptography.MD5.Create())
            {
                // Tạo giá trị băm
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                // Chuyển giá trị băm thành chuỗi ký tự hexa
                StringBuilder hashStringBuilder = new StringBuilder();
                foreach (byte b in hashBytes)
                {
                    hashStringBuilder.Append(b.ToString("x2")); // x2: Ký tự hexa, 2 chữ số
                }

                return hashStringBuilder.ToString();
            }
        }

        private string GenetateMD5HashProgram(string filePath)
        {
            try
            {
                using (FileStream stream = File.OpenRead(filePath))
                {
                    System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create();
                    byte[] hashBytes = md5.ComputeHash(stream);
                    StringBuilder sb = new StringBuilder();
                    foreach (byte b in hashBytes)
                    {
                        sb.Append(b.ToString("x2"));
                    }
                    return sb.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tạo mã băm: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return string.Empty;
            }
        }

        private void md5_btn_Click(object sender, EventArgs e)
        {
            string message1 = message1_txt.Text;
            string message2 = message2_txt.Text;

            string md5_1 = GenerateMD5Hash(message1);
            string md5_2 = GenerateMD5Hash(message2);

            md5_1_txt.Text = md5_1;
            md5_2_txt.Text = md5_2;
        }

        private void browser_btn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Executable Files (*.exe)|*.exe|All Files (*.*)|*.*";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    filePath_txt.Text = ofd.FileName;
                }
            }
        }

        private void md5_2_btn_Click(object sender, EventArgs e)
        {
            string filePath = filePath_txt.Text;

            if (File.Exists(filePath))
            {
                string md5Hash = GenetateMD5HashProgram(filePath);
                md5_program_txt.Text = md5Hash;
            }
            else
            {
                MessageBox.Show("Tệp không tồn tại. Vui lòng kiểm tra lại đường dẫn.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
