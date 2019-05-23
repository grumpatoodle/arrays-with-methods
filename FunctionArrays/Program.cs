using System;

namespace FunctionArrays
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
        // function
        public void StartHere()
        {
            var answer1 = PythagoreanTheorem(2, 4);
            var answer2 = PythagoreanTheorem(1, 3);
            var answer3 = PythagoreanTheorem(5, 45);
            var answer4 = PythagoreanTheorem(1, 12);

            var stringArray = ChangeThreeStringsIntoArray("Dog", "Cat", "Bird");
        }

        public double PythagoreanTheorem(int a, int b)
        {
            var cSquared = a ^ 2 + b ^ 2;
            var c = Math.Sqrt(cSquared);
            return c;
        }

        public string[] ChangeThreeStringsIntoArray(string s1, string s2, string s3)
        {
            var arrayToReturn = new string[] {s1, s2, s3};
            return arrayToReturn;
        }
    }
}
