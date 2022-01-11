using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCSharpLasta20220111_3
{
    internal class JamMin : Student
    {
        public JamMin(int id, string name, int age, int ab) : base(id, name, age, ab)
        {
        }

        public void DoPlay()
        {
            Console.WriteLine(Name+"은 하라는 공부는 안 하고 게임한다.");
            Console.WriteLine("나이는 겨우 " + Age + "살이다");
        }
    }
}
