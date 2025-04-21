using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai9
{
    internal class BienLai
    {
        //Tạo các thuộc tính thông tin hộ sử dụng điện, chỉ số cũ, chỉ số mới, số tiền phải trả
        public KhanhHang thongTinKhachHang { get; set; }
        public int chiSoCu { get; set; }
        public int chiSoMoi { get; set; }
        public double soTienPhaiTra { get; set; }
        //Tạo phương thức nhập xuất thông tin hộ sử dụng điện
        public void Nhap()
        {
            thongTinKhachHang = new KhanhHang();
            thongTinKhachHang.Nhap();
            Console.Write("Nhập chỉ số cũ: ");
            chiSoCu = int.Parse(Console.ReadLine());
            Console.Write("Nhập chỉ số mới: ");
            chiSoMoi = int.Parse(Console.ReadLine());
        }
        public void Xuat()
        {
            Console.WriteLine("Thông tin hộ sử dụng điện: ");
            thongTinKhachHang.Xuat();
            Console.WriteLine("Chỉ số cũ: " + chiSoCu);
            Console.WriteLine("Chỉ số mới: " + chiSoMoi);
            Console.WriteLine("Số tiền phải trả: " + soTienPhaiTra);
        }
        public void TinhTien()
        {
            int soDien = chiSoMoi - chiSoCu;
            if (soDien < 50)
            {
                soTienPhaiTra = soDien * 1250;
            }
            else if (soDien < 100)
            {
                soTienPhaiTra = (50 * 1250) + ((soDien - 50) * 1500);
            }
            else
            {
                soTienPhaiTra = (50 * 1250)+ (50 * 1500) + ((soDien - 100) * 1500);
            }
        }

    }
}
