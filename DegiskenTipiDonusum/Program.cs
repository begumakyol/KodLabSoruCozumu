/* Klavyeden girilen iki tam sayıyı (39 ve 5) birbirine bölen ve sonucu
ondalık olarak ekrana yazan programı yazınız. */

int sayi1, sayi2;

Console.Write("İlk sayıyı giriniz: ");
sayi1 = Int16.Parse(Console.ReadLine());

Console.Write("İkinci sayıyı giriniz: ");
sayi2= Int16.Parse(Console.ReadLine());

float bolum = (float)sayi1/ (float)sayi2;

Console.Write("Bölüm: " + bolum);
