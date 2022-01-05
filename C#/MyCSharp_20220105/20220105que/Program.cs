using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20220105que
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("숫자 5개 입력");
            //String[] arr1 = new string[5];
            //for(int i = 0; i < 5; i++)
            //{
            //    arr1[i] = Console.ReadLine();
            //}
            //Console.WriteLine($"큰수 {arr1.Max()}");
            //Console.WriteLine($"작은수 {arr1.Min()}");
            
            //---------------------------------------------------------------------------------------
            //풀이

            //int[] numbers = new int[5];
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    numbers[i] = int.Parse(Console.ReadLine());
            //}
            //int max = numbers[0];
            //int min = numbers[0];
            //foreach(var item in numbers)
            //{
            //    if(item > max)
            //        max = item;
            //    if(item < min)
            //        min = item;
            //}
            //Console.WriteLine($"최대값은 {max},최솟값은 {min}입니다.");

            String start = "1";
            for(int i = 0; i>20;i++)
            {
                Console.WriteLine($"{i+1}번째: {start}");
                String end = "";
                char number = start[0];
                int count = 0;
                for(int j = 0; j < start.Length; j++)
                {
                    if (start[j] != number)
                    {
                        end = end + number + count;
                        number = start[j];
                        count = 1;
                    }
                    else
                        count++;
                }
                end = end + number + count;
                start = end;
            }
        }
    }
}
