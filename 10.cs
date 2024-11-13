using System;
public class GenericList<T>{
  void Add(T input){}
}
class TestGenericList{
  private class ExampleClass{}
  static void main(){
    GenericList<int> list1=new GenericList<int>();
    GenericList<string> list2=new GenericList<string>();
    GenericList<ExampleClass> list3 = new GenericList<ExampleClass>();
    
  }
}
