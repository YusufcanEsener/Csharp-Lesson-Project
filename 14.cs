using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        // 81 il listesi
        List<string> iller = new List<string>
        {
            "Adana", "Adıyaman", "Afyonkarahisar", "Ağrı", "Amasya", "Ankara", "Antalya", "Artvin", "Aydın",
            "Balıkesir", "Bilecik", "Bingöl", "Bitlis", "Bolu", "Burdur", "Bursa", "Çanakkale", "Çankırı", "Çorum",
            "Denizli", "Diyarbakır", "Edirne", "Elazığ", "Erzincan", "Erzurum", "Eskişehir", "Gaziantep", "Giresun",
            "Gümüşhane", "Hakkâri", "Hatay", "Isparta", "İçel", "İstanbul", "İzmir", "Kars", "Kastamonu", "Kayseri",
            "Kırklareli", "Kırşehir", "Kocaeli", "Konya", "Kütahya", "Malatya", "Manisa", "Kahramanmaraş", "Mardin",
            "Muğla", "Muş", "Nevşehir", "Niğde", "Ordu", "Rize", "Sakarya", "Samsun", "Siirt", "Sinop", "Sivas",
            "Tekirdağ", "Tokat", "Trabzon", "Tunceli", "Şanlıurfa", "Uşak", "Van", "Yozgat", "Zonguldak", "Aksaray",
            "Bayburt", "Karaman", "Kırıkkale", "Batman", "Şırnak", "Bartın", "Ardahan", "Iğdır", "Yalova", "Karabük",
            "Kilis", "Osmaniye", "Düzce"
        };

        Stopwatch stopwatch = new Stopwatch();

        // List
        stopwatch.Start();
        List<string> list = new List<string>();
        foreach (var il in iller)
        {
            list.Add(il);
        }
        stopwatch.Stop();
        Console.WriteLine("Liste Ekleme Süresi: " + stopwatch.ElapsedMilliseconds + " ms");

        stopwatch.Reset();

        stopwatch.Start();
        foreach (var il in iller)
        {
            list.Remove(il);
        }
        stopwatch.Stop();
        Console.WriteLine("Liste Çıkarma Süresi: " + stopwatch.ElapsedMilliseconds + " ms");

        // Queue
        stopwatch.Reset();

        stopwatch.Start();
        Queue<string> queue = new Queue<string>(iller);
        stopwatch.Stop();
        Console.WriteLine("Queue Ekleme Süresi: " + stopwatch.ElapsedMilliseconds + " ms");

        stopwatch.Reset();

        stopwatch.Start();
        while (queue.Count > 0)
        {
            queue.Dequeue();
        }
        stopwatch.Stop();
        Console.WriteLine("Queue Çıkarma Süresi: " + stopwatch.ElapsedMilliseconds + " ms");

        // ArrayList
        stopwatch.Reset();

        stopwatch.Start();
        ArrayList arrayList = new ArrayList(iller);
        stopwatch.Stop();
        Console.WriteLine("ArrayList Ekleme Süresi: " + stopwatch.ElapsedMilliseconds + " ms");

        stopwatch.Reset();

        stopwatch.Start();
        foreach (var il in iller)
        {
            arrayList.Remove(il);
        }
        stopwatch.Stop();
        Console.WriteLine("ArrayList Çıkarma Süresi: " + stopwatch.ElapsedMilliseconds + " ms");

        // Stack
        stopwatch.Reset();

        stopwatch.Start();
        Stack<string> stack = new Stack<string>(iller);
        stopwatch.Stop();
        Console.WriteLine("Stack Ekleme Süresi: " + stopwatch.ElapsedMilliseconds + " ms");

        stopwatch.Reset();

        stopwatch.Start();
        while (stack.Count > 0)
        {
            stack.Pop();
        }
        stopwatch.Stop();
        Console.WriteLine("Stack Çıkarma Süresi: " + stopwatch.ElapsedMilliseconds + " ms");

        Console.ReadLine();
    }
}
