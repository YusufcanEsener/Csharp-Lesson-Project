using System;
//delegate ve event /temsilci/olaylar
//erişim_belirteci delegate methodun_geri_dönüş_tip_değeri=>delegate in imzasını belirler(hangi eventi tetikleneceğini belirler)
//delegate_ismi(methodun parametreleri)=>delegate in imzasını belirler(hangi eventi tetikleneceğini belirler) invoke var ise delegate vardır
delegate void Temsilci();
class Program{
    static void Test(){
        Console.WriteLine("method çalıştı");
        Console.ReadLine();
    }
    static void Main(){
        Temsilci te=new Temsilci(Test);
        te.Invoke();
    }
}

