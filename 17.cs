using System;

delegate void Sayi();

class Program
{
    static void Ust()
    {
        Console.WriteLine("50 üstü ");
    }

    static void Alt()
    {
        Console.WriteLine("50 altı");
    }

    static void Main()
    {
        Random rastgele = new Random();
        int sayi = rastgele.Next(0, 100);
       

        if (sayi >= 50)
        {
            Sayi sayi1=new Sayi(Ust);
            sayi1.Invoke();
        }
        else
        {
            Sayi sayi1=new Sayi(Alt);
            sayi1.Invoke();
        }
        Console.WriteLine("Seçilen Sayı: " + sayi);
    }
}
