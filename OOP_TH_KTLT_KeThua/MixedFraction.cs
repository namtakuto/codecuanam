using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_ThucHanh_KTLT_KeThua 
{
    internal class MixedFraction:Fraction
    {
        public MixedFraction() : base() { }
        public MixedFraction(int wholePart, int numerator, int denominator)
        {
            this.Numerator = wholePart * denominator + numerator;
            this.Denominator = denominator;
        }
        public MixedFraction(Fraction f)
        {
            this.Numerator = f.Numerator;
            this.Denominator = f.Denominator;
        }
        public override string ToString()
        {
            int whole = this.Numerator / this.Denominator;
            int t = this.Numerator % this.Denominator;
            return whole + "[" + t + "/" +this.Denominator + "]";
        }
    }
}
