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
    public partial class BedChoose : Form
    {
        public BedChoose()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            GlobalVar.bed_op = 1;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            GlobalVar.bed_op = 2;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            GlobalVar.bed_op = 3;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            GlobalVar.bed_op = 4;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            roompreview room_Preview_var = new roompreview();
            room_Preview_var.Show();
        }

        private void BedChoose_Load(object sender, EventArgs e)
        {
            switch (GlobalVar.bed_op)
            {
                case 1: radioButton1.Select(); break;
                case 2: radioButton2.Select(); break;
                case 3: radioButton4.Select(); break;
                case 4: radioButton3.Select(); break;
            }
        }
    }
}
