/* Klavyeden kullanıcı tarafından girilen dört sayının aritmetik ortalamasını
bulan programı yazınız. */

Console.Write("İlk sayıyı giriniz: ");
double sayi1 = Double.Parse(Console.ReadLine());    
Console.Write("İkinci sayıyı giriniz: ");
double sayi2 = Double.Parse(Console.ReadLine());
Console.Write("Üçüncü sayıyı giriniz: ");
double sayi3 = Double.Parse(Console.ReadLine());
Console.Write("Dördüncü sayıyı giriniz: ");
double sayi4 = Double.Parse(Console.ReadLine());

Console.Write("Ortalama: " + (sayi1+sayi2+sayi3+sayi4)/4);
