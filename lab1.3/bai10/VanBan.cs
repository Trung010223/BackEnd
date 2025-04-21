using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace bai10
{
    internal class VanBan
    {
        public string vanBan { get; set; }

        //hàm tạo không đối số
        public VanBan()
        {
            vanBan = "";
        }
        //hàm tạo có đối số
        public VanBan(string st)
        {
            vanBan = st;
        }
        //Hàm nhập xâu
        public void Nhap()
        {
            Console.Write("Nhập xâu: ");
            vanBan = Console.ReadLine();
        }

        //xây dựng đếm số từ của một sâu
        public int DemSoTu()
        {
            int dem = 0;
            string[] arr = vanBan.Split(new char[] { ' ', '\n', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string s in arr)
            {
                dem++;
            }
            return dem;
        }
        //xây dựng đếm số ký tự "H" của một sâu không phân biệt chữ hoa hay thường
        public int DemKyTuH()
        {
            int dem = 0;
            for (int i = 0; i < vanBan.Length; i++)
            {
                if (char.ToLower(vanBan[i]) == 'h')
                {
                    dem++;
                }
            }
            return dem;
        }
        //Chuẩn hoá một xâu theo tiêu chuẩn (Ở đầu và cuối của xâu không có ký tự trống, ở giữa xâu không có hai ký tự trắng liền nhau).
        public string ChuanHoa()
        {
            //Xóa các ký tự trắng ở đầu và cuối xâu
            vanBan = vanBan.Trim();
            //Xóa các ký tự trắng ở giữa xâu
            StringBuilder sb = new StringBuilder();
            bool space = false;
            for (int i = 0; i < vanBan.Length; i++)
            {
                if (vanBan[i] != ' ')
                {
                    sb.Append(vanBan[i]);
                    space = false;
                }
                else if (!space)
                {
                    sb.Append(' ');
                    space = true;
                }
            }
            return sb.ToString();
        }

    }
}
