using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DegiskenTurleri
{
    internal class Program
    {
        /* Genel olarak g değişkeni ile yerel olarak y değişkeninin değerlerinin
    çarpımını bulan programı yazınız. */

        public static int g = 56;

        static void Main(string[] args)
        {
            int y = 7;

            Console.WriteLine("Çarpımları: " + g * y);
            Console.ReadKey();
        }
    }
}
