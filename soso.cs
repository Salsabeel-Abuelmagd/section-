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
    public class Database{
    public Person[] People=new Person[50];
    private int currentIndex=0;
    public void AddStudent(Student student){
        People[currentIndex++]=student;
    }
    public void AddStaff(Staff staff){
        People[currentIndex++]=staff;
    }
}
