using Generic_CollectionsConsoleApp.Models;
using System;
using System.Text.RegularExpressions;

namespace Generic_CollectionsConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {           
            
            Student student = new Student("Mammadov", "Farid", 85)
            {
                Age =30
            };            
            Student student1 = new Student("Elgun", "Quluzade", 50)
            {
                Age = 29
            };
            Student student2 = new Student("Ulvi", "Mecidov", 100)
            {
                Age = 28
            };
            Student student3 = new Student("Loerm", "Ipsum", 15)
            {
                Age = 18
            };
            Groups group1 = new Groups();            
            group1.AddStudent(student);            
            group1.AddStudent(student1);
            group1.AddStudent(student2);
            group1.AddStudent(student3);

            group1.GetAllStudent();
            
            group1.Sort();
            Groups group2 = new Groups();
            Student stud = new Student("test", "testov", 55)
            {
                Age = 20
            };

            Student stud1 = new Student("admin", "adminov", 60)
            {
                Age = 35
            };
            Console.WriteLine(group2.No);
        }
    }
}
