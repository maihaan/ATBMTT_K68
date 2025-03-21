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

namespace MaHoaRSA
{
    public partial class Form1 : Form
    {
        RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(1024);
        public Form1()
        {
            InitializeComponent();
        }

        private void rbMaHoa_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMaHoa.Checked)
                rbGiaiMa.Checked = false;
        }

        private void rbGiaiMa_CheckedChanged(object sender, EventArgs e)
        {
            if (rbGiaiMa.Checked)
                rbMaHoa.Checked = false;
        }

        private void btTaoKhoaMoi_Click(object sender, EventArgs e)
        {            
            String khoaCongKhai = rsa.ToXmlString(false);
            String khoaBiMat = rsa.ToXmlString(true);
            SaveFileDialog sd = new SaveFileDialog();


            // Lưu khoa công khai
            sd.Filter = "Khóa RSA (*.ckxml) | *.ckxml";
            sd.Title = "Lưu khóa công khai";
            if(sd.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(sd.FileName, khoaCongKhai);
            }

            // Lưu khoa bí mật
            sd.Filter = "Khóa RSA (*.bmxml) | *.bmxml";
            sd.Title = "Lưu khóa bí mật";
            if(sd.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(sd.FileName, khoaBiMat);
            }    
        }

        private void btTimTep_Click(object sender, EventArgs e)
        {
            OpenFileDialog od = new OpenFileDialog();
            if(od.ShowDialog() == DialogResult.OK)
            {
                tbDuongDanTep.Text = od.FileName;
            }    
        }

        private void btTimKhoa_Click(object sender, EventArgs e)
        {
            OpenFileDialog od = new OpenFileDialog();
            od.Filter = "Khóa RSA (*.xml) | *.xml";
            if (rbMaHoa.Checked)
            {
                od.Filter = "Khóa công khai (*.ckxml) | *.ckxml";
                od.Title = "Chọn khóa công khai";
            }
            else
            {
                od.Filter = "Khóa bí mật (*.bmxml) | *.bmxml";
                od.Title = "Chọn khóa bí mật";
            }
            if(od.ShowDialog() == DialogResult.OK)
            {
                tbDuongDanKhoa.Text = od.FileName;
            }    
        }

        private void btThucHien_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu đầu vào

            // Đọc khóa
            String khoa = File.ReadAllText(tbDuongDanKhoa.Text);

            // Đọc nội dung tệp tin
            var tep = File.ReadAllBytes(tbDuongDanTep.Text);

            // Mã hóa hoặc giải mã
            
            rsa.FromXmlString(khoa);

            // Luu tệp
            String ext = Path.GetExtension(tbDuongDanTep.Text);
            SaveFileDialog sd = new SaveFileDialog();
            sd.Filter = "File (*" + ext + ") | *" + ext;
            if (sd.ShowDialog() == DialogResult.OK)
            {
                StreamWriter s = new StreamWriter(sd.FileName, true);

                for (int i = 0; i < tep.Length; i = i + 117)
                {
                    
                    int chieuDai = 117;
                    if (tep.Length - i < chieuDai)
                        chieuDai = tep.Length - i;
                    byte[] duLieu = new byte[chieuDai];
                    Array.Copy(tep, i, duLieu, 0, chieuDai);
                    if (rbMaHoa.Checked)
                    {
                        // Mã hóa
                        var kq = rsa.Encrypt(duLieu, RSAEncryptionPadding.Pkcs1);
                        // Chuyển đổi thành base64
                        string b64 = Convert.ToBase64String(kq);
                        // Ghi dữ liệu base64 vào tệp tin
                        s.WriteLine(b64);
                    }
                    else
                    {
                        // Chuyển đổi dữ liệu base64 thành mảng byte
                        var dl = Convert.FromBase64String(Encoding.UTF8.GetString(duLieu));
                        // Giải mã
                        var kq = rsa.Decrypt(dl, RSAEncryptionPadding.Pkcs1);
                        // Ghi vào tệp tin
                        fs.Write(dl, 0, dl.Length);
                    }   
                }
                
                fs.Close();
            } 
        }
    }
}
