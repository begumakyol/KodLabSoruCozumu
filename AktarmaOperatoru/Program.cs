/* Klavyeden kullanıcı tarafından girilen sayıların toplamını, çarpımını ve mod
alma işlemlerini kısaltılmış aktarma opertörleri ile yapan programı yazınız. */

Console.Write("Bir sayı giriniz: ");
int s1 = Int16.Parse(Console.ReadLine());
Console.Write("Bir sayı giriniz: ");
int s2 = Int16.Parse(Console.ReadLine());
s1 += s2;
Console.WriteLine("Toplam: " + s1);

Console.Write("Bir sayı giriniz: ");
int s3 = Int16.Parse(Console.ReadLine());
Console.Write("Bir sayı giriniz: ");
int s4 = Int16.Parse(Console.ReadLine());
s3 *= s4;
Console.WriteLine("Çarpım: " + s3);

Console.Write("Bir sayı giriniz: ");
double s5 = Double.Parse(Console.ReadLine());
Console.Write("Bir sayı giriniz: ");
double s6 = Double.Parse(Console.ReadLine());
s5 %= s6; //s5=s5%s6
Console.WriteLine("Modu: " + s5);