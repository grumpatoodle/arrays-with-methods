using System;

namespace ConsoleApp3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var realProgram = new MyActualProgram();
            realProgram.StartHere();
        }
    }

    public class MyActualProgram
    {
        public void StartHere()
        {
            var thisVariableShouldNeverBeUsed = "PUT A BREAK POINT ON THIS LINE AND DEBUG EVERY THING YOU EVER DO";

            int[] array1 = new int[] { 9, 27, 15 };
            int[] array2 = new int[] { 68, 42, 6, 9, 14 };
            int[] array3 = new int[] { 87, 32, 2, 65, 12, 8, 78, 42, 1 };

            var array1Largest = GetLargestValueInArray(array1);
            var array2Largest = GetLargestValueInArray(array2);
            var array3Largest = GetLargestValueInArray(array3);

            Console.WriteLine($"The largest value is: {array1Largest}");
            Console.WriteLine($"The largest value is: {array2Largest}");
            Console.WriteLine($"The largest value is: {array3Largest}");
        }

        public int GetLargestValueInArray(int[] array)
        {
            int largestValue = array[0];

            for (var i = 0; i < array.GetLength(0); i++)
            {
                if (array[i] > largestValue)
                {
                    largestValue = array[i];
                }
            }

            return largestValue;
        }
    }
}
