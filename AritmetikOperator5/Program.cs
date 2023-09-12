/* Klavyeden kullanıcı tarafından TL cinsinden para miktarını, yine kullanıcı
tarafından girilen Euro ve Dolar kuruna göre, TL'nin kaç Euro ve kaç Dolar 
olduğunu bulan programı yazınız. */

Console.Write("TL cinsinden para miktarını giriniz: ");
double p = Double.Parse(Console.ReadLine());
Console.Write("Euro kurunu giriniz: ");
double k1 = Double.Parse(Console.ReadLine());
Console.Write("Dolar kurunu giriniz: ");
double k2 = Double.Parse(Console.ReadLine());

Console.WriteLine("{0} TL = {1} Euro" , p , p/k1);
Console.WriteLine("{0} TL = {1} Dolar" , p , p/k2);
