using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Student Ali = new Student("ali", "veli", 1001);
            Ali.StudentLog();
            Teacher Ayşe = new Teacher("ayşe", "mayşe", 25000);
            Ayşe.TeacherLog();
        }
    }
}