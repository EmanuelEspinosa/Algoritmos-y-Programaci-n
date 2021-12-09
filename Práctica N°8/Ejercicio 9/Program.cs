using System;

namespace Ejercicio_9
{
	class Program
	{
		public static void Main(string[] args)
		{
			int[] arr = new int[]{2,5,3,9,4,3,16,5,8,12,5,9};
			int ind = 0, cont = 0, tam = arr.Length, numero, cant=0;
			Console.Write("Ingrese un numero para buscar cuantas veces aparece en el arreglo: ");
			numero = Convert.ToInt32(Console.ReadLine());
			Recorrer(arr, ind, cont, tam, numero, ref cant);
			Console.WriteLine("\nEl número {0} aparece {1} veces en el arreglo", numero, cant);
			Console.ReadKey();
			
			
		}
		public static void Recorrer(int[] arreglo, int indice, int contNum, int tamañoArr, int num, ref int veces)
		{
			if(indice == tamañoArr)
			{
				veces = contNum;
			}
			else
			{
				if(arreglo[indice] == num)
				{
					Recorrer(arreglo, indice + 1, contNum + 1, tamañoArr, num, ref veces);
				}
				else
				{
					Recorrer(arreglo, indice + 1, contNum, tamañoArr, num, ref veces);
				}
			}
		}
	}
}