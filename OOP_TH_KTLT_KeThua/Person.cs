using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_ThucHanh_KTLT_KeThua
{
    internal class Person
    {
        private string name;
        private int birthYear;
        private string address;
        public string Name
        {
            get { return name; }
            set
            {
                if (value.Length > 3)
                    this.name = value;
                else
                {
                    Console.WriteLine("Invalid name");
                    this.name = "NoName";
                }
            }
        }
        public int BirthYear
        {
            get { return birthYear; }
            set
            {
                if (value >= 1900 && value <= DateTime.Now.Year)
                    this.birthYear = value;
                else
                {
                    Console.WriteLine("Invalid birth year");
                    this.birthYear = 1900;
                }
            }
        }
        public string Address
        {
            get { return address; }
            set
            {
                if (value.Length > 5)
                    this.address = value;
                else
                {
                    Console.WriteLine("Invalid address");
                    this.name = "NoAddress";
                }
            }
        }
        public Person()
        {
            this.Name = "NoName";
            this.BirthYear = 1900;
            this.Address = "NoAddress";
        }
        public Person(string name, int birthYear, string address)
        {
            this.Name = name;
            this.BirthYear = birthYear;
            this.Address = address;
        }
        public virtual void Input()
        {
            Console.Write("Enter name: ");
            this.Name = Console.ReadLine();
            Console.Write("Enter birth year: ");
            this.BirthYear = int.Parse(Console.ReadLine());
            Console.Write("Enter address: ");
            this.Address = Console.ReadLine();
        }
        public int GetAge()
        {
            return DateTime.Now.Year - birthYear;
        }
        public virtual string ToString()
        {
            return $"Person[Name: {name}, Age: {this.GetAge()}, Address: {address}]";
        }
    }
}
