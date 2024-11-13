using System;
using System.Collections.Generic;
public class GenericList<T>{//class içinde class var nested class olur
  private class Node{
    public Node(T t){
      next = null;
      data = t;
    }
    private Node next;
    public Node Next{
    get{return next;}
    set{next = value;}
  }
  private T data;
  public T Data{
  get { return data; }
  set{data=value;}
  }
}
  private Node head;
  public GenericList(){
    head=null;
  }
  public void AddHead(T t){
    Node n=new Node(t);
    n.Next = head;
    head= n;
  }
  public IEnumerator<T> GetEnumerator(){
    Node current = head;
    while(current!=null){
      yield return current.Data;
      current = current.Next;
    }
  }
  void Add(T input){}
}

class GenericTestList{
  static void main(){
    GenericList<int> list= new GenericList<int>();
    for(int i=0;i<10;i++){
      list.AddHead(i);
    }
    foreach(int i in list){
    Console.WriteLine("{0}",i);
    }
  }
}