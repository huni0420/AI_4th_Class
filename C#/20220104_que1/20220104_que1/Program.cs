using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20220104_que1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double.TryParse(Console.ReadLine(), out double i);
            Console.WriteLine($"{i}inch = {i*2.54}");
            double.TryParse(Console.ReadLine(), out double r);
            const double PI = 3.14;
            Console.WriteLine($"둘레 = {r * PI}");
            Console.WriteLine($"넓이 = {PI*r*r}");

            int.TryParse(Console.ReadLine(), out int a);
            int.TryParse((string)Console.ReadLine(),out int b);
            Console.WriteLine($"{b}"[0] * a);
            Console.WriteLine($"{b}"[1] * a);
            Console.WriteLine($"{b}"[3] * a);
            Console.WriteLine(a * b);

        }
    }
}
