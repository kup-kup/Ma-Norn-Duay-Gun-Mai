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

        private void OwnerChoose_Load(object sender, EventArgs e)
        {
            switch (GlobalVar.owner_op)
            {
                case 1: radioButton1.Select(); break;
                case 2: radioButton2.Select(); break;
                case 3: radioButton4.Select(); break;
                case 4: radioButton3.Select(); break;
                case 5: radioButton5.Select(); break;
                case 6: radioButton6.Select(); break;
                case 7: radioButton7.Select(); break;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            GlobalVar.owner_op = 1;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            GlobalVar.owner_op = 2;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            GlobalVar.owner_op = 3;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            GlobalVar.owner_op = 4;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            GlobalVar.owner_op = 5;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            GlobalVar.owner_op = 6;
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            GlobalVar.owner_op = 7;
        }
    }
}
