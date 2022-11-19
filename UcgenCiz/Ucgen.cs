using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcgenCiz
{
    public class Ucgen
    {

        public static void UcgenCiz(int sayi)
        {
            for (int i = 0; i <= sayi; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
