using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai7
{
    internal class Nguoi
    {
        public string hoTen { get; set; }
        public int tuoi { get; set; }
        public int namSinh { get; set; }
        public string CCCD { get; set; }

        public void Nhap()
        {
            Console.Write("Nhập họ tên: ");
            hoTen = Console.ReadLine();
            Console.Write("Nhập tuổi: ");
            tuoi = int.Parse(Console.ReadLine());
            Console.Write("Nhập năm sinh: ");
            namSinh = int.Parse(Console.ReadLine());
            Console.Write("Nhập quê quán: ");
            CCCD = Console.ReadLine();
           
        }

        public void xuat()
        {
            Console.WriteLine($"Họ tên: {hoTen}\ntuổi: {tuoi}\n" +
                $"Năm sinh: {namSinh} \nCCCD: {CCCD}");
        }
    }
}
