using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using Bai_1;
using System.Data.SqlClient;
using System.Data.Linq.Mapping;

namespace QlkhNamespace
{
    public partial class MainForm : Form
    {
        List<TextBox> nddTextBoxList;
        DBqlkhDataContext db = new DBqlkhDataContext();
        private List<TextBox> khTextBoxList;
        private List<TextBox> gdTextBoxList;

        public MainForm()
        {
            InitializeComponent();
            this.Text = "Quản lý khách hàng";
            try
            {
                loadKhachHang();
                loadNhanVien();
                loadNguoiDaiDien();
                loadGiaoDich();
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
            }
        }

        void loadGiaoDich()
        {
            dgvGiaoDich.DataSource = db.GiaoDich_selectall();
            gdTextBoxList = new List<TextBox>();
            gdTextBoxList.Add(gd_tb1);
            gdTextBoxList.Add(gd_tb2);
            gdTextBoxList.Add(gd_tb3);
            gdTextBoxList.Add(gd_tb4);
            gdTextBoxList.Add(gd_tb5);
            gdTextBoxList.Add(gd_tb6);
            gdTextBoxList.Add(gd_tb7);
            gdTextBoxList.Add(gd_tb8);
            gdTextBoxList.Add(gd_tb9);
            gdTextBoxList.Add(gd_tb10);
            bindingDataBy(typeof(GiaoDich), gdTextBoxList, dgvGiaoDich);
        }

        void loadNguoiDaiDien()
        {
            nddTextBoxList = new List<TextBox>();
            nddTextBoxList.Add(ndd_tb1);
            nddTextBoxList.Add(ndd_tb2);
            nddTextBoxList.Add(ndd_tb3);
        }

        void loadKhachHang()
        {
            dgvKhachHang.DataSource = db.KhachHang_selectall();
            khTextBoxList = new List<TextBox>();
            khTextBoxList.Add(kh_tb1);
            khTextBoxList.Add(kh_tb2);
            khTextBoxList.Add(kh_tb3);
            khTextBoxList.Add(kh_tb4);
            khTextBoxList.Add(kh_tb5);
            khTextBoxList.Add(kh_tb6);
            khTextBoxList.Add(kh_tb7);
            khTextBoxList.Add(kh_tb8);
            khTextBoxList.Add(kh_tb9);
            khTextBoxList.Add(kh_tb10);
            khTextBoxList.Add(kh_tb11);
            khTextBoxList.Add(kh_tb12);

            bindingDataBy(typeof(KhachHang), khTextBoxList, dgvKhachHang);
        }

        void bindingDataBy(Type tableName, List<TextBox> tbList, DataGridView dgv)
        {
            var columnNames = db.Mapping.MappingSource
                      .GetModel(typeof(DBqlkhDataContext))
                      .GetMetaType(tableName)
                      .DataMembers;
            for (int i = 0; i < tbList.Count; i++)
            {
                tbList[i].DataBindings.Clear();
                tbList[i].DataBindings.Add("text", dgv.DataSource, columnNames[i].Name);
            }
        }
        void loadNhanVien()
        {
            dgvNhanVien.DataSource = db.NhanVien_selectall();

        }

        //private void btnThem_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        KhachHang kh = new KhachHang()
        //        {
        //            TenKH = tbTenKH.Text,
        //            LoaiKH = tbLoaiKH.Text,
        //            LinhVucKinhDoanh = tbLinhVuc.Text,
        //            NguoiDaiDien = tbNguoiDaiDien.Text,
        //            DiaChi = tbDiaChi.Text,
        //            SDT = Int32.Parse(tbSdt.Text),
        //            Fax = Int32.Parse(tbFax.Text),
        //            Website = tbWebsite.Text,
        //            SoTaiKhoan = tbSoTaiKhoan.Text,
        //            SoDuKhaDung = Int32.Parse(tbNguoiDaiDien.Text),
        //            LoaiTien = tbLoaiTien.Text,
        //            MaSoThue = tbMaSoThue.Text
        //        };
        //        db.KhachHangs.Add(kh);
        //        db.SaveChanges();       // Lưu xuống CSDL
        //        MessageBox.Show("Thêm thành công");
        //        ListViewItem itemNew = new ListViewItem(kh.MaKH.ToString());
        //        itemNew.SubItems.Add(kh.TenKH);
        //        itemNew.SubItems.Add(kh.LoaiKH);
        //        itemNew.SubItems.Add(kh.LinhVucKinhDoanh);
        //        itemNew.SubItems.Add(kh.NguoiDaiDien);
        //        itemNew.SubItems.Add(kh.DiaChi);
        //        itemNew.SubItems.Add(kh.SDT.ToString());
        //        itemNew.SubItems.Add(kh.Fax.ToString());
        //        itemNew.SubItems.Add(kh.Website);
        //        itemNew.SubItems.Add(kh.SoTaiKhoan);
        //        itemNew.SubItems.Add(kh.SoDuKhaDung.ToString());
        //        itemNew.SubItems.Add(kh.LoaiTien);
        //        itemNew.SubItems.Add(kh.MaSoThue);
        //        lvDsKhachHang.Items.Add(itemNew);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Thêm thất bại. Chi tiết lỗi: " + ex.Message);
        //    }
        //}

        //private void btnXoa_Click(object sender, EventArgs e)
        //{

        //    //KhachHang KhachHang = db.KhachHangs.Find(int.Parse(lblMaKhachHang.Text));
        //    int MaKhachHang = int.Parse(lbMaKH.Text);
        //    KhachHang KhachHang = db.KhachHangs.SingleOrDefault(m => m.MaKH == MaKhachHang);
        //    if (KhachHang != null)
        //    {
        //        db.KhachHangs.Remove(KhachHang);
        //        db.SaveChanges();
        //        MessageBox.Show("Xóa thành công");
        //        Form1_Load(sender, e);
        //    }
        //    else
        //    {
        //        MessageBox.Show("Nhân viên không còn tồn tại!");
        //    }
        //}

        //private void btnSua_Click(object sender, EventArgs e)
        //{
        //    int MaKhachHang = int.Parse(lbMaKH.Text);
        //    KhachHang khachHang = db.KhachHangs.SingleOrDefault(m => m.MaKH == MaKhachHang);
        //    khachHang.TenKH = tbTenKH.Text;
        //    khachHang.LoaiKH = tbLoaiKH.Text;
        //    khachHang.LinhVucKinhDoanh = tbLinhVuc.Text;
        //    khachHang.NguoiDaiDien = tbNguoiDaiDien.Text;
        //    khachHang.DiaChi = tbDiaChi.Text;
        //    khachHang.SDT = Int32.Parse(tbSdt.Text);
        //    khachHang.Fax = Int32.Parse(tbFax.Text);
        //    khachHang.Website = tbWebsite.Text;
        //    khachHang.SoTaiKhoan = tbSoTaiKhoan.Text;
        //    khachHang.SoDuKhaDung = Int32.Parse(tbNguoiDaiDien.Text);
        //    khachHang.LoaiTien = tbLoaiTien.Text;
        //    khachHang.MaSoThue = tbMaSoThue.Text;
        //    db.SaveChanges();
        //    MessageBox.Show("Sửa thành công");
        //    Form1_Load(sender, e);
        //}

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        //private void txtHotentim_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    string tukhoa = txtHotentim.Text;
        //    if (tukhoa == "")
        //    {
        //        HienThiDuLieuKH(db.KhachHangs.ToList());
        //        return;
        //    }
        //    List<KhachHang> ketquatim = db.KhachHangs.Where(m => m.TenKH.ToUpper().Contains(tukhoa.ToUpper())).ToList();
        //    HienThiDuLieuKH(ketquatim);
        //}

        private void lvDsKhachHang_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //if (lvDsKhachHang.SelectedItems.Count > 0)
            //{
            //    ListViewItem itemselected = lvDsKhachHang.SelectedItems[0];
            //    lbMaKH.Text = itemselected.SubItems[0].Text;
            //    tbTenKH.Text = itemselected.SubItems[1].Text;
            //    tbLoaiKH.Text = itemselected.SubItems[2].Text;
            //    tbLinhVuc.Text = itemselected.SubItems[3].Text;
            //    tbNguoiDaiDien.Text = itemselected.SubItems[4].Text;
            //    tbDiaChi.Text = itemselected.SubItems[5].Text;
            //    tbSdt.Text = itemselected.SubItems[6].Text;
            //    tbFax.Text = itemselected.SubItems[7].Text;
            //    tbWebsite.Text = itemselected.SubItems[8].Text;
            //    tbSoTaiKhoan.Text = itemselected.SubItems[9].Text;
            //    tbSoDuKhaDung.Text = itemselected.SubItems[10].Text;
            //    tbLoaiTien.Text = itemselected.SubItems[11].Text;
            //    tbMaSoThue.Text = itemselected.SubItems[12].Text;
            //    currentKH = new KhachHang(itemselected);
            //}
        }

        private void lvdsgd_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (lvDSGD.SelectedItems.Count > 0)
            //{
            //    ListViewItem itemselected = lvDSGD.SelectedItems[0];
            //    lbMaGD.Text = itemselected.SubItems[0].Text;
            //    tbMaKH.Text = itemselected.SubItems[1].Text;
            //    tbMaNV.Text = itemselected.SubItems[2].Text;
            //    tbNoiDung.Text = itemselected.SubItems[3].Text;
            //    tbNgayGD.Text = itemselected.SubItems[4].Text;
            //    tbPhatSinhNo.Text = itemselected.SubItems[5].Text;
            //    tbPhatSinhCo.Text = itemselected.SubItems[6].Text;
            //    tbTenNguoiNhan.Text = itemselected.SubItems[7].Text;
            //    //currentKH = new KhachHang(itemselected);
            //}
        }

        private void txtHotentim_TextChanged(object sender, EventArgs e)
        {

        }

        private void btInsaoke_Click(object sender, EventArgs e)
        {
            //if (currentKH != null)
            //{

            //} else {
            //    MessageBox.Show("Bạn chưa chọn khách hàng!");
            //}
        }

    }

}

//public KhachHang(ListViewItem itemselected)
//{
//    MaKH = Int32.Parse(itemselected.SubItems[0].Text);
//    TenKH = itemselected.SubItems[1].Text;
//    SoTaiKhoan = itemselected.SubItems[2].Text;
//    SoDuKhaDung = Int32.Parse(itemselected.SubItems[3].Text);
//    LoaiTien = itemselected.SubItems[4].Text;
//    SDT = Int32.Parse(itemselected.SubItems[5].Text);
//    Fax = Int32.Parse(itemselected.SubItems[6].Text);
//    CMND = itemselected.SubItems[7].Text;
//    DiaChi = itemselected.SubItems[8].Text;
//    SoCIF = Int32.Parse(itemselected.SubItems[9].Text);
//}