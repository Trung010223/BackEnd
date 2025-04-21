using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai8
{
    internal class TheMuon
    {
        //Tạo các thuộc tính số phiếu mượn, ngày mượn, hạn trả, số hiệu sách và thông tin sinh viên
        private string soPhieuMuon { get; set; }
        private DateTime ngayMuon { get; set; }
        public DateTime hanTra { get; set; }
        private string soHieuSach { get; set; }
        public SinhVien sinhVien { get; set; }
        //Tạo phương thức nhập xuất thông tin thẻ mượn
        public void Nhap()
        {
            Console.Write("Nhập số phiếu mượn: ");
            soPhieuMuon = Console.ReadLine();
            Console.Write("Nhập ngày mượn (dd/MM/yyyy): ");
            ngayMuon = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
            Console.Write("Nhập hạn trả (dd/MM/yyyy): ");
            hanTra = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
            Console.Write("Nhập số hiệu sách: ");
            soHieuSach = Console.ReadLine();
            sinhVien = new SinhVien();
            sinhVien.Nhap();
        }
        public void Xuat()
        {
            Console.WriteLine("Số phiếu mượn: " + soPhieuMuon);
            Console.WriteLine("Ngày mượn: " + ngayMuon.ToString("dd/MM/yyyy"));
            Console.WriteLine("Hạn trả: " + hanTra.ToString("dd/MM/yyyy"));
            Console.WriteLine("Số hiệu sách: " + soHieuSach);
            Console.WriteLine("Thông tin sinh viên:");
            sinhVien.Xuat();
        }
    }
}
