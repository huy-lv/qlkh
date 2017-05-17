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
    public partial class TransactionLog : Form
    {
        private string khId;
        DBqlkhDataContext db = new DBqlkhDataContext();
        public TransactionLog()
        {
            InitializeComponent();
        }

        public TransactionLog(String id)
        {
            khId = id;
            InitializeComponent();
             var result = db.KhachHangSelectById(khId);

            this.Text = "In sao kê";
            saoke_tb4.CustomFormat = "hh:mm:ss dd/MM/yyyy";
            saoke_tb5.CustomFormat = "hh:mm:ss dd/MM/yyyy";

            foreach (var r in result)
            {
                saoke_tb1.Text = r.TenKH;
                saoke_tb2.Text = r.SoTK;
                saoke_tb3.Text = r.LoaiTien;
            }
        }

        private void saoke_bt_Click(object sender, EventArgs e)
        {
            DateTime dt1 = saoke_tb4.Value;
            DateTime dt2 = saoke_tb5.Value;

            if (dt1 < dt2)
            {
                dgvSaoke.DataSource = db.GiaoDichSelectByMaKHAndTime(khId, dt1, dt2);
            }
            else
            {
                MessageBox.Show("Ngày đã chọn không hợp lệ!");
            }
        }

        private void TransactionLog_Load(object sender, EventArgs e)
        {
        }
    }
}
