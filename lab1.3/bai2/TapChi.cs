using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai2
{
    internal class TapChi : TaiLieu
    {
        protected int soPhatHanh {  get; set; }

        protected string thangPhatHanh { get; set;}

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhập số phát hành: ");
            soPhatHanh = int.Parse(Console.ReadLine());
            Console.Write("Nhập tháng phát hành: ");
            thangPhatHanh = Console.ReadLine();
        }
        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine($"Số phát hành: {soPhatHanh}\nTháng phát hành: {thangPhatHanh}");
        }
    }
}
