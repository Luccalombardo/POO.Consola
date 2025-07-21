


namespace PooActividad.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            int cantidad = GetInt("Ingrese la cantidad de personas que quiere crear: ");
            Console.Clear();
            for (int i = 0; i < cantidad; i++) 
            {
                Console.Write("Ingrese el nombre: ");
                string nombre = Console.ReadLine();
                int edad = GetInt("Ingrese la edad: ");
                people.Add(new Person(nombre, edad));
            }
            Console.Clear();
            bool seguir = true;
            do
            {
                string[] seleccion;
                MenuOpcion();
                int opcion = GetInt("Ingrese la opcion: ");
                switch (opcion)
                {
                    case 1:
                        int posicion = 0;
                        foreach (Person person in people)
                        {
                            posicion++;
                            Console.WriteLine($"{posicion}º lugar: {person.Name} - {person.Age} años");

                        }
                        EsperarTecla();
                        break;

                    case 2:
                        Console.Write("Ingrese que personas quiere que saluden(Separar número con ','):");
                        seleccion = Console.ReadLine().Trim().Split(",");


                        foreach (string selec in seleccion)
                        {
                            if (int.TryParse(selec, out int index))
                            {
                                index -= 1;
                                people[index].Saluda();
                            }
                            else
                            {
                                Console.WriteLine($"El número {selec} no existe");
                            }

                        }
                        EsperarTecla();
                        break;

                    case 3:
                        Console.Write("Ingrese que personas quiere que cumplan años(Separar número con ','):");
                        seleccion = Console.ReadLine().Trim().Split(",");
                        foreach(string selec in seleccion)
                        {
                            if (int.TryParse(selec, out int index))
                            {
                                index -= 1;
                                people[index].BirthDay();
                            }
                            else
                            {
                                Console.WriteLine($"El número {selec} no existe");
                            }
                        }

                        EsperarTecla();
                        break;
                }
                seguir = preguntar();
                EsperarTecla();
            } while (seguir);
        }

        private static bool preguntar()
        {
            do
            {
                Console.WriteLine("¿Ingrese si quiere realizar alguna otra operación?(Segun las opciones mostradas abajo)");
                Console.WriteLine("S -> Si");
                Console.WriteLine("N -> No");
                Console.Write("Ingrese la opcion: ");
                string seguir = Console.ReadLine();
                if (seguir.ToUpper() == "N")
                {
                    return false;
                }
                else if (seguir.ToUpper() == "S")
                {
                    return true;
                }
                else
                {
                    Console.WriteLine("La opcion ingresada no es valida");
                }
            } while (true);

        }
        private static void EsperarTecla()
        {
            Console.Write("Toque cualquier tecla para continuar");
            Console.ReadKey();
            Console.Clear();
        }
        private static void MenuOpcion()
        {
            Console.WriteLine("Ingrese lo que quiere realizar con la opcion:");
            Console.WriteLine("1 - Mostrar personas registradas");
            Console.WriteLine("2 - Saludar");
            Console.WriteLine("3 - Cumpleaños");

        }

        private static int GetInt(string mensaje)
        {
            
            do
            {
                Console.Write(mensaje);
                if (int.TryParse(Console.ReadLine(), out int nro) && (nro>0))
                {
                    return nro;
                }
                {
                    Console.WriteLine("ERROR: El valor ingresado es invalido");
                }

            }while (true);
        }
    }
}
