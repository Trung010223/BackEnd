using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai1
{
    internal class CongNhan : CanBo
    {
        protected string bac {  get; set; }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhập bậc quản lí: ");
            bac = Console.ReadLine();
        }
        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine($"Bâc: {bac}");
        }
    }
}
