using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ma_Norn_Duay_Gun_Mai
{
    public partial class room_preview : Form
    {
        public room_preview()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_mousehover(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources._2;
        }

        private void pictureBox1_mouseleave(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources._361213576_2898278143635793_7378312839190816006_n;
        }

        private void room_preview_Load(object sender, EventArgs e)
        {

        }
    }
}
