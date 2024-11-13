using System;
public class Animal{
  public string Name{get;set;}
  public void Eat(){
  Console.WriteLine($"{Name} is eating");
  }
  public virtual void Make_Sound(){//çok biçimlilik
  Console.WriteLine("Animal class make sound");
  }
public int allthem(int num1,int num2)
{
  Console.WriteLine("3");
  return 0;
  }
  public int allthem(int num1, int num2,int num3)
  {
   return num1 + num2+num3;
 //bir ust sunftaki 3 parametreli metodu base ile cağır
             
 }

public class Dog:Animal{//kalıtım
  public override void Make_Sound()
   {
    Console.WriteLine($"{Name}is barking");
  }
  public Dog(){
  Console.WriteLine("sa knk");
  }
}
class Program{
static void Main(){
Animal an=new Animal();
Dog dg=new Dog();
an.Make_Sound();
an.Eat();
an.allthem(1,2);
dg.Make_Sound();
}
}
}