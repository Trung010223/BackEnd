using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai3
{
    internal class KhoiB : ThiSinh
    {
        protected float toan { get; set; }
        protected float hoa { get; set; }
        protected float sinh { get; set; }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhập điểm toán: ");
            toan = float.Parse(Console.ReadLine());
            Console.Write("Nhập điểm hóa: ");
            hoa = float.Parse(Console.ReadLine());
            Console.Write("Nhập điểm sinh: ");
            sinh = float.Parse(Console.ReadLine());
            diem = toan + hoa + sinh;
        }
        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine($"Điểm toán: {toan}\nĐiểm lý: {hoa}\nĐiểm hóa: {sinh}");
        }

    }
}
