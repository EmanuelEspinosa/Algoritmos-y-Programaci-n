using System;

namespace Ejercicio_1___A
{
	class Program
	{
		public static void Main(string[] args)
		{
			int[] vec = new int[]{12,3,8,6,2,9,10,-3,0,5};
            int n = vec.Length ;
            
            /*Muestro el arreglo desordenado*/
            foreach (int date in vec)
            {
            	Console.Write(date + " ");
            }
            Console.WriteLine("\n");
            
            /*Ordeno los elementos*/
            for(int i = 0; i < (n - 1); i++)
            {
            	for(int j = i + 1; j < n; j++)
            	{
            		if(vec[i] > vec[j])
            		{
            			int aux = vec[i];
            			vec[i] = vec[j];
            			vec[j] = aux;
            		}   
            	}
            }
            
            /*Muestros los elementos del arreglo ordenados*/
            foreach (int element in vec) 
            {
            	Console.Write(element + " ");
            }
            Console.ReadKey();
		}
	}
}