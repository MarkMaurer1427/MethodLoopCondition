using System;

namespace MethodsWithLoopsAndConditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            //PrintCascade();
            //Count3();
            //Console.WriteLine(IsEqual(10, 10));
            //Console.WriteLine(IsEqual(10, 17));
            //PosNeg();
            //EvenOdd();
            //InRange();
            //TimesTables();
        }

        public static void PrintCascade()
        {
            for (int i = 1000; i > -1000; i--)
            {
                Console.WriteLine(i);
            }

            for (int i = -1000; i <= 1000; i++)
            {
                Console.WriteLine(i);
            }
        }

        public static void Count3()
        {
            for (int i = 3; i <= 999; i += 3) 
            {
                Console.WriteLine(i);
            }
        }

        public static string IsEqual(int input1 , int input2)
        {
            int in1 = input1;
            int in2 = input2;
            string isEqual = "These are equal.";
            string isNotEqual = "These are not equal.";
            string output = (in1 == in2 ? isEqual : isNotEqual);
            return output;
        }

        public static void PosNeg()
        {
            int checkNum;
            Console.Write("Input a number: ");
            checkNum = int.Parse(Console.ReadLine());

            var output1 = "This number is positive.";
            var output2 = "This number is negative.";
            var output3 = "You entered in zero....";

            if (checkNum > 0) Console.WriteLine(output1);
            else if (checkNum < 0) Console.WriteLine(output2);
            else if (checkNum == 0) Console.WriteLine(output3);

        }

        public static void EvenOdd() 
        {
            int checkNum;
            Console.Write("Input a number: ");
            checkNum = int.Parse(Console.ReadLine());

            var output1 = "This number is odd.";
            var output2 = "This number is even.";
            var output3 = "You entered in zero....";

            if (checkNum == 0) Console.WriteLine(output3);
            else if (checkNum % 2 == 0) Console.WriteLine(output2);
            else Console.WriteLine(output1);

        }

        public static void InRange()
        {
            int checkNum;
            Console.Write("Input a number: ");
            checkNum = int.Parse(Console.ReadLine());

            bool inRange = (checkNum >= -10 && checkNum <= 10);
            var output1 = "This number is in range between -10 and 10.";
            var output2 = "This number is not in range between -10 and 10.";

            Console.WriteLine((inRange ? output1 : output2));
        }

        public static void TimesTables()
        {
            int inputNum;
            Console.Write("Input a number: ");
            inputNum = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine($"{inputNum} * {i} = {inputNum * i}");
            }
        }

    }


}
