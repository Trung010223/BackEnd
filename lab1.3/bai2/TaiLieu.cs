using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai2
{
    internal class TaiLieu
    {
        public string maTaiLieu {  get; set; }
        public string tenNXB { get; set; }  

        public int soBPH { get; set; }

        public virtual void Nhap()
        {
            Console.Write("Nhập thông tin: ");
            Console.Write("Nhập mã tài liệu: ");
            maTaiLieu = Console.ReadLine();
            Console.Write("Nhập tên nhà xuất bản: ");
            tenNXB = Console.ReadLine();
            Console.Write("Nhập số bản phát hành: ");
            soBPH = int.Parse(Console.ReadLine());
        }

        public virtual void Xuat()
        {
            Console.WriteLine("Thông tin: ");
            Console.WriteLine($"Mã tài liêu: {maTaiLieu}\nTên nhà xuất bản: {tenNXB}\nSố bản phát hành: {soBPH}");
        }

    }
}
