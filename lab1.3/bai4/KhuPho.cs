using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai4
{
    internal class KhuPho
    {
        public List<hoDan> DanhSachHoDan = new List<hoDan>();
        public void Nhap()
        {
            Console.WriteLine("Nhập số hệ dân: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Nhập hộ dân thứ {i + 1}: ");
                hoDan hoDan = new hoDan(); 
                hoDan.Nhap();
                DanhSachHoDan.Add( hoDan );
            }
        }
        public void Xuat()
        {
            Console.WriteLine("Hiện thị tất cả hộ dân: ");
            foreach (var hoDan in DanhSachHoDan) {
                Console.WriteLine("--------------------");
                hoDan.Xuat();
            }
        }
        public void TimKiem(string tuKhoa)
        {
            foreach (var hoDan in DanhSachHoDan) 
            {
                if (hoDan.soNha == tuKhoa)
                {
                    hoDan.Xuat();
                    return;
                }
            foreach (var nguoi in hoDan.ThanhVien)
                {
                    if(nguoi.hoTen.Contains(tuKhoa, StringComparison.OrdinalIgnoreCase))
                    {
                        hoDan.Xuat();
                    }
                }
            }
            Console.WriteLine("Không tìm thấy hộ dân nào.");
        }
    }
}
