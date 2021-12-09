using System;

namespace Ejercicio_3
{
	class Program
	{
		public static void Main(string[] args)
		{
			double número1, número2, suma;

            Console.Write("Ingrese el primer número a sumar: ");
            número1 = double.Parse(Console.ReadLine());
            Console.Write("Ingrese el segundo número a sumar: ");
            número2 = double.Parse(Console.ReadLine());

            suma = número1 + número2;
            Console.WriteLine("El resultado de la suma es: " + suma);

            Console.ReadKey();
		}
	}
}