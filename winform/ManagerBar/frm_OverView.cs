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
            InitializeChart();
        }
        private void InitializeChart()
        {
            // Kiểm tra xem Guna2Panel2 đã được khởi tạo chưa
            if (guna2Panel6 != null)
            {
                // Tạo một biểu đồ mới
                Chart waveChart = new Chart();

                // Đặt kích thước của biểu đồ
                waveChart.Size = new Size(957, 279);

                // Tạo loại biểu đồ Line
                Series series = new Series("Wave");
                series.ChartType = SeriesChartType.Line;

                // Thêm dữ liệu mẫu cho biểu đồ sóng
                for (double x = 0; x <= 2 * Math.PI; x += 0.1)
                {
                    double y = Math.Sin(x);
                    series.Points.AddXY(x, y);
                }

                // Thêm loại biểu đồ vào biểu đồ
                waveChart.Series.Add(series);

                // Kiểm tra và thêm ChartArea nếu chưa có
                if (waveChart.ChartAreas.Count == 0)
                {
                    waveChart.ChartAreas.Add(new ChartArea());
                }

                // Đặt tên cho trục x và trục y
                waveChart.ChartAreas[0].AxisX.Title = "X-Axis";
                waveChart.ChartAreas[0].AxisY.Title = "Y-Axis";

                // Đặt vị trí của biểu đồ (góc dưới bên trái của panel)
                waveChart.Location = new Point(0, guna2Panel6.Height - waveChart.Height);

                // Thêm biểu đồ vào Guna2Panel2
                guna2Panel6.Controls.Add(waveChart);

                // Đặt vị trí và kích thước của biểu đồ trong Guna2Panel2
                waveChart.Dock = DockStyle.Fill;
            }
            else
            {
                MessageBox.Show("Guna2Panel6 is not initialized.");
            }
        }


        private void frm_OverView_Load(object sender, EventArgs e)
        {
            guna2ComboBox1.SelectedIndex = 0;
            guna2ComboBox2.SelectedIndex = 0;
            guna2ComboBox3.SelectedIndex = 0;
        }
    }
}
