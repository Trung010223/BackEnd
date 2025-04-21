using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test;

namespace test
{
    internal class Class1
    {
        public int chieuCao;
        public int chieuDai;

        public void view()
        {
            Console.WriteLine("Chiều cao của bạn là: " + chieuCao + "Chiều dài của bạn là: " + chieuDai);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Class1 trung = new Class1();
            trung.chieuCao = 12;
            trung.chieuDai = 13;
            
            trung.view();
        }
    }
}


