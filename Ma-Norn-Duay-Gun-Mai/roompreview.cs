using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ma_Norn_Duay_Gun_Mai
{
    public partial class roompreview : Form
    {
        public static class GlobalVar
        {
            public static int bed_op = 1;
            public static int window_op = 1;
            public static int lamp_op = 1;
            public static int wardrobe_op = 1;
            public static int clock_op = 1;
            public static int owner_op = 1;
            public static String aircon_temp = "25";
        }

        public roompreview()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        // BED Features
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            BedChoose bedChoose_var = new BedChoose();
            bedChoose_var.Show();
        }

        private void pictureBox1_enter(object sender, EventArgs e)
        {
            switch (GlobalVar.bed_op)
            {
                case 1: pictureBox1.Image = Properties.Resources.Bed1_blue_h; break;
                case 2: pictureBox1.Image = Properties.Resources.Bed2_cream_h; break;
                case 3: pictureBox1.Image = Properties.Resources.Bed3_grey_h; break;
                case 4: pictureBox1.Image = Properties.Resources.Bed4_kid_h; break;
            }
        }

        private void pictureBox1_leave(object sender, EventArgs e)
        {
            switch (GlobalVar.bed_op)
            {
                case 1: pictureBox1.Image = Properties.Resources.Bed1_blue; break;
                case 2: pictureBox1.Image = Properties.Resources.Bed2_cream; break;
                case 3: pictureBox1.Image = Properties.Resources.Bed3_grey; break;
                case 4: pictureBox1.Image = Properties.Resources.Bed4_kid; break;
            }
        }

        // FormLoad
        private void roompreview_Load(object sender, EventArgs e)
        {
            // bed
            switch (GlobalVar.bed_op)
            {
                case 1: pictureBox1.Image = Properties.Resources.Bed1_blue; break;
                case 2: pictureBox1.Image = Properties.Resources.Bed2_cream; break;
                case 3: pictureBox1.Image = Properties.Resources.Bed3_grey; break;
                case 4: pictureBox1.Image = Properties.Resources.Bed4_kid; break;
            }

            // aircon
            label1.Text = GlobalVar.aircon_temp + "C";
        }

        // AIRCON features
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
            TempChoose tempChoose_var = new TempChoose();
            tempChoose_var.Show();
        }

        private void pictureBox5_enter(object sender, EventArgs e)
        {
            pictureBox5.Image = Properties.Resources.aircon_h;
        }

        private void pictureBox5_leave(object sender, EventArgs e)
        {
            pictureBox5.Image = Properties.Resources.aircon;
        }

        // WINDOW Feature
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox6_enter(object sender, EventArgs e)
        {
            switch (GlobalVar.window_op)
            {
                case 1: pictureBox6.Image = Properties.Resources.window1_blue_h; break;
                case 2: pictureBox6.Image = Properties.Resources.window2_green_h; break;
                case 3: pictureBox6.Image = Properties.Resources.window3_pink_h; break;
                case 4: pictureBox6.Image = Properties.Resources.window4_red_h; break;
            }
        }

        private void pictureBox6_leave(object sender, EventArgs e)
        {
            switch (GlobalVar.window_op)
            {
                case 1: pictureBox6.Image = Properties.Resources.window1_blue; break;
                case 2: pictureBox6.Image = Properties.Resources.window2_green; break;
                case 3: pictureBox6.Image = Properties.Resources.window3_pink; break;
                case 4: pictureBox6.Image = Properties.Resources.window4_red; break;
            }
        }
    }
}
