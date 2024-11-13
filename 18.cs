using System;
using System.Threading;
delegate void StokAzaldiEventHandler();
class Urun{
    private string ad;
    private int stokMiktari;
    public event StokAzaldiEventHandler StokAzaldi;
    public int StokMiktari{
    get{return stokMiktari;}
    set{stokMiktari=value;
        if(value<=10&& StokAzaldi!=null){
            StokAzaldi();
        }
    }
    }
    public string Ad{
    get{return Ad;}
    set{Ad=value;}
    }
    public Urun(string adi,int stoksayisi){
        Ad=adi;
        StokMiktari=stoksayisi;
    }
}
class Program{
    static void Main(){
        Urun urun=new Urun("un",23);
        urun.StokAzaldi += new StokAzaldiEventHandler(sevdi);
        for(int i=0;i<10;i++){
            urun.StokMiktari-=2;
            Thread.Sleep(1000);
            Console.WriteLine(urun.Ad+urun.StokMiktari.ToString());
            Console.Read();
        }
    }
    static void sevdi(){
        Console.WriteLine("Toptancıyı çağır batıyoruz");
    }    
}