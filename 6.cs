using System;

interface IArayüz{
  void EkranaYaz();
  int Yas{get;set;}
  string isim{get;set;}
}
class Kisiler:IArayüz{
  private int y;
  private string i;
  public Kisiler(){
  y=18;
  i="Yok";
  }
  public Kisiler(string ad,int yas){
  y=yas;
  i=ad;
  }
  public int Yas{
  get{return y;}
  set{y=value;}
  }
  public string isim{
  get{return i;}
  set{i=value;}
  }
  public void EkranaYaz(){
  Console.WriteLine($"Adı:{i} Yaşı:{y}");
  }
}
class Program{
  static void Main(){
  Kisiler kisi=new Kisiler();
  Console.WriteLine("yaş: ",kisi.Yas.ToString());
  Console.WriteLine("ad: ",kisi.isim);
  kisi.EkranaYaz();
  }
}