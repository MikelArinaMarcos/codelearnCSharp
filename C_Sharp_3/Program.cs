using System;
namespace Codelearn
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            int age;

            Console.Write("What's your name? ");
            name = Console.ReadLine();

            Console.Write("How old are you? ");
            age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Welcome " + name + "! You are " + age + " years old.");
            Console.WriteLine("Press any key.");
            Console.ReadLine();
        }
    }
}