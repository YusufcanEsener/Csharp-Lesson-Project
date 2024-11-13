using System;
using Microsoft.VisualBasic;

interface IParentInterface{
  void ParentInterfaceMethod();
}
interface IMyInterface:IParentInterface{
  void methodToImplement();
}
class InterfaceImplementer:IMyInterface{
  static void Main(){
  InterfaceImplementer imp = new InterfaceImplementer();
  imp.methodToImplement();
  imp.ParentInterfaceMethod();
  }
  public void methodToImplement(){
  Console.WriteLine("method to ımplement");
  }
  public void ParentInterfaceMethod(){
  Console.WriteLine("parent ınterface method");
  }
}