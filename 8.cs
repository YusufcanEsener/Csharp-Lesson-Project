using System;
abstract class Insan{
  public abstract void SelamVer();
}
class Ingılız:Insan{
    public override void SelamVer(){
    Console.WriteLine("hello");
    }
}
class Program{
  static void Main(){
  Ingılız I= new Ingılız();
  I.SelamVer();
  }
}