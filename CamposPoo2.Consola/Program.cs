namespace CamposPoo2.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Person juan = new Person("Juan", 8);
                Person carlos = new Person("Carlos", 35);
                juan.MostrarInfo();
                Console.WriteLine("");
                carlos.MostrarInfo();

            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Error: " + ex.Message);

            }
        }
    }
}
