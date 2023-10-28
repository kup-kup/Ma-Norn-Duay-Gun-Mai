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
    public partial class Title : Form
    {
        int hold_timer = 0, speed = 2, hold_for = 110;
        string moving = "left";

        public Title()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            // room_preview room_Preview_var = new room_preview();
            // room_Preview_var.Show();

            //roompreview room_Preview_var = new roompreview();
            //room_Preview_var.Show();

            explain explain_var = new explain();
            explain_var.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Title_Load(object sender, EventArgs e)
        {

        }

        private void moveTimerEvent(object sender, EventArgs e)
        {
            //0, 543
            if (moving == "right")
            {
                if (pictureBox1.Left <= 0)
                {
                    pictureBox1.Left += speed;
                    return;
                }

                hold_timer -= speed;
                if (hold_timer <= 0) moving = "left";
            }

            if (moving == "left")
            {
                if (pictureBox1.Left >= -543)
                {
                    pictureBox1.Left -= speed;
                    return;
                }

                hold_timer += speed;
                if (hold_timer >= hold_for) moving = "right";
            }
        }
    }
}