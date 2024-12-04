using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Security.Cryptography;
using System.IO;

namespace LAB4_Task1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Text_Calculate()
        {
            // Chuyển chuỗi thành mảng byte
            byte[] inputBytes = Encoding.UTF8.GetBytes(tbxData.Text);

            //MD5
            using (MD5 md5 = MD5.Create())
            {
                // Băm dữ liệu
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                // Chuyển đổi mảng byte thành chuỗi hex
                StringBuilder sb = new StringBuilder();
                foreach (byte b in hashBytes)
                {
                    sb.Append(b.ToString("x2"));
                }
                tbxMD5.Text = sb.ToString();
            }

            //SHA1
            using (SHA1 sha1 = SHA1.Create())
            {
                byte[] hashBytes = sha1.ComputeHash(inputBytes);

                StringBuilder sb = new StringBuilder();
                foreach (byte b in hashBytes)
                {
                    sb.Append(b.ToString("x2"));
                }
                tbxSHA1.Text = sb.ToString();
            }

            //SHA256
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashBytes = sha256.ComputeHash(inputBytes);

                StringBuilder sb = new StringBuilder();
                foreach (byte b in hashBytes)
                {
                    sb.Append(b.ToString("x2"));
                }
                tbxSHA256.Text = sb.ToString();
            }

            //SHA512
            using (SHA512 sha512 = SHA512.Create())
            {
                byte[] hashBytes = sha512.ComputeHash(inputBytes);

                StringBuilder sb = new StringBuilder();
                foreach (byte b in hashBytes)
                {
                    sb.Append(b.ToString("x2"));
                }
                tbxSHA512.Text = sb.ToString();
            }
        }

        private static byte[] ConvertHexStringToBytes(string hex)
        {
            if (string.IsNullOrEmpty(hex))
            {
                MessageBox.Show("Input HEX string is null or empty.");
            }

            if (hex.Length % 2 != 0)
            {
                MessageBox.Show("Invalid HEX string!");
            }

            byte[] bytes = new byte[hex.Length / 2];
            for (int i = 0; i < hex.Length; i += 2)
            {
                bytes[i / 2] = Convert.ToByte(hex.Substring(i, 2), 16);
            }

            return bytes;
        }
        private void HEX_Calculate()
        {
            try
            {
                byte[] inputBytes = ConvertHexStringToBytes(tbxData.Text);

                //MD5
                using (MD5 md5 = MD5.Create())
                {
                    // Băm dữ liệu
                    byte[] hashBytes = md5.ComputeHash(inputBytes);

                    // Chuyển đổi mảng byte thành chuỗi hex
                    StringBuilder sb = new StringBuilder();
                    foreach (byte b in hashBytes)
                    {
                        sb.Append(b.ToString("x2"));
                    }
                    tbxMD5.Text = sb.ToString();
                }

                //SHA1
                using (SHA1 sha1 = SHA1.Create())
                {
                    byte[] hashBytes = sha1.ComputeHash(inputBytes);

                    StringBuilder sb = new StringBuilder();
                    foreach (byte b in hashBytes)
                    {
                        sb.Append(b.ToString("x2"));
                    }
                    tbxSHA1.Text = sb.ToString();
                }

                //SHA256
                using (SHA256 sha256 = SHA256.Create())
                {
                    // Băm dữ liệu
                    byte[] hashBytes = sha256.ComputeHash(inputBytes);

                    // Chuyển đổi mảng byte thành chuỗi hex
                    StringBuilder sb = new StringBuilder();
                    foreach (byte b in hashBytes)
                    {
                        sb.Append(b.ToString("x2"));
                    }
                    tbxSHA256.Text = sb.ToString();
                }

                //SHA512
                using (SHA512 sha512 = SHA512.Create())
                {
                    byte[] hashBytes = sha512.ComputeHash(inputBytes);

                    StringBuilder sb = new StringBuilder();
                    foreach (byte b in hashBytes)
                    {
                        sb.Append(b.ToString("x2"));
                    }
                    tbxSHA512.Text = sb.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }
        
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (btnText.Checked)
            {
                Text_Calculate();
            }
            else if(btnHEX.Checked)
            {
                HEX_Calculate();
            }
            else
            {
                Text_Calculate();
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbxData.Text = "";
            tbxMD5.Text = "";
            tbxSHA1.Text = "";
            tbxSHA256.Text = "";
            tbxSHA512.Text = "";
        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files|*.txt";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Kiểm tra nếu file tồn tại
                    if (!File.Exists(openFileDialog.FileName))
                    {
                        MessageBox.Show("File không tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Đọc toàn bộ nội dung của file
                    string fileContent = File.ReadAllText(openFileDialog.FileName);

                    tbxData.Text = fileContent;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }
    }
}
