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

namespace MaHoaMD5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rbMaHoa_CheckedChanged(object sender, EventArgs e)
        {
            if(rbMaHoa.Checked)
                rbGiaiMa.Checked = false;
        }

        private void rbGiaiMa_CheckedChanged(object sender, EventArgs e)
        {
            if (rbGiaiMa.Checked)
                rbMaHoa.Checked = false;
        }

        private void btTim_Click(object sender, EventArgs e)
        {
            OpenFileDialog od = new OpenFileDialog();
            od.Multiselect = false;
            if (od.ShowDialog() == DialogResult.OK)
                tbDuongDan.Text = od.FileName;
        }

        private void btThucHien_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu đầu vào
            if(tbDuongDan.Text.Length == 0)
            {
                MessageBox.Show("Bạn phải chọn tệp tin");
                btTim.Focus();
                return;
            }    
            if(!File.Exists(tbDuongDan.Text))
            {
                MessageBox.Show("Không tìm thấy tệp tin");
                btTim.Focus();
                return;
            }

            // Mã hóa
            try
            {
                var tep = File.ReadAllBytes(tbDuongDan.Text);
                MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
                var khoa = md5.ComputeHash(Encoding.UTF8.GetBytes(tbMatKhau.Text));
                TripleDESCryptoServiceProvider trip = new TripleDESCryptoServiceProvider();
                trip.Key = khoa;
                trip.Padding = PaddingMode.PKCS7;
                trip.Mode = CipherMode.ECB;

                if (rbMaHoa.Checked) // Mã hóa
                {
                    var tran = trip.CreateEncryptor();
                    var ketQua = tran.TransformFinalBlock(tep, 0, tep.Length);
                    // Lưu trữ kết quả
                    SaveFileDialog sd = new SaveFileDialog();
                    String ext = Path.GetExtension(tbDuongDan.Text);
                    sd.Filter = " Files *" + ext + " | *" + ext;
                    if (sd.ShowDialog() == DialogResult.OK)
                    {
                        File.WriteAllBytes(sd.FileName, ketQua);
                    }
                }
                else // Giải mã
                {
                    var tran = trip.CreateDecryptor();
                    var ketQua = tran.TransformFinalBlock(tep, 0, tep.Length);
                    // Lưu trữ kết quả
                    SaveFileDialog sd = new SaveFileDialog();
                    String ext = Path.GetExtension(tbDuongDan.Text);
                    sd.Filter = " Files *" + ext + " | *" + ext;
                    if (sd.ShowDialog() == DialogResult.OK)
                    {
                        File.WriteAllBytes(sd.FileName, ketQua);
                    }
                }

                tbDuongDan.Text = "";
                tbMatKhau.Text = "";
                   
            }
            catch
            {
                MessageBox.Show("Không thể truy cập vào tệp tin. Hãy kiểm tra lại quyền truy cập hoặc các chương trình đang sử dụng tệp tin");
                return;
            }

            

        }
    }
}
