using ConsoleApp6.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Storage<Student> students = new Storage<Student>();

            students.Add(new Student("Alice", 90));
            students.Add(new Student("Bob", 75));
            students.Add(new Student("Charlie", 85));

            students.Print();


            Student min=students.GetMin();


            Console.WriteLine("***************");

            Console.WriteLine("student with lowest grade:");

            min.Print();



            Console.ReadKey();
        }
    }
}
