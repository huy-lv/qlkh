using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QlkhNamespace
{
    public partial class SaoKeForm : Form
    {
        public SaoKeForm()
        {
            InitializeComponent();
            //kh = k; 
        }

        private void SaoKeForm_Load(object sender, EventArgs e)
        {
            this.Text = "In sao kê";

            //lbTenKH.Text = kh.TenKH;
            //lbSoTaiKhoan.Text = kh.SoTaiKhoan;
            //lbType.Text = kh.LoaiTien;

            //var query = from p in db.GiaoDiches where p.MaKH == kh.MaKH select p;
            //IEnumerable<GiaoDich> gds = query.ToList();

            //if (gds.Count() > 0)
            //{
            //    DateTime dtmin = gds.FirstOrDefault().NgayGD;
            //    DateTime dtmax = gds.FirstOrDefault().NgayGD;
            //    foreach (GiaoDich gd in gds)
            //    {
            //        if (dtmin > gd.NgayGD) dtmin = gd.NgayGD;
            //        if (dtmax < gd.NgayGD) dtmax = gd.NgayGD;
            //        ListViewItem item = new ListViewItem(gd.MaGD.ToString());
            //        item.SubItems.Add(gd.MaKH.ToString());
            //        item.SubItems.Add(gd.MaNV.ToString());
            //        item.SubItems.Add(gd.NoiDung);
            //        item.SubItems.Add(gd.NgayGD.ToString());
            //        item.SubItems.Add(gd.PhatSinhNo.ToString());
            //        item.SubItems.Add(gd.PhatSinhCo.ToString());
            //        item.SubItems.Add(gd.TenNguoiNhan);
            //        lvDsGiaoDich.Items.Add(item);
            //    }
            //    lbFromTo.Text = dtmin + " đến ngày " + dtmax.ToString();
            //}
            
        }

        private void lvDsGiaoDich_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
