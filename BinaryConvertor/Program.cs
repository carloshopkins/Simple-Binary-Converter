using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryConvertor
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] testArray = new int[8] { 1, 0, 1, 0, 0, 1, 1, 1 };
            Console.WriteLine(BinaryConvertor(testArray));
        }
        static int BinaryConvertor(int[] input)
        {
            //Reversing the array makes it easier to compare the values to the binaryValues array
            //This is particularly useful when you don't know the number of values in the array.
            input.Reverse();
            var binarySum = 0;

            //This array holds the value of binary numbers in reverse
            int[] binaryValues = new int[12] { 1, 2, 4, 8, 16, 32, 64, 128, 256, 512, 1024, 65536 };
            for (int i = 0; i < input.Length; i++)
            {
                //Check if the bit is turned on. If it is the corresponding index from binaryValues is added to binarySum
                if (input[i] == 1)
                    binarySum += binaryValues[i];
            }
            return binarySum;
        }
    }
}
