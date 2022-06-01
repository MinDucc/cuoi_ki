namespace CuoiKi
{
    partial class formAccount
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
            this.cbx_cv = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.tbx_mk = new System.Windows.Forms.TextBox();
            this.tbx_tk = new System.Windows.Forms.TextBox();
            this.tbx_ten = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv_account = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_account)).BeginInit();
            this.SuspendLayout();
            // 
            // cbx_cv
            // 
            this.cbx_cv.FormattingEnabled = true;
            this.cbx_cv.Items.AddRange(new object[] {
            "Admin",
            "Employee"});
            this.cbx_cv.Location = new System.Drawing.Point(174, 144);
            this.cbx_cv.Margin = new System.Windows.Forms.Padding(4);
            this.cbx_cv.Name = "cbx_cv";
            this.cbx_cv.Size = new System.Drawing.Size(279, 24);
            this.cbx_cv.TabIndex = 62;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 134);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 17);
            this.label5.TabIndex = 61;
            this.label5.Text = "Chức vụ";
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(491, 183);
            this.btn_back.Margin = new System.Windows.Forms.Padding(4);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(172, 46);
            this.btn_back.TabIndex = 60;
            this.btn_back.Text = "Trở về";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(491, 127);
            this.btn_sua.Margin = new System.Windows.Forms.Padding(4);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(172, 56);
            this.btn_sua.TabIndex = 59;
            this.btn_sua.Text = "Sửa Tài Khoản";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(491, 69);
            this.btn_xoa.Margin = new System.Windows.Forms.Padding(4);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(172, 53);
            this.btn_xoa.TabIndex = 58;
            this.btn_xoa.Text = "Xóa Tài Khoản Admin";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(491, 5);
            this.btn_them.Margin = new System.Windows.Forms.Padding(4);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(172, 56);
            this.btn_them.TabIndex = 57;
            this.btn_them.Text = "Thêm Tài Khoản Admin\r\n";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // tbx_mk
            // 
            this.tbx_mk.Location = new System.Drawing.Point(174, 93);
            this.tbx_mk.Margin = new System.Windows.Forms.Padding(4);
            this.tbx_mk.Multiline = true;
            this.tbx_mk.Name = "tbx_mk";
            this.tbx_mk.Size = new System.Drawing.Size(279, 29);
            this.tbx_mk.TabIndex = 56;
            // 
            // tbx_tk
            // 
            this.tbx_tk.Location = new System.Drawing.Point(174, 55);
            this.tbx_tk.Margin = new System.Windows.Forms.Padding(4);
            this.tbx_tk.Multiline = true;
            this.tbx_tk.Name = "tbx_tk";
            this.tbx_tk.Size = new System.Drawing.Size(279, 29);
            this.tbx_tk.TabIndex = 55;
            // 
            // tbx_ten
            // 
            this.tbx_ten.Location = new System.Drawing.Point(174, 18);
            this.tbx_ten.Margin = new System.Windows.Forms.Padding(4);
            this.tbx_ten.Multiline = true;
            this.tbx_ten.Name = "tbx_ten";
            this.tbx_ten.Size = new System.Drawing.Size(279, 29);
            this.tbx_ten.TabIndex = 54;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 53;
            this.label2.Text = "Tài khoản";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 95);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 17);
            this.label4.TabIndex = 52;
            this.label4.Text = "Mật khẩu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 22);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 17);
            this.label3.TabIndex = 51;
            this.label3.Text = "Tên ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(26, 183);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 20);
            this.label1.TabIndex = 50;
            this.label1.Text = "Danh sách tài khoản";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dgv_account);
            this.panel1.Location = new System.Drawing.Point(13, 229);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(650, 479);
            this.panel1.TabIndex = 49;
            // 
            // dgv_account
            // 
            this.dgv_account.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_account.Location = new System.Drawing.Point(3, 4);
            this.dgv_account.Name = "dgv_account";
            this.dgv_account.RowHeadersWidth = 51;
            this.dgv_account.RowTemplate.Height = 24;
            this.dgv_account.Size = new System.Drawing.Size(646, 474);
            this.dgv_account.TabIndex = 0;
            this.dgv_account.SelectionChanged += new System.EventHandler(this.dgv_account_SelectionChanged);
            // 
            // TaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 713);
            this.Controls.Add(this.cbx_cv);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.tbx_mk);
            this.Controls.Add(this.tbx_tk);
            this.Controls.Add(this.tbx_ten);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "TaiKhoan";
            this.Text = "TaiKhoan";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TaiKhoan_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Account_FormClosed);
            this.Load += new System.EventHandler(this.TaiKhoan_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_account)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbx_cv;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.TextBox tbx_mk;
        private System.Windows.Forms.TextBox tbx_tk;
        private System.Windows.Forms.TextBox tbx_ten;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv_account;
    }
}