namespace CuoiKi
{
    partial class ThongKe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btn_dt_nam = new System.Windows.Forms.Button();
            this.dgv_kq = new System.Windows.Forms.DataGridView();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_doanhthu_thang = new System.Windows.Forms.Button();
            this.cbx_nam = new System.Windows.Forms.ComboBox();
            this.cbx_yeucau = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_kq)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea5.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea5);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Bottom;
            legend5.Name = "Legend1";
            this.chart1.Legends.Add(legend5);
            this.chart1.Location = new System.Drawing.Point(0, 340);
            this.chart1.Name = "chart1";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Doanh thu";
            this.chart1.Series.Add(series5);
            this.chart1.Size = new System.Drawing.Size(1129, 418);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // btn_dt_nam
            // 
            this.btn_dt_nam.Location = new System.Drawing.Point(245, 32);
            this.btn_dt_nam.Name = "btn_dt_nam";
            this.btn_dt_nam.Size = new System.Drawing.Size(216, 27);
            this.btn_dt_nam.TabIndex = 1;
            this.btn_dt_nam.Text = "Theo năm";
            this.btn_dt_nam.UseVisualStyleBackColor = true;
            this.btn_dt_nam.Click += new System.EventHandler(this.btn_dt_nam_Click);
            // 
            // dgv_kq
            // 
            this.dgv_kq.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_kq.Location = new System.Drawing.Point(12, 89);
            this.dgv_kq.Name = "dgv_kq";
            this.dgv_kq.RowHeadersWidth = 51;
            this.dgv_kq.RowTemplate.Height = 24;
            this.dgv_kq.Size = new System.Drawing.Size(1102, 245);
            this.dgv_kq.TabIndex = 2;
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(956, 23);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(128, 36);
            this.btn_back.TabIndex = 3;
            this.btn_back.Text = "Trở về";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_doanhthu_thang
            // 
            this.btn_doanhthu_thang.Location = new System.Drawing.Point(501, 33);
            this.btn_doanhthu_thang.Name = "btn_doanhthu_thang";
            this.btn_doanhthu_thang.Size = new System.Drawing.Size(216, 26);
            this.btn_doanhthu_thang.TabIndex = 4;
            this.btn_doanhthu_thang.Text = "Theo tháng";
            this.btn_doanhthu_thang.UseVisualStyleBackColor = true;
            this.btn_doanhthu_thang.Click += new System.EventHandler(this.btn_doanhthu_thang_Click);
            // 
            // cbx_nam
            // 
            this.cbx_nam.FormattingEnabled = true;
            this.cbx_nam.Location = new System.Drawing.Point(774, 36);
            this.cbx_nam.Name = "cbx_nam";
            this.cbx_nam.Size = new System.Drawing.Size(145, 24);
            this.cbx_nam.TabIndex = 5;
            this.cbx_nam.SelectedIndexChanged += new System.EventHandler(this.cbx_nam_SelectedIndexChanged);
            // 
            // cbx_yeucau
            // 
            this.cbx_yeucau.FormattingEnabled = true;
            this.cbx_yeucau.Items.AddRange(new object[] {
            "Doanh thu",
            "Hàng hóa"});
            this.cbx_yeucau.Location = new System.Drawing.Point(33, 33);
            this.cbx_yeucau.Name = "cbx_yeucau";
            this.cbx_yeucau.Size = new System.Drawing.Size(166, 24);
            this.cbx_yeucau.TabIndex = 6;
            this.cbx_yeucau.SelectedIndexChanged += new System.EventHandler(this.cbx_yeucau_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(723, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Năm: ";
            // 
            // ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 758);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbx_yeucau);
            this.Controls.Add(this.cbx_nam);
            this.Controls.Add(this.btn_doanhthu_thang);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.dgv_kq);
            this.Controls.Add(this.btn_dt_nam);
            this.Controls.Add(this.chart1);
            this.Name = "ThongKe";
            this.Text = "ThongKe";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ThongKe_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ThongKe_FormClosed);
            this.Load += new System.EventHandler(this.ThongKe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_kq)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button btn_dt_nam;
        private System.Windows.Forms.DataGridView dgv_kq;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_doanhthu_thang;
        private System.Windows.Forms.ComboBox cbx_nam;
        private System.Windows.Forms.ComboBox cbx_yeucau;
        private System.Windows.Forms.Label label1;
    }
}