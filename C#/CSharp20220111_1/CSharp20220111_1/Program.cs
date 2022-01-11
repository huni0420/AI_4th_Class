using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp20220111_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("숫자를 입력하세요");
            int input = int.Parse(Console.ReadLine());
            int max = 1;
            int counter = 0;
            while (true)
            {
                max = max + (6 * counter);
                if (max < input)
                {
                    counter++;
                    continue;
                }
                else
                    Console.WriteLine($"{input}은/는 {counter+1}번째 벌집에 속함");
                break;
            }



            int t = 0;
            int[] arr = new int[5];
            arr = new int[] {13,15,5,8,1};
            Array.Sort(arr);
            foreach(int value in arr)
            {
                Console.WriteLine(value+" ");   
            }
            Console.WriteLine();
            Array.Reverse(arr);   
            foreach(int value in arr)
            {
                Console.WriteLine(value+" ");
            }
        }
    }
}
