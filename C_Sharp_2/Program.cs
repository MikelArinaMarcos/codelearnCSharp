using System;
namespace Codelearn
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, result;
            string line;

            Console.Write("Insert first number: ");
            line = Console.ReadLine();

            num1 = int.Parse(line);

            Console.Write("Insert second number: ");
            line = Console.ReadLine();

            num2 = int.Parse(line);

            result = (num1 + num2);
            Console.WriteLine("The sum of " + num1 + " and " + num2 + " is " + result);
            result = (num1 - num2);
            Console.WriteLine("The substraction of " + num1 + " and " + num2 + " is " + result);
            result = (num1 * num2);
            Console.WriteLine("The multiplication of " + num1 + " and " + num2 + " is " + result);
            result = (num1 / num2);
            Console.WriteLine("The division of " + num1 + " and " + num2 + " is " + result);
            result = (num1 % num2);
            Console.WriteLine("The modulus of " + num1 + " and " + num2 + " is " + result);
            Console.WriteLine("Press any key.");
            Console.ReadLine();
        }
    }

}