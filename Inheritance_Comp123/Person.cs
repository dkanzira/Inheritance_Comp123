﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Comp123
{
    /// <summary>
    /// This is the Person Class
    /// </summary>
    public class Person
    {
        //PRIVATE INSTANCE VARIABLES(FIELDS)
        private string _name;
        private int _age;
        //PUBLIC PROPERTIES ----------------------------------------
        public string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
            }
        }
        public int Age
        {
            get
            {
                return this._age;
            }
            set
            {
                this._age = value;
            }
        }
        //CONSTRUCTORS ---------------------------------------------
        /// <summary>
        /// This is the constructor for the Person class.
        /// It takes two arguements - name(string) and age (int)
        /// </summary>
        /// <param name="name"></param>
        /// <param name="age"></param>
        public Person(string name, int age)
        {
            this.Name = name;
            this._age = age;
        }
        // PUBLIC METHODS ------------------------------------------
        /// <summary>
        /// 
        /// </summary>
        public void Talks()
        {
            Console.WriteLine(this.Name+" is talking");
        }
    }
}
