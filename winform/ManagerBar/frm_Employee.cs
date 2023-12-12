using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagerBar
{
    public partial class frm_Employee : Form
    {
        private frm_Home parentForm;
        public frm_Employee(frm_Home parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
        }
        private int clickCount = 0;
        private void guna2PictureBox3_Click(object sender, EventArgs e)
        {
            clickCount++;
            if (clickCount % 2 == 1)
            {
                guna2PictureBox3.Image = Properties.Resources.up_arrow;
                guna2Panel2.Height = 93;
                guna2Panel3.Location = new Point(0, 46 + 53);
            }
            else
            {
                guna2PictureBox3.Image = Properties.Resources.arrow_down_sign_to_navigate;
                guna2Panel2.Height = 40;
                guna2Panel3.Location = new Point(0, 46);
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {
            guna2ComboBox1.DroppedDown = true;
        }

        private void guna2PictureBox4_Click(object sender, EventArgs e)
        {
            clickCount++;
            if (clickCount % 2 == 1)
            {
                guna2PictureBox4.Image = Properties.Resources.up_arrow;
                guna2Panel3.Height = 93;
            }
            else
            {
                guna2PictureBox4.Image = Properties.Resources.arrow_down_sign_to_navigate;
                guna2Panel3.Height = 40;
            }
        }

        private void guna2ComboBox1_Enter(object sender, EventArgs e)
        {
            Software_Functions.ChangeStateComboBox(guna2Separator2, guna2ComboBox1);
        }

        private void guna2ComboBox1_Leave(object sender, EventArgs e)
        {
            Software_Functions.ChangeStateComboBox(guna2Separator2, guna2ComboBox1);
        }

        private void guna2ComboBox3_Enter(object sender, EventArgs e)
        {
            Software_Functions.ChangeStateComboBox(guna2Separator1, guna2ComboBox3);
        }

        private void guna2ComboBox3_Leave(object sender, EventArgs e)
        {
            Software_Functions.ChangeStateComboBox(guna2Separator1, guna2ComboBox3);
        }

        private void guna2TextBox1_Enter(object sender, EventArgs e)
        {
            Software_Functions.ChangeStateComboBox(guna2Separator2, guna2ComboBox1);
        }

        private void guna2TextBox1_Leave(object sender, EventArgs e)
        {
            Software_Functions.ChangeStateComboBox(guna2Separator2, guna2ComboBox1);
        }

        private void guna2Separator4_Enter(object sender, EventArgs e)
        {

        }

        private void guna2Separator4_Leave(object sender, EventArgs e)
        {

        }
    }
}
