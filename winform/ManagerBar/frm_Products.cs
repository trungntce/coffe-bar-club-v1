using Guna.UI.WinForms;
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
using System.Windows.Forms.VisualStyles;

namespace ManagerBar
{
    public partial class frm_Products : Form
    {
        private frm_Home parentForm;
        public frm_Products(frm_Home parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;

        }
        private void frm_Products_Load(object sender, EventArgs e)
        {
            guna2Panel_Checkbox.Visible = false;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            guna2ComboBox2.DroppedDown = true;
        }
       
        private void guna2ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(guna2ComboBox2.SelectedIndex == 0)
            {
                frm_AddProduct f = new frm_AddProduct();
                f.Show();
            }
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            modal_ImportProduct modalproduct = new modal_ImportProduct();
            modalproduct.ShowDialog();
        }
        private void guna2Button4_Click_1(object sender, EventArgs e)
        {
            if (!guna2Panel_Checkbox.Visible)
            {
                guna2Panel_Checkbox.Visible = true;
                guna2Button4.Image = Properties.Resources.arrow_up;
            }
            else
            {
                guna2Panel_Checkbox.Visible = false;
                guna2Button4.Image = Properties.Resources.down1;
            }
        }
        private void guna2TextBox1_Enter(object sender, EventArgs e)
        {
           Software_Functions.ChangeStateTextBox(guna2Separator2, guna2TextBox1);
        }

        private void guna2TextBox1_Leave(object sender, EventArgs e)
        {
            Software_Functions.ChangeStateTextBox(guna2Separator2, guna2TextBox1);
        }
    }
}

