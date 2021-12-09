using System;

namespace Ejercicio_3
{
	class Program
	{
		public static void Main(string[] args)
		{
			string pal1, pal2, palindromo=null; 
			Console.Write("Ingrese la primera palabra: "); 
			pal1=Console.ReadLine(); Console.Write("Ingrese la segunda palabra: "); 
			pal2=Console.ReadLine();
			
			for(int i = pal2.Length - 1; i >= 0; i--)
			{
				palindromo += pal2[i];
			}
			if(palindromo == pal1)
			{
				Console.WriteLine("Las palabras son palíndromos");
			}
			else
			{
				Console.WriteLine("Las palabras no son palíndromos");
			}
			Console.ReadKey();
		}
	}
}