using System;

namespace Ejercicio_1___D
{
	class Program
	{
		public static void Main(string[] args)
		{
			/*ORDENAMIENTO POR BURBUJA*/
            
            int[] vec = new int[]{12,3,8,6,2,9,10,-3,0,5};
            int n = vec.Length ;
            
            /*Muestro elementos desordenados*/
            foreach (int elementos in vec) 
            {
            	Console.Write(elementos + " ");
            }
            Console.WriteLine("\n");
                        
            /*Se ordenan los elementos en orden ascendente*/
            for(int i = 0; i < n; i++)
            {
            	for(int j = 0; j < (n - i - 1); j++)
            	{
            		if(vec[j] > vec[j + 1])
            		{
            			int aux = vec[j];
            			vec[j] = vec[j + 1];
            			vec[j + 1] = aux;
            		}
            	}
            }
            
            /*Muestro elementos ordenados*/
            foreach (int element in vec) 
            {
            	Console.Write(element + " ");
            }
            Console.ReadKey();
		}
	}
}