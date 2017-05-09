using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QlkhNamespace
{
    class SinhVien
    {
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public string SDT { get; set; }
        public string DiaChi { get; set; }
        public SinhVien()
        {

        }
        public SinhVien(string hoTen, DateTime ngaySinh, string sDT, string diaChi)
        {
            this.HoTen = hoTen;
            this.NgaySinh = ngaySinh;
            this.SDT = sDT;
            this.DiaChi = diaChi;
        }
    }
}
