using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Comp123
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n");
            Person person = new Person("Dennis", 25);
            person.Talks();
            Console.WriteLine("\n");
            Student student = new Student("Dennis", 20, "3000914940");
            student.Studies();
            student.Talks();
            Console.WriteLine("\n");
        }
    }
}
