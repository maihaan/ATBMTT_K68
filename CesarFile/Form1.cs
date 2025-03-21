using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;

namespace CesarFile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rbMaHoa_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMaHoa.Checked)
                rbGiaiMa.Checked = false;
            tbDuongDan.Text = "";
            btTim.Focus();
        }

        private void rbGiaiMa_CheckedChanged(object sender, EventArgs e)
        {
            if (rbGiaiMa.Checked)
                rbMaHoa.Checked = false;
            tbDuongDan.Text = "";
            btTim.Focus();
        }

        private void btTim_Click(object sender, EventArgs e)
        {
            OpenFileDialog od = new OpenFileDialog();
            //od.Filter = "Tệp tin word (*.docx) | *.docx";
            if(od.ShowDialog() == DialogResult.OK)
            {
                tbDuongDan.Text = od.FileName;
            }    
        }

        private void btThucHien_Click(object sender, EventArgs e)
        {
            // B1: Kiểm tra dữ liệu đầu vào hợp lệ chưa
            if(tbDuongDan.Text.Length== 0)
            {
                MessageBox.Show("Bạn phải chọn tệp tin cần mã hóa hoặc giải mã");
                btTim.Focus();
                return;
            }   
            if(!File.Exists(tbDuongDan.Text))
            {
                MessageBox.Show("Không tìm thấy tệp tin bạn đã chọn. Hãy chọn lại tệp tin");
                btTim.Focus();
                return;
            }    


            // B2: Đọc nội dung tệp tin vào mảng byte
            try
            {
                // Chỉ làm với tệp tin có dung lượng nhỏ, với tệp tin có dung lượng lớn thì phải đọc từng phần của tệp tin để xử lý
                byte[] noiDungTep = File.ReadAllBytes(tbDuongDan.Text);

                // B3: Mã hóa hoặc giải mã tệp tin và lưu vào mảng byte mới
                CesarFileHelpper cs = new CesarFileHelpper();
                byte[] ketQua;
                if (rbMaHoa.Checked)
                {
                    // Mã hóa tệp tin
                    ketQua = cs.MaHoa(noiDungTep);
                }   
                else
                {
                    // Giải mã tệp tin
                    ketQua = cs.GiaiMa(noiDungTep);
                }


                // B4: Lưu mảng byte mới vào tệp tin kết quả
                String ext = Path.GetExtension(tbDuongDan.Text);
                SaveFileDialog sd = new SaveFileDialog();
                sd.Filter = "*" + ext + " | *" + ext;
                if(sd.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllBytes(sd.FileName, ketQua);
                }    
            }
            catch
            {
                MessageBox.Show("Không thể truy cập tệp tin do tệp tin đang được sử dụng bởi chương trình khác. Hãy đóng chương trình đang sử dụng tệp tin và thử lại");
                return;
            }

            

        }
    }
}
