using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai2
{
    internal class Bao : TaiLieu
    {
        protected string ngayPhatHanh {  get; set; }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhập ngày phát hành: ");
            ngayPhatHanh = Console.ReadLine();
        }
        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine($"Ngày phát hanh: {ngayPhatHanh}");
        }
    }
}
