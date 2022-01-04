using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCharp_02_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //escape문자
            Console.WriteLine("내 이름은 \"이동준\" 입니다.");
            Console.WriteLine("\\");
            Console.WriteLine(@"이동준\류경문");

            //문자열 인덱스
            Console.WriteLine("Hellow World"[0]);
            Console.WriteLine("안녕하세요"[0]);
            Console.WriteLine("Hellow World"[1]);
            Console.WriteLine("안녕하세요"[1]);
            Console.WriteLine("Hellow World"[2]);
            Console.WriteLine("안녕하세요"[2]);


            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine(a + b);

            Console.WriteLine("원주율은?");
            double d = double.Parse(Console.ReadLine());
            Console.WriteLine("이름은?");
            String s = Console.ReadLine();
            Console.WriteLine(d);
            Console.WriteLine(s);

            //문자열 입력받는 방법 3가지
            Console.WriteLine("원의 넓이는 " + d + "입니다");
            Console.WriteLine(String.Format("원의 넓이는 {0}이고,내이름은 {1}입니다.", d, s));
            Console.WriteLine($"원주율은 {d}이고, 이름은 {s}입니다.");


            
            Console.WriteLine("문자 입력해보세요");
            char c = Console.ReadLine()[0];
            Console.WriteLine("c="+c);

        }
    }
}