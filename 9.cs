using System;
abstract class Islemler{
  public abstract int DortIslem(int sayi1,int sayi2);
  public int Topla(int sayi1,int sayi2){
  return sayi1+sayi2;
  }
}
class Program:Islemler{
  static void Main(){
  Program p=new Program();
  p.Topla(3,5);
  p.DortIslem(3,5);
  }
  override public int DortIslem(int sayi1,int sayi2) {
  return sayi1*sayi2;
  }
}