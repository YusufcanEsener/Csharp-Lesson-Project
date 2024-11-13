using System;

interface IArayüz1{
  int metot1();
}
interface IArayüz2{
  string metot2();
}
interface IArayüz3:IArayüz1,IArayüz2{
  new int metot1();//adı aynı ama farklı method
  double metot3();
}
class Program:IArayüz3{
  int IArayüz.metot1(){
  }
  int IArayüz3.metot1(){
  }
}