using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace findsmallestNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 0, 4, -5, 8, 7, 1 };

            int smallestMissing = 1;

            if (!array.Contains(smallestMissing))
            {
                Console.WriteLine("{0} is the missing number", smallestMissing);
            }

            else
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (!array.Contains(i))
                    {
                        smallestMissing = i;
                        Console.WriteLine("{0} is the missing number", smallestMissing);
                        break;                       
                    }
                }
            }
            Console.Read();
        }
    }
}