using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCSharp_20220105
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("몇 인치?");
            int myinch = int.Parse(Console.ReadLine());
            Console.WriteLine($"{myinch}inch = {myinch*2.54}cm");
            Console.WriteLine("몇 kg");
            int mykg = int.Parse(Console.ReadLine());
            const double pound = 2.20462262;
            //Console.WriteLine($"{mykg}kg = {mykg*pound}pound");
            int ct = Console.CursorTop;
            int cl = Console.CursorLeft;
            Console.SetCursorPosition(cl+mykg.ToString().Length,ct-1);
            Console.WriteLine($"kg = {mykg * pound}pound");

            const double PI = 3.14;
            Console.WriteLine("원의 반지름 입력받아 원의 둘레와 넓이 구하기");
            int.TryParse(Console.ReadLine(), out int r);
            Console.WriteLine($"둘레 = {2 * PI * r}");
            Console.WriteLine($"넓이 = {PI*r*r}");

            Console.WriteLine("첫 번째 숫자를 입력해주세요");
            int.TryParse(Console.ReadLine(),out int first);
            Console.WriteLine("두 번째 숫자를 입력해주세요");
            int.TryParse(Console.ReadLine(),out int second);
            Console.WriteLine($"{first*(second%10)}");
            Console.WriteLine($"{first*((second/10)%10)}");
            Console.WriteLine($"{first*(second/100)}");
            Console.WriteLine($"{first * second}");



            string str_secont = second.ToString();
            Console.WriteLine($"{first * (str_secont[2]-'0')}");
            Console.WriteLine($"{first * (str_secont[1] - '0')}");
            Console.WriteLine($"{first * (str_secont[0] - '0')}");

            Console.WriteLine($"{first*Char.GetNumericValue(str_secont[0])}");

            Console.WriteLine($"{first * int.Parse(str_secont[2].ToString())}");
            Console.WriteLine($"{first * int.Parse(str_secont[1].ToString())}");
            Console.WriteLine($"{first * int.Parse(str_secont[0].ToString())}");
        }
    }
}
