using System;
namespace Soso;
public abstract class Person{

    public string Name;
    public int Age;

    public Person(string name, int age ){
        Name=name;
        Age=age;
    }

    public abstract void Print();
}

public class Student :Person{
    public int Year;
    public float Gpa;
    public Student (string name,int age,float gpa ):base(name,age){
        Year=year;
        Gpa=gpa;
    }
    public override void Print(){
        Console.WriteLine($"My name is{Name},my age is{Age},and gpa is {Gpa}");
    }
}
public class Staff : Person
{
    public double Salary;
    public int JoinYear;
    public Staff(string name, int age, double salary, int joinyear) : base(name, age)
    {
        Salary = salary;
        JoinYear = joinyear;
    }
    public override void Print()
    {
        Console.WriteLine
        ($"Name: {Name}, Age: {Age}, Salary: {Salary} , JoinYear : {JoinYear}");
    }

}
  public class Database
{
    private int _currentIndex;
    public Person[] People = new Person[50];
    public void AddStudent(Student student)
    {
        People[_currentIndex++] = student;
    }
    public void AddStaff(Staff staff)
    {
        People[_currentIndex++] = staff;
    }
    public void PrintAll()
    {
        for (int i = 0; i <= _currentIndex; i++)
        {
            Console.WriteLine($"{i + 1} -{People[i]}");
        }

    }

}
