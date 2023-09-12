/* Kullanıcı tarafında girilen cinsiyet bilgisine göre (Erkek için e, Kadın 
 için k) hangi cinsiyet değerinin girildiğini bulan programı yazınız. */

Console.Write("Kadın iseniz 'k', Erkek iseniz 'e' tuşuna basınız: ");

char x = Convert.ToChar(Console.ReadLine());

if (x == 'k')
    Console.WriteLine("Kadın olarak tuşlama yaptınız.");
else if (x == 'e')
    Console.WriteLine("Erkek olarak tuşlama yaptınız.");
else
    Console.WriteLine("Geçersiz tuşlama yaptınız.");