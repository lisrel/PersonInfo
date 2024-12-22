using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonInfo
{
    internal class Person
    {
        private string name;    
        private int age;
        private string address;
        private string position;
        private string department;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get {
                return age;
            }
            set {
                if (value >= 0){  
                    age = value;
                }
                else
                {
                    Console.WriteLine("Age can not be negative");
                }
            }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public string Position
        {
            get { return position; }
            set { position = value; }
        }

        public string Department
        {
            get { return department; }
            set { department = value; }
        }

        public void DisplayPersonInfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Address: {Address}");
            Console.WriteLine($"Position: {Position}");
            Console.WriteLine($"Department: {Department}");
        }
    }
}
