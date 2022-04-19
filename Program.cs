using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _54DersForeach
{
    class Program
    {
        static void Main(string[] args)
        {
            int toplam = 0;
            int[] sayilar = { 1, 2, 3, 4, 5 };
            foreach(var item in sayilar)
            {
                toplam += item;
            }
            Console.WriteLine(toplam);
        }
    }
}
