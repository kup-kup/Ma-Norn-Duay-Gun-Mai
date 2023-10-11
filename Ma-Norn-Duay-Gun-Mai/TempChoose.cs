using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Ma_Norn_Duay_Gun_Mai.roompreview;

namespace Ma_Norn_Duay_Gun_Mai
{
    public partial class TempChoose : Form
    {
        public TempChoose()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            roompreview room_Preview_var = new roompreview();
            room_Preview_var.Show();
        }

        private void TempChoose_Load(object sender, EventArgs e)
        {
            label2.Text = GlobalVar.aircon_temp + "C";
        }

        // UP BUTTON
        private void button2_Click(object sender, EventArgs e)
        {
            GlobalVar.aircon_temp = Convert.ToString(Convert.ToInt32(GlobalVar.aircon_temp) + 1);
            label2.Text = GlobalVar.aircon_temp + "C";
        }

        // DOWN BUTTON
        private void button3_Click(object sender, EventArgs e)
        {
            GlobalVar.aircon_temp = Convert.ToString(Convert.ToInt32(GlobalVar.aircon_temp) - 1);
            label2.Text = GlobalVar.aircon_temp + "C";
        }
    }
}
