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
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            
        }
        private void label_forgotPW_Click(object sender, EventArgs e)
        {
            frm_ForgotPassword frm_Forgotpw = new frm_ForgotPassword();
            frm_Forgotpw.ShowDialog();
            this.Hide();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Bạn có chắc muốn thoát không (Do you sure you want to exit)?", "Exit??", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (ret == DialogResult.Yes)
            {
                Application.Exit();
            }  
        }
        private void btn_Login_Click(object sender, EventArgs e)
        {
            if(guna2TextBox1.Text != null && txt_PassWord.Text=="admin" && txt_UserName.Text == "admin")
            {
                frm_Home frmhome = new frm_Home();
                frmhome.Show();
                this.Hide();
            }
        }

        private void txt_PassWord_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Login.PerformClick();
            }
        }

        private void txt_PassWord_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_PassWord.Text))
            {
                btn_view.Visible = false;
            }
            else
            {
                btn_view.Visible = true;
            }
        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            if (txt_PassWord.PasswordChar == '\0')
            {
                txt_PassWord.PasswordChar = '*';
            }
            else
            {
                txt_PassWord.PasswordChar = '\0';
            }
        }

        private void frm_Login_Load(object sender, EventArgs e)
        {
            btn_view.Visible = false;
        }
    }
}
