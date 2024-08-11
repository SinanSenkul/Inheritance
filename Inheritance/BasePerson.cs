using System;
using System.Xml.Linq;

public class BasePerson
{
    string Name { get; set; }
    string LastName { get; set; }
    public void NameLog()
    {
        Console.WriteLine($"name: {Name} lastname: {LastName}");
    }
}

//derived class
public class Student : BasePerson
{
    string Name { get; set; }
    string LastName { get; set; }
    int StudentNumber { get; set; }
    public Student(string name, string lastName, int studentNumber)
    {
        Name = name;
        LastName = lastName;
        StudentNumber = studentNumber;
    }
    public void StudentLog()
    {
        Console.WriteLine($"student's number: {StudentNumber} name: {Name} lastname: {LastName}");
    }
}

public class Teacher : BasePerson
{
    string Name { get; set; }
    string LastName { get; set; }
    int Salary { get; set; }
    public Teacher(string name, string lastName, int salary)
    {
        Name = name;
        LastName = lastName;
        Salary = salary;
    }
    public void TeacherLog()
    {
        Console.WriteLine($"teacher's name: {Name} lastname: {LastName} salary:{Salary}");
    }
}
