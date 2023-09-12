using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DegiskenTipiOgrenmek
{
    internal class Program
    {
        /* Programda kullandığımız değişkenlerin tipini GetType metodu
        kullanarak bulan programı yazınız. */

        static void Main(string[] args)
        {
            Object obje = new Object();
            string kelime = "Baran";
            sbyte sayi = 76;

            Type tip1 = obje.GetType();
            Type tip2 = kelime.GetType();
            Type tip3 = sayi.GetType();

            Console.WriteLine(tip1);
            Console.WriteLine(tip2);
            Console.WriteLine(tip3);
            Console.ReadKey();
        }
    }
}
