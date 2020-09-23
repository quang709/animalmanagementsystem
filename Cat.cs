﻿using System;
using System.Collections.Generic;
using System.Text;

namespace animemanagersystem
{
    class Cat : ITerrestrialAnimal
    {

        int id;
        string name;
        int age;
        public int ID
        {
            set
            {
                id = value;
            }
            get
            {
                return id;
            }
        }
        public string Name
        {
            set
            {
                name = value;
            }
            get
            {
                return name;
            }
        }

        public int Age
        {
            set
            {
                age = value;
            }
            get
            {
                return age;
            }
        }

        public void Move()
        {
            Console.WriteLine("Run");
        }
        public override string ToString()
        {
            return $" id {ID} name {Name} Age{Age} {GetType()} ";
        }
    }
}
