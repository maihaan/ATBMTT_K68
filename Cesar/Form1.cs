using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cesar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btMaHoa_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu đầu vào
            if (tbDuLieuCanMaHoa.Text.Length == 0)
                return;

            // Mã hóa và hiển thị kết quả
            CesarHepper cs = new CesarHepper();
            String ketQua = cs.MaHoa(tbDuLieuCanMaHoa.Text);
            tbKetQuaMaHoa.Text = ketQua;
        }

        private void btGiaiMa_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu đầu vào
            if (tbKetQuaMaHoa.Text.Length == 0)
                return;

            // Giải mã và hiển thị kết quả
            CesarHepper cs = new CesarHepper();
            String ketQua = cs.GiaiMa(tbKetQuaMaHoa.Text);
            tbKetQuaGiaiMa.Text = ketQua;
        }
    }
}
