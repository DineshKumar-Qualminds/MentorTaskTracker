using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentalPrograms
{
    class MultiDimentionalArray
    {
        static void Main()
        {
            //Two dimensional Values
            int[,] multiDimentionalArray1 = new int[2, 3] { { 1, 2, 3 }, { 5, 6, 7 } };


            Console.WriteLine(multiDimentionalArray1[0, 1]);
            Console.WriteLine(multiDimentionalArray1[1, 1]);
            Console.WriteLine(multiDimentionalArray1[0, 0]);
            Console.WriteLine(multiDimentionalArray1[1, 2]);

            Console.WriteLine("\n");

            //Three dimensional Values
            int[,,] multiDimentionalArray2 = new int[3, 4, 2] //3 rows, 4columns, 2 is elements
            {
                { { 1, 2 },{ 2, 3 }, { 3, 4 }, { 4, 5 } },
                { { 2, 3 },{ 4, 6 }, { 7, 8 }, { 9, 10 } },
                { { 10, 12 },{ 15, 16 }, { 17, 18 }, { 19, 20 } }
            };


            Console.WriteLine(multiDimentionalArray2[0, 0, 1]);
            Console.WriteLine(multiDimentionalArray2[0, 1, 1]);
            Console.WriteLine(multiDimentionalArray2[0, 2, 1]);
            Console.WriteLine(multiDimentionalArray2[0, 3, 1]);
            Console.WriteLine(multiDimentionalArray2[1, 3, 1]);
            Console.WriteLine(multiDimentionalArray2[2, 3, 1]);
            Console.WriteLine();

          
            var totalLength = multiDimentionalArray2.Length;
            Console.WriteLine(totalLength);

            var total = 1;
            for (int i = 0; i < multiDimentionalArray2.Rank; i++)
            {
                total *= multiDimentionalArray2.GetLength(i);
            }
            Console.WriteLine(total);
            Console.WriteLine($"{totalLength} equals {total}");

        }
    }
}
