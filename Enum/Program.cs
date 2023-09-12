using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    internal class Program
    {
        /* Hafta içindeki gün isimlerini enum olarak tanımladıktan sonra,
        kullanıcının rakam olarak girdiği günün ismini bulan programı yazınız. */
        enum Gunler
        {
            Pazartesi = 1, Sali = 2, Carsamba = 3,
            Persembe = 4, Cuma = 5, Cumartesi = 6, Pazar = 7
        };
        static void Main(string[] args)
        {
            Console.Write("1-7 arasında bir sayı giriniz: ");
            int girilenSayi = Int16.Parse(Console.ReadLine());
            Gunler gunler = (Gunler)girilenSayi;
            Console.WriteLine();
            Console.Write("Seçtiğiniz gün: " + gunler.ToString());
            Console.ReadKey();
        }
    }
}
