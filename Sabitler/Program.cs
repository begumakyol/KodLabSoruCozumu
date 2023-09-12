/* Tam biletin fiyatı 10 tl, öğrenci biletinin fiyatı 7 tl olan bir sinema 
salonuna giden 3 çocuklu bir ailenin (anne-baba ve 3 çocuk) ödemesi gereken
toplam ücreti bulan programı giriniz. (Bilet fiyatları programa sabit olarak
girilecektir.) */

int tamBilet = 10;
int ogrenciBilet = 7;

int tamAdet, ogrenciAdet, toplam;

Console.Write("Tam bilet alacak kişi sayısını giriniz: ");
tamAdet = Int32.Parse(Console.ReadLine());

Console.Write("Öğrenci bileti alacak kişi sayısını giriniz: ");
ogrenciAdet = Int32.Parse(Console.ReadLine());

toplam = (tamAdet * tamBilet) + (ogrenciAdet * ogrenciBilet);

Console.WriteLine("Toplam tutar: " + toplam + " tl");