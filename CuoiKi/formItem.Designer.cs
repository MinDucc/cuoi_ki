namespace CuoiKi
{
    partial class formItem
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
            this.btn_hangton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dt_hsd = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_hsd = new System.Windows.Forms.Button();
            this.tbx_hangton = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.bt_them = new System.Windows.Forms.Button();
            this.tbx_giaban = new System.Windows.Forms.TextBox();
            this.tbx_giamua = new System.Windows.Forms.TextBox();
            this.tbx_tenhang = new System.Windows.Forms.TextBox();
            this.tbx_mahang = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv_show = new System.Windows.Forms.DataGridView();
            this.btn_all = new System.Windows.Forms.Button();
            this.ckb_them = new System.Windows.Forms.CheckBox();
            this.ckb_sua = new System.Windows.Forms.CheckBox();
            this.ckb_xoa = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_show)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_hangton
            // 
            this.btn_hangton.Location = new System.Drawing.Point(654, 15);
            this.btn_hangton.Margin = new System.Windows.Forms.Padding(4);
            this.btn_hangton.Name = "btn_hangton";
            this.btn_hangton.Size = new System.Drawing.Size(156, 57);
            this.btn_hangton.TabIndex = 59;
            this.btn_hangton.Text = "Số lượng hàng tồn còn ít";
            this.btn_hangton.UseVisualStyleBackColor = true;
            this.btn_hangton.Click += new System.EventHandler(this.btn_hangton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(25, 245);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 20);
            this.label1.TabIndex = 41;
            this.label1.Text = "Thông tin hàng hóa";
            // 
            // dt_hsd
            // 
            this.dt_hsd.Location = new System.Drawing.Point(149, 192);
            this.dt_hsd.Margin = new System.Windows.Forms.Padding(4);
            this.dt_hsd.Name = "dt_hsd";
            this.dt_hsd.Size = new System.Drawing.Size(279, 22);
            this.dt_hsd.TabIndex = 58;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 204);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 17);
            this.label7.TabIndex = 57;
            this.label7.Text = "HSD:";
            // 
            // btn_hsd
            // 
            this.btn_hsd.Location = new System.Drawing.Point(654, 154);
            this.btn_hsd.Margin = new System.Windows.Forms.Padding(4);
            this.btn_hsd.Name = "btn_hsd";
            this.btn_hsd.Size = new System.Drawing.Size(156, 58);
            this.btn_hsd.TabIndex = 56;
            this.btn_hsd.Text = "Hàng hết HSD";
            this.btn_hsd.UseVisualStyleBackColor = true;
            this.btn_hsd.Click += new System.EventHandler(this.btn_hsd_Click);
            // 
            // tbx_hangton
            // 
            this.tbx_hangton.Location = new System.Drawing.Point(149, 156);
            this.tbx_hangton.Margin = new System.Windows.Forms.Padding(4);
            this.tbx_hangton.Name = "tbx_hangton";
            this.tbx_hangton.Size = new System.Drawing.Size(279, 22);
            this.tbx_hangton.TabIndex = 55;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 132);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 17);
            this.label6.TabIndex = 54;
            this.label6.Text = "Giá bán ra";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 165);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 17);
            this.label5.TabIndex = 53;
            this.label5.Text = "Số lượng hàng tồn";
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(654, 220);
            this.btn_back.Margin = new System.Windows.Forms.Padding(4);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(156, 44);
            this.btn_back.TabIndex = 52;
            this.btn_back.Text = "Trở về";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(453, 85);
            this.btn_sua.Margin = new System.Windows.Forms.Padding(4);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(156, 60);
            this.btn_sua.TabIndex = 51;
            this.btn_sua.Text = "Sửa thông tin";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(453, 156);
            this.btn_xoa.Margin = new System.Windows.Forms.Padding(4);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(156, 61);
            this.btn_xoa.TabIndex = 50;
            this.btn_xoa.Text = "Xóa mặt hàng";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // bt_them
            // 
            this.bt_them.Location = new System.Drawing.Point(453, 15);
            this.bt_them.Margin = new System.Windows.Forms.Padding(4);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(156, 60);
            this.bt_them.TabIndex = 49;
            this.bt_them.Text = "Thêm mặt hàng ";
            this.bt_them.UseVisualStyleBackColor = true;
            this.bt_them.Click += new System.EventHandler(this.bt_them_Click);
            // 
            // tbx_giaban
            // 
            this.tbx_giaban.Location = new System.Drawing.Point(149, 123);
            this.tbx_giaban.Margin = new System.Windows.Forms.Padding(4);
            this.tbx_giaban.Name = "tbx_giaban";
            this.tbx_giaban.Size = new System.Drawing.Size(279, 22);
            this.tbx_giaban.TabIndex = 48;
            // 
            // tbx_giamua
            // 
            this.tbx_giamua.Location = new System.Drawing.Point(149, 82);
            this.tbx_giamua.Margin = new System.Windows.Forms.Padding(4);
            this.tbx_giamua.Name = "tbx_giamua";
            this.tbx_giamua.Size = new System.Drawing.Size(279, 22);
            this.tbx_giamua.TabIndex = 47;
            // 
            // tbx_tenhang
            // 
            this.tbx_tenhang.Location = new System.Drawing.Point(149, 50);
            this.tbx_tenhang.Margin = new System.Windows.Forms.Padding(4);
            this.tbx_tenhang.Name = "tbx_tenhang";
            this.tbx_tenhang.Size = new System.Drawing.Size(279, 22);
            this.tbx_tenhang.TabIndex = 46;
            // 
            // tbx_mahang
            // 
            this.tbx_mahang.Enabled = false;
            this.tbx_mahang.Location = new System.Drawing.Point(149, 6);
            this.tbx_mahang.Margin = new System.Windows.Forms.Padding(4);
            this.tbx_mahang.Name = "tbx_mahang";
            this.tbx_mahang.Size = new System.Drawing.Size(279, 22);
            this.tbx_mahang.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 17);
            this.label2.TabIndex = 44;
            this.label2.Text = "Tên hàng hóa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 91);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 17);
            this.label4.TabIndex = 43;
            this.label4.Text = "Giá mua vào";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 15);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 17);
            this.label3.TabIndex = 42;
            this.label3.Text = "Mã hàng hóa";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dgv_show);
            this.panel1.Location = new System.Drawing.Point(13, 265);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(937, 313);
            this.panel1.TabIndex = 40;
            // 
            // dgv_show
            // 
            this.dgv_show.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_show.Location = new System.Drawing.Point(5, 5);
            this.dgv_show.Name = "dgv_show";
            this.dgv_show.RowHeadersWidth = 51;
            this.dgv_show.RowTemplate.Height = 24;
            this.dgv_show.Size = new System.Drawing.Size(932, 308);
            this.dgv_show.TabIndex = 0;
            this.dgv_show.SelectionChanged += new System.EventHandler(this.dgv_show_SelectionChanged);
            // 
            // btn_all
            // 
            this.btn_all.Location = new System.Drawing.Point(654, 82);
            this.btn_all.Name = "btn_all";
            this.btn_all.Size = new System.Drawing.Size(156, 57);
            this.btn_all.TabIndex = 61;
            this.btn_all.Text = "Xem tất cả";
            this.btn_all.UseVisualStyleBackColor = true;
            this.btn_all.Click += new System.EventHandler(this.btn_all_Click);
            // 
            // ckb_them
            // 
            this.ckb_them.AutoSize = true;
            this.ckb_them.Location = new System.Drawing.Point(616, 36);
            this.ckb_them.Name = "ckb_them";
            this.ckb_them.Size = new System.Drawing.Size(18, 17);
            this.ckb_them.TabIndex = 62;
            this.ckb_them.UseVisualStyleBackColor = true;
            this.ckb_them.CheckedChanged += new System.EventHandler(this.ckb_them_CheckedChanged);
            // 
            // ckb_sua
            // 
            this.ckb_sua.AutoSize = true;
            this.ckb_sua.Location = new System.Drawing.Point(616, 108);
            this.ckb_sua.Name = "ckb_sua";
            this.ckb_sua.Size = new System.Drawing.Size(18, 17);
            this.ckb_sua.TabIndex = 63;
            this.ckb_sua.UseVisualStyleBackColor = true;
            this.ckb_sua.CheckedChanged += new System.EventHandler(this.ckb_sua_CheckedChanged);
            // 
            // ckb_xoa
            // 
            this.ckb_xoa.AutoSize = true;
            this.ckb_xoa.Location = new System.Drawing.Point(616, 179);
            this.ckb_xoa.Name = "ckb_xoa";
            this.ckb_xoa.Size = new System.Drawing.Size(18, 17);
            this.ckb_xoa.TabIndex = 64;
            this.ckb_xoa.UseVisualStyleBackColor = true;
            this.ckb_xoa.CheckedChanged += new System.EventHandler(this.ckb_xoa_CheckedChanged);
            // 
            // HangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 591);
            this.Controls.Add(this.ckb_xoa);
            this.Controls.Add(this.ckb_sua);
            this.Controls.Add(this.ckb_them);
            this.Controls.Add(this.btn_all);
            this.Controls.Add(this.btn_hangton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dt_hsd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_hsd);
            this.Controls.Add(this.tbx_hangton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.bt_them);
            this.Controls.Add(this.tbx_giaban);
            this.Controls.Add(this.tbx_giamua);
            this.Controls.Add(this.tbx_tenhang);
            this.Controls.Add(this.tbx_mahang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Name = "HangHoa";
            this.Text = "HangHoa";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HangHoa_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.HangHoa_FormClosed);
            this.Load += new System.EventHandler(this.HangHoa_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_show)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_hangton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dt_hsd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_hsd;
        private System.Windows.Forms.TextBox tbx_hangton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button bt_them;
        private System.Windows.Forms.TextBox tbx_giaban;
        private System.Windows.Forms.TextBox tbx_giamua;
        private System.Windows.Forms.TextBox tbx_tenhang;
        private System.Windows.Forms.TextBox tbx_mahang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv_show;
        private System.Windows.Forms.Button btn_all;
        private System.Windows.Forms.CheckBox ckb_them;
        private System.Windows.Forms.CheckBox ckb_sua;
        private System.Windows.Forms.CheckBox ckb_xoa;
    }
}