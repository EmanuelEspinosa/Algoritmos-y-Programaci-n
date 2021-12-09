using System;

namespace Ejercicio_7
{
	class Program
	{
		public static void Main(string[] args)
		{
			double [,] mat = new double[2,4];
			
			for(int i = 0; i < 2; i++) //Este for va desde la fila 0 a la fila 1
			{
				for(int j = 0; j < 4; j++) //Este for maneja los indices de las columas (0, 1, 2 y 3)
				{
					Console.Write("Ingrese un valor: "); 
					mat[i,j]=Convert.ToDouble(Console.ReadLine());
				}
			}
			Console.Clear(); 
			Console.WriteLine("La matriz es: \n"); 
			imprimirMatriz(mat); 
			Console.WriteLine("\nLa suma de sus valores es: {0}",sumaMatriz(mat));
			Console.ReadKey();
		}
		public static void imprimirMatriz(double[,] matriz)
		{
			for(int i = 0; i < 2; i++)
			{
				for(int j = 0; j < 4; j++)
				{
					Console.Write(matriz[i,j] + " ");
				}
				Console.WriteLine();
			}
		}
		public static double sumaMatriz(double[,] matriz)
		{
			double suma = 0;
			/*Suma valores de las columnas*/
			for(int i = 0; i < matriz.GetLength(1); i++)
			{
				for(int j = 0; j < matriz.GetLength(0); j++)
				{
					suma = suma + matriz[j,i];
				}
			}
			return suma;
		}
	}
}