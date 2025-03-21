using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OneTimePad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btMaHoa_Click(object sender, EventArgs e)
        {
            MHOneTimePad mh = new MHOneTimePad();
            tbKetQuaMaHoa.Text = mh.MaHoa(tbDuLieuCanMaHoa.Text);
        }

        private void btGiaiMa_Click(object sender, EventArgs e)
        {
            MHOneTimePad mh = new MHOneTimePad();
            tbKetQuaGiaiMa.Text = mh.GiaiMa(tbKetQuaMaHoa.Text);
        }
    }
}
