using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1_TinhTong
{
    class Program
    {
        public static int Nhap()
        {
            int n;
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Moi nhap n");
            n = Convert.ToInt32(Console.ReadLine());
            return n;
        }
        public static int Tong(int n)
        {
            int s = 0;
            for (int i = 1; i <= n; i++)
            {
                s += i;
            }
            return s;
        }
        static void Main(string[] args)
        {
            int n;
            n = Nhap();
            Console.WriteLine("Tong tu 1 den {0} la {1}", n, Tong(n));
            Console.ReadLine();
        }
    }
}
