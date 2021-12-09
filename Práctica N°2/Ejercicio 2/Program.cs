using System;

namespace Ejercicio_2
{
	class Program
	{
		public static void Main(string[] args)
		{
			int sum=0; int i=1; 
			while (i<=10)
			{
				sum += i++;
			}
			Console.WriteLine(sum); 
			Console.ReadKey();
		}
	}
}