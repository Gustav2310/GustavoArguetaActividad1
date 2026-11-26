using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace actividad2_tareas_Gustavo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenidos a UMI/Universidad Coppel");
            Console.WriteLine();

            Console.Write("Nombre completo: ");
            string nombre = Console.ReadLine();

            Console.Write("Edad: ");
            string edad = Console.ReadLine();

            Console.Write("Fecha de Nacimiento: ");
            string fechaNacimiento = Console.ReadLine();

            Console.Write("Carrera a la que desea ingresar: ");
            string carrera = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Gracias " + nombre + " por formar parte de UMI/Universidad Coppel, Bienvenido a la carrera " + carrera);

            Console.ReadKey();
        }
    }
}
