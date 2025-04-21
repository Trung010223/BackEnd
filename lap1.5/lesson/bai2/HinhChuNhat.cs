using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai2
{
    internal class HinhChuNhat : Hinh
    {
        private double chieuDai;
        private double chieuRong;
        public HinhChuNhat(double chieuDai, double chieuRong)
        {
            this.chieuDai = chieuDai;
            this.chieuRong = chieuRong;
        }
        public override double TinhDienTich()
        {
            return chieuDai * chieuRong;
        }
        public override double TinhChuVi()
        {
            return 2 * (chieuDai + chieuRong);
        }
    }
    
}
