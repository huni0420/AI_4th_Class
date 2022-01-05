﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCSharp_20220105_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4, 5 };
            Console.WriteLine("nums의 길이 = "+ nums.Length);
            int[] numarr = new int[10];
            //int[] long_num_arr = new int[int.MaxValue];
            Console.WriteLine("numarr의 길이 = " + numarr.Length);

            int[,] num2dim = { { 1, 2, 3, }, { 4, 5, 6 } }; //2행 3열
            num2dim[0, 0] = 1000; // 값 쓰기
            Console.WriteLine(num2dim[0,0]); // 값 읽기
            int[,] num2dim2 = new int[2,3]; //2행 3열

            Console.WriteLine("배열의 크기?");
            int size = int.Parse(Console.ReadLine());
            int[] my_size_arr = new int[size];
            Console.WriteLine("my_size_arr의 길이 = "+my_size_arr.Length);

            my_size_arr[0] = 10000;
            Console.WriteLine(my_size_arr[0]);

            while (true)
            {
                Console.WriteLine("무한반복중...");
                Console.WriteLine(Console.ReadLine());
            }

        }
    }
}
