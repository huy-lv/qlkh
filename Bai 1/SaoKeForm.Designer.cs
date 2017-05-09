namespace QlkhNamespace
{
    partial class SaoKeForm
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
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "GD443262",
            "KH435457",
            "NV456534",
            "Thu phi dich vu SMS Banking",
            "12-4-2017 12:00:00",
            "3300",
            "0",
            ""}, -1);
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new string[] {
            "GD435656",
            "KH346586",
            "NV657423",
            "Chuyen khoan di",
            "12-4-2017 23:44:00",
            "230000",
            "0",
            "Nguyễn Văn Nam"}, -1);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbTenKH = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbSoTaiKhoan = new System.Windows.Forms.Label();
            this.lbType = new System.Windows.Forms.Label();
            this.lvDsGiaoDich = new System.Windows.Forms.ListView();
            this.colMaGD = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMaKH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNoiDung = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNgayGD = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPhatSinhNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPhatSinhCo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSoThamChieu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(178, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông báo sao kê tài khoản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Khách hàng";
            // 
            // lbTenKH
            // 
            this.lbTenKH.AutoSize = true;
            this.lbTenKH.Location = new System.Drawing.Point(119, 95);
            this.lbTenKH.Name = "lbTenKH";
            this.lbTenKH.Size = new System.Drawing.Size(99, 13);
            this.lbTenKH.TabIndex = 2;
            this.lbTenKH.Text = "Cty TNHH Sao Việt";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Số tài khoản:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Loại tiền:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Sao kê từ ngày:";
            // 
            // lbSoTaiKhoan
            // 
            this.lbSoTaiKhoan.AutoSize = true;
            this.lbSoTaiKhoan.Location = new System.Drawing.Point(119, 124);
            this.lbSoTaiKhoan.Name = "lbSoTaiKhoan";
            this.lbSoTaiKhoan.Size = new System.Drawing.Size(61, 13);
            this.lbSoTaiKhoan.TabIndex = 6;
            this.lbSoTaiKhoan.Text = "525436452";
            // 
            // lbType
            // 
            this.lbType.AutoSize = true;
            this.lbType.Location = new System.Drawing.Point(119, 150);
            this.lbType.Name = "lbType";
            this.lbType.Size = new System.Drawing.Size(30, 13);
            this.lbType.TabIndex = 8;
            this.lbType.Text = "VND";
            // 
            // lvDsGiaoDich
            // 
            this.lvDsGiaoDich.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMaGD,
            this.colMaKH,
            this.columnHeader1,
            this.colNoiDung,
            this.colNgayGD,
            this.colPhatSinhNo,
            this.colPhatSinhCo,
            this.colSoThamChieu});
            this.lvDsGiaoDich.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem3,
            listViewItem4});
            this.lvDsGiaoDich.Location = new System.Drawing.Point(15, 215);
            this.lvDsGiaoDich.Name = "lvDsGiaoDich";
            this.lvDsGiaoDich.Size = new System.Drawing.Size(688, 128);
            this.lvDsGiaoDich.TabIndex = 10;
            this.lvDsGiaoDich.UseCompatibleStateImageBehavior = false;
            this.lvDsGiaoDich.View = System.Windows.Forms.View.Details;
            this.lvDsGiaoDich.SelectedIndexChanged += new System.EventHandler(this.lvDsGiaoDich_SelectedIndexChanged);
            // 
            // colMaGD
            // 
            this.colMaGD.Text = "Mã GD";
            this.colMaGD.Width = 47;
            // 
            // colMaKH
            // 
            this.colMaKH.Text = "Mã KH";
            this.colMaKH.Width = 49;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã NV";
            // 
            // colNoiDung
            // 
            this.colNoiDung.Text = "Nội dung";
            this.colNoiDung.Width = 154;
            // 
            // colNgayGD
            // 
            this.colNgayGD.Text = "Ngày Giao Dịch";
            this.colNgayGD.Width = 109;
            // 
            // colPhatSinhNo
            // 
            this.colPhatSinhNo.Text = "Phát sinh nợ";
            this.colPhatSinhNo.Width = 78;
            // 
            // colPhatSinhCo
            // 
            this.colPhatSinhCo.Text = "Phát sinh có";
            this.colPhatSinhCo.Width = 72;
            // 
            // colSoThamChieu
            // 
            this.colSoThamChieu.Text = "Tên người nhận";
            this.colSoThamChieu.Width = 100;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(122, 171);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 11;
            this.dateTimePicker1.Value = new System.DateTime(2017, 4, 12, 0, 0, 0, 0);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(410, 171);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 12;
            this.dateTimePicker2.Value = new System.DateTime(2017, 4, 19, 0, 0, 0, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(341, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "đến ngày";
            // 
            // SaoKeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 355);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lvDsGiaoDich);
            this.Controls.Add(this.lbType);
            this.Controls.Add(this.lbSoTaiKhoan);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbTenKH);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SaoKeForm";
            this.Text = "SaoKeForm";
            this.Load += new System.EventHandler(this.SaoKeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbTenKH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbSoTaiKhoan;
        private System.Windows.Forms.Label lbType;
        private System.Windows.Forms.ListView lvDsGiaoDich;
        private System.Windows.Forms.ColumnHeader colNgayGD;
        private System.Windows.Forms.ColumnHeader colSoThamChieu;
        private System.Windows.Forms.ColumnHeader colPhatSinhNo;
        private System.Windows.Forms.ColumnHeader colPhatSinhCo;
        private System.Windows.Forms.ColumnHeader colNoiDung;
        private System.Windows.Forms.ColumnHeader colMaGD;
        private System.Windows.Forms.ColumnHeader colMaKH;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label6;
    }
}