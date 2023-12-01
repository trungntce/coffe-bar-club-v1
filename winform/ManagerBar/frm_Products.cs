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

        }
    }
}
