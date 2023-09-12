/* Kullanıcı tarafında girilen dört sayının toplamını ve ortalamasını
bulan programı yazınız. */

int e, f, g, h, top = 0;
float ort;
Console.WriteLine("1. sayıyı giriniz.");
e = Convert.ToInt16(Console.ReadLine());

Console.WriteLine("2. sayıyı giriniz.");
f = Convert.ToInt16(Console.ReadLine());

Console.WriteLine("3. sayıyı giriniz.");
g = Convert.ToInt16(Console.ReadLine());

Console.WriteLine("4. sayıyı giriniz.");
h = Int16.Parse(Console.ReadLine());

top = e + f + g + h;
ort = top / 4;

Console.WriteLine("Toplamları: {0} ", top);
Console.WriteLine("Ortalamaları: " + ort);

/* Klavyeden basılan tuşun ASCII kodunu bulan programı Read
komutunu kullanarak yazınız. */

int x;

Console.WriteLine("Bir tuşa basınız.");
x = Console.Read();

Console.WriteLine("ASCII kodu: " + x);
