using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalPrograms
{
    internal class JoggedArray
    {
       static void Main()
        {
            int[][] array = new int[2][];

            array[0] = [4, 6, 1, 8, 6, 7];
            array[1] = [3, 6, 2, 4];


            for (int i=0; i<array.Length; i++)
            {
                Console.Write($"Elements ({i}) :");
             

                for(int j=0; j < array[i].Length; j++)
                {
                    Console.Write("{0}{1}",array[i][j], j == (array[i].Length-1) ? "": " ");
                  
                }
                Console.WriteLine();

            }  
        }
    }
}
