using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaHoaDaBang
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tbMatKhau_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                // Thuc hien ma hoa
                btMaHoa_Click(sender, e);
            }    
        }

        private void btMaHoa_Click(object sender, EventArgs e)
        {
            DaBang db = new DaBang();
            tbKetQuaMaHoa.Text = db.MaHoa(tbDuLieuCanMaHoa.Text, tbMatKhau.Text);
        }

        private void btGiaiMa_Click(object sender, EventArgs e)
        {
            DaBang db = new DaBang();
            tbKetQuaGiaiMa.Text = db.GiaiMa(tbKetQuaMaHoa.Text, tbMatKhau.Text);
        }
    }
}
