using System;
using System.Collections;

interface IArayüz{
void method();
}
class Sinif:IArayüz{
void IArayüz.method(){
Console.WriteLine("deneme mesajı");
}
}
class Program{
  static void Main(){
  Sinif sinif =new Sinif();
  ((IArayüz)sinif).method();
  }
}