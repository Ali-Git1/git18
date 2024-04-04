using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task1
            //Employee employeev = new Employee("Namiq", true, 1000);


            //Manager manager=new Manager("Namiq", true, 1000);
            ////manager.GetPromotion(employeev);
            ////manager.GetMinusPromotion(employeev);

            //Asisstant asisstant = new Asisstant("Namiq", true, 1000);
            //Console.WriteLine(employeev.Salary);

            //asisstant.GetFeedBack(employeev);

            //Console.WriteLine(employeev.Salary);
            #endregion

            #region Task2

            Student[] student = new Student[]
            {
            new Student("ELi","Eliyev",23,true),
            new Student("Mehman","Eliyev",24,false),
            new Student("Cavid","Huseyinli",34,false),
            new Student("Ceyhun","Eliyev",21,true),

            };

            Group group = new Group("C#", student);

            group.GetAll();
            group.GetOnlineStudents();
            group.GetOfflineStudents();
            #endregion

        }
    }
}
