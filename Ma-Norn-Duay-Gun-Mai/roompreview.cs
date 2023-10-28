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

        //LAMP Features
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            LampChoose lampChoose_var = new LampChoose();
            lampChoose_var.Show();
        }
        private void pictureBox3_enter(object sender, EventArgs e)
        {
            switch (GlobalVar.lamp_op)
            {
                case 1: pictureBox3.Image = Properties.Resources.Lamp1_brown_h; break;
                case 2: pictureBox3.Image = Properties.Resources.Lamp2_pink_h; break;
                case 3: pictureBox3.Image = Properties.Resources.Lamp3_red_h; break;
                case 4: pictureBox3.Image = Properties.Resources.Lamp4_yellow_h; break;
            }
        }

        private void pictureBox3_leave(object sender, EventArgs e)
        {
            switch (GlobalVar.lamp_op)
            {
                case 1: pictureBox3.Image = Properties.Resources.Lamp1_brown; break;
                case 2: pictureBox3.Image = Properties.Resources.Lamp2_pink; break;
                case 3: pictureBox3.Image = Properties.Resources.Lamp3_red; break;
                case 4: pictureBox3.Image = Properties.Resources.Lamp4_yellow; break;
            }
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

        //WARDROBE features
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            WardrobeChoose WardrobeChoose_var = new WardrobeChoose();
            WardrobeChoose_var.Show();
        }
        private void pictureBox4_enter(object sender, EventArgs e)
        {
            switch (GlobalVar.wardrobe_op)
            {
                case 1: pictureBox4.Image = Properties.Resources.Ward1_kid_h; break;
                case 2: pictureBox4.Image = Properties.Resources.Ward2_mirror_h; break;
                case 3: pictureBox4.Image = Properties.Resources.Ward3_plain_h; break;
                case 4: pictureBox4.Image = Properties.Resources.Ward4_white_h; break;
            }
        }

        private void pictureBox4_leave(object sender, EventArgs e)
        {
            switch (GlobalVar.wardrobe_op)
            {
                case 1: pictureBox4.Image = Properties.Resources.Ward1_kid; break;
                case 2: pictureBox4.Image = Properties.Resources.Ward2_mirror; break;
                case 3: pictureBox4.Image = Properties.Resources.Ward3_plain; break;
                case 4: pictureBox4.Image = Properties.Resources.Ward4_white; break;
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

        // WINDOW Features
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Hide();
            WindowChoose WindowChoose_var = new WindowChoose();
            WindowChoose_var.Show();
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

        // CLOCK Features
        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Hide();
            ClockChoose ClockChoose_var = new ClockChoose();
            ClockChoose_var.Show();
        }

        private void pictureBox7_enter(object sender, EventArgs e)
        {
            switch (GlobalVar.clock_op)
            {
                case 1: pictureBox7.Image = Properties.Resources.clock1_pink_h; break;
                case 2: pictureBox7.Image = Properties.Resources.clock2_kid_h; break;
                case 3: pictureBox7.Image = Properties.Resources.clock3_old_h; break;
                case 4: pictureBox7.Image = Properties.Resources.clock4_cuckoo_h; break;
            }
        }

        private void pictureBox7_leave(object sender, EventArgs e)
        {
            switch (GlobalVar.clock_op)
            {
                case 1: pictureBox7.Image = Properties.Resources.clock1_pink; break;
                case 2: pictureBox7.Image = Properties.Resources.clock2_kid; break;
                case 3: pictureBox7.Image = Properties.Resources.clock3_old; break;
                case 4: pictureBox7.Image = Properties.Resources.clock4_cuckoo; break;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            OwnerChoose OwnerChoose_var = new OwnerChoose();
            OwnerChoose_var.Show();
        }

        private void next_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            FinalForm FinalForm_var = new FinalForm();
            FinalForm_var.Show();
        }
    }
}
