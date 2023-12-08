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
    public partial class frm_Home : Form
    {
        public frm_Home()
        {
            InitializeComponent();
        }

        private Form currentFormChild;
        public void OpenChildForm(Form childform)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            panel_childform.Controls.Add(childform);
            panel_childform.Tag = childform;
            childform.BringToFront();
            childform.Show();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_OverView(this));
        }

        private void frm_Home_Load(object sender, EventArgs e)
        {
            OpenChildForm(new frm_OverView(this));
        }

        private void tổngQuanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_OverView(this));
        }

        private void danhMụcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_Products(this));
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Bạn có chắc muốn thoát không (Do you sure you want to exit)?", "Exit??", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (ret == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void thiếtLậpGiáToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_PriceSetting(this));
        }

        private void chấmCôngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frm_Employee(this));
        }
    }
}
