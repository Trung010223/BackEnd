using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai4
{
     class Nguoi
    {
        protected string CCCD { get; set; }
        public string hoTen { get; set; }
        protected int tuoi { get; set; }
        protected int namSinh { get; set; }
        protected string ngheNghiep { get; set; }

        public void Nhap()
        {
            Console.Write("Nhập số CCCD");
            CCCD = Console.ReadLine();
            Console.Write("Nhập họ tên: ");
            hoTen = Console.ReadLine();
            Console.Write("Nhập tuôi: ");
            tuoi = int.Parse(Console.ReadLine());
            Console.Write("Nhập năm sinh: ");
            namSinh = int.Parse(Console.ReadLine());
            Console.Write("Nhập nghề nghiệp: ");
            ngheNghiep = Console.ReadLine();
        }
        public void Xuat()
        {
            Console.WriteLine($"CCCD: {CCCD}\nHọ Tên: {hoTen}" +
                $"\ntuổi: {tuoi}\nNăm sinh: {namSinh}\n" +
                $"Nghề nghiệp: {ngheNghiep}");
        }
    }
}
