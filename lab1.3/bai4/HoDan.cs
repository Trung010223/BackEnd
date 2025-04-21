using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai4
{
    class hoDan
    {
        public int soThanhVien {  get; set; }
        public string soNha {  get; set; }

        public List<Nguoi> ThanhVien = new List<Nguoi>();

        public void Nhap()
        {
            Console.Write("Nhập số thành viên: ");
            soThanhVien = int.Parse(Console.ReadLine());
            Console.Write("Nhập số nhà: ");
            soNha = Console.ReadLine();

            for (int i = 0; i < soThanhVien; i++)
            {
                Console.WriteLine($"Nhập thông tin cho thành viên {i + 1}: ");
                Nguoi nguoi = new Nguoi();
                nguoi.Nhap();
                ThanhVien.Add( nguoi );
            }
        }
        public void Xuat()
        {
            Console.WriteLine($"Số Nhà: {soNha}, Số thành viên: {soThanhVien}");
            foreach (var nguoi in ThanhVien)
            {
                nguoi.Xuat();
            }
        }

    }
}
