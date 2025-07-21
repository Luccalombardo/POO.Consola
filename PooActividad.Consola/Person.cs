using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooActividad.Consola
{
    internal class Person
    {
        public string Name {  get; set; }
        private int _age;
        public int Age
        {
            get
            {
                return _age;
            }

            set
            {
                if (value < 0)
                {
                    value = 0;
                }
                _age = value;
            }
        }
            public Person(string name, int age)
        {
             Name = name;
             Age = age;
        }

        public void Saluda()
        {
            Console.WriteLine($"Hola, Soy {Name}, y tengo {Age} años");
        }
        public void BirthDay()
        {
            Age++;
            Console.WriteLine($"{Name} ahora tiene {Age} años");
        }
    }
}
