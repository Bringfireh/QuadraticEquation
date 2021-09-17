using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadraticEquation
{
    class Program
    {
        static void Main(string[] args)
        {
            //The quadratic Equation is in the form aX^2 + bX + c =0
            Console.WriteLine("Enter the value of a");
            string a1 = Console.ReadLine();
            double a = double.Parse(a1);

            Console.WriteLine("Enter the value of b");
            string b1 = Console.ReadLine();
            double b = double.Parse(b1);

            Console.WriteLine("Enter the value of c");
            String c1 = Console.ReadLine();
            double c = double.Parse(c1);

            //The Descriminant of the Equation
            double D = (b * b) - (4 * a * c);
            if (D == 0)
            {
                Console.WriteLine("Descriminant D = " + D);
                Console.WriteLine("The equation is a perfect square");

                double X = -b / (2 * a);
                Console.WriteLine("The value of X =" + X);


            }else if (D < 0)
            {
                Console.WriteLine("Descriminant D = " + D);
                Console.WriteLine("The equation has two Complex roots");

                //The first term is
                double t1 = -b / (2 * a);
                double t2 = Math.Sqrt(-D) / (2 * a);

                string X1 = t1 +"-" + t2 + "i";
                string X2 = t1 + "+" + t2 + "i";
                Console.WriteLine("The value of X1 =" + X1 );
                Console.WriteLine("The value of X2 = " + X2 );


            }
            else if (D > 0)
            {
                double X1 = (-b + Math.Sqrt(D)) / (2 * a);

                double X2 = (-b - Math.Sqrt(D)) / (2 * a);

                Console.WriteLine("The value of X1 =" + X1 );
                Console.WriteLine("The value of X2 = " + X2 );
            }

        }
    }
}
