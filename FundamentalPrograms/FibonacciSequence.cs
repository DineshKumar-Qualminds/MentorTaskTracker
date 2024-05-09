using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalPrograms
{
    internal class FibonacciSequence
    {
        static void Main()
        {
           

            int x;
            do
            {
                Console.Write("Enter countervalue upto you get FibonaaciSeries : ");

                if (!int.TryParse(Console.ReadLine(), out x))
                {
                    Console.WriteLine("Invalid Input,Enter Valid Input");
                }

            } while (x == 0);
            Console.WriteLine();

            Console.WriteLine("FibonacciSequence : ");

            for (int i = 0; i < x; i++)
            {

                Console.Write(fibonacciSequence(i) + " ");
            }
            Console.ReadLine() ;



        }
    
        static int fibonacciSequence(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            else if (n == 1)
            {
                return 1;
            }
            else
            {
                return fibonacciSequence(n -1) + fibonacciSequence(n-2);
            }
        }
    
    }
}