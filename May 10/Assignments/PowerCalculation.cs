using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{

    class Power
    {
        public int power(int Base, int Exponent)
        {

            int res = 1;

            if (Exponent>0)
            {
                for (int i = 0; i < Exponent; i++)
                {
                    res *= Base;
                }
            }
            else
            {
                return 0;
            }

            return res;
        }

        public double power(double Base, double Exponent)
        {
            double res = Math.Pow(Base, Exponent);

            return res;
        }
    }

    class PRogrammain : Power
    {

        static void Main()
        {

            Power p = new Power();

            int res1 =  p.power(2, 3);

            double res2 = p.power(5.5, 2);

            Console.WriteLine($"The power of two integer numbers:{res1}");


            Console.WriteLine($"The power of two Decimal numbers:{res2}");

        }
       
    }
}
    