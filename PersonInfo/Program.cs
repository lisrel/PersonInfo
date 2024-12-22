using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonInfo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            Console.Write("Enter Person Name: ");
            person.Name = Console.ReadLine();

            Console.Write("Enter Person's Age: ");
            int age = int.Parse(Console.ReadLine());

            if (age > 0)
            {
                person.Age =age;
            }
            else
            {
                Console.WriteLine("Invalid Age");
            }


            Console.Write("Enter Address: ");
            person.Address = Console.ReadLine();


            Console.Write("Enter Position: ");
            person.Position = Console.ReadLine();

            Console.Write("Enter Department: ");
            person.Department = Console.ReadLine();


            Console.WriteLine("\nPerson Info:");
            person.DisplayPersonInfo();

        }
    }
}
