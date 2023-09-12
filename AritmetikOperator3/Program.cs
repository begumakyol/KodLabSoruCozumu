/* Klavyeden kullanıcı tarafında dik kenarları girilen bir üçgenin
alanını ve çevresini bulan programı yazınız. */

Console.Write("Dik üçgene ait bir dik kenar giriniz: ");
int dik1 = Int16.Parse(Console.ReadLine());
Console.Write("Dik üçgene ait ikinci dik kenarı giriniz: ");
int dik2 = Int16.Parse(Console.ReadLine());

double hipo = Math.Sqrt((int)Math.Pow(dik1,2) + (int)Math.Pow(dik2,2));

float alan = (float)(dik1*dik2) / 2;

double cevre = dik1 + dik2 + hipo;

Console.Write("Hipotenüs: {0}, Alanı: {1} , Çevresi: {2}" , hipo, alan, cevre);

