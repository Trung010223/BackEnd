using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai9
{
    internal class KhanhHang
    {
        //Tạo các thuộc tính họ tên, số nhà, mã công tơ
        private string hoTen { get; set; }
        private string soNha { get; set; }
        public string maCongTo { get; set; }
        //Tạo phương thức nhập xuất thông tin khách hàng
        public void Nhap()
        {
            Console.Write("Nhập họ tên khách hàng: ");
            hoTen = Console.ReadLine();
            Console.Write("Nhập số nhà: ");
            soNha = Console.ReadLine();
            Console.Write("Nhập mã công tơ: ");
            maCongTo = Console.ReadLine();
        }
        public void Xuat()
        {
            Console.WriteLine("Họ tên khách hàng: " + hoTen);
            Console.WriteLine("Số nhà: " + soNha);
            Console.WriteLine("Mã công tơ: " + maCongTo);
        }

    }
}
