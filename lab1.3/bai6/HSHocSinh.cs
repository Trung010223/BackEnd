using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai6
{
    internal class HSHocSinh
    {
        public Nguoi thongTinSinhVien { get; set; }
        public String lop {  get; set; }
        public string khoaHoc { get; set; }
        public string kyHoc { get; set; }

        public void Nhap()
        {
            thongTinSinhVien = new Nguoi();
            thongTinSinhVien.Nhap();
            Console.Write("Nhập lớp: ");
            lop = Console.ReadLine();
            Console.Write("Nhập khóa học: ");
            khoaHoc = Console.ReadLine();
            Console.Write("Nhập kì học: ");
            kyHoc = Console.ReadLine();
        }
        public void Xuat()
        {
            thongTinSinhVien.xuat();
            Console.WriteLine($"Lớp: {lop}\n Khóa học: {khoaHoc} \n Kì học: {kyHoc}");
        }
    }
}
