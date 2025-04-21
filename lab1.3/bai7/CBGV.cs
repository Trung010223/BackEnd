using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai7
{
    internal class CBGV
    {
        public Nguoi thongTinGiaoVien { get; set; }
        public float luongCung { get; set; }
        public float thuong { get; set; }
        public float phat { get; set; }
        public float luongThucLinh { get; set; }

        public void Nhap()
        {
            thongTinGiaoVien = new Nguoi();
            thongTinGiaoVien.Nhap();
            Console.Write("Nhập lương cơ bản: ");
            luongCung = float.Parse(Console.ReadLine());
            Console.Write("Nhập số tiền phạt: ");
            phat = float.Parse(Console.ReadLine());
        }

        public void TinhLuongThucLinh()
        {
            luongThucLinh = luongCung + thuong - phat;
        }

        public void xuat()
        {
            Console.WriteLine($"Họ tên: {thongTinGiaoVien.hoTen}\ntuổi: {thongTinGiaoVien.tuoi}\n" +
                $"Năm sinh: {thongTinGiaoVien.namSinh} \nCCCD: {thongTinGiaoVien.CCCD}");
            Console.WriteLine($"Lương cơ bản: {luongCung}\nTiền thưởng: {thuong}\nTiền phạt: {phat}");
            Console.WriteLine($"Lương thực lĩnh: {luongThucLinh}");
        }
    }
}
