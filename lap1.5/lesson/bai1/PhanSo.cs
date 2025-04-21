using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai1
{
    internal class PhanSo
    {
        internal int TuSo { get; set; }
        internal int MauSo { get; set; }
        public PhanSo(int tuSo, int mauSo)
        {
            TuSo = tuSo;
            MauSo = mauSo;
        }
        public PhanSo()
        {
            TuSo = 0;
            MauSo = 1;
        }
        // Tạo hàm nhập xuất
        public void Nhap()
        {
            Console.Write("Nhập tử số: ");
            TuSo = int.Parse(Console.ReadLine());
            Console.Write("Nhập mẫu số: ");
            MauSo = int.Parse(Console.ReadLine());
        }
        public void Xuat()
        {
            Console.WriteLine($"{TuSo}/{MauSo}");
        }
        //Tạo hàm tính ước chung lớn nhất
        public int UCLN(int a, int b)
        {
            if (b == 0)
                return a;
            return UCLN(b, a % b);
        }
        //Tạo hàm tính tổng và rút gọn phân số
        public PhanSo Tong(PhanSo ps)
        {
            PhanSo tong = new PhanSo();
            tong.TuSo = TuSo * ps.MauSo + MauSo * ps.TuSo;
            tong.MauSo = MauSo * ps.MauSo;
            int ucln = UCLN(tong.TuSo, tong.MauSo);
            tong.TuSo /= ucln;
            tong.MauSo /= ucln;
            return tong;
        }

    }
}
