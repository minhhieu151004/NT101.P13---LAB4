using System;
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
    public partial class SHA1_form : Form
    {
        public SHA1_form()
        {
            InitializeComponent();
        }

        private string GenerateSHA1(string filePath)
        {
            try
            {
                using (FileStream stream = File.OpenRead(filePath))
                {
                    SHA1 sha1 = SHA1.Create();
                    byte[] hashBytes = sha1.ComputeHash(stream);
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
                MessageBox.Show($"Lỗi khi tạo giá trị băm: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return string.Empty;
            }
        }

        private void browser_btn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "PDF Files (*.pdf)|*.pdf|All Files (*.*)|*.*";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    filePath_txt.Text = ofd.FileName;
                }
            }
        }

        private void sha1_2_btn_Click(object sender, EventArgs e)
        {
            string filePath = filePath_txt.Text;

            if (File.Exists(filePath))
            {
                string sha1Hash = GenerateSHA1(filePath);
                sha1_txt.Text = sha1Hash;
            }
            else
            {
                MessageBox.Show("Tệp không tồn tại. Vui lòng kiểm tra lại đường dẫn.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
