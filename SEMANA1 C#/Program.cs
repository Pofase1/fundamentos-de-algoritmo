using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA1_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ejer1();
            Console.ReadKey(); // Realizando detenimiento de consola
        }

        static void ejer1()

        {
            string nombre, carrera;

            Console.Write("Ingrese su nombre: ");
            nombre = Console.ReadLine();

            Console.Write("Ingrese su carrera: ");
            carrera = Console.ReadLine();

            Console.WriteLine($"{nombre}, bienbenido al curso FA de {carrera}");



        }
        static void ejer2()
        {
            Console.WriteLine("\"Dylan\"");
        }
        static void ejer3()
        {
            Console.Write("Ingrese x: ");
            int x = int.Parse(Console.ReadLine());

            Console.Write("Ingrese y:");
            int y = Convert.ToInt32(Console.ReadLine());

            int sum = x + y;
            double divi = (double)x / (double)y;


            Console.WriteLine("Suma: " + (x + y));
            Console.WriteLine("Resta:" + (x - y));
            Console.WriteLine("Multiplicacion:" + (x * y));
            Console.WriteLine("Division:" + (x / y));

        }
    }


}










