using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Consola
{
    internal class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }

        public Person(string name, int age, string addres) 
        { 
            this.Name = name;
            this.Age = age;
            this.Address = addres;
        }
        public void saludar()
        {
            Console.WriteLine($"Hola, soy {Name} y tengo {Age} ");
        }

    }
}
