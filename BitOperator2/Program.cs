/* Klavyeden kullanıcı tarafından girilen iki sayının toplamını sağa 3 ve sola
4 bit öteleme operatörlerini kullanarak elde edilen sonuçları ekrana yazdıran
programı yazınız. */

Console.Write("Bir sayı giriniz: ");
int s1 = Int16.Parse(Console.ReadLine());
Console.Write("Bir sayı giriniz: ");
int s2 = Int16.Parse(Console.ReadLine());

int toplam = s1 + s2;

Console.WriteLine("Toplamlarının sağa 3 bit ötelenmiş hali: " + (toplam>>3));
Console.Write("Toplamlarının sola 4 bit ötelenmiş hali: " + (toplam<<4));