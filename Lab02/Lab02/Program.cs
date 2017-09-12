using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02
{
    class Addition
    {
        static void Main()
        {
            int number1;
            int number2;
            int sum;

            Console.Write("Enter first integer: ");
            number1 = int.Parse(Console.ReadLine());

            Console.Write("Enter second integer: ");
            number2 = int.Parse(Console.ReadLine());

            sum = number1 + number2;

            Console.WriteLine($"Sum is {sum}");
            Console.ReadKey();

            int x;
            int y;
            int z;

            Console.Write("Enter x value: ");
            x = int.Parse(Console.ReadLine());

            Console.Write("Enter y value: ");
            y = int.Parse(Console.ReadLine());

            Console.Write("Enter z value: ");
            z = int.Parse(Console.ReadLine());

            sum = (x + y) * (z + 10);

            Console.WriteLine($"Answer is {(x + y)*(z + 10)}");
            Console.ReadKey();

            Console.WriteLine("Hello\tWorld");
            Console.ReadKey();

            Console.WriteLine("Hello\nWorld");
            Console.ReadKey();

            Console.WriteLine("\"Hello World\"");
            Console.ReadKey();

            Console.WriteLine("Hello\\World");
            Console.ReadKey();
        }
    }
}
