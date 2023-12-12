using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace ManagerBar
{
    public partial class frm_AddEmployee : Form
    {
        public frm_AddEmployee()
        {
            InitializeComponent();
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (!panel2.Visible)
            {
                panel2.Visible = true;
                guna2Button1.CustomImages.Image = Properties.Resources.upload;
                guna2Button5.Location = new Point(528, 722);
                guna2Button2.Location = new Point(656, 722);
                this.Height = 598;
                tabControl1.Height = 797;
                this.CenterToScreen();
            }
            else
            {
                panel2.Visible = false;
                guna2Button1.CustomImages.Image = Properties.Resources.upload__1_;
                guna2Button5.Location = new Point(528, 722 - panel2.Height);
                guna2Button2.Location = new Point(656, 722 - panel2.Height);
                this.Height = 330;
                tabControl1.Height = 290;
                this.CenterToScreen();
            }
        }
        private void guna2Button4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void SetupForm()
        {
            panel2.Visible = false;
            guna2Button5.Location = new Point(528, 722 - panel2.Height);
            guna2Button2.Location = new Point(656, 722 - panel2.Height);
            tabControl1.Height = 290;
            this.Height = 330;
            this.CenterToScreen();
        }
        private void frm_AddEmployee_Load(object sender, EventArgs e)
        {
            SetupForm();
        }

        private void guna2TextBox_IdEMployee_Enter(object sender, EventArgs e)
        {
            Software_Functions.ChangeStateTextBox(guna2Separator_IdProduct, guna2TextBox_IdEMployee);
        }

        private void guna2TextBox_IdEMployee_Leave(object sender, EventArgs e)
        {
            Software_Functions.ChangeStateTextBox(guna2Separator_IdProduct, guna2TextBox_IdEMployee);
        }

        private void guna2TextBox_Phone_Enter(object sender, EventArgs e)
        {
            Software_Functions.ChangeStateTextBox(guna2Separator_NameProduct, guna2TextBox_Phone);
        }
        private void guna2TextBox_Phone_Leave(object sender, EventArgs e)
        {
            Software_Functions.ChangeStateTextBox(guna2Separator_NameProduct, guna2TextBox_Phone);
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
            Software_Functions.ChangeStateComboBox(guna2Separator3, guna2ComboBox4);
        }
        private void guna2Separator3_Leave(object sender, EventArgs e)
        {
            Software_Functions.ChangeStateComboBox(guna2Separator3, guna2ComboBox4);
        }

        private void guna2TextBox2_Enter(object sender, EventArgs e)
        {
            Software_Functions.ChangeStateTextBox(guna2Separator2, guna2TextBox2);
        }

        private void guna2TextBox2_Leave(object sender, EventArgs e)
        {
            Software_Functions.ChangeStateTextBox(guna2Separator2, guna2TextBox2);
        }

        private void guna2TextBox6_Enter(object sender, EventArgs e)
        {
            Software_Functions.ChangeStateTextBox(guna2Separator8, guna2TextBox2);
        }

        private void guna2TextBox6_Leave(object sender, EventArgs e)
        {
            Software_Functions.ChangeStateTextBox(guna2Separator8, guna2TextBox2);
        }
        private void guna2ComboBox3_Enter(object sender, EventArgs e)
        {
            Software_Functions.ChangeStateComboBox(guna2Separator9, guna2ComboBox3);
        }

        private void guna2ComboBox3_Leave(object sender, EventArgs e)
        {
            Software_Functions.ChangeStateComboBox(guna2Separator9, guna2ComboBox3);
        }

        private void guna2ComboBox2_Enter(object sender, EventArgs e)
        {
            Software_Functions.ChangeStateComboBox(guna2Separator6, guna2ComboBox2);
        }

        private void guna2ComboBox2_Leave(object sender, EventArgs e)
        {
            Software_Functions.ChangeStateComboBox(guna2Separator6, guna2ComboBox2);
        }

        private void guna2ComboBox1_Enter(object sender, EventArgs e)
        {
            Software_Functions.ChangeStateComboBox(guna2Separator4, guna2ComboBox1);
        }

        private void guna2ComboBox1_Leave(object sender, EventArgs e)
        {
            Software_Functions.ChangeStateComboBox(guna2Separator4, guna2ComboBox1);
        }

        private void guna2TextBox3_Enter(object sender, EventArgs e)
        {
            Software_Functions.ChangeStateTextBox(guna2Separator5, guna2TextBox3);
        }

        private void guna2TextBox3_Leave(object sender, EventArgs e)
        {
            Software_Functions.ChangeStateTextBox(guna2Separator5, guna2TextBox3);
        }

        private void guna2TextBox5_Enter(object sender, EventArgs e)
        {
            Software_Functions.ChangeStateTextBox(guna2Separator13, guna2TextBox5);
        }

        private void guna2TextBox5_Leave(object sender, EventArgs e)
        {
            Software_Functions.ChangeStateTextBox(guna2Separator13, guna2TextBox5);
        }

        private void guna2TextBox9_Enter(object sender, EventArgs e)
        {
            Software_Functions.ChangeStateTextBox(guna2Separator12, guna2TextBox9);
        }

        private void guna2TextBox9_Leave(object sender, EventArgs e)
        {
            Software_Functions.ChangeStateTextBox(guna2Separator12, guna2TextBox9);
        }

        private void guna2TextBox8_Enter(object sender, EventArgs e)
        {
            Software_Functions.ChangeStateTextBox(guna2Separator18, guna2TextBox8);
        }

        private void guna2TextBox8_Leave(object sender, EventArgs e)
        {
            Software_Functions.ChangeStateTextBox(guna2Separator18, guna2TextBox8);
        }

        private void guna2TextBox11_Enter(object sender, EventArgs e)
        {
            Software_Functions.ChangeStateTextBox(guna2Separator11, guna2TextBox11);
        }

        private void guna2TextBox11_Leave(object sender, EventArgs e)
        {
            Software_Functions.ChangeStateTextBox(guna2Separator11, guna2TextBox11);
        }

        private void guna2TextBox4_Enter(object sender, EventArgs e)
        {
            Software_Functions.ChangeStateTextBox(guna2Separator7, guna2TextBox4);
        }

        private void guna2TextBox4_Leave(object sender, EventArgs e)
        {
            Software_Functions.ChangeStateTextBox(guna2Separator7, guna2TextBox4);
        }

        private void guna2TextBox10_Enter(object sender, EventArgs e)
        {
            Software_Functions.ChangeStateTextBox(guna2Separator10, guna2TextBox10);
        }

        private void guna2TextBox10_Leave(object sender, EventArgs e)
        {
            Software_Functions.ChangeStateTextBox(guna2Separator10, guna2TextBox10);
        }

        private void guna2TextBox7_Enter(object sender, EventArgs e)
        {
            Software_Functions.ChangeStateTextBox(guna2Separator14, guna2TextBox7);
        }

        private void guna2TextBox7_Leave(object sender, EventArgs e)
        {
            Software_Functions.ChangeStateTextBox(guna2Separator14, guna2TextBox7);
        }
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            guna2DateTimePicker1.PerformClick();
        }
        private void guna2DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            guna2TextBox6.Text = guna2DateTimePicker1.Value.ToString("dd/MM/yyyy");
        }
        private bool IsValidDateFormat(string input)
        {
            return DateTime.TryParseExact(input, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out _);
        }
        private void guna2TextBox6_TextChanged(object sender, EventArgs e)
        {
            string inputText = guna2TextBox6.Text;

            if (IsValidDateFormat(inputText))
            {
                DateTime selectedDate = DateTime.ParseExact(inputText, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                guna2DateTimePicker1.Value = selectedDate;
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Chọn một tệp hình ảnh";
            openFileDialog.Filter = "Tệp hình ảnh|*.png;*.jpg;*.jpeg;*.gif;*.bmp|Tất cả các tệp|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedImagePath = openFileDialog.FileName;
                pictureBox1.ImageLocation = selectedImagePath;
            }
        }
        private void label26_Click(object sender, EventArgs e)
        {
            guna2ComboBox3.DroppedDown = true;
        }
        private void label16_Click(object sender, EventArgs e)
        {
            guna2ComboBox2.DroppedDown = true;
        }

        private void label17_Click(object sender, EventArgs e)
        {
            guna2ComboBox1.DroppedDown = true;
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}
