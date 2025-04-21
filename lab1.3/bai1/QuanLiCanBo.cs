using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace bai1
{
    internal class QuanLiCanBo
    {
        private List<CanBo> danhSachCanBo = new List<CanBo>();
        public void NhapCanBo()
        {
            Console.WriteLine("Nhập loai cán bộ (1: Công nhân, 2: Kỹ sư, 3: Nhân viên): ");
            int loai = int.Parse(Console.ReadLine());
            CanBo canBo = null;

            switch (loai)
            {
                case 1:
                    canBo = new CongNhan();
                    break;
                case 2:
                    canBo = new KySu();
                    break;
                case 3:
                    canBo = new NhanVienPhucVu();
                    break;
                default:
                    Console.WriteLine("Nhập không hợp lệ.");
                    return;
            }
            canBo.Nhap();
            danhSachCanBo.Add(canBo);
        }
        public void TimKiem(string hoTen)
        {
            foreach (var canBo in danhSachCanBo)
            {
                if(canBo.hoTen.Equals(hoTen, StringComparison.OrdinalIgnoreCase))
                {
                    canBo.Xuat();
                    return;
                }
            }
            Console.WriteLine($"Không tìm thấy người có tên: {hoTen}");
        }
        public void HienThiDanhSach()
        {
            foreach(var canBo in danhSachCanBo)
            {
                canBo.Xuat();
                Console.WriteLine("------------------------");
            }
        }
    }
}
