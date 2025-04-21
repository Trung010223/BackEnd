using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai2
{
    internal class HinhVuong : Hinh
    {
        private double canh;
        public HinhVuong(double canh)
        {
            this.canh = canh;
        }
        public override double TinhDienTich()
        {
            return Math.Pow(canh, 2);
        }
        public override double TinhChuVi()
        {
            return 4 * canh;
        }
    }
}
