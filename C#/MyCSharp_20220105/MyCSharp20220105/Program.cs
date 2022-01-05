using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCSharp20220105
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int testnum = 100;
            if (testnum >= 50)
            {
                Console.WriteLine($"testnum은 50을 넘는다.");
            }
            if (testnum < 0)
            {
                Console.WriteLine("testnum은 음수");
            }
            else
            {
                Console.WriteLine("testnum은 양수");
            }
            if(testnum == 10)
            {
                Console.WriteLine("testnum은 10이다.");
            }
            else if(testnum==100)
            {
                Console.WriteLine("testnum은 100이다!!!");
            }
            else
            {
                Console.WriteLine($"testnum은 {testnum}이다.");
            }
            


            Console.WriteLine("나이를 입력해주세요.");
            int.TryParse(Console.ReadLine(), out int age);
            if (0 <= age && age < 20)
            {
                Console.WriteLine("미성년자");
            }
            else if (age < 40)
            {
                Console.WriteLine("청년");
            }
            else if (age<=100)
            {
                Console.WriteLine("노년");
            }
            else if (age<=123)
            {
                Console.WriteLine("장수");
            }
            else if (123<age)
            {
                Console.WriteLine("타노스");
            }
            
            
            char hakjeom = 'A';
            switch (hakjeom)
            {
                case 'A':
                    Console.WriteLine("엘리트");
                    break;
                case 'B':
                    Console.WriteLine("나쁘진않음");
                    break;
                case 'C':
                    Console.WriteLine("좀 문제있음");
                    break;
                case 'D':
                    Console.WriteLine("문제 많음");
                    break;
                case 'F':
                    Console.WriteLine("탈락");
                    break;
            }
                    

            int mynumber = 100;
            String result = mynumber % 2 == 0 ? "짝수" : "홀수";
            Console.WriteLine(result);
            Console.WriteLine(mynumber%2 ==0 ? "짝수":"홀수");


            String Hello = "Hello World";
            bool t1 = Hello.Contains("Hell");
            bool t2 = Hello.Contains("HELL");
            Console.WriteLine(t1);
            Console.WriteLine(t2);
            
            
            //쥐 - 소 - 호랑이 - 토끼 - 용 - 뱀 - 말 - 양 - 원숭이 - 닭 - 개 - 돼지
            Console.WriteLine("올해의 띠는");
            if (DateTime.Now.Year % 12 == 0)
                Console.WriteLine("범");
            else if (DateTime.Now.Year % 12 == 1)
                Console.WriteLine("토끼");
            else if (DateTime.Now.Year % 12 == 2)
                Console.WriteLine("용");
            else if (DateTime.Now.Year % 12 == 3)
                Console.WriteLine("뱀");
            else if (DateTime.Now.Year % 12 == 4)
                Console.WriteLine("말");
            else if (DateTime.Now.Year % 12 == 5)
                Console.WriteLine("양");
            else if (DateTime.Now.Year % 12 == 6)
                Console.WriteLine("원숭이");
            else if (DateTime.Now.Year % 12 == 7)
                Console.WriteLine("닭");
            else if (DateTime.Now.Year % 12 == 8)
                Console.WriteLine("개");
            else if (DateTime.Now.Year % 12 == 9)
                Console.WriteLine("돼지");
            else if (DateTime.Now.Year % 12 == 10)
                Console.WriteLine("쥐");
            else if (DateTime.Now.Year % 12 == 11)
                Console.WriteLine("소");

            switch(DateTime.Now.Month)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("겨울");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("봄");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("여름");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("가을");
                    break;
            }

            Console.WriteLine("");
            switch(DateTime.Now.Month)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                    Console.WriteLine("미성년자");
                    break ;
                case 4:
                case 5:
                case 6:
                    Console.WriteLine("청년");
                    break;
                case 7:
                case 8:
                case 9:
                    Console.WriteLine("노년");
                    break;
                case 10:
                case 11:
                case 12:
                    if (age < 123)
                        Console.WriteLine("장수");
                    else
                        Console.WriteLine("타노스");
                    break;
                default:
                    Console.WriteLine("타노스");
                    break;
            }
        }
    }
}
