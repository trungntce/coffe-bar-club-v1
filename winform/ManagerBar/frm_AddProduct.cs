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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
        private void SetUpTooltip()
        {
            System.Windows.Forms.ToolTip toolTip1 = new System.Windows.Forms.ToolTip();
            toolTip1.SetToolTip(pictureBox8, "Mã hàng là thông tin duy nhất");
            toolTip1.SetToolTip(pictureBox9, "Tên hàng là tên của sản phẩm");
            toolTip1.SetToolTip(pictureBox10, "Lựa chọn loại thực đơn sản phẩm");
            toolTip1.SetToolTip(pictureBox11, "Lựa chọn nhóm hàng cho sản phẩm");
            toolTip1.SetToolTip(pictureBox12, "Sử dụng vị trí để ghi lại vị trí mà hàng hóa được cất giữ. Ví dụ : Tủ lạnh, bếp từ....");
            toolTip1.SetToolTip(pictureBox13, "Giá vốn dùng để tính lợi nhuận cho sản phẩm \n( sẽ tự động thay đổi khi thay đổi phương pháp tính giá vốn.");
            toolTip1.SetToolTip(pictureBox14, "Sản phẩm sẽ xuất hiện trên màn hình bán hàng ");
            toolTip1.SetToolTip(pictureBox15, "Là hàng hóa có thể bán kèm cùng với hàng hóa khác.\nVí dụ hàng toping như thịt heo thêm, rau thêm, trân châu, thạch,...");
            toolTip1.SetToolTip(pictureBox16, "Hàng hóa được tạo thành từ nhiều hàng hóa và dịch vụ khác");
            toolTip1.InitialDelay = 500;
            toolTip1.AutoPopDelay = 2000;
            toolTip1.ReshowDelay = 500;
            
        }
        private void frm_AddProduct_Load(object sender, EventArgs e)
        {
            heightPanel3 = guna2Panel3.Height;
            guna2Panel3.Height = 31;
            guna2Panel3.Location = new Point(4, 300);
            guna2Panel_AddgroupProduct.Visible = false;
            guna2Panel_Location.Visible = false;
            guna2Panel2.Visible = false;
            guna2Panel4.Visible = false;
            originalPanel1Height = guna2Panel1.Height;

            
            SetUpTooltip();

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
        private int heightPanel3;
        private int clickCount = 0;
        private void guna2Button8_Click(object sender, EventArgs e)
        {
            clickCount++;
            if (clickCount % 2 == 1)
            {
                guna2Panel4.Visible = true;
                guna2Panel3.Height = heightPanel3;
                // guna2Panel.Location = new Point(4, 300 + guna2Panel2.Height);
                guna2Button8.CustomImages.Image = Properties.Resources.up_arrow;
            }
            else
            {
                guna2Panel4.Visible = false;
                guna2Panel3.Height = heightPanel3 - guna2Panel4.Height;          
                guna2Button8.CustomImages.Image = Properties.Resources.arrow_down_sign_to_navigate;
            }
        }
        private void guna2Button3_Click(object sender, EventArgs e)
        {
           // MyToolTip.Show("Tooltip text goes here", MyButton);
        }
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabPage1)
            {
                tabControl1.Height = 562;
                this.Height = 598;
            }
            else if (tabControl1.SelectedTab == tabPage2)
            {
                tabControl1.Height = 400;
                this.Height = 436;
            }
            else
            {
                tabControl1.Height = 200;
                this.Height = 236;
            }
        }
        private void guna2TextBox8_Enter(object sender, EventArgs e)
        {
            Software_Functions.ChangeStateTextBox(guna2Separator12, guna2TextBox8);
        }
        private void guna2TextBox8_Leave(object sender, EventArgs e)
        {
            Software_Functions.ChangeStateTextBox(guna2Separator12, guna2TextBox8);
        }
        private void guna2Button12_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void guna2TextBox9_Enter(object sender, EventArgs e)
        {
            Software_Functions.ChangeStateTextBox(guna2Separator13, guna2TextBox9);
        }
        private void guna2TextBox9_Leave(object sender, EventArgs e)
        {
            Software_Functions.ChangeStateTextBox(guna2Separator13, guna2TextBox9);
        }
        private void guna2Button16_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

