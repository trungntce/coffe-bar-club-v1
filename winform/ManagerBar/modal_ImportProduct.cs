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
    public partial class modal_ImportProduct : Form
    {
        public modal_ImportProduct()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void modal_ImportProduct_Load(object sender, EventArgs e)
        {

        }

        private void btn_choosefiledataProduct_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Chọn tệp tin dữ liệu sản phẩm";
            openFileDialog.Filter = "Tất cả các tệp tin|*.*|Tệp tin Excel|*.xlsx|Tệp tin CSV|*.csv";
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Lấy đường dẫn của tệp tin đã chọn
                string selectedFilePath = openFileDialog.FileName;
                // Xử lý tệp tin ở đây (ví dụ: đặt đường dẫn vào một TextBox)
            }
        }
    }
}
