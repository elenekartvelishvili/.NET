using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6.Classes
{
    public class Student:IComparable<Student>,IPrintable
    {
        public string Name { get; set; }
        public int Grade { get; set; }

       public Student(string name,int grade) { 
        Name = name;
        Grade = grade;
        }

        public int CompareTo(Student other)
        {

            return this.Grade.CompareTo(other.Grade);
        }

        public void Print()
        {
            Console.WriteLine($"{Name}:{Grade}");
        }

    }
}
