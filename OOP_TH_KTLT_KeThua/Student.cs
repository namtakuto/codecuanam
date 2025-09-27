using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_ThucHanh_KTLT_KeThua
{
    internal class Student:Person
    {
        private string program;
        private int year;
        public string Program
        {
            get { return program; } 
            set
            {
                if(value != "")
                    this.program = value;
                else
                {
                    Console.WriteLine("Invalid program");
                    this.program = "CNTT";
                }
            }
        }
        public int Year
        {
            get { return year; }
            set
            {
                if (value >= 1900 && value <= DateTime.Now.Year)
                    this.year = value;
                else
                {
                    Console.WriteLine("Invalid year");
                    this.year = DateTime.Now.Year; 
                }
            }
        }
        public Student() : base()
        {
            this.Program = "CNTT";
            this.Year = DateTime.Now.Year;
        }
        public Student(string name, int birthYear, string address, string program, int year):base(name, birthYear, address)
        {
            this.Program = program;
            this.Year = year; 
        }
        public void ChangeProgram(string program)
        {
            this.Program = program;
        }
        public override void Input()
        {
            base.Input();
            Console.Write("Enter program: ");
            this.Program = Console.ReadLine();
            Console.Write("Enter year: ");
            this.Year = int.Parse(Console.ReadLine());
        }
        public override string ToString()
        {
            return $"Student[{base.ToString()}, Program: {program}, Year: {year}]";
        }
    }
}
