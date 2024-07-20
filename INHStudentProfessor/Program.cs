using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INHStudentProfessor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Student(1, "101 Moanrch Elegance", new DateTime(2003, 5, 04), "Computer Science");
            Console.WriteLine(((Student)person).PrintDetails());
            Person person1 = new Student(2, "301 Oriental Heights", new DateTime(2004, 12, 12), "Electrical");
            Console.WriteLine(((Student)person1).PrintDetails());
            Person person2 = new Professor(10, "1201 Greenscape tricity", new DateTime(1990, 8, 21), 6000);
            Console.WriteLine(((Professor)person2).PrintDetails());
            Person person3 = new Professor(20, "503 Gokuldham society", new DateTime(1985, 9, 15), 6500);
            Console.WriteLine(((Professor)person3).PrintDetails());
        }

      
        
    }
}
