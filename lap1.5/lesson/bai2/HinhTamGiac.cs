using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai2
{
    internal class HinhTamGiac : Hinh
    {
        private double canh1;
        private double canh2;
        private double canh3;
        public HinhTamGiac(double canh1, double canh2, double canh3)
        {
            this.canh1 = canh1;
            this.canh2 = canh2;
            this.canh3 = canh3;
        }
        public override double TinhDienTich()
        {
            double p = TinhChuVi() / 2;
            return Math.Sqrt(p * (p - canh1) * (p - canh2) * (p - canh3));
        }
        public override double TinhChuVi()
        {
            return canh1 + canh2 + canh3;
        }
    }
}
