/* ConsoleKeyInfo metodunu kullanarak klavyeden hangi tuşa basıldığını
bulan programı yazınız. */

    ConsoleKeyInfo tus;
    Console.Write("Klavyeden bir tuşa basınız: ");
    tus = Console.ReadKey();
    Console.WriteLine(tus.Key.ToString() + " tuşuna bastınız.");