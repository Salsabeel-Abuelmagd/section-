using System;

namespace Salsabeel;
public abstract class Person
{
    public string Name;
    public int Age;

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
    public abstract void Print();
}
public class Student : Person
{
    public int Year;
    public float Gpa;
    public Student(string name, int age, int year, float gpa) : base(name, age)
    {
        Year = year;
        Gpa = gpa;
    }
    public override void Print()
    {
        Console.WriteLine
        ($"Name is: {Name}, Age is: {Age}, Gpa is: {Gpa}");
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
        ($"Name is: {Name}, Age is: {Age}, Salary is: {Salary} , JoinYear is: {JoinYear}");
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
        for (var i = 0; i < _currentIndex; i++)
        {
            People[i].Print();
        }

    }

}

public class Program
{
    private static void Main()
    {
        var database = new Database();

        while(true){
            Console.WriteLine("enter option 1 to add student : 2 to add staff : 3 to print all : 0 to stop");
            Console.Write("option :");
            var option =Convert.ToInt32(Console.ReadLine());
      
        
        switch (option)
        {
            case 0:
                Console.WriteLine("Done !");
                break;

            case 1:
                Console.Write("Name: ");
                var name = Console.ReadLine();

                Console.Write("Age: ");
                var age = Convert.ToInt32(Console.ReadLine());

                Console.Write("Year: ");
                var year = Convert.ToInt32(Console.ReadLine());

                Console.Write("Gpa: ");
                var gpa = Convert.ToInt32(Console.ReadLine());

                var student = new Student(name,age,year,gpa);
                database.AddStudent(student);

                break;

            case 2:
                Console.Write("Name: ");
                var name2 = Console.ReadLine();

                Console.Write("Age: ");
                var age2 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Slary: ");
                var salary = Convert.ToDouble(Console.ReadLine());

                Console.Write("JoinYear: ");
                var joinyear = Convert.ToInt32(Console.ReadLine());

                var staff = new Staff(name2,age2,salary,joinyear);
                database.AddStaff(staff);
                
                break;

            case 3:
                database.PrintAll();
                break;

            default:
                return;

        }       
    }
}
}
