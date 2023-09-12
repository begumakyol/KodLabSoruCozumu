/* Klavyeden kullanıcı tarafından girilen iki sayı için AND, OR, XOR mantıksal
operatörlerini kullanarak elde edilen sonuçları ekrana yazdıran programı yazınız.*/

Console.Write("Bir sayı giriniz: ");
int s1 = Int16.Parse(Console.ReadLine());
Console.Write("Bir sayı giriniz: ");
int s2 = Int16.Parse(Console.ReadLine());

Console.WriteLine("{0} & {1} = {2}" , s1, s2, s1&s2);
Console.WriteLine("{0} | {1} = {2}" , s1, s2, s1|s2);
Console.WriteLine("{0} ^ {1} = {2}" , s1, s2, s1^s2);