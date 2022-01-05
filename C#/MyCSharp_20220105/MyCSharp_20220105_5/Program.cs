using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCSharp_20220105_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //String input = Console.ReadLine();
            //while(input != "exit")
            //{
            //    Console.WriteLine("안녕하세요. 당신의 이름은?");
            //    input = Console.ReadLine();
            //    Console.WriteLine($"{input}님 안녕하세요.");
            //}

            //int count = 0;
            //do
            //{
            //    count++;
            //    Console.WriteLine("숫자를 입력하세요");
            //    count = int.Parse(Console.ReadLine());
            //} while (count) != 0;

            int sum = 0;
            for (int i = 1; i <= 100; i++)
            {
                sum += 1;
            }
            Console.WriteLine("sum = " + sum);

            sum = 0;
            int mycount = 1;
            while (true)
            {
                sum += mycount;
                if (mycount == 100)
                    break;
                mycount++;
            }
            Console.WriteLine("sum = " + sum);
            
            sum = 0;
            for(int i = 1;i <= 100;i++)
            {
                if (i % 2 != 0)
                    continue;
                sum += i;
            }
            Console.WriteLine("sum(짝수) = "+sum);

            int[] myarr = new int[5];
            myarr[0] = 10;
            myarr[1] = 15;
            myarr[2] = 100;
            myarr[3] = 29;
            myarr[4] = 34;
            sum = 0;
            Console.WriteLine("foreach문 활용해보기");
            foreach(var item in myarr)
            {
                sum += item;
                Console.WriteLine("item = "+item);
            }
            Console.WriteLine("sum = "+sum);
            sum = 0;
            Console.WriteLine("for문 활용");
            for(int i = 0;i<myarr.Length;i++)
            {
                sum += myarr[i];
                Console.WriteLine($"myarr[{i}] = {myarr[i]}");
            }
            Console.WriteLine("sum = "+sum);

            int testcount = 0;
            while (true)
            {
                testcount++;
                if (testcount > 100)
                    goto mytest;
            }

            Console.WriteLine("안녕히가세요.");
            mytest:
                Console.WriteLine("여기로 순간이동했어요");

            Console.WriteLine("비파괴적 메서드(원본 변경 안 함)");
            String tomato = "My Tomato";
            Console.WriteLine(tomato.ToLower());
            Console.WriteLine(tomato.ToUpper());
            Console.WriteLine(tomato);

            Console.WriteLine("문자열 자르기");
            String sentense = "안녕 하세요. 이동준 입니다.";
            //Split - 문자열 자르기
            String[] stringarray = sentense.Split(' ');
            foreach(var item in stringarray)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("문자열을 잘라야하는 구분자가 2개 이상일 경우");
            String example = "ldj good@19 89@12 34";
            String[] myinput  = example.Split('@',' ');
            foreach(var item in myinput)
            {
                Console.WriteLine(item);
            }

            String total = String.Join(",", myinput);
            foreach(var item in myinput)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(total);

            String replace_test = total.Replace(",","s");
            Console.WriteLine(replace_test);
        }
    }
}