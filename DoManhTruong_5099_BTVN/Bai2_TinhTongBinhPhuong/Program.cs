using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2_TinhTongBinhPhuong
{
    class Program
    {

        static int TinhTongBP(int n)
        {
            int s = 0;
            for (int i = 1; i <= n; i++)
            {
                s += (i * i);
            }
            return s;
        }
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Moi nhap n:");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Tong binh phuong tu 1 toi {0} la {1}", n, TinhTongBP(n));
            Console.ReadLine();
        }
    }
}
