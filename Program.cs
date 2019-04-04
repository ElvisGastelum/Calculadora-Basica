using System;

namespace suma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.Title = "Calculadora";
            Engine Calcular = new Engine();
            string op = "";
            Console.WriteLine("\t\t\t\n\nCALDULADORA\n\n\n");
            Console.WriteLine("1. Sumar");
            Console.WriteLine("2. Restar");
            Console.WriteLine("3. Multiplicar");
            Console.WriteLine("4. Dividir");
            Console.Write("Elegir opcion: ");
            op = Console.ReadLine();


            switch (op)
            {
                case "1":
                    Calcular.Sumar();
                break;
                case "2":
                    Calcular.Restar();
                break;
                case "3":
                    Calcular.Multiplicar();
                break;
                case "4":
                    Calcular.Dividir();
                break;


                default:
                Console.Write("Opcion elegida no valida...");
                break;
            }

            Console.ReadKey();
            Console.Clear();

        }
    }
}
