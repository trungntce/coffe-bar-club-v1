using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ManagerBar
{
    public partial class frm_OverView : Form
    {
        private frm_Home parentForm;
        public frm_OverView(frm_Home parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
        }

        private void frm_OverView_Load(object sender, EventArgs e)
        {
            guna2ComboBox1.SelectedIndex = 0;
            guna2ComboBox2.SelectedIndex = 0;
            guna2ComboBox3.SelectedIndex = 0;
            List<string> categories = new List<string> { "Category A", "Category B", "Category C", "Category D" };
            List<int> values = new List<int> { 10, 20, 15, 25 };

            // Tạo đối tượng Series để chứa dữ liệu
            Series series = chart1.Series.Add("DataSeries");

            // Thiết lập loại biểu đồ là cột
            series.ChartType = SeriesChartType.Column;

            // Thêm dữ liệu vào series
            for (int i = 0; i < categories.Count; i++)
            {
                series.Points.AddXY(categories[i], values[i]);
            }

            // Đặt tên cho trục x và trục y
            chart1.ChartAreas[0].AxisX.Title = "Categories";
            chart1.ChartAreas[0].AxisY.Title = "Values";
        }
    }
}
