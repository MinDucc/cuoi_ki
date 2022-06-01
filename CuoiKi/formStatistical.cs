using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CuoiKi.BLL;
namespace CuoiKi
{
    public partial class formStatistical : Form
    {
        public bool isExit = true;
        public event EventHandler TroVe;
        ManagementDFContext db = new ManagementDFContext();
        public formStatistical()
        {
            InitializeComponent();
        }

        private void ThongKe_Load(object sender, EventArgs e)
        {
            Load_cbx_nam();
            
        } 
        private void btn_back_Click(object sender, EventArgs e)
        {
            TroVe(this, new EventArgs());
            this.Close();
        }
        
        
        public delegate void Exit(bool exit);
        public Exit exit;
        private void ThongKe_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isExit)
            {
                exit(true);
                Application.Exit();
            }
        }

        private void ThongKe_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isExit)
            {
                if (MessageBox.Show("Bạn có muốn đóng form", "Thông báo", MessageBoxButtons.YesNo) != DialogResult.Yes)
                {
                    e.Cancel = true;
                }
            }
        }
        private void Clear_chart()
        {

            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }
        }
        private void DoanhThu_Thang(int year)
        {
            Clear_chart();
           

            DataTable dt = StatisticalBLL.Instance.Revenue_month(year);
            
            
            chart1.ChartAreas["ChartArea1"].AxisX.Title = "Doanh thu theo tháng trong năm "+year.ToString();
            chart1.ChartAreas["ChartArea1"].AxisY.Title = "Doanh thu (vnd)";
            chart1.ChartAreas["ChartArea1"].AxisY.Maximum = 1000000;
            chart1.ChartAreas["ChartArea1"].AxisX.MajorGrid.Enabled = false;
            chart1.ChartAreas["ChartArea1"].AxisY.MajorGrid.Enabled = false;
            chart1.ChartAreas["ChartArea1"].AxisX.Interval = 1;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                chart1.Series["Doanh thu"].Points.AddXY(dt.Rows[i]["Thang"], dt.Rows[i]["Total"]);
                chart1.Series["Doanh thu"].Points[i].AxisLabel = "Tháng " + dt.Rows[i]["Thang"].ToString();
                chart1.Series["Doanh thu"].Points[i].Label = dt.Rows[i]["Total"].ToString();
            }
        }
        private void Doanhthu_nam()
        {
            Clear_chart();          

            DataTable dt = StatisticalBLL.Instance.Revenue_year();
            
            
            chart1.ChartAreas["ChartArea1"].AxisX.Title = "Doanh thu theo năm";
            chart1.ChartAreas["ChartArea1"].AxisY.Title = "Doanh thu (vnd)";
            chart1.ChartAreas["ChartArea1"].AxisX.Interval = 1;
            chart1.ChartAreas["ChartArea1"].AxisY.Maximum = 1000000;
            chart1.ChartAreas["ChartArea1"].AxisX.MajorGrid.Enabled = false;
            chart1.ChartAreas["ChartArea1"].AxisY.MajorGrid.Enabled = false;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                
                chart1.Series["Doanh thu"].Points.AddXY(dt.Rows[i]["Year"], dt.Rows[i]["Total"]);
                chart1.Series["Doanh thu"].Points[i].AxisLabel = "Năm " + dt.Rows[i]["Year"].ToString();
                chart1.Series["Doanh thu"].Points[i].Label = dt.Rows[i]["Total"].ToString();
            }

        }
        private void HangHoa_thang(int year)
        {
            Clear_chart();
            DataTable dt = StatisticalBLL.Instance.LineItem_in_year(year);           
            chart1.ChartAreas["ChartArea1"].AxisX.Title = "Tên các loại hàng hóa";
            chart1.ChartAreas["ChartArea1"].AxisY.Title = "Doanh thu theo hàng hóa bán ra "+"trong năm "+year.ToString();
            chart1.ChartAreas["ChartArea1"].AxisY.Maximum = 1000000;
            chart1.ChartAreas["ChartArea1"].AxisX.MajorGrid.Enabled = false;
            chart1.ChartAreas["ChartArea1"].AxisY.MajorGrid.Enabled = false;
            chart1.ChartAreas["ChartArea1"].AxisX.Interval = 1;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                chart1.Series["Doanh thu"].Points.AddXY(dt.Rows[i]["Ten"], dt.Rows[i]["Doanh thu"]);
                chart1.Series["Doanh thu"].Points[i].Label = dt.Rows[i]["Doanh thu"].ToString();
            }
            chart1.Series["Doanh thu"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            
        }
        private void HangHoa_tung_thang(int year,int month)
        {
            Clear_chart();
            DataTable dt = StatisticalBLL.Instance.LineItem_in_month(year, month);
            

            chart1.ChartAreas["ChartArea1"].AxisX.Title = "Tên các loại hàng hóa";
            chart1.ChartAreas["ChartArea1"].AxisY.Title = "Doanh thu theo hàng hóa bán ra " + "trong tháng " + month.ToString();
            chart1.ChartAreas["ChartArea1"].AxisY.Maximum = 1000000;
            chart1.ChartAreas["ChartArea1"].AxisX.MajorGrid.Enabled = false;
            chart1.ChartAreas["ChartArea1"].AxisY.MajorGrid.Enabled = false;
            chart1.ChartAreas["ChartArea1"].AxisX.Interval = 1;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                chart1.Series["Doanh thu"].Points.AddXY(dt.Rows[i]["Ten"], dt.Rows[i]["Doanh thu"]);
                chart1.Series["Doanh thu"].Points[i].Label = dt.Rows[i]["Doanh thu"].ToString();
            }
            chart1.Series["Doanh thu"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
        }    
        private void btn_dt_nam_Click(object sender, EventArgs e)
        {
            if(yeucau=="Doanh thu")
                Doanhthu_nam();
            if (yeucau == "Hàng hóa")
            {
                int year = int.Parse(cbx_nam.SelectedItem.ToString());
                HangHoa_thang(year);
            }
        }

        private void btn_doanhthu_thang_Click(object sender, EventArgs e)
        {
            int year = int.Parse(cbx_nam.SelectedItem.ToString());
            if (yeucau=="Doanh thu")
            {
                
                DoanhThu_Thang(year);
            }
            if(yeucau=="Hàng hóa")
            {
                if(cbx_thang.SelectedItem!=null)
                {
                    int month = int.Parse(cbx_thang.SelectedItem.ToString());
                    HangHoa_tung_thang(year,month);
                }    
            }    
        }
        /// <summary>
        /// Các combo bo    x
        /// </summary>
        private void Load_cbx_nam()
        {
            
            cbx_nam.DataSource = StatisticalBLL.Instance.Load_year();
        }
        private void cbx_nam_SelectedIndexChanged(object sender, EventArgs e)
        {              
        }
        private string yeucau = "";
        private void cbx_yeucau_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbx_yeucau.SelectedItem != null)
            {
                yeucau = cbx_yeucau.SelectedItem.ToString();
            }
            if(yeucau=="Doanh thu")
            {
                cbx_thang.Enabled = false;
            }
            else
            {
                cbx_thang.Enabled = true;
            }    
        }
    }
}
