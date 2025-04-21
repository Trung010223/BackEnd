using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai1
{
    internal class CanBo
    {
        public string hoTen { get; set; }
        public int namSinh { get; set; }

        public string gioiTinh { get; set; }

        public string diaChi { get; set; }

        public virtual void Nhap()
        {
            Console.Write("Nhập tên: ");
            hoTen = Console.ReadLine();
            Console.Write("Nhâp năm sinh: ");
            namSinh = int.Parse(Console.ReadLine());
            Console.Write("Nhập giới tính: ");
            gioiTinh = Console.ReadLine();
            Console.Write("Nhập địa chỉ: ");
            diaChi = Console.ReadLine();

        }

        public virtual void Xuat()
        {
            Console.WriteLine("------------------------");
            Console.WriteLine("Thông tin: ");
            Console.WriteLine($"Họ tên: {hoTen}");
            Console.WriteLine($"Năm sinh: {namSinh}");
            Console.WriteLine($"Giới tính: {gioiTinh}");
            Console.WriteLine($"Địa chỉ: {diaChi}");
        }
    }
}
