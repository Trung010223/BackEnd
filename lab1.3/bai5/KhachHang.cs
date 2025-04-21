using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai5
{
    internal class KhachHang
    {
        public Nguoi ThongTinCaNhan {  get; set; }
        public int soNgayTro {  get; set; }
        public string loaiPhong { get; set; }
        public float giaPhong { get; set; }

        public void Nhap()
        {
            ThongTinCaNhan = new Nguoi();
            ThongTinCaNhan.Nhap();
            Console.Write("Nhập số ngày trọ: ");
            soNgayTro = int.Parse(Console.ReadLine());
            Console.Write("Nhập loại phòng: ");
            loaiPhong = Console.ReadLine();
            Console.Write("Nhập giá phòng: ");
            giaPhong = float.Parse(Console.ReadLine());
        }

        public void HienThi()
        {
            Console.WriteLine($"Thông tin cá nhân:");
            ThongTinCaNhan.Xuat();
            Console.WriteLine($"Số ngày trọ: {soNgayTro}, Loại phòng: {loaiPhong}, Giá phòng: {giaPhong}");
        }

        public float TinhTien()
        {
            return soNgayTro * giaPhong;
        }

    }
}
