using System;

namespace Ejercicio_7
{
	class Program
	{
		public static void Main(string[] args)
		{
			int num, sum = 0, cont = 0;
			Console.WriteLine("Ingrese el número que desea sumar / Ingrese 0 para finalizar la suma ");
			num = Convert.ToInt32(Console.ReadLine());
			while(num != 0)
			{
				sum += num; 
				Console.Clear();
				Console.WriteLine("La suma hasta el momento es: {0}", sum); 
				Console.WriteLine("Ingrese el número que desea sumar: ");
				num = Convert.ToInt32(Console.ReadLine());
				cont++;
			}
			Console.Clear();
			Console.WriteLine("--------------------------------------------"); 
			Console.WriteLine("El resultado de la suma es: {0}", sum); 
			Console.WriteLine("--------------------------------------------");
			Console.WriteLine("El total de números ingresados es: {0}", cont);
			Console.ReadKey();
		}
	}
}