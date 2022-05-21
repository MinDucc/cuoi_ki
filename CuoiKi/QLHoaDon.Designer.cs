namespace CuoiKi
{
    partial class QLHoaDon
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
            this.btn_back = new System.Windows.Forms.Button();
            this.dt_ngaymua = new System.Windows.Forms.DateTimePicker();
            this.tbx_ma = new System.Windows.Forms.TextBox();
            this.tbx_ten = new System.Windows.Forms.TextBox();
            this.btn_tim = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbx_yeucau = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv_Order = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Order)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(454, 121);
            this.btn_back.Margin = new System.Windows.Forms.Padding(4);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(111, 47);
            this.btn_back.TabIndex = 45;
            this.btn_back.Text = "Trở về";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // dt_ngaymua
            // 
            this.dt_ngaymua.Location = new System.Drawing.Point(147, 131);
            this.dt_ngaymua.Margin = new System.Windows.Forms.Padding(4);
            this.dt_ngaymua.Name = "dt_ngaymua";
            this.dt_ngaymua.Size = new System.Drawing.Size(277, 22);
            this.dt_ngaymua.TabIndex = 44;
            // 
            // tbx_ma
            // 
            this.tbx_ma.Location = new System.Drawing.Point(147, 91);
            this.tbx_ma.Margin = new System.Windows.Forms.Padding(4);
            this.tbx_ma.Name = "tbx_ma";
            this.tbx_ma.Size = new System.Drawing.Size(277, 22);
            this.tbx_ma.TabIndex = 43;
            // 
            // tbx_ten
            // 
            this.tbx_ten.Location = new System.Drawing.Point(147, 59);
            this.tbx_ten.Margin = new System.Windows.Forms.Padding(4);
            this.tbx_ten.Name = "tbx_ten";
            this.tbx_ten.Size = new System.Drawing.Size(277, 22);
            this.tbx_ten.TabIndex = 42;
            // 
            // btn_tim
            // 
            this.btn_tim.Location = new System.Drawing.Point(454, 66);
            this.btn_tim.Margin = new System.Windows.Forms.Padding(4);
            this.btn_tim.Name = "btn_tim";
            this.btn_tim.Size = new System.Drawing.Size(111, 47);
            this.btn_tim.TabIndex = 41;
            this.btn_tim.Text = "Tìm";
            this.btn_tim.UseVisualStyleBackColor = true;
            this.btn_tim.Click += new System.EventHandler(this.btn_tim_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 138);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 17);
            this.label5.TabIndex = 40;
            this.label5.Text = "Ngày mua";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 97);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 17);
            this.label4.TabIndex = 39;
            this.label4.Text = "Mã hóa đơn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 59);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 17);
            this.label3.TabIndex = 38;
            this.label3.Text = "Tên khách hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 37;
            this.label2.Text = "Chọn yêu cầu";
            // 
            // cbx_yeucau
            // 
            this.cbx_yeucau.FormattingEnabled = true;
            this.cbx_yeucau.Items.AddRange(new object[] {
            "Xem hóa đơn theo ngày",
            "Xem hóa đơn theo mã hóa đơn",
            "Xem hóa đơn theo tên khách hàng"});
            this.cbx_yeucau.Location = new System.Drawing.Point(147, 9);
            this.cbx_yeucau.Margin = new System.Windows.Forms.Padding(4);
            this.cbx_yeucau.Name = "cbx_yeucau";
            this.cbx_yeucau.Size = new System.Drawing.Size(277, 24);
            this.cbx_yeucau.TabIndex = 36;
            this.cbx_yeucau.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(24, 171);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 20);
            this.label1.TabIndex = 35;
            this.label1.Text = "Thông tin hóa đơn";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dgv_Order);
            this.panel1.Location = new System.Drawing.Point(19, 181);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(885, 247);
            this.panel1.TabIndex = 34;
            // 
            // dgv_Order
            // 
            this.dgv_Order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Order.Location = new System.Drawing.Point(7, 12);
            this.dgv_Order.Name = "dgv_Order";
            this.dgv_Order.RowHeadersWidth = 51;
            this.dgv_Order.RowTemplate.Height = 24;
            this.dgv_Order.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Order.Size = new System.Drawing.Size(862, 230);
            this.dgv_Order.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(454, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 47);
            this.button1.TabIndex = 46;
            this.button1.Text = "Xem tất cả";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // QLHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 443);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.dt_ngaymua);
            this.Controls.Add(this.tbx_ma);
            this.Controls.Add(this.tbx_ten);
            this.Controls.Add(this.btn_tim);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbx_yeucau);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "QLHoaDon";
            this.Text = "QLHoaDon";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.QLHoaDon_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.QLHoaDon_FormClosed);
            this.Load += new System.EventHandler(this.QLHoaDon_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Order)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.DateTimePicker dt_ngaymua;
        private System.Windows.Forms.TextBox tbx_ma;
        private System.Windows.Forms.TextBox tbx_ten;
        private System.Windows.Forms.Button btn_tim;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbx_yeucau;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv_Order;
        private System.Windows.Forms.Button button1;
    }
}