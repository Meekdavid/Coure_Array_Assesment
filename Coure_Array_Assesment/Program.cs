using System;

namespace CoreTech_Array_Assesment
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //Test the implementation
            int[] arrayTest1 = { 1, 2, 3, 4, 5 };
            int[] arrayTest2 = { 15, 25, 35 };
            int[] arrayTest3 = { 8, 8 };

            Console.WriteLine($"Output 1: {ArraySumOfIntegers(arrayTest1)}");
            Console.WriteLine($"Output 2: {ArraySumOfIntegers(arrayTest2)}");
            Console.WriteLine($"Output 3: {ArraySumOfIntegers(arrayTest3)}");
        }

        public static int ArraySumOfIntegers(int[] theArray)
        {
            int totalSum = 0;

            for (int i = 0; i < theArray.Length; i++)
            {
                if (theArray[i] % 2 == 0)//Add one to the sum for any even number
                {
                    totalSum += 1;
                    if (theArray[i] == 8) totalSum += 5; //If the integer is 8, Add 5 to the sum

                }
                else
                {
                    //If the integer is an odd number
                    totalSum += 3;
                }
            }

            return totalSum;
        }
    }
}
