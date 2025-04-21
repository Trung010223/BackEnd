using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai5
{
    internal class Nguoi
    {
        public string hoTen {  get; set; }
        public int namSinh { get; set; }
        public string CCCD { get; set; }

        public void Nhap()
        {
            Console.Write("Nhập thông tin cá nhân: ");
            Console.Write("Nhập họ và tên: ");
            hoTen = Console.ReadLine();
            Console.Write("Nhập năm sinh: ");
            namSinh = int.Parse(Console.ReadLine());
            Console.Write("Nhập CCCD: ");
            CCCD = Console.ReadLine();
        }

        public void Xuat()
        {
            Console.WriteLine($"CCCD: {CCCD}\nHọ Tên: {hoTen}\nNăm sinh: {namSinh}" );
        }
    }
}
