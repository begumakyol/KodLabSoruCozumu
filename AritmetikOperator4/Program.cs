/* Klavyeden kullanıcı tarafından yarıçapı girilen bir çemberin alanını
ve çevresini bulan programı yazınız. */

Console.Write("Yarıçap giriniz: ");
int yaricap = Int16.Parse(Console.ReadLine());

double alan = Math.PI * Math.Pow(yaricap, 2);

double cevre = 2 * Math.PI * yaricap;

Console.Write("Alan: {0} , Cevre: {1}" , alan,cevre);