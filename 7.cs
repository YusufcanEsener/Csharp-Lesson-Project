using System;
//abstract classlar en az 1 tane gövdesiz abstract class içermeli
abstract class Calisan{
  public string pozisyon ="Çalışan";
  public abstract void calis();//gövdesiz
  public void ZamIste(){
  Console.WriteLine("Asgeri ücret ne kadar olmalı?");
  }
}
public class Mudur:Calisan{
  public Mudur(){
  pozisyon="Mudur";
  }
  public override void calis(){
  Console.WriteLine("Müdür çalışıyor");
  }
}
public class Yazilimci:Calisan{
  public Yazilimci(){
  pozisyon="Yazılımcı";
  }
  public override void calis()
  {
    Console.WriteLine("Yazılımcı çalışıyor");
  }
  public void ZamIste(){
  Console.WriteLine("Yazılımcı zam istiyor");
  }
}
public class Program{
  static void Main(){
  Calisan[] c = new Calisan[2];
  c[0] = new Mudur();
  c[1] = new Yazilimci();
  MesaiBasla(c);
  Console.ReadKey();
  }
  static void MesaiBasla(Calisan[] c){
  for(int i=0;i<c.Length;i++){
    c[i].calis();
    }
  }
}