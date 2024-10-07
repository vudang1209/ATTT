using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private char[,] TaoBang(string khoa)
        {
            khoa = khoa.ToUpper().Replace("J", "I"); 
            List<char> chuCaiTrongBang = new List<char>();

            foreach (char c in khoa)
            {
                if (!chuCaiTrongBang.Contains(c) && c != 'J' && !char.IsWhiteSpace(c))
                {
                    chuCaiTrongBang.Add(c);
                }
            }

            for (char c = 'A'; c <= 'Z'; c++)
            {
                if (!chuCaiTrongBang.Contains(c) && c != 'J')
                {
                    chuCaiTrongBang.Add(c);
                }
            }

            char[,] bang = new char[5, 5];
            int chiSo = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    bang[i, j] = chuCaiTrongBang[chiSo++];
                }
            }

            return bang;
        }

        
        private (int, int) TimViTri(char[,] bang, char c)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (bang[i, j] == c)
                    {
                        return (i, j);
                    }
                }
            }
            return (-1, -1); 
        }

        //private string MaHoa(string vanBan, string khoa)
        //{
        //    char[,] bang = TaoBang(khoa);
        //    vanBan = vanBan.ToUpper().Replace("J", "I");

        //    StringBuilder ketQua = new StringBuilder();
        //    StringBuilder vanBanDaXuLy = new StringBuilder();

        //    foreach (char kyTu in vanBan)
        //    {
        //        if (!char.IsWhiteSpace(kyTu))
        //        {
        //            vanBanDaXuLy.Append(kyTu);
        //        }
        //    }

        //    int i = 0;
        //    while (i < vanBanDaXuLy.Length)
        //    {
        //        char kyTu1 = vanBanDaXuLy[i];
        //        char kyTu2 = (i + 1 < vanBanDaXuLy.Length) ? vanBanDaXuLy[i + 1] : 'X';

        //        var (hang1, cot1) = TimViTri(bang, kyTu1);
        //        var (hang2, cot2) = TimViTri(bang, kyTu2);

        //        if (hang1 == hang2)
        //        {
        //            ketQua.Append(bang[hang1, (cot1 + 1) % 5]);
        //            ketQua.Append(bang[hang2, (cot2 + 1) % 5]);
        //        }
        //        else if (cot1 == cot2)
        //        {
        //            ketQua.Append(bang[(hang1 + 1) % 5, cot1]);
        //            ketQua.Append(bang[(hang2 + 1) % 5, cot2]);
        //        }
        //        else
        //        {
        //            ketQua.Append(bang[hang1, cot2]);
        //            ketQua.Append(bang[hang2, cot1]);
        //        }

        //        i += 2;
        //    }

        //    StringBuilder ketQuaCuoi = new StringBuilder();
        //    int chiSoMaHoa = 0;

        //    for (int j = 0; j < vanBan.Length; j++)
        //    {
        //        if (char.IsWhiteSpace(vanBan[j]))
        //        {
        //            ketQuaCuoi.Append(' ');
        //        }
        //        else
        //        {
        //            ketQuaCuoi.Append(ketQua[chiSoMaHoa++]);
        //        }
        //    }

        //    return ketQuaCuoi.ToString();
        //}
        private string MaHoa(string vanBan, string khoa)
        {
            char[,] bang = TaoBang(khoa);
            vanBan = vanBan.ToUpper().Replace("J", "I");

            StringBuilder ketQua = new StringBuilder();
            StringBuilder vanBanDaXuLy = new StringBuilder();

            int i = 0;
            while (i < vanBan.Length)
            {
                if (char.IsWhiteSpace(vanBan[i]))
                {
                    ketQua.Append(' ');
                    i++;
                    continue;
                }

                char kyTu1 = vanBan[i];
                char kyTu2;
                if (i + 1 < vanBan.Length && !char.IsWhiteSpace(vanBan[i + 1]))
                {
                    kyTu2 = vanBan[i + 1];

                    i += 2;
                }
                else
                {
                    kyTu2 = 'X';
                    i++;
                }

                var (hang1, cot1) = TimViTri(bang, kyTu1);
                var (hang2, cot2) = TimViTri(bang, kyTu2);

                if (hang1 == hang2)
                {
                    ketQua.Append(bang[hang1, (cot1 + 1) % 5]);
                    ketQua.Append(bang[hang2, (cot2 + 1) % 5]);
                }
                else if (cot1 == cot2)
                {
                    ketQua.Append(bang[(hang1 + 1) % 5, cot1]);
                    ketQua.Append(bang[(hang2 + 1) % 5, cot2]);
                }
                else
                {
                    ketQua.Append(bang[hang1, cot2]);
                    ketQua.Append(bang[hang2, cot1]);
                }
            }

            return ketQua.ToString();
        }



        //private string GiaiMa(string vanBan, string khoa)
        //{
        //    char[,] bang = TaoBang(khoa);
        //    vanBan = vanBan.ToUpper();

        //    StringBuilder ketQua = new StringBuilder();
        //    StringBuilder vanBanDaXuLy = new StringBuilder();

        //    foreach (char kyTu in vanBan)
        //    {
        //        if (!char.IsWhiteSpace(kyTu))
        //        {
        //            vanBanDaXuLy.Append(kyTu);
        //        }
        //    }

        //    int i = 0;
        //    while (i < vanBanDaXuLy.Length)
        //    {
        //        char kyTu1 = vanBanDaXuLy[i];
        //        char kyTu2 = (i + 1 < vanBanDaXuLy.Length) ? vanBanDaXuLy[i + 1] : 'X';

        //        var (hang1, cot1) = TimViTri(bang, kyTu1);
        //        var (hang2, cot2) = TimViTri(bang, kyTu2);

        //        if (hang1 == hang2)
        //        {
        //            ketQua.Append(bang[hang1, (cot1 + 4) % 5]);
        //            ketQua.Append(bang[hang2, (cot2 + 4) % 5]);
        //        }
        //        else if (cot1 == cot2)
        //        {
        //            ketQua.Append(bang[(hang1 + 4) % 5, cot1]);
        //            ketQua.Append(bang[(hang2 + 4) % 5, cot2]);
        //        }
        //        else
        //        {
        //            ketQua.Append(bang[hang1, cot2]);
        //            ketQua.Append(bang[hang2, cot1]);
        //        }

        //        i += 2;
        //    }

        //    StringBuilder ketQuaCuoi = new StringBuilder();
        //    int chiSoGiaiMa = 0;

        //    for (int j = 0; j < vanBan.Length; j++)
        //    {
        //        if (char.IsWhiteSpace(vanBan[j]))
        //        {
        //            ketQuaCuoi.Append(' ');
        //        }
        //        else
        //        {
        //            ketQuaCuoi.Append(ketQua[chiSoGiaiMa++]);
        //        }
        //    }

        //    return ketQuaCuoi.ToString();
        //}
        private string GiaiMa(string vanBan, string khoa)
        {
            char[,] bang = TaoBang(khoa);
            vanBan = vanBan.ToUpper();

            StringBuilder ketQua = new StringBuilder();
            StringBuilder vanBanDaXuLy = new StringBuilder();

            foreach (char kyTu in vanBan)
            {
                if (!char.IsWhiteSpace(kyTu))
                {
                    vanBanDaXuLy.Append(kyTu);
                }
            }

            int i = 0;
            while (i < vanBanDaXuLy.Length)
            {
                char kyTu1 = vanBanDaXuLy[i];
                char kyTu2 = (i + 1 < vanBanDaXuLy.Length) ? vanBanDaXuLy[i + 1] : 'X';

                var (hang1, cot1) = TimViTri(bang, kyTu1);
                var (hang2, cot2) = TimViTri(bang, kyTu2);

                if (hang1 == hang2)
                {
                    ketQua.Append(bang[hang1, (cot1 + 4) % 5]);
                    ketQua.Append(bang[hang2, (cot2 + 4) % 5]);
                }
                else if (cot1 == cot2)
                {
                    ketQua.Append(bang[(hang1 + 4) % 5, cot1]);
                    ketQua.Append(bang[(hang2 + 4) % 5, cot2]);
                }
                else
                {
                    ketQua.Append(bang[hang1, cot2]);
                    ketQua.Append(bang[hang2, cot1]);
                }

                i += 2;
            }

            StringBuilder ketQuaCuoi = new StringBuilder();
            int chiSoGiaiMa = 0;

            for (int j = 0; j < vanBan.Length; j++)
            {
                if (char.IsWhiteSpace(vanBan[j]))
                {
                    ketQuaCuoi.Append(' ');
                }
                else
                {
                    ketQuaCuoi.Append(ketQua[chiSoGiaiMa++]);
                }
            }

            return ketQuaCuoi.ToString();
        }



        private bool KiemTraChuoiHopLe(string vanBan)
        {            
            foreach (char kyTu in vanBan)
            {                
                if (!char.IsLetter(kyTu) && !char.IsWhiteSpace(kyTu))
                {                  
                    return false;
                }
            }

            return true;
        }

        private void btn_maHoa_Click(object sender, EventArgs e)
        {
            string vanBan = txb_chuoiKiTu.Text;
            string khoa = txb_khoa.Text;
             if (!KiemTraChuoiHopLe(vanBan) || !KiemTraChuoiHopLe(khoa))
            {
                MessageBox.Show("Vui lòng chỉ nhập chữ cái!", "Ê rô, lỗi đầu vào", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string ketQua = MaHoa(vanBan, khoa);
            lb_ketQua.Text = "Kết quả mã hóa";
            txb_ketQua.Text = ketQua;
        }

        private void btn_giaiMa_Click(object sender, EventArgs e)
        {
            string vanBan = txb_chuoiKiTu.Text;
            string khoa = txb_khoa.Text;
            if (!KiemTraChuoiHopLe(vanBan) || !KiemTraChuoiHopLe(khoa))
            {
                MessageBox.Show("Vui lòng chỉ nhập chữ cái !", "Lỗi đầu vào", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string ketQua = GiaiMa(vanBan, khoa);
            lb_ketQua.Text = "Kết quả giải mã";
            txb_ketQua.Text = ketQua;
        }

        private void btn_matran_Click(object sender, EventArgs e)
        {
            string khoa = txb_khoa.Text.ToUpper();
            rbt_matran.Clear();
            char[,] bang = TaoBang(khoa);
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    rbt_matran.AppendText(bang[i, j].ToString() + " ");  
                }
                rbt_matran.AppendText(Environment.NewLine); 
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
