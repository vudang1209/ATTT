using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vingenere
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private string MaHoaVigenere(string vanBan, string khoa)
        {
            vanBan = vanBan.ToUpper();
            khoa = khoa.ToUpper();
            StringBuilder ketQua = new StringBuilder();

            for (int i = 0, j = 0; i < vanBan.Length; i++)
            {
                char kyTu = vanBan[i];

                if (char.IsLetter(kyTu)) // Kiểm tra ký tự có phải là chữ cái không
                {
                    char kyTuKhoa = khoa[j % khoa.Length];
                    char kyTuMaHoa = (char)((kyTu + kyTuKhoa - 2 * 'A') % 26 + 'A'); // Mã hóa
                    ketQua.Append(kyTuMaHoa);
                    j++;
                }
                else
                {
                    ketQua.Append(kyTu); // Nếu không phải chữ cái, giữ nguyên
                }
            }

            return ketQua.ToString();
        }

        // Hàm giải mã Vigenère
        private string GiaiMaVigenere(string vanBan, string khoa)
        {
            vanBan = vanBan.ToUpper();
            khoa = khoa.ToUpper();
            StringBuilder ketQua = new StringBuilder();

            for (int i = 0, j = 0; i < vanBan.Length; i++)
            {
                char kyTu = vanBan[i];

                if (char.IsLetter(kyTu)) // Kiểm tra ký tự có phải là chữ cái không
                {
                    char kyTuKhoa = khoa[j % khoa.Length];
                    char kyTuGiaiMa = (char)((kyTu - kyTuKhoa + 26) % 26 + 'A'); // Giải mã
                    ketQua.Append(kyTuGiaiMa);
                    j++;
                }
                else
                {
                    ketQua.Append(kyTu); // Nếu không phải chữ cái, giữ nguyên
                }
            }

            return ketQua.ToString();
        }

        // Xử lý sự kiện nút Mã hóa
        private void btnMaHoa_Click(object sender, EventArgs e)
        {
            string vanBan = txtVanBan.Text;   // Lấy văn bản từ TextBox
            string khoa = txtKhoa.Text;       // Lấy từ khóa từ TextBox

            if (string.IsNullOrWhiteSpace(vanBan) || string.IsNullOrWhiteSpace(khoa))
            {
                MessageBox.Show("Vui lòng nhập văn bản và từ khóa!");
                return;
            }

            string ketQuaMaHoa = MaHoaVigenere(vanBan, khoa); // Mã hóa văn bản
            txtKetQua.Text = ketQuaMaHoa;                     // Hiển thị kết quả mã hóa
        }

        // Xử lý sự kiện nút Giải mã
        private void btnGiaiMa_Click(object sender, EventArgs e)
        {
            string vanBan = txtVanBan.Text;   // Lấy văn bản từ TextBox
            string khoa = txtKhoa.Text;       // Lấy từ khóa từ TextBox

            if (string.IsNullOrWhiteSpace(vanBan) || string.IsNullOrWhiteSpace(khoa))
            {
                MessageBox.Show("Vui lòng nhập văn bản và từ khóa!");
                return;
            }

            string ketQuaGiaiMa = GiaiMaVigenere(vanBan, khoa); // Giải mã văn bản
            txtKetQua.Text = ketQuaGiaiMa;                      // Hiển thị kết quả giải mã
        }
    }
}
