using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arithmetic_Operations
{
    class Multiplication
    {
        public static void Multiply()
        {
            int firstNumber = 0, secondNumber = 0;

            Console.WriteLine("Enter 1st Value : ");
            firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd Value : ");
            secondNumber = Convert.ToInt32(Console.ReadLine());

            int result = firstNumber * secondNumber;
            Console.WriteLine("Multplication of {0} & {1} is : {2}", firstNumber, secondNumber, result);
        }

    }
}
