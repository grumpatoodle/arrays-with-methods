using System;

namespace ConsoleApp1
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

            var array1Value = GetArrayValueOfNine(array1);
            var array2Value = GetArrayValueOfNine(array2);
            var array3Value = GetArrayValueOfNine(array3);

            Console.WriteLine($"Does Array 1 contain the number 9? {array1Value}");
            Console.WriteLine($"Does Array 2 contain the number 9? {array2Value}");
            Console.WriteLine($"Does Array 3 contain the number 9? {array3Value}");
        }

        public bool GetArrayValueOfNine(int[] array)
        {
            for (var i = 0; i < array.GetLength(0); i++)
            {
                if (array[i] == 9)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
