using System;
//delegate ve event /temsilci/olaylar
//erişim_belirteci delegate methodun_geri_dönüş_tip_değeri=>delegate in imzasını belirler(hangi eventi tetikleneceğini belirler)
//delegate_ismi(methodun parametreleri)=>delegate in imzasını belirler(hangi eventi tetikleneceğini belirler) invoke var ise delegate vardır
delegate int Temsilci(int x);
class Program{
    static int kupal(int sayi){
        return sayi*sayi*sayi;
    }
    static int kareal(int sayi){
        return sayi*sayi;
    }
    static void Main(){
        Temsilci te=new Temsilci(kupal);
        te+= new Temsilci(kupal);
        //te-=new Temsilci(kupal);
        Temsilci tem=new Temsilci(kareal);
        Console.WriteLine(te.Invoke(3));
        Console.WriteLine(tem.Invoke(6));
    }
}
