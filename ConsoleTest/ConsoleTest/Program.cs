using System;

namespace ConsoleTest
{

    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Hello");
            Console.WriteLine("This job is awesome");
        }
    }
    //---------------------------------------------------------------------------------
    class calculatorExercise
    {
        static void Main()
        {
            int x = 5;
            int y = 6;
            int z = x + y;
            Console.WriteLine(z);
        }
    }
    //-----------------------------------------------------------------------------------
    class calculatorDivide
    {
        static void Main()
        {
            int x = 10;
            int y = 2;
            int z = x / y;
            Console.WriteLine(z);
        }
    }
    //------------------------------------------------------------------------------------
    class calculatorMathProblems
    {
        static void Main()
        {
            Console.WriteLine(-1 + 4 * 6);
            Console.WriteLine((35 + 5) % 7);
            Console.WriteLine(14 + -4 * 6 / 11);
            Console.WriteLine(2 + 15 / 6 * 1 - 7 % 2);
        }
    }
    //------------------------------------------------------------------------------------
    class ifStatement
    {
        public static void Main()
        {
            int x = 5;
            if (x == 5)
            {
                Console.WriteLine("this is how bad i am at if else statements");
            }
        }
    }
    //------------------------------------------------------------------------------------
    class ifStatement2
    {
        public static void Main()
        {
            int number = 200;

            if (number >= 200)
            {
                Console.WriteLine("Awesome");
            }
            else
            {
                Console.WriteLine("No bueno");
            }

        }
    }
    //--------------------------------------------------------------------------------------

}
