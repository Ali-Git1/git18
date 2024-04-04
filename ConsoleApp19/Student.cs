using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    public class Student:Person
    {
        public bool IsOnline;

        public Student(string name, string surname, int age,bool isonline) : base(name, surname, age)
        {
            IsOnline = isonline;

            
        }
    }
}
