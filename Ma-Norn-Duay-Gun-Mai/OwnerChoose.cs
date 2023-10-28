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
    public partial class OwnerChoose : Form
    {
        public OwnerChoose()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            explain explain_var = new explain();
            explain_var.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            roompreview roompreview_var = new roompreview();
            roompreview_var.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
