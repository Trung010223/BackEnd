using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai3
{
    internal class KhoiC : ThiSinh
    {
        protected float van { get; set; }
        protected float su { get; set; }
        protected float dia { get; set; }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhập điểm toán: ");
            van = float.Parse(Console.ReadLine());
            Console.Write("Nhập điểm lý: ");
            su = float.Parse(Console.ReadLine());
            Console.Write("Nhập điểm hóa: ");
            dia = float.Parse(Console.ReadLine());
            diem = van + su + dia;
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine($"Điểm toán: {van}\nĐiểm lý: {su}\nĐiểm hóa: {dia}");
        }

    }
}
