using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai2
{
    internal class Sach : TaiLieu
    {
        protected string tenTG { get; set; }
        protected int soTrang { get; set; }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhập tên tác giả: ");
            tenTG = Console.ReadLine();
            Console.Write("Nhập số trang: ");
            soTrang = int.Parse(Console.ReadLine());
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine($"Tên tác giả: {tenTG}\nSố Trang: {soTrang}");
        }
    }
}
