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
    public partial class frm_PriceSetting : Form
    {
        private frm_Home parentForm;
        private Guna2Button guna2Button;
        private ContextMenuStrip itemsMenu;

        public frm_PriceSetting(frm_Home parentForm)
        {
            InitializeComponent();
            InitializeButton();
            this.parentForm = parentForm;
        }

        private void InitializeButton()
        {
            guna2Button = guna2Button2; // Sử dụng nút bạn đã kéo vào từ Toolbox
            guna2Button.Text = "Select Item";
            guna2Button.Click += Guna2Button2_Click;

            itemsMenu = new ContextMenuStrip();
            ToolStripMenuItem item1 = new ToolStripMenuItem("Item 1");
            item1.CheckOnClick = true;
            itemsMenu.Items.Add(item1);

            ToolStripMenuItem item2 = new ToolStripMenuItem("Item 2");
            item2.CheckOnClick = true;
            itemsMenu.Items.Add(item2);

            ToolStripMenuItem item3 = new ToolStripMenuItem("Item 3");
            item3.CheckOnClick = true;
            itemsMenu.Items.Add(item3);
            // Bạn không cần thêm nút vào Controls nếu đã kéo vào form từ Toolbox.
        }

        private void Guna2Button2_Click(object sender, EventArgs e)
        {
            itemsMenu.Show(guna2Button, 0, guna2Button.Height);
        }

        private void Item_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem clickedItem = (ToolStripMenuItem)sender;
            guna2Button.Text = clickedItem.Text;
        }
    }
}
