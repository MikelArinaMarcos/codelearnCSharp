using System;
namespace Codelearn
{
    class Program
    {
        static void Main(string[] args) {
            int num, aux, dec, uni;
            string line;

            Console.Write("Insert a two digit number: ");
            line = Console.ReadLine();

            num = int.Parse(line);
            dec = num / 10;
            uni = num % 10;
            aux = (uni * 10) + dec; 

            Console.WriteLine("The reversed number is: " + aux);
            Console.WriteLine("Press any key.");
            Console.ReadLine();
        }
    }
}