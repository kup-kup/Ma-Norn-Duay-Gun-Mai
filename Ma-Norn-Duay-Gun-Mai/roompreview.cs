﻿using System;
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
        public static class GrobalVar
        {
            public static int bed_op = 1;
        }

        public roompreview()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            BedChoose bedChoose_var = new BedChoose();
            bedChoose_var.Show();
        }

        private void pictureBox1_enter(object sender, EventArgs e)
        {
            switch (GrobalVar.bed_op)
            {
                case 1: pictureBox1.Image = Properties.Resources.Bed1_blue_h; break;
            }
        }

        private void pictureBox1_leave(object sender, EventArgs e)
        {
            switch (GrobalVar.bed_op)
            {
                case 1: pictureBox1.Image = Properties.Resources.Bed1_blue; break;
            }
        }

        private void roompreview_Load(object sender, EventArgs e)
        {
            switch (GrobalVar.bed_op)
            {
                case 1: pictureBox1.Image = Properties.Resources.Bed1_blue; break;
                case 2: pictureBox1.Image = Properties.Resources.Bed2_cream; break;
                case 3: pictureBox1.Image = Properties.Resources.Bed3_grey; break;
                case 4: pictureBox1.Image = Properties.Resources.Bed4_kid; break;
            }
        }
    }
}
