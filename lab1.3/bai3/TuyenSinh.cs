using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai3
{
    internal class TuyenSinh
    {
        private List<ThiSinh> danhSachThiSinh = new List<ThiSinh>();

        public void NhapThongTin()
        {
            Console.WriteLine("Nhập lựa chọn (1: Khối A, 2: Khối B, 3: Khối C)");
            int loai = int.Parse(Console.ReadLine());
            ThiSinh thiSinh = null;
            switch (loai)
            {
                case 1:
                    thiSinh = new KhoiA();
                    break;
                case 2:
                    thiSinh = new KhoiB();
                    break;
                case 3:
                    thiSinh = new KhoiC();
                    break;
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ.");
                    return;
            }
            thiSinh.Nhap();
            danhSachThiSinh.Add(thiSinh);
        }

        public void HienThi()
        {
            foreach (var thiSinh in danhSachThiSinh)
            {
                float diemChuan = 0;
                if (thiSinh is KhoiA) diemChuan = 15;
                else if (thiSinh is KhoiB) diemChuan = 16;
                else if(thiSinh is KhoiC) diemChuan = 13.5f;

                if (thiSinh.diem + thiSinh.diemUuTien >= diemChuan)
                {
                    thiSinh.Xuat();
                    Console.WriteLine("----------------------------");
                }
            }
        }

        public void TimKiem(string SBD)
        {
            foreach (var thiSinh in danhSachThiSinh)
            {
                if (thiSinh.SBD == SBD)
                {
                    thiSinh.Xuat();
                    return;
                }
            }
            Console.WriteLine("Không tìm thấy.");
        }
    }
}
