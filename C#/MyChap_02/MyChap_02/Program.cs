using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyChap_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("안녕하세요");
            Console.WriteLine(Console.ReadLine());

            int a = int.Parse(Console.ReadLine()); // 정수를 입력받는 방법1

            int.TryParse(Console.ReadLine(), out a); // 정수를 입력받는 방법2
            
            int.TryParse(Console.ReadLine(), out int b); // 정수를 입력받는 방법3

            String myname = Console.ReadLine();

            String name = Console.ReadLine();

            //cr,intcr,tryint

            Console.ReadLine();

            int.Parse(Console.ReadLine());

            int.TryParse(Console.ReadLine(), out int ex);
        }
    }
}