using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai1
{
    internal class NhanVienPhucVu : CanBo
    {
        protected string congViec {  get; set; }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhập công việc: ");
            congViec = Console.ReadLine();
        }
        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine($"Công việc: {congViec}");
        }
    }
}
