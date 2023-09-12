/* Klavyeden kulllanıcı tarafından girilen iki sayının toplamını,
  farkını, çarpımını, bölümünü ve mod alma işlemini yapan 
  programı yazınız. */

Console.Write("Bir sayı giriniz: ");

double sayi1 = Double.Parse(Console.ReadLine());

Console.Write("Bir sayı giriniz: ");

double sayi2 = Double.Parse(Console.ReadLine());

Console.WriteLine("{0} + {1} = {2}" , sayi1, sayi2, sayi1+sayi2);
Console.WriteLine("{0} - {1} = {2}" , sayi1, sayi2, sayi1-sayi2);
Console.WriteLine("{0} x {1} = {2}" , sayi1, sayi2, sayi1*sayi2);
Console.WriteLine("{0} / {1} = {2}" , sayi1, sayi2, sayi1/sayi2);
Console.WriteLine("{0} % {1} = {2}" , sayi1, sayi2, sayi1%sayi2);

