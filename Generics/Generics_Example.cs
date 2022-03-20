using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Generics_Example
    {
        public static void FindIntMax(int num1, int num2, int num3)
        {
            if (num1.CompareTo(num2) >= 0 && num1.CompareTo(num3) >= 0)
                Console.WriteLine("max num is: " + num1);
            else if (num2.CompareTo(num3) >= 0)
                Console.WriteLine("max num is: " + num2);
            else
                Console.WriteLine("max num is: " + num3);
        }

        public static void GetMax(float firstNumber, float secondNumber, float thirdNumber)
        {
            //// used compareto method
            Console.WriteLine();
            if (firstNumber.CompareTo(secondNumber) > 0 && firstNumber.CompareTo(thirdNumber) > 0)
                Console.WriteLine(firstNumber + ": Is the max float value .");
            if (secondNumber.CompareTo(firstNumber) > 0 && secondNumber.CompareTo(thirdNumber) > 0)
                Console.WriteLine(secondNumber + ": Is the max float value.");
            if (thirdNumber.CompareTo(firstNumber) > 0 && thirdNumber.CompareTo(secondNumber) > 0)
                Console.WriteLine(thirdNumber + ": Is the max float value.");
        }
    }
}
