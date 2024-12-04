using System.Text;

namespace Task2._1
{
    public partial class Task2_1 : Form
    {
        public Task2_1()
        {
            InitializeComponent();
        }

        private void compare_btn_Click(object sender, EventArgs e)
        {
            string message1 = message1_txt.Text;
            string message2 = message2_txt.Text;

            // Kiểm tra độ dài của các chuỗi
            if (message1.Length != 256 || message2.Length != 256)
            {
                MessageBox.Show("Cả hai chuỗi phải có độ dài đúng 256 ký tự.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Chuyển chuỗi thành mảng byte
            byte[] bytes1 = Encoding.ASCII.GetBytes(message1);
            byte[] bytes2 = Encoding.ASCII.GetBytes(message2);

            int differentByteCount = 0;

            // So sánh từng byte
            for (int i = 0; i < 256; i++)
            {
                if (bytes1[i] != bytes2[i])
                {
                    differentByteCount++;
                }
            }

            // Hiển thị kết quả
            result_txt.Text = $"{differentByteCount}";
        }

        private void md5_btn_Click(object sender, EventArgs e)
        {
            OpenForm(new MD5());
        }

        private void sha1_btn_Click(object sender, EventArgs e)
        {
            OpenForm(new SHA1_form());
        }

        private void OpenForm (Form form)
        {
            form.Show();
        }
    }
}
