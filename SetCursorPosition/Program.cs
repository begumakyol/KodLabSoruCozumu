/* SetCursorPosition metodunu kullanarak ekrana rastgele konumlarda
100 tane * karakterini koyan programı yazınız. */

Random yer = new Random();

Console.SetWindowSize(20,30);

for(int i = 0;i < 100; i++)
{
    int satir = yer.Next(1,19);
    int sutun = yer.Next(1,29);
    Console.SetCursorPosition(satir, sutun);
    Console.WriteLine("*");
    System.Threading.Thread.Sleep(150);
}