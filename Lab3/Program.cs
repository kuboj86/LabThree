using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Please enter a number");
                string input = Console.ReadLine();
                int num;
                bool success = int.TryParse(input, out num);
                if (!success)
                {
                    Console.WriteLine("That input is not a number.");
                }
                Console.WriteLine("Number\tSquared\tCubed");
                Console.WriteLine("=======\t=======\t=======");
                for (int x = 1; x <= num; x++)
                {
                    MakeTable(x);
                }
            }
        }
        static void MakeTable(int input)
        {
            for (int power = 1; power <= 3; power++)
            {
                double output = Math.Pow(input, power);
                Console.Write($"{output}\t");
            }
            Console.WriteLine();
        }
    }
}

