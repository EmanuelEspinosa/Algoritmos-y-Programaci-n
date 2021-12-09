using System;

namespace Ejercicio_2
{
	class Program
	{
		public static void Main(string[] args)
		{
			string nombre_apell, saludo;
			int length;
			Console.WriteLine("Ingrese su nombre: ");
			nombre_apell = Console.ReadLine();
			
			saludo = "Hola " + nombre_apell + ", bienvenido a la materia";
			length = saludo.Length;
			
			Console.WriteLine(saludo + " ( " + length + " )");
			
			Console.ReadKey();
		}
	}
}