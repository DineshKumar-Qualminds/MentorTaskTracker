using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalPrograms
{
    class LeftAngleTriangle
    {
     static void Main()
        {
           
            int x;
            do
            {
                Console.Write("Enter value based on size of triangle depends : ");
             
                if (!int.TryParse(Console.ReadLine(), out x))
                {
                    Console.WriteLine("Invalid Input Value,Enter Valid Number");
                }

            }while(x==0);
            Console.WriteLine("\n");

            for (int i = 1; i <=x; i++)
            {
               for(int j = 1; j <= x-i; j++)
                {
                    Console.Write(" ");
                }
               for(int k = 1; k <=i; k++)
                {
                    Console.Write("*");
                }
               Console.WriteLine();
            
            }
          
        }
       
    }
}
