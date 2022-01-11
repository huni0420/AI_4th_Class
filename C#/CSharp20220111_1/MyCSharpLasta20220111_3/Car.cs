using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCSharpLasta20220111_3
{
    internal class Car
    {
        public String Name { get; set; }
        public String Description { get; set; }

        public int price;

        private int q;

        public int quantity 
        { 
            get 
            { return q; } 
            set 
            {   if (value < 0)
                {
                    Console.WriteLine($"{value}는 음수입니다");
                    q=0;
                }
                else
                    q=value; 
            }
        }
    }
}