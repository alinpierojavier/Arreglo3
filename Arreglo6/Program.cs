using System;

namespace Arreglo6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Empleando arreglos mostrar los nombres de 4 alumnos con sus respectivas notas finales.
            string[] nombre = new string[5];
            int[] notas = new int[5];

            for (int i = 0; i < nombre.Length; i++)
            {
                Console.WriteLine("Ingrese nombre del estudiante " + i);
                nombre[i] = Console.ReadLine();
                Console.WriteLine("Ingresar su nota");
                notas[i] =Convert.ToInt32(Console.ReadLine());
            }
            Console.ReadKey();
        }
    }
}
