using System;
using System.Collections;

namespace Ejercicio_6
{
	class Program
	{
		public static void Main(string[] args)
		{
			int cantidad,edad,documento;
            string nombre ;
             
            Console.WriteLine("Ingrese la cantidad de personas a ingresar: ");
            cantidad = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Persona [] arreglo = new Persona[cantidad];
            for(int i = 0; i < arreglo.Length; i++)
            {
                Console.Write("Ingrese el nombre: ");
                nombre = Console.ReadLine();             
                Console.Write("Ingrese la edad: ");
                edad = int.Parse(Console.ReadLine());
                Console.Write("Ingrese su documento:");
                documento = int.Parse(Console.ReadLine());

                arreglo[i] = new Persona(nombre, edad, documento);
            }
            Console.Clear();
            Persona people1 = new Persona();
            for (int i=0; i < arreglo.Length; i++)
            {
                people1 = (Persona)arreglo[i];
                Console.Write(i+1 + ")");
                people1.imprimir();     
            }
            people1.esMayorQue(arreglo);
            Console.ReadKey();
		}
	}
}