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
    public partial class FinalForm : Form
    {
        public FinalForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Title title_var = new Title();
            title_var.Show();
        }

        private void FinalForm_Load(object sender, EventArgs e)
        {
            // bed
            switch (GlobalVar.bed_op)
            {
                case 1: pictureBox1.Image = Properties.Resources.Bed1_blue; break;
                case 2: pictureBox1.Image = Properties.Resources.Bed2_cream; break;
                case 3: pictureBox1.Image = Properties.Resources.Bed3_grey; break;
                case 4: pictureBox1.Image = Properties.Resources.Bed4_kid; break;
            }

            //lamp
            switch (GlobalVar.lamp_op)
            {
                case 1: pictureBox3.Image = Properties.Resources.Lamp1_brown; break;
                case 2: pictureBox3.Image = Properties.Resources.Lamp2_pink; break;
                case 3: pictureBox3.Image = Properties.Resources.Lamp3_red; break;
                case 4: pictureBox3.Image = Properties.Resources.Lamp4_yellow; break;
            }

            // window
            switch (GlobalVar.window_op)
            {
                case 1: pictureBox6.Image = Properties.Resources.window1_blue; break;
                case 2: pictureBox6.Image = Properties.Resources.window2_green; break;
                case 3: pictureBox6.Image = Properties.Resources.window3_pink; break;
                case 4: pictureBox6.Image = Properties.Resources.window4_red; break;
            }

            // clock
            switch (GlobalVar.clock_op)
            {
                case 1: pictureBox7.Image = Properties.Resources.clock1_pink; break;
                case 2: pictureBox7.Image = Properties.Resources.clock2_kid; break;
                case 3: pictureBox7.Image = Properties.Resources.clock3_old; break;
                case 4: pictureBox7.Image = Properties.Resources.clock4_cuckoo; break;
            }

            // aircon
            label4.Text = GlobalVar.aircon_temp + "C";
        }
    }
}
