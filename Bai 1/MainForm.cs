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
using System.Data.SqlClient;
using System.Data.Linq.Mapping;
using System.Data.Linq;

namespace QlkhNamespace
{
    public partial class MainForm : Form
    {
        DBqlkhDataContext db = new DBqlkhDataContext();
        private List<Control> khTextBoxList;
        List<Control> nddTextBoxList;
        private List<Control> gdTextBoxList;
        private List<Control> dvTbList;
        private List<Control> nvTbList;
        private List<Control> hdTbList;
        private List<Control> dgTbList;
        private string selectedKH;
        private string selectedNDD;
        string selectedDV;
        string selectedGD;
        private string selectedNV;
        string selectedDG;
        string selectedHD;
        DateTime currentDateValue;

        public MainForm()
        {
            InitializeComponent();
            this.Text = "Quản lý khách hàng";
            khTextBoxList = new List<Control>();
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
            khTextBoxList.Add(kh_tb13);
            nddTextBoxList = new List<Control>();
            nddTextBoxList.Add(ndd_tb1);
            nddTextBoxList.Add(ndd_tb2);
            nddTextBoxList.Add(ndd_tb3);
            nddTextBoxList.Add(ndd_tb4);
            nddTextBoxList.Add(ndd_tb5);
            nddTextBoxList.Add(ndd_tb6);
            nddTextBoxList.Add(ndd_tb7);
            nddTextBoxList.Add(ndd_tb8);
            nddTextBoxList.Add(ndd_tb9);
            gdTextBoxList = new List<Control>();
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
            dvTbList = new List<Control>();
            dvTbList.Add(dv_tb1);
            dvTbList.Add(dv_tb2);
            dvTbList.Add(dv_tb3);
            dvTbList.Add(dv_tb4);
            dvTbList.Add(dv_tb5);
            dvTbList.Add(dv_tb6);
            dvTbList.Add(dv_tb7);
            nvTbList = new List<Control>();
            nvTbList.Add(nv_tb1);
            nvTbList.Add(nv_tb2);
            nvTbList.Add(nv_tb3);
            nvTbList.Add(nv_tb4);
            nvTbList.Add(nv_tb5);
            nvTbList.Add(nv_tb6);
            dgTbList = new List<Control>();
            dgTbList.Add(dgtb1);
            dgTbList.Add(dgtb2);
            dgTbList.Add(dgtb3);
            dgTbList.Add(dgtb4);
            dgTbList.Add(dgtb5);
            dgTbList.Add(dgtb6);
            hdTbList = new List<Control>();
            hdTbList.Add(hd_tb1);
            hdTbList.Add(hd_tb2);
            hdTbList.Add(hd_tb3);
            hdTbList.Add(hd_tb4);
            hdTbList.Add(hd_tb5);
            hdTbList.Add(hd_tb6);
            hdTbList.Add(hd_tb7);
            try
            {
                loadKhachHang();
                loadNhanVien();
                loadNguoiDaiDien();
                loadGiaoDich();
                loadDichVu();
                loadHopDong();
                loadDanhGia();
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
            }

            printDanhSachKhachHang();
            printDanhGia();
        }

        void loadKhachHang()
        {
            dgvKhachHang.DataSource = db.KhachHangs;

            bindingDataBy(typeof(KhachHang), khTextBoxList, dgvKhachHang, new int[] { 3 });
            //var columnNames = db.Mapping.MappingSource
            //          .GetModel(typeof(DBqlkhDataContext))
            //          .GetMetaType(typeof(KhachHang))
            //          .DataMembers;
            //kh_tb4.DataBindings.Add("value", dgvKhachHang.DataSource, columnNames[3].Name);
            selectedKH = dgvKhachHang.RowCount > 0 ? dgvKhachHang.Rows[0].Cells[0].Value.ToString() : null;
        }
        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvKhachHang.CurrentCell.RowIndex;
            //Console.WriteLine(" selectt " + dgvKhachHang.Rows[i].Cells[0].Value.ToString());
            selectedKH = dgvKhachHang.Rows[i].Cells[0].Value.ToString();
        }
        private void button29_Click(object sender, EventArgs e)
        {
            if (selectedKH != null)
            {
                TransactionLog v = new TransactionLog(selectedKH);
                v.Show();
            }
            else
            {
                MessageBox.Show("Bạn chưa lựa chọn khách hàng!");
            }
        }
        private void kh_btXoa_Click(object sender, EventArgs e)
        {
            if (selectedKH != null)
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa khách hàng này không?", "Xóa", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    db.KhachHangDelete(selectedKH);
                    MessageBox.Show("Xóa thành công!");
                    db = new DBqlkhDataContext();
                    loadKhachHang();
                    //foreach(Control tb in khTextBoxList)
                    //{
                    //    tb.Text = "";
                    //}
                }
            }
            else
                MessageBox.Show("Bạn chưa chọn khách hàng!");
        }
        private void kh_btThem_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Control t in khTextBoxList)
                {
                    if (t.Text == "")
                    {
                        MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                        return;
                    }
                }
                var result = db.KhachHangInsert(kh_tb1.Text, kh_tb2.Text, kh_tb3.Text,
                                                DateTime.Parse(kh_tb4.Text), kh_tb5.Text, kh_tb6.Text,
                                                kh_tb7.Text, kh_tb8.Text, kh_tb9.Text,
                                                kh_tb10.Text, kh_tb11.Text, kh_tb12.Text, kh_tb13.Text);
                db = new DBqlkhDataContext();
                loadKhachHang();
                MessageBox.Show("Thêm thành công!");
            }
            catch (SqlException ee)
            {
                MessageBox.Show(ee.Message);
            }

        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            db.KhachHangUpdate(kh_tb1.Text, kh_tb2.Text, kh_tb3.Text, kh_tb4.Value,
                                kh_tb5.Text, kh_tb6.Text, kh_tb7.Text, kh_tb8.Text,
                                kh_tb9.Text, kh_tb10.Text, kh_tb11.Text, kh_tb12.Text, kh_tb13.Text);
            dgvKhachHang.Refresh();
            MessageBox.Show("Cập nhật dữ liệu thành công!");
        }
        private void kh_tbSearch_TextChanged(object sender, EventArgs e)
        {
            if (kh_tbSearch.Text != "Mã khách hàng")
            {
                string key = kh_tbSearch.Text;
                var re = db.KhachHangs.Where(m => m.MaKH.ToLower().Contains(key.ToLower()) || key == null).ToList();
                dgvKhachHang.DataSource = re;
                bindingDataBy(typeof(KhachHang), khTextBoxList, dgvKhachHang, new int[] { 3 });
                selectedKH = dgvKhachHang.RowCount > 0 ? dgvKhachHang.Rows[0].Cells[0].Value.ToString() : null;
                if (dgvKhachHang.RowCount == 0)
                {
                    foreach (Control k in khTextBoxList) k.Text = "";
                }

            }
        }
        private void kh_tbSearch_Enter(object sender, EventArgs e)
        {
            if (kh_tbSearch.Text == "Mã khách hàng")
            {
                kh_tbSearch.Text = "";
            }
        }
        private void kh_tbSearch_Leave(object sender, EventArgs e)
        {
            if (kh_tbSearch.Text == "")
            {
                kh_tbSearch.Text = "Mã khách hàng";
            }
        }
        private void kh_btThoat_Click(object sender, EventArgs e)
        {
            logout();
        }

        void loadNguoiDaiDien()
        {
            dgvNguoiDaiDien.DataSource = db.NguoiDaiDiens;
            bindingDataBy(typeof(NguoiDaiDien), nddTextBoxList, dgvNguoiDaiDien);
            selectedNDD = dgvNguoiDaiDien.RowCount > 0 ? dgvNguoiDaiDien.Rows[0].Cells[0].Value.ToString() : null;
        }
        private void ndd_btThem_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Control t in nddTextBoxList)
                {
                    if (t.Text == "")
                    {
                        MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                        return;
                    }
                }
                db.NDDInsert(ndd_tb1.Text, ndd_tb2.Text,
                    ndd_tb3.Text, ndd_tb4.Text,
                    DateTime.Parse(ndd_tb5.Text), ndd_tb6.Text,
                    ndd_tb7.Text, ndd_tb8.Text, ndd_tb9.Text);
                db = new DBqlkhDataContext();
                loadNguoiDaiDien();
                MessageBox.Show("Thêm thành công!");
            }
            catch (SqlException e1)
            {
                MessageBox.Show(e1.Message);
            }
        }
        private void ndd_Xoa_Click(object sender, EventArgs e)
        {
            db.NDDDelete(selectedNDD);
            db = new DBqlkhDataContext();
            loadNguoiDaiDien();
            MessageBox.Show("Xóa thành công!");
        }
        private void ndd_Sua_Click(object sender, EventArgs e)
        {
            db.NDDUpdate(ndd_tb1.Text, ndd_tb2.Text, ndd_tb3.Text,
                ndd_tb4.Text, DateTime.Parse(ndd_tb5.Text), ndd_tb6.Text,
                ndd_tb7.Text, ndd_tb8.Text, ndd_tb9.Text, ndd_tb1.Text);
            dgvNguoiDaiDien.Refresh();
            MessageBox.Show("Cập nhật dữ liệu thành công!");
        }
        private void ndd_tbSearch_TextChanged(object sender, EventArgs e)
        {
            if (kh_tbSearch.Text != "Tên người đại diện")
            {
                string key = ndd_tbSearch.Text;
                var re = db.NguoiDaiDiens.Where(m => m.TenNDD.ToLower().Contains(key.ToLower()) || key == null).ToList();
                dgvNguoiDaiDien.DataSource = re;
                bindingDataBy(typeof(NguoiDaiDien), nddTextBoxList, dgvNguoiDaiDien);
                selectedNDD = dgvNguoiDaiDien.RowCount > 0 ? dgvNguoiDaiDien.Rows[0].Cells[0].Value.ToString() : null;
                if (dgvNguoiDaiDien.RowCount == 0)
                {
                    foreach (Control k in nddTextBoxList) k.Text = "";
                }
            }
        }
        private void dgvNguoiDaiDien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvNguoiDaiDien.CurrentCell.RowIndex;
            selectedNDD = dgvNguoiDaiDien.Rows[i].Cells[0].Value.ToString();
        }
        private void button13_Click(object sender, EventArgs e)
        {
            logout();
        }
        private void ndd_tbSearch_Leave(object sender, EventArgs e)
        {
            if (kh_tbSearch.Text == "")
            {
                kh_tbSearch.Text = "Tên người đại diện";
            }
        }
        private void ndd_tbSearch_Enter(object sender, EventArgs e)
        {
            if (kh_tbSearch.Text == "Tên người đại diện")
            {
                kh_tbSearch.Text = "";
            }
        }

        void loadGiaoDich()
        {
            dgvGiaoDich.DataSource = db.GiaoDich_selectAll();
            gd_tb8.CustomFormat = "hh:mm:ss dd/MM/yyyy";
            bindingDataBy(typeof(GiaoDich), gdTextBoxList, dgvGiaoDich, new int[] { 7 });
            selectedGD = dgvGiaoDich.RowCount > 0 ? dgvGiaoDich.Rows[0].Cells[0].Value.ToString() : null;
        }
        private void gdThem_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Control t in gdTextBoxList)
                {
                    if (t.Text == "")
                    {
                        MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                        return;
                    }
                }
                db.GDInsert(gd_tb1.Text, gd_tb2.Text,
                    gd_tb3.Text, gd_tb4.Text,
                    gd_tb5.Text, gd_tb6.Text,
                    gd_tb7.Text, DateTime.Parse(gd_tb8.Text),
                    gd_tb9.Text, gd_tb10.Text);
                db = new DBqlkhDataContext();
                loadGiaoDich();
                MessageBox.Show("Thêm thành công!");
            }
            catch (SqlException e1)
            {
                MessageBox.Show(e1.Message);
            }
        }
        private void gdXoa_Click(object sender, EventArgs e)
        {
            db.GDDelete(selectedGD);
            db = new DBqlkhDataContext();
            loadGiaoDich();
            MessageBox.Show("Xóa thành công!");
        }
        private void gdSua_Click(object sender, EventArgs e)
        {
            db.GDUpdate(gd_tb1.Text, gd_tb2.Text, gd_tb3.Text,
                gd_tb4.Text, gd_tb5.Text, gd_tb6.Text,
                gd_tb7.Text, DateTime.Parse(gd_tb8.Text), gd_tb9.Text,
                gd_tb10.Text, gd_tb1.Text);
            dgvGiaoDich.Refresh();
            MessageBox.Show("Cập nhật dữ liệu thành công!");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            logout();
        }
        private void dgvGiaoDich_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedGD = getSelectedItem(dgvGiaoDich);
        }
        private void gdSearch_TextChanged(object sender, EventArgs e)
        {
            if (gdSearch.Text != "Tên người nhận")
            {
                string key = gdSearch.Text;
                var re = db.GiaoDiches.Where(m => m.TenNN.ToLower().Contains(key.ToLower()) || key == null).ToList();
                dgvGiaoDich.DataSource = re;
                bindingDataBy(typeof(GiaoDich), gdTextBoxList, dgvGiaoDich, new int[] { 7 });
                selectedGD = dgvGiaoDich.RowCount > 0 ? dgvGiaoDich.Rows[0].Cells[0].Value.ToString() : null;
                if (dgvGiaoDich.RowCount == 0)
                {
                    foreach (Control k in gdTextBoxList) k.Text = "";
                }
            }
        }
        private void gdSearch_Leave(object sender, EventArgs e)
        {
            if (gdSearch.Text == "")
            {
                gdSearch.Text = "Tên người nhận";
            }
        }
        private void gdSearch_Enter(object sender, EventArgs e)
        {
            if (gdSearch.Text == "Tên người nhận")
            {
                gdSearch.Text = "";
            }
        }

        void loadDichVu()
        {
            dgvDichVu.DataSource = db.DichVu_selectAll();
            bindingDataBy(typeof(DichVu), dvTbList, dgvDichVu);
            selectedDV = dgvDichVu.RowCount > 0 ? dgvDichVu.Rows[0].Cells[0].Value.ToString() : null;
        }
        private void dvThem_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Control t in dvTbList)
                {
                    if (t.Text == "")
                    {
                        MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                        return;
                    }
                }
                db.DVInsert(dv_tb1.Text, dv_tb2.Text,
                    dv_tb3.Text, dv_tb4.Text,
                    dv_tb5.Text, dv_tb6.Text,
                    dv_tb7.Text);
                db = new DBqlkhDataContext();
                loadDichVu();
                MessageBox.Show("Thêm thành công!");
            }
            catch (SqlException e1)
            {
                MessageBox.Show(e1.Message);
            }
        }
        private void dvXoa_Click(object sender, EventArgs e)
        {
            db.DVDelete(selectedDV);
            db = new DBqlkhDataContext();
            loadDichVu();
            MessageBox.Show("Xóa thành công!");
        }
        private void dvSua_Click(object sender, EventArgs e)
        {
            db.DVUpdate(dv_tb1.Text, dv_tb2.Text, dv_tb3.Text,
                dv_tb4.Text, dv_tb5.Text, dv_tb6.Text,
                dv_tb7.Text, dv_tb1.Text);
            dgvDichVu.Refresh();
            MessageBox.Show("Cập nhật dữ liệu thành công!");
        }
        private void dvSearch_TextChanged(object sender, EventArgs e)
        {
            if (dvSearch.Text != "Tên dịch vụ")
            {
                string key = dvSearch.Text;
                dgvDichVu.DataSource = db.DichVus.Where(m => m.TenDV.ToLower().Contains(key.ToLower()) || key == null).ToList();
                bindingDataBy(typeof(DichVu), dvTbList, dgvDichVu);
                selectedDV = dgvDichVu.RowCount > 0 ? dgvDichVu.Rows[0].Cells[0].Value.ToString() : null;
                if (dgvDichVu.RowCount == 0)
                {
                    foreach (Control k in dvTbList) k.Text = "";
                }
            }
        }
        private void dvThoat_Click(object sender, EventArgs e)
        {
            logout();
        }
        private void dgvDichVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedDV = dgvDichVu.Rows[dgvDichVu.CurrentCell.RowIndex].Cells[0].Value.ToString();
        }
        private void dvSearch_Leave(object sender, EventArgs e)
        {
            if (gdSearch.Text == "")
            {
                gdSearch.Text = "Tên dịch vụ";
            }
        }
        private void dvSearch_Enter(object sender, EventArgs e)
        {
            if (gdSearch.Text == "Tên dịch vụ")
            {
                gdSearch.Text = "";
            }
        }


        void loadNhanVien()
        {
            dgvNhanVien.DataSource = db.NhanVien_selectall();
            bindingDataBy(typeof(NhanVien), nvTbList, dgvNhanVien);
            selectedNV = dgvNhanVien.RowCount > 0 ? dgvNhanVien.Rows[0].Cells[0].Value.ToString() : null;
        }
        private void nvThem_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Control t in nvTbList)
                {
                    if (t.Text == "")
                    {
                        MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                        return;
                    }
                }
                db.NVInsert(nv_tb1.Text, nv_tb2.Text,
                    nv_tb3.Text, nv_tb4.Text,
                    nv_tb5.Text, nv_tb6.Text);
                db = new DBqlkhDataContext();
                loadNhanVien();
                MessageBox.Show("Thêm thành công!");
            }
            catch (SqlException e1)
            {
                MessageBox.Show(e1.Message);
            }
        }
        private void nvXoa_Click(object sender, EventArgs e)
        {
            db.NVDelete(selectedNV);
            db = new DBqlkhDataContext();
            loadNhanVien();
            MessageBox.Show("Xóa thành công!");
        }
        private void nvSua_Click(object sender, EventArgs e)
        {
            db.NVUpdate(nv_tb1.Text, nv_tb2.Text, nv_tb3.Text,
               nv_tb4.Text, nv_tb5.Text, nv_tb6.Text, nv_tb1.Text);
            dgvNhanVien.Refresh();
            MessageBox.Show("Cập nhật dữ liệu thành công!");
        }
        private void nvThoat_Click(object sender, EventArgs e)
        {
            logout();
        }
        private void nvSearch_TextChanged(object sender, EventArgs e)
        {
            if (nvSearch.Text != "Tên nhân viên")
            {
                string key = nvSearch.Text;
                dgvNhanVien.DataSource = db.NhanViens.Where(m => m.Hoten.ToLower().Contains(key.ToLower()) || key == null).ToList();
                bindingDataBy(typeof(NhanVien), nvTbList, dgvNhanVien);
                selectedNV = dgvNhanVien.RowCount > 0 ? dgvNhanVien.Rows[0].Cells[0].Value.ToString() : null;
                if (dgvNhanVien.RowCount == 0)
                {
                    foreach (Control k in nvTbList) k.Text = "";
                }
            }
        }
        private void nvSearch_Enter(object sender, EventArgs e)
        {
            if (nvSearch.Text == "Tên nhân viên")
            {
                nvSearch.Text = "";
            }
        }
        private void nvSearch_Leave(object sender, EventArgs e)
        {
            if (nvSearch.Text == "")
            {
                nvSearch.Text = "Tên nhân viên";
            }
        }
        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedNV = dgvNhanVien.Rows[dgvNhanVien.CurrentCell.RowIndex].Cells[0].Value.ToString();
        }

        void loadDanhGia()
        {
            dgvDanhGia.DataSource = db.Danhgias;
            bindingDataBy(typeof(Danhgia), dgTbList, dgvDanhGia, new int[] { 3 });
            selectedDG = dgvDanhGia.RowCount > 0 ? dgvDanhGia.Rows[0].Cells[0].Value.ToString() : null;
        }
        private void dgSearch_TextChanged(object sender, EventArgs e)
        {
            if (dgSearch.Text != "Mã khách hàng")
            {
                string key = dgSearch.Text;
                dgvDanhGia.DataSource = db.Danhgias.Where(m => m.MaKH.ToLower().Contains(key.ToLower()) || key == null).ToList();
                bindingDataBy(typeof(Danhgia), dgTbList, dgvDanhGia, new int[] { 3 });
                selectedDG = dgvDanhGia.RowCount > 0 ? dgvDanhGia.Rows[0].Cells[0].Value.ToString() : null;
                if (dgvDanhGia.RowCount == 0)
                {
                    foreach (Control k in dgTbList) k.Text = "";
                }
            }
        }
        private void dgThem_Click(object sender, EventArgs e)
        {
            foreach (Control t in dgTbList)
            {
                if (t.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                    return;
                }
            }
            try
            {
                db.DGInsert(dgtb1.Text, dgtb2.Text,
                    dgtb3.Text, DateTime.Parse(dgtb4.Text),
                    dgtb5.Text, dgtb6.Text);
                db = new DBqlkhDataContext();
                loadDanhGia();
                MessageBox.Show("Thêm thành công!");
            }
            catch (SqlException e1)
            {
                MessageBox.Show(e1.Message);
            }
        }
        private void dgXoa_Click(object sender, EventArgs e)
        {
            db.DGDelete(selectedDG);
            db = new DBqlkhDataContext();
            loadDanhGia();
            MessageBox.Show("Xóa thành công!");
        }
        private void dgSua_Click(object sender, EventArgs e)
        {
            db.DGUpdate(dgtb1.Text, dgtb2.Text, dgtb3.Text,
               DateTime.Parse(dgtb4.Text), dgtb5.Text, dgtb6.Text, dgtb1.Text);
            dgvDanhGia.Refresh();
            MessageBox.Show("Cập nhật dữ liệu thành công!");
        }
        private void dgThoat_Click(object sender, EventArgs e)
        {
            logout();
        }
        private void dgSearch_Enter(object sender, EventArgs e)
        {
            if (dgSearch.Text == "Mã khách hàng")
            {
                dgSearch.Text = "";
            }
        }
        private void dgSearch_Leave(object sender, EventArgs e)
        {
            if (dgSearch.Text == "")
            {
                dgSearch.Text = "Mã khách hàng";
            }
        }
        private void dgvDanhGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedDG = dgvDanhGia.Rows[dgvDanhGia.CurrentCell.RowIndex].Cells[0].Value.ToString();
        }

        void loadHopDong()
        {
            hd_tb7.CustomFormat = "hh:mm:ss dd/MM/yyyy";
            dgvHopDong.DataSource = db.HopDongs;
            bindingDataBy(typeof(HopDong), hdTbList, dgvHopDong, new int[] { 6 });
            selectedHD = dgvHopDong.RowCount>0 ? dgvHopDong.Rows[0].Cells[0].Value.ToString():null;
        }
        private void hdSearch_TextChanged(object sender, EventArgs e)
        {
            if (hdSearch.Text != "Mã khách hàng")
            {
                string key = hdSearch.Text;
                dgvHopDong.DataSource = db.HopDongs.Where(m => m.MaKH.ToLower().Contains(key.ToLower()) || key == null).ToList();
                bindingDataBy(typeof(HopDong), hdTbList, dgvHopDong, new int[] { 6 });
                selectedHD = dgvHopDong.RowCount > 0 ? dgvHopDong.Rows[0].Cells[0].Value.ToString() : null;
                if (dgvHopDong.RowCount == 0)
                {
                    foreach (Control k in hdTbList) k.Text = "";
                }
            }
        }
        private void hdThem_Click(object sender, EventArgs e)
        {
            foreach (Control t in hdTbList)
            {
                if (t.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                    return;
                }
            }
            try
            {
                db.HDInsert(hd_tb1.Text, hd_tb2.Text,
                    hd_tb3.Text, hd_tb4.Text,
                    hd_tb5.Text, hd_tb6.Text,
                    DateTime.Parse(hd_tb7.Text));
                db = new DBqlkhDataContext();
                loadHopDong();
                MessageBox.Show("Thêm thành công!");
            }
            catch (SqlException e1)
            {
                MessageBox.Show(e1.Message);
            }
        }
        private void hdXoa_Click(object sender, EventArgs e)
        {
            db.HDDelete(selectedHD);
            db = new DBqlkhDataContext();
            loadHopDong();
            MessageBox.Show("Xóa thành công!");
        }
        private void hdSua_Click(object sender, EventArgs e)
        {
            db.HDUpdate(hd_tb1.Text, hd_tb2.Text, hd_tb3.Text,
               hd_tb4.Text, hd_tb5.Text, hd_tb6.Text,
               DateTime.Parse(hd_tb7.Text), hd_tb1.Text);
            dgvHopDong.Refresh();
            MessageBox.Show("Cập nhật dữ liệu thành công!");
        }
        private void hdThoat_Click(object sender, EventArgs e)
        {
            logout();
        }
        private void hdSearch_Enter(object sender, EventArgs e)
        {
            if (hdSearch.Text == "Mã khách hàng")
            {
                hdSearch.Text = "";
            }
        }
        private void hdSearch_Leave(object sender, EventArgs e)
        {
            if (hdSearch.Text == "")
            {
                hdSearch.Text = "Mã khách hàng";
            }
        }
        private void dgvHopDong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedHD = dgvHopDong.Rows[dgvHopDong.CurrentCell.RowIndex].Cells[0].Value.ToString();
        }

        void bindingDataBy(Type tableName, List<Control> tbList, DataGridView dgv, int[] datePos = null)
        {
            if (datePos == null) datePos = new int[] { };
            var columnNames = db.Mapping.MappingSource
                      .GetModel(typeof(DBqlkhDataContext))
                      .GetMetaType(tableName)
                      .DataMembers;
            for (int i = 0; i < tbList.Count; i++)
            {
                tbList[i].DataBindings.Clear();
                if (datePos.Contains(i))
                {
                    tbList[i].DataBindings.Add("value", dgv.DataSource, columnNames[i].Name);
                }
                else
                {
                    tbList[i].DataBindings.Add("text", dgv.DataSource, columnNames[i].Name);
                }
            }
        }
        string getSelectedItem(DataGridView dgv)
        {
            return dgv.Rows[dgv.CurrentCell.RowIndex].Cells[0].Value.ToString();
        }
        void printDanhSachKhachHang()
        {
            var list = db.KhachHang_loaiKH_thang("01", 4, 2017);
            foreach (var v in list)
            {
                tlpKhachHang.RowCount += 1;
                panel5.Height += 50;
                tlpKhachHang.RowStyles.Add(new RowStyle(SizeType.Absolute, 50));
                tlpKhachHang.Controls.Add(createLabel(v.MaKH), 0, tlpKhachHang.RowCount - 1);
                tlpKhachHang.Controls.Add(createLabel(v.TenKH), 1, tlpKhachHang.RowCount - 1);
                tlpKhachHang.Controls.Add(createLabel(v.MaNDD), 2, tlpKhachHang.RowCount - 1);
                tlpKhachHang.Controls.Add(createLabel(v.DiaChi), 3, tlpKhachHang.RowCount - 1);
                tlpKhachHang.Controls.Add(createLabel(v.SDT), 4, tlpKhachHang.RowCount - 1);
                tlpKhachHang.Controls.Add(createLabel(v.Website), 5, tlpKhachHang.RowCount - 1);
            }
        }
        void printDanhGia()
        {
            var list = db.DanhGia_thang(4, 2017);
            int i = 0;
            foreach (var v in list)
            {
                tlpDanhGia.RowCount += 1;
                //tlpDanhGia.Height += 50;
                panel7.Height += 50;
                tlpDanhGia.RowStyles.Add(new RowStyle(SizeType.Absolute, 50));
                tlpDanhGia.Controls.Add(createLabel(v.makh), 0, tlpDanhGia.RowCount - 1);
                tlpDanhGia.Controls.Add(createLabel(v.TenKH), 1, tlpDanhGia.RowCount - 1);
                tlpDanhGia.Controls.Add(createLabel(v.MaNDD), 2, tlpDanhGia.RowCount - 1);
                tlpDanhGia.Controls.Add(createLabel(v.madv), 3, tlpDanhGia.RowCount - 1);
                tlpDanhGia.Controls.Add(createLabel(v.danhgia), 4, tlpDanhGia.RowCount - 1);
                string dateString = String.Format("{0:dd/MM/yyyy}", v.ngaydanhgia);
                tlpDanhGia.Controls.Add(createLabel(dateString), 5, tlpDanhGia.RowCount - 1);
                tlpDanhGia.Controls.Add(createLabel(v.tinhtrangxuly), 6, tlpDanhGia.RowCount - 1);
            }
        }
        Label createLabel(string text)
        {
            Label b = new Label() { Text = text };
            b.TextAlign = ContentAlignment.MiddleCenter;
            b.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                    | System.Windows.Forms.AnchorStyles.Left)
                    | System.Windows.Forms.AnchorStyles.Right)));
            return b;
        }
        void logout()
        {
            this.Close();
            (new LoginForm()).Show();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void kh_tb4_ValueChanged(object sender, EventArgs e)
        {
            Console.WriteLine("change " + kh_tb4.Value);
        }
        private void kh_tb4_Leave(object sender, EventArgs e)
        {
            Console.WriteLine("leave " + kh_tb4.Value);
        }
    }

}
