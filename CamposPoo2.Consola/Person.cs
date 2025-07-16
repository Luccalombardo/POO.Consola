using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamposPoo2.Consola
{
    internal class Person
    {
        private static int NroId =0;
        public string Name { get; set; }
        public int Id { get; set; }
        private int _age;
        public int Age
        {
            get { return _age; }
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
            NroId++;
            this.Name = name;
            this.Age = age;
            this.Id = NroId;
            
        }
        public void MostrarInfo()
        {
            Console.WriteLine($"Nombre: {Name}");
            Console.WriteLine($"Edad: {Age} años");
            Console.WriteLine($"Id: {Id}");

        }
    }
}

