using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai3
{
    internal class KhoiA : ThiSinh
    {
        protected float toan {  get; set; } 
        protected float ly { get; set; }
        protected float hoa { get; set; }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhập điểm toán: ");
            toan = float.Parse(Console.ReadLine());
            Console.Write("Nhập điểm lý: ");
            ly = float.Parse(Console.ReadLine());
            Console.Write("Nhập điểm hóa: ");
            hoa = float.Parse(Console.ReadLine());
            diem = toan + ly + hoa;
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine($"Điểm toán: {toan}\nĐiểm lý: {ly}\nĐiểm hóa: {hoa}");
        }

    }
}
