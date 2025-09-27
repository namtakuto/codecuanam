using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_ThucHanh_KTLT_KeThua
{
    internal class Staff:Person
    {
        private string department;
        private double salary;
        public string Department
        {
            get { return department; }
            set
            {
                if (value != "")
                    this.department = value;
                else
                {
                    this.department = "NoDepartment";
                }
            }
        }
        public double Salary
        {
            get { return salary; }
            set
            {
                if (value >= 0)
                    this.salary = value;
                else 
                    this.salary = 0;
            }
        }
        public Staff() : base()
        {
            this.Department = "NoDepartment";
            this.Salary = 0;
        }
        public Staff(string name, int birthYear, string address, string department, double salary) : base (name, birthYear, address)
        {
            this.Department = department;
            this.Salary = salary;
        }
        public void UpdateSalary(double salary)
        {
            this.Salary = salary;
        }
        public override void Input()
        {
            base.Input();
            Console.Write("Enter department: ");
            this.Department = Console.ReadLine();
            Console.Write("Enter salary: ");
            this.Salary = double.Parse(Console.ReadLine());
        }
        public override string ToString()
        {
            return $"Staff[{base.ToString()}, Department: {department}, Salary: {salary}]";
        }
    }
}
