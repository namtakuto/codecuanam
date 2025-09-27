namespace OOP_ThucHanh_KTLT_KeThua
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Student std = new Student();
            //std.Input();
            //Console.WriteLine("---Student---");
            //Console.WriteLine(std.ToString());
            //Staff b = new Staff();
            //b.Input();
            //Console.WriteLine("---Staff---");
            //Console.WriteLine(b.ToString());
            int chon;
            do
            {
                Console.Clear();
                Console.Write("1.Fraction & Fraction\n" +
                    "2.MixedFraction & Fraction\n" +
                    "3.MixedFraction & MixedFraction\n" +
                    "4.End\n" +
                    "Choose: ");
                chon = int.Parse(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        Console.WriteLine("Enter fraction 1");
                        Fraction f1 = new Fraction();
                        f1.Input();
                        Console.WriteLine("Enter fraction 2");
                        Fraction f2 = new Fraction();
                        f2.Input();
                        Console.WriteLine($"{f1.ToString()} + {f2.ToString()} = {f1.Add(f2).ToString()}");
                        Console.WriteLine($"{f1.ToString()} - {f2.ToString()} = {f1.Subtract(f2).ToString()}");
                        Console.WriteLine($"{f1.ToString()} * {f2.ToString()} = {f1.Multiply(f2).ToString()}");
                        Console.WriteLine($"{f1.ToString()} / {f2.ToString()} = {f1.Divide(f2).ToString()}");
                        break;
                    case 2:
                        Console.WriteLine("Enter fraction");
                        Fraction f = new Fraction();
                        f.Input();
                        Console.WriteLine("Enter mixedfraction");
                        Console.WriteLine("Enter Whole: ");
                        int whole = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter numerator: ");
                        int numerator = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter denominator: ");
                        int denominator = int.Parse(Console.ReadLine());
                        MixedFraction mixfraction = new MixedFraction(whole, numerator, denominator);

                        break;
                    case 3:
                        break;
                    default:
                        Console.WriteLine("Goodbye!");
                        return;
                }
                Console.ReadKey();
            }
            while (true);
        }

    }
}

