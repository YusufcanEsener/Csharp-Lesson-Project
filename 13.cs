using System;
using System.Collections;
using System.Collections.Generic;
class Hacim<Tip>{
    public int yukseklik;
    public double hacimBul(){
        double sonuc=0;
        Type yeniTip = typeof(Tip);
        if (yeniTip.Name== "Kare"){
            sonuc=Kare.Alan()*yukseklik;
        }
        else if (yeniTip.Name== "Dikdortgen"){
            sonuc=Dikdortgen.Alan()*yukseklik;
        }
        else if (yeniTip.Name== "üçgen"){
            sonuc=Ucgen.Alan()*yukseklik;
        }
        return sonuc;
    }
}
public class Kare{
    public static int Kenar=10;
    public static double Alan(){
        return Kenar*Kenar;
    }
}
public class Ucgen{
    public static int Kenar=10;
    public static double Alan(){
        return (Kenar*Kenar)/2;
    }
}
public class Dikdortgen{
    public static int Kenar=10;
    public static double Alan(){
        return Kenar*Kenar;
    }
}
class Program{
    static void Main(){
        Console.WriteLine("Hesaplamak istediğin Alan:");
        Console.WriteLine("Kare için 1,Üçgen için 2, Dikdörtgen için 3");
        int secim = int.Parse(Console.ReadLine());
        if(secim ==1){
            Hacim<Kare> hacim = new Hacim<Kare>();
            hacim.yukseklik=10;
            hacim.hacimBul();
        }else if(secim ==2){
            Hacim<Ucgen> hacim = new Hacim<Ucgen>();
            hacim.yukseklik=10;
            hacim.hacimBul();
        }else if(secim ==3){
            Hacim<Dikdortgen> hacim = new Hacim<Dikdortgen>();
            hacim.yukseklik=10;
            hacim.hacimBul();
        }
    }
}