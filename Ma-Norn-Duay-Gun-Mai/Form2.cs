﻿using System;
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
    public partial class explain : Form
    {
        public explain()
        {
            InitializeComponent();
        }

        private void next_button_Click(object sender, EventArgs e)
        {
            roompreview room_Preview_var = new roompreview();
            room_Preview_var.Show();
        }
    }
}