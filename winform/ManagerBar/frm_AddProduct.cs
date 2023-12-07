using Guna.UI2.WinForms;
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
    public partial class frm_AddProduct : Form
    {
        public frm_AddProduct()
        {
            InitializeComponent();
        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void guna2TextBox_IdProduct_Enter(object sender, EventArgs e)
        {
            Software_Functions.ChangeStateTextBox(guna2Separator_IdProduct, guna2TextBox_IdProduct);
        }

        private void guna2TextBox_IdProduct_Leave(object sender, EventArgs e)
        {
            Software_Functions.ChangeStateTextBox(guna2Separator_IdProduct, guna2TextBox_IdProduct);
        }

        private void guna2TextBox_NameProduct_Enter(object sender, EventArgs e)
        {
            Software_Functions.ChangeStateTextBox(guna2Separator_NameProduct, guna2TextBox_NameProduct);
        }
        private void guna2TextBox_NameProduct_Leave(object sender, EventArgs e)
        {
            Software_Functions.ChangeStateTextBox(guna2Separator_NameProduct, guna2TextBox_NameProduct);
        }

        private void guna2ComboBox1_Enter(object sender, EventArgs e)
        {
            Software_Functions.ChangeStateComboBox(guna2Separator3, guna2ComboBox1);
        }

        private void guna2ComboBox1_Leave(object sender, EventArgs e)
        {
            Software_Functions.ChangeStateComboBox(guna2Separator3, guna2ComboBox1);
        }

        private void guna2ComboBox2_Enter(object sender, EventArgs e)
        {
            Software_Functions.ChangeStateComboBox(guna2Separator4, guna2ComboBox2);
        }

        private void guna2ComboBox2_Leave(object sender, EventArgs e)
        {
            Software_Functions.ChangeStateComboBox(guna2Separator4, guna2ComboBox2);
        }

        private void guna2ComboBox3_Enter(object sender, EventArgs e)
        {
            Software_Functions.ChangeStateComboBox(guna2Separator5, guna2ComboBox3);
        }

        private void guna2ComboBox3_Leave(object sender, EventArgs e)
        {
            Software_Functions.ChangeStateComboBox(guna2Separator5, guna2ComboBox3);
        }

        private void guna2TextBox3_Enter(object sender, EventArgs e)
        {
            Software_Functions.ChangeStateTextBox(guna2Separator6, guna2TextBox3);
        }

        private void guna2TextBox3_Leave(object sender, EventArgs e)
        {
            Software_Functions.ChangeStateTextBox(guna2Separator6, guna2TextBox3);
        }

        private void guna2TextBox4_Enter(object sender, EventArgs e)
        {
            Software_Functions.ChangeStateTextBox(guna2Separator7, guna2TextBox4);
        }

        private void guna2TextBox4_Leave(object sender, EventArgs e)
        {
            Software_Functions.ChangeStateTextBox(guna2Separator7, guna2TextBox4);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            guna2Panel_AddgroupProduct.Visible = !guna2Panel_AddgroupProduct.Visible;
        }
       

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            guna2Panel_Location.Visible = !guna2Panel_Location.Visible;
        }

        private void label12_Click(object sender, EventArgs e)
        {
            guna2ComboBox4.DroppedDown = true;
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            guna2Panel_AddgroupProduct.Visible = false;
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            guna2Panel_Location.Visible = false;
        }

        private void guna2TextBox2_Enter(object sender, EventArgs e)
        {
            Software_Functions.ChangeStateTextBox(guna2Separator9, guna2TextBox2);
        }

        private void guna2TextBox2_Leave(object sender, EventArgs e)
        {
            Software_Functions.ChangeStateTextBox(guna2Separator9, guna2TextBox2);
        }

        private void guna2TextBox1_Enter(object sender, EventArgs e)
        {
            Software_Functions.ChangeStateTextBox(guna2Separator1, guna2TextBox1);
        }

        private void guna2TextBox1_Leave(object sender, EventArgs e)
        {
            Software_Functions.ChangeStateTextBox(guna2Separator1, guna2TextBox1);
        }

        private void guna2ComboBox4_Enter(object sender, EventArgs e)
        {
            Software_Functions.ChangeStateComboBox(guna2Separator2, guna2ComboBox4);
        }

        private void guna2ComboBox4_Leave(object sender, EventArgs e)
        {
            Software_Functions.ChangeStateComboBox(guna2Separator2, guna2ComboBox4);
        }

        private void label12_Enter(object sender, EventArgs e)
        {
            Software_Functions.ChangeStateComboBox(guna2Separator2, guna2ComboBox4);
        }

        private void label12_Leave(object sender, EventArgs e)
        {
            Software_Functions.ChangeStateComboBox(guna2Separator2, guna2ComboBox4);
        }

        private void guna2ComboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            label12.Visible = false;
        }
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            guna2Panel_Location.Visible = false;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            guna2Panel_AddgroupProduct.Visible = false;
        }
        private int originalPanel1Height;
        private void guna2ToggleSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2ToggleSwitch1.Checked)
            {
                guna2Panel2.Visible = true;
                guna2Panel1.Height = originalPanel1Height;
                guna2Panel3.Location = new Point(4, 300 + guna2Panel2.Height);
            }
            else
            {
                guna2Panel3.Location = new Point(4, 300);
                guna2Panel2.Visible = false;
                // Trừ chiều cao của guna2Panel2 khi ẩn nó
                guna2Panel1.Height = originalPanel1Height - guna2Panel2.Height;

            }
        }

        private void frm_AddProduct_Load(object sender, EventArgs e)
        {
            guna2Panel_AddgroupProduct.Visible = false;
            guna2Panel_Location.Visible = false;
            guna2Panel2.Visible = false;
            originalPanel1Height = guna2Panel1.Height;
            guna2Panel3.Location = new Point(4, 300);
        }

        private void guna2TextBox5_Enter(object sender, EventArgs e)
        {
            Software_Functions.ChangeStateTextBox(guna2Separator8, guna2TextBox5);
        }

        private void guna2TextBox5_Leave(object sender, EventArgs e)
        {
            Software_Functions.ChangeStateTextBox(guna2Separator8, guna2TextBox5);
        }

        private void guna2TextBox6_Enter(object sender, EventArgs e)
        {
            Software_Functions.ChangeStateTextBox(guna2Separator10, guna2TextBox6);
        }

        private void guna2TextBox6_Leave(object sender, EventArgs e)
        {
            Software_Functions.ChangeStateTextBox(guna2Separator10, guna2TextBox6);
        }

        private void guna2TextBox7_Enter(object sender, EventArgs e)
        {
            Software_Functions.ChangeStateTextBox(guna2Separator11, guna2TextBox7);
        }

        private void guna2TextBox7_Leave(object sender, EventArgs e)
        {
            Software_Functions.ChangeStateTextBox(guna2Separator11, guna2TextBox7);
        }
    }
}

