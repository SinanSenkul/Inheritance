using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Student Ali = new Student("ali", "veli", 1001);
            Ali.NameLog(); //base class method
            Ali.StudentLog(); //student class method
            Teacher Ayşe = new Teacher("ayşe", "mayşe", 25000);
            Ayşe.NameLog();
            Ayşe.TeacherLog();
            
        }
    }
}