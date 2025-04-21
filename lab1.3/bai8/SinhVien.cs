using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai8
{
    internal class SinhVien
    {
        //Tạo các thuộc tính họ tên, năm sinh, lớp, mã số sinh viên
        private string hoTen { get; set; }
        private int namSinh { get; set; }
        private string lop { get; set; }
        public string maSoSV { get; set; }

        //Tạo phương thức nhập xuất thông tin sinh viên
        public void Nhap()
        {
            Console.Write("Nhập họ tên sinh viên: ");
            hoTen = Console.ReadLine();
            Console.Write("Nhập năm sinh: ");
            namSinh = int.Parse(Console.ReadLine());
            Console.Write("Nhập lớp: ");
            lop = Console.ReadLine();
            Console.Write("Nhập mã số sinh viên: ");
            maSoSV = Console.ReadLine();
        }

        public void Xuat()
        {
            Console.WriteLine("Họ tên sinh viên: " + hoTen);
            Console.WriteLine("Năm sinh: " + namSinh);
            Console.WriteLine("Lớp: " + lop);
            Console.WriteLine("Mã số sinh viên: " + maSoSV);
        }

    }
}
