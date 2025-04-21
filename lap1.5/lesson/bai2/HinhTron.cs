using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai2
{
    internal class HinhTron : Hinh
    {
        private double banKinh;
        public HinhTron(double banKinh)
        {
            this.banKinh = banKinh;
        }
        public override double TinhDienTich()
        {
            return Math.PI * Math.Pow(banKinh, 2);
        }
        public override double TinhChuVi()
        {
            return 2 * Math.PI * banKinh;
        }
    }
}
