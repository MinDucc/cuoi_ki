using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuoiKi
{
    public partial class ThongKe : Form
    {
        public bool isExit = true;
        public event EventHandler TroVe;
        ManagementDFContext db = new ManagementDFContext();
        public ThongKe()
        {
            InitializeComponent();
        }

        private void ThongKe_Load(object sender, EventArgs e)
        {
            Load_cbx_nam();
            HangHoa_thang();
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
            var result = from c in db.Orders
                         where c.order_date.Value.Year==year
                         group c by c.order_date.Value.Month;

            DataTable dt = new DataTable();
            DataColumn thang = new DataColumn("Thang");
            dt.Columns.Add(thang);
            DataColumn tong = new DataColumn("Total");
            dt.Columns.Add(tong);
            foreach (var key in result)
            {
                var kq = key.Sum(c => c.total);
                DataRow row = dt.NewRow();
                row["Total"] = kq;
                row["Thang"] = key.Key;
                dt.Rows.Add(row);
            }
            dgv_kq.DataSource = dt;
            chart1.ChartAreas["ChartArea1"].AxisX.Title = "Doanh thu theo tháng trong năm "+year.ToString();
            chart1.ChartAreas["ChartArea1"].AxisY.Title = "Doanh thu (vnd)";
            chart1.ChartAreas["ChartArea1"].AxisX.Interval = 1;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                chart1.Series["Doanh thu"].Points.AddXY(dt.Rows[i]["Thang"], dt.Rows[i]["Total"]);
                chart1.Series["Doanh thu"].Points[i].AxisLabel = "Tháng " + dt.Rows[i]["Thang"].ToString();
            }
        }
        private void Doanhthu_nam()
        {
            Clear_chart();
            var result = from c in db.Orders
                         
                         group c by c.order_date.Value.Year;

            DataTable dt = new DataTable();
            DataColumn Year = new DataColumn("Year");
            dt.Columns.Add(Year);
            DataColumn Total = new DataColumn("Total");
            dt.Columns.Add(Total);
            foreach (var key in result)
            {
                var kq = key.Sum(c => c.total);
                DataRow row = dt.NewRow();
                row["Total"] = kq;
                row["Year"] = key.Key;
                dt.Rows.Add(row);
            }
            dgv_kq.DataSource = dt;
            chart1.ChartAreas["ChartArea1"].AxisX.Title = "Doanh thu theo năm";
            chart1.ChartAreas["ChartArea1"].AxisY.Title = "Doanh thu (vnd)";
            chart1.ChartAreas["ChartArea1"].AxisX.Interval = 1;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                
                chart1.Series["Doanh thu"].Points.AddXY(dt.Rows[i]["Year"], dt.Rows[i]["Total"]);
                chart1.Series["Doanh thu"].Points[i].AxisLabel = "Năm " + dt.Rows[i]["Year"].ToString();
            }

        }
        private void HangHoa_thang()
        {

            DataTable dt = new DataTable();
            var kq = db.Doanhthu_thang(2022).Select(c => c);
            DataColumn Ten = new DataColumn("Ten");
            dt.Columns.Add(Ten);
            DataColumn SL = new DataColumn("SL");
            dt.Columns.Add(SL);

            foreach (var key in kq)
            {
                DataRow row = dt.NewRow();
                row["Ten"] = key.item_name;
                row["SL"] = key.tong;
                dt.Rows.Add(row);
            }
            dgv_kq.DataSource = kq.ToList();

            chart1.ChartAreas["ChartArea1"].AxisX.Title = "Tên các loại hàng hóa";
            chart1.ChartAreas["ChartArea1"].AxisY.Title = "Số lượng bán ra";
            chart1.ChartAreas["ChartArea1"].AxisX.Interval = 1;

            for (int i = 0; i < dt.Rows.Count; i++)
            {

                chart1.Series["Doanh thu"].Points.AddXY(dt.Rows[i]["Ten"], dt.Rows[i]["SL"]);
                
            }
        }
        private void btn_dt_nam_Click(object sender, EventArgs e)
        {
            if(yeucau=="Doanh thu")
                Doanhthu_nam();
            else
            {

            }    
        }

        private void btn_doanhthu_thang_Click(object sender, EventArgs e)
        {
            if(yeucau=="Doanh thu")
            {
                int year = int.Parse(cbx_nam.SelectedItem.ToString());
                DoanhThu_Thang(year);
            }
            else
            {

            }    
        }
        /// <summary>
        /// Các combo box
        /// </summary>
        private void Load_cbx_nam()
        {
            var result = db.Orders.GroupBy(c => c.order_date.Value.Year);
            var nam = result.Select(c => c.Key);
            cbx_nam.DataSource = nam.ToList();
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
        }
    }
}
