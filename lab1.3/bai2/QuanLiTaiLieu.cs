using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace bai2
{
    internal class QuanLiTaiLieu
    {
        private List<TaiLieu> danhSachTaiLieu = new List<TaiLieu>();

        public void NhapTaiLieu()
        {
            Console.WriteLine("Nhập thông tin tài liệu (1: Sách, 2: TapChi, 3: Báo)");
            int loai = int.Parse(Console.ReadLine());
            TaiLieu taiLieu = null;

            switch (loai)
            {
                case 1:
                    taiLieu = new Sach();
                    break;
                case 2:
                    taiLieu = new TapChi();
                    break;
                case 3:
                    taiLieu = new Bao();
                    break;
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ: ");
                    break;
            }
            taiLieu.Nhap();
            danhSachTaiLieu.Add(taiLieu);
        }
        public void HienThi()
        {
            foreach (var taiLieu in danhSachTaiLieu)
            {
                taiLieu.Xuat();
                Console.WriteLine("-----------------------------");
                return;
            }
        }
        public void TimKiem(int loai)
        {
            foreach (var taiLieu in danhSachTaiLieu)
            {
                if ((loai == 1 && taiLieu is Sach) ||
                    (loai == 2 && taiLieu is TapChi) ||
                    (loai == 3 && taiLieu is Bao))
                {
                    taiLieu.Xuat();
                    Console.WriteLine("------------------------");
                }

            }
        }
    }
}
