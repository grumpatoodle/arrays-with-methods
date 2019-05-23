using System;

namespace ConsoleApp4
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

            Random rnd = new Random();
            int attackValue = rnd.Next(1, 40);
            Console.WriteLine(attackValue);

            int attackValue2 = rnd.Next(1, 40);
            Console.WriteLine(attackValue2);

            int attackValue3 = rnd.Next(1, 40);
            Console.WriteLine(attackValue3);

            int attackValue4 = rnd.Next(1, 40);
            Console.WriteLine(attackValue4);

            int attackValue5 = rnd.Next(1, 40);
            Console.WriteLine(attackValue5);

            int attackValue6 = rnd.Next(1, 40);
            Console.WriteLine(attackValue6); 
        }
    }
}
