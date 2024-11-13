using System;
using System.Collections;
using System.Reflection.Emit;
public class Employee{
  string _firstName;
  string _lastName;
  int _age;
  public Employee(string firstName,string lastName,int age){
    this._firstName=firstName;
    this._lastName=lastName;
    this._age=age;
  }
  public override string ToString()
    {
        return $"{_firstName} {_lastName}, Age: {_age}";
    }
}
public class EmployeeCollection: IEnumerable{
  ArrayList arrayList=new ArrayList();
  public void AddEmployee(Employee employee){
    arrayList.Add(employee);
  }
  public Employee GetEmployee(int index){
    return (Employee)arrayList[index];
  }
  public IEnumerator GetEnumerator()
    {
        return arrayList.GetEnumerator();
    }
  static void Main(){
     EmployeeCollection employeeCollection = new EmployeeCollection();

        // Çalışanlar ekleniyor
        employeeCollection.AddEmployee(new Employee("John", "Doe", 30));
        employeeCollection.AddEmployee(new Employee("Jane", "Smith", 25));
        employeeCollection.AddEmployee(new Employee("Bob", "Johnson", 35));

        // Çalışanlar listeleniyor
        Console.WriteLine("Employee List:");
        foreach (Employee employee in employeeCollection)
        {
            Console.WriteLine(employee);
        }
  }
}