using Dominio;
namespace Obligatorio1P2
    
{
    internal class Program
    {

        static Sistema sistema = Sistema.Instancia;
        static void Main(string[] args)
        {
           
            Console.WriteLine("Presione 'M' para desplegar el menú");
            string op = Console.ReadLine();
            if (op == "m" || op == "M")
            {
                DesplegarMenu();
            }
            else
            {
                Console.WriteLine("Tecla inválida");
            }
        }
        static void DesplegarMenu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("*** Inicio ***");
                Console.WriteLine("1. Mostrar listado de clientes.");
                Console.WriteLine("2. Buscador de vuelos.");
                Console.WriteLine("3. Alta cliente ocasional.");
                Console.WriteLine("4. Buscador de pasajes.");
                Console.WriteLine("Ingrese una opción: ");
                string op = Console.ReadLine();

                switch (op)
                {
                    case "1":
                        MostrarClientes();
                        break;
                    case "2":
                        BuscarVuelo();
                        break;
                    case "3":
                        AltaCliente();
                        break;
                    case "4":
                        BuscadorPasajes();
                        break;
                    case "0":
                        return;
                }
            }
        }

        static void MostrarClientes()
        {
            Console.Clear();
            Console.WriteLine( sistema.ObtenerListadoClientes());
            Console.ReadLine();
        }

        static void BuscarVuelo()
        {
            Console.Clear();
            Console.WriteLine("Aca van los vuelos");
            Console.WriteLine("Presione una tecla para volver al menú.");
            Console.ReadLine();
        }

        static void AltaCliente()
        {
            Console.Clear();
            Console.WriteLine("Aca va el alta del cliente ocasional");
            Console.WriteLine("Presione una tecla para volver al menú.");
            Console.ReadLine();
        }

        static void BuscadorPasajes()
        {
            Console.Clear();
            Console.WriteLine("Aca va el buscador de pasajes segun codigo");
            Console.WriteLine("Presione una tecla para volver al menú.");
            Console.ReadLine();
        }
    }
}

