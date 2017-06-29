using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Comp123
{
    class Student : Person
    {
        //PRIVATE INSTANCE VARIBALES (FIELDS)
        private string _studentID;

        //PUBLIC INSTANCE VARIABLE ----------------------------------
        public string _StudentID
        {
            get
            {
                return this._studentID;
            }
            set
            {
                this._studentID = value;
            }
        }

        //CONSTRUCTORS --------------------------------
        /// <summary>
        /// This is the constructor for the Student Class.
        /// This takes three arguements
        /// </summary>
        /// <param name="name"></param>
        /// <param name="age"></param>
        /// <param name="studentID"></param>
        public Student(string name,int age,string studentID)
            : base(name, age)
        {
            this._StudentID = studentID;
        }

        //PUBLIC METHODS ---------------------------------
        /// <summary>
        /// This is the public method for the Studet class
        /// </summary>
        public void Studies()
        {
            Console.WriteLine(this.Name+"is Studying!");
        }
    }
}
