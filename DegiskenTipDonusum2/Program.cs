/* Ekranda verilen (15/3=5) işlemi doğru ise kullanıcıdan true, yanlış
ise false değerini alan ve kullanıcının matematik bilgisini ölçen
programı yazınız. */


Console.Write("15/3=5 ifadesi doğru ise 'true', yanlış ise 'false' yazınız: ");

bool x = Convert.ToBoolean(Console.ReadLine());

if (x)
    Console.WriteLine("Doğru bildiniz!");
else
    Console.WriteLine("Hatalı cevap verdiniz.");

Console.ReadKey();
