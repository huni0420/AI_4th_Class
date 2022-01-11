using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp20220111_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("배열의 길이 정해주세요");
            int arrsize = int.Parse(Console.ReadLine());

            int[] numbers = new int[arrsize];
            
            for(int i = 0; i < arrsize; i++)
            {
                Console.WriteLine($"{i}번째 값 입력");
                numbers[i] = int.Parse(Console.ReadLine());

            }

            Array.Reverse(numbers);

            foreach(var item in numbers)
            {
                Console.WriteLine(item);
            }
            Array.Reverse(numbers);
            for(int i = 0; i < arrsize; i++)
            {
                for(int j =0; j < numbers.Length; j++)
                {
                    int temp = numbers[j];
                    numbers[j] = numbers[j+1];
                    numbers[j+1] = temp;
                }
            }
            foreach(var item in numbers)
            {
                Console.WriteLine(item);
            }

            Array.Reverse(numbers);
        }
    }
}
