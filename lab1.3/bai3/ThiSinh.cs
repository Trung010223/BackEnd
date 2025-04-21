using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai3
{
    internal class ThiSinh
    {
        public string SBD {  get; set; }
        public string hoTen { get; set; }

        public string diaChi{ get; set; }

        public float diemUuTien { get; set; }

        public float diem {  get; set; }

        public virtual void Nhap()
        {
            Console.WriteLine("Nhập thông tin: ");
            Console.Write("Số báo danh: ");
            SBD = Console.ReadLine();
            Console.Write("Nhập họ tên: ");
            hoTen = Console.ReadLine();
            Console.Write("Nhập địa chỉ: ");
            diaChi = Console.ReadLine();
            Console.Write("Điểm ưu tiên: ");
            diemUuTien = float.Parse(Console.ReadLine());
        }

        public virtual void Xuat()
        {
            Console.WriteLine($"SBD: {SBD}\nTên: {hoTen}\nĐịa chỉ: {diaChi}\nƯu tiên: {diemUuTien}");
        }
    }
}
