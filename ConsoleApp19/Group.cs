using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    public class Group
    {
        public string GroupName;

        Student[] students;

        public Group(string groupName, Student[] student)
        {
            GroupName = groupName;
            students = student;

        }


        public void GetAll()
        {
            foreach(var item in students)
            {
                Console.WriteLine(item.Name);
                Console.WriteLine(item.SurName);
                Console.WriteLine(" - - - - - - ");
            }
        }

        public void GetOnlineStudents()
        {
            foreach (var item in students)
            {
                if (item.IsOnline)
                {
                    Console.WriteLine(item.Name);
                    Console.WriteLine(item.SurName);
                    Console.WriteLine(" - - - - - - ");

                }
            }
        }


        public void GetOfflineStudents()
        {
            foreach (var item in students)
            {
                if (!item.IsOnline)
                {
                    Console.WriteLine(item.Name);
                    Console.WriteLine(item.SurName);
                    Console.WriteLine(" - - - - - - ");

                }
            }
        }
    }
}
