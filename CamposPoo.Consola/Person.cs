using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamposPoo.Consola
{
    internal class Person
    {
        public string Name { get; set; }
        public Guid Id { get; set; }
        private int _age;
        public int Age 
        {
            get { return _age;}
            set
            {
                if (value > 0)
                {
                    _age = value;
                }
                else
                {
                    throw new ArgumentException("La edad debe ser mayor a 0.");

                }
            }
        
        }

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
            this.Id = Guid.NewGuid();
        }
        public void MostrarInfo()
        {
            Console.WriteLine($"Nombre: {Name}");
            Console.WriteLine($"Edad: {Age} años");
            Console.WriteLine($"Id: {Id}");

        }
    }
}
