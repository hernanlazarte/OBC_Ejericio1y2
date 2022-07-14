using System;

namespace OBC_Ejericio1y2
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Ejercicio1()
        {
            Console.Clear();
            Console.WriteLine("============================");
            Console.Write("Ingresa tu nombre: ");
            string name=Console.ReadLine();
            Console.WriteLine("============================");
            Console.Clear();
            Console.WriteLine("============================");
            Console.Write("El Nombre ingresado fue: ");
            Console.WriteLine(name.ToUpper());
            Console.WriteLine("============================");
            Menu();
        }
        static void Ejercicio2()
        {
            Console.Clear();
            Console.WriteLine("============================");
            Console.WriteLine("Hora del sistema: " + DateTime.Now.ToShortDateString());
            Console.WriteLine("============================");
            Menu();
        }

        static void Menu()
        {
            Console.WriteLine("============================");
            Console.WriteLine("=           MENU           =");
            Console.WriteLine("============================");
            Console.WriteLine("= 1. EJERCICIO 1           =");
            Console.WriteLine("= 2. EJERCICIO 2           =");
            Console.WriteLine("= 3. SALIR                 =");
            Console.WriteLine("============================");
            Console.Write("Seleccioná una opción:");
            string option = Console.ReadLine();
            switch (option)
            {
                case "1": Ejercicio1();
                    break;
                case "2": Ejercicio2();
                    break;
                case "3":
                    Console.Clear();
                    Console.WriteLine("Hasta luego!");
                    Console.Read();
                    break;
                default:
                    Console.WriteLine("Seleccione una opción válida!");
                    Menu();
                    break;
            }
        }
    }
}
