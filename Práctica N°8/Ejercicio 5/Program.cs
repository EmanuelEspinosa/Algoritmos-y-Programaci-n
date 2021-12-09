using System;

namespace Ejercicio_5
{
	class Program
	{
		public static void Main(string[] args)
		{
			string t;
			Console.WriteLine("Ingrese una palabra o una oracion para contar sus vocales");
			t = Console.ReadLine();
			int ind = 0, contador = 0, veces = 0, tamañoPal = t.Length;
			
			
			palVocales(ind, ref veces, contador, t, tamañoPal);
			Console.WriteLine("La cantidad de vocales que contiene el string es: {0}",veces);
			Console.ReadKey();
		}
		public static void palVocales(int indice, ref int contVocal, int cont, string f, int tamPal )
		{
			if(indice == tamPal)
			{
				contVocal = cont;
			}
			else
			{
				if(f[indice]=='a' | f[indice]=='e' | f[indice]=='i' | f[indice]=='o' | f[indice]=='u' )
				{
					palVocales(indice + 1, ref contVocal, cont + 1, f, tamPal);
				}
				else
				{
					palVocales(indice + 1, ref contVocal, cont, f, tamPal);
				}
			}
		}
	}
}