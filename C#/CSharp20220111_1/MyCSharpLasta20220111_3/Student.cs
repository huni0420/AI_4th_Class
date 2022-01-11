using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCSharpLasta20220111_3
{
    internal class Student
    {
        public Student()
        {
        }

        public Student(int id, string name, int age, int ab)
        {
            Id = id;
            Name = name;
            Age = age;
            Ab = ab;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int Ab { get; set; }
        public void DoStudy()
        {
            Console.WriteLine($"{Name}은 열심히 공부하고있습니다");
        }
    }
}
