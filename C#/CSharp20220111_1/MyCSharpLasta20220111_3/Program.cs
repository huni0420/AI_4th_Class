using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCSharpLasta20220111_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car c = new Car();
            c.Name = "마티즈";
            c.Description = "토스에 조회해보니 0원";
            c.price = 0;
            c.quantity = -100;
            Console.WriteLine(c.quantity);
            c.quantity = 100;
            Console.WriteLine(c.quantity);

            Student s = new Student(111, "이동준", 34, 1);
            Student s1 = new Student();
            s1.Name = "이승훈";

            s.DoStudy();
            s1.DoStudy();

            JamMin j = new JamMin(12,"도너",14,2);
        }
    }
}
