using Enum;

Console.ForegroundColor=ConsoleColor.Red;
Console.WriteLine("merhaba");

    Thread.Sleep(100);
for (int i = 0; i < 15; i++)
{
    Console.ForegroundColor =(ConsoleColor)i;
    Console.WriteLine("deneme");
}

Depo depo = new Depo();
depo.Hareket = DepoHareketleri.Iade;
Console.WriteLine((int)DepoHareketleri.Fire);