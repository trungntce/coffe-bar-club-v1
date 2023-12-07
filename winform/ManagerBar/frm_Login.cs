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
    }
}
