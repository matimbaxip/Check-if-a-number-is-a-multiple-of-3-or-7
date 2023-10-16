using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check_if_a_number_is_a_multiple_of_3_or_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a positive number:");
            int number = Convert.ToInt32(Console.ReadLine());

            bool result = IsMultipleOfThreeOrSeven(number);

            Console.WriteLine("Result: " + result);

        }
        static bool IsMultipleOfThreeOrSeven(int number)
        {
            return (number % 3 == 0) || (number % 7 == 0);
        }

    }
}
