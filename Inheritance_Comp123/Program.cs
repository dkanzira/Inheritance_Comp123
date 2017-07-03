using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Comp123
{
    /// <summary>
    /// This is the driver class
    /// </summary>
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

            DomesticStudent domestic = new DomesticStudent("Mary", 19, "12342344546456");
            domestic.Talks();

            Console.WriteLine("\n");
        }
    }
}
