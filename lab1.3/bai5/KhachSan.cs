using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai5
{
    internal class KhachSan
    {
        public List<KhachHang> DanhSachKhach = new List<KhachHang>();

        public void NhapKhach()
        {
            Console.Write("Nhập số khách trọ: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Nhập thông tin khách trọ {i + 1}:");
                KhachHang khach = new KhachHang();
                khach.Nhap();
                DanhSachKhach.Add(khach);
            }
        }

        public void HienThiTatCaKhach()
        {
            Console.WriteLine("Thông tin khách đang trọ:");
            foreach (var khach in DanhSachKhach)
            {
                khach.HienThi();
                Console.WriteLine("------------------------------------");
            }
        }

        public void TimKiemKhach(string hoTen)
        {
            var ketQua = DanhSachKhach.Where(k => k.ThongTinCaNhan.hoTen.Contains(hoTen, StringComparison.OrdinalIgnoreCase)).ToList();

            if (ketQua.Count > 0)
            {
                Console.WriteLine("Kết quả tìm kiếm:");
                foreach (var khach in ketQua)
                {
                    khach.HienThi();
                    Console.WriteLine("------------------------------------");
                }
            }
            else
            {
                Console.WriteLine("Không tìm thấy khách nào.");
            }
        }
    }
}
