using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_ThucHanh_KTLT_KeThua
{
    internal class Fraction
    {
        private int numerator;
        private int denominator;

        public int Numerator
        {
            get { return numerator; }
            set { numerator = value; }
        }
        public int Denominator
        {
            get { return denominator; }
            set
            {
                if (value == 0)
                {
                    Console.WriteLine("Invalid denominator value!");
                    denominator = 1;
                }
                else
                    denominator = value;
            }
        }
        public Fraction()
        {
            Numerator = 0;
            Denominator = 1;
        }
        public Fraction(int numerator, int denominator)
        {
            this.Numerator = numerator;
            this.Denominator = denominator;
        }
        public Fraction(int numerator)
        {
            this.Numerator = numerator;
            this.Denominator = 1;
        }

        private int timUCLN(int a, int b)
        {
            while (b != 0)
            {
                int r = a % b;
                a = b;
                b = r;
            }
            return a;
        }
        private void Simplify()
        {
            int uoc = timUCLN(numerator, denominator);
            this.numerator /= uoc;
            this.denominator /= uoc;
        }
        public void Input()
        {
            Console.Write("Enter numerator: ");
            this.Numerator = int.Parse(Console.ReadLine());
            Console.Write("Enter denominator: ");
            this.Denominator = int.Parse(Console.ReadLine());
        }
        public double Decimal()
        {
            return (double)numerator / denominator;
        }
        public virtual string ToString()
        {
            if (denominator < 0)
                return $"{numerator * -1}/{denominator * -1}";
            else
                return $"{numerator}/{denominator}";
        }

        public Fraction Add(Fraction p)
        {
            Fraction kq = new Fraction();
            kq.numerator = this.numerator * p.denominator + this.denominator * p.numerator;
            kq.denominator = this.denominator * p.denominator;
            kq.Simplify();
            return kq;
        }
        public Fraction Subtract(Fraction p)
        {
            Fraction kq = new Fraction();
            kq.numerator = this.numerator * p.denominator - this.denominator * p.numerator;
            kq.denominator = this.denominator * p.denominator;
            kq.Simplify();
            return kq;
        }
        public Fraction Multiply(Fraction p)
        {
            Fraction kq = new Fraction();
            kq.numerator = this.numerator * p.numerator;
            kq.denominator = this.denominator * p.denominator;
            kq.Simplify();
            return kq;
        }
        public Fraction Divide(Fraction p)
        {
            Fraction kq = new Fraction();
            kq.numerator = this.numerator * p.denominator;
            kq.denominator = this.denominator * p.numerator;
            kq.Simplify();
            return kq;
        }
    }
}
