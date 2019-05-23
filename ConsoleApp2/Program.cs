using System;

namespace ConsoleApp2
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

            var array1 = new [] { 9, 27, 48, 15 };
            var array2 = new [] { 68, 42, 6, 6, 9, 14 };
            var array3 = new [] { 87, 32, 2, 2, 65 };

            var array1Consecutive = GetConsecutiveNumbers(array1);
            var array2Consecutive = GetConsecutiveNumbers(array2);
            var array3Consecutive = GetConsecutiveNumbers(array3);

            Console.WriteLine($"Does Array 1 contain any consecutive numbers? {array1Consecutive}");
            Console.WriteLine($"Does Array 2 contain any consecutive numbers? {array2Consecutive}");
            Console.WriteLine($"Does Array 3 contain any consecutive numbers? {array3Consecutive}");

            var array1ValueOfNine = GetValueOfNine(array1);
            var array2ValueOfNine = GetValueOfNine(array2);
            var array3ValueOfNine = GetValueOfNine(array3);

            Console.WriteLine($"Does Array 1 contain the number 9? {array1ValueOfNine}");
            Console.WriteLine($"Does Array 2 contain the number 9? {array2ValueOfNine}");
            Console.WriteLine($"Does Array 3 contain the number 9? {array3ValueOfNine}");

            var array1HighestValue = GetHighestValue(array1);
            var array2HighestValue = GetHighestValue(array2);
            var array3HighestValue = GetHighestValue(array3);

            Console.WriteLine($"What is the highest value in Array 1? {array1HighestValue}");
            Console.WriteLine($"What is the highest value in Array 2? {array2HighestValue}");
            Console.WriteLine($"What is the highest value in Array 3? {array3HighestValue}");

            ChangeArrayRange(array1);
            ChangeArrayRange(array2);
            ChangeArrayRange(array3);

            PrintArrayValues(array1);
            PrintArrayValues(array2);
            PrintArrayValues(array3);
        }

        public bool GetConsecutiveNumbers(int[] array)
        {
            int previousNum = array[0];

            for (var i = 1; i < array.GetLength(0); i++)
            {
                if (array[i] == previousNum)
                {
                    return true;
                }

                previousNum = array[i];
            }

            return false;
        }

        public bool GetValueOfNine(int[] array)
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

        public int GetHighestValue(int[] array)
        {
            var highestValue = array[0];

            for (var i = 0; i < array.GetLength(0); i++)
            {
                if (array[i] > highestValue)
                {
                    highestValue = array[i];
                }
            }

            return highestValue;
        }

        public void ChangeArrayRange(int[] array)
        {
            for (var i = 0; i < array.GetLength(0); i++)
            {
                if (array[i] < 5)
                {
                    array[i] = 5;
                }
                else if (array[i] > 40)
                {
                    array[i] = 40;
                }
            }
        }

        public void PrintArrayValues(int[] array)
        {
            for (var i = 0; i < array.GetLength(0); i++)
            {
                Console.Write(array[i] + " ");
            }

            Console.WriteLine();
        }
    }
}
