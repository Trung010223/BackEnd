using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai1
{
    internal class KySu : CanBo
    {
        protected String nganhDaoTao {  get; set; }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhập ngành đào tạo: ");
            nganhDaoTao = Console.ReadLine();
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine($"Ngành đào tạo: {nganhDaoTao}"); 
        }
    }
}
