using System;

namespace Ejercicio_1___B
{
	class Program
	{
		public static void Main(string[] args)
		{
			/*ORDENAMIENTO POR SELECCIÓN*/
            
            int[] vec = new int[]{12,3,8,6,2,9,10,-3,0,5};
            int n = vec.Length ;
            
            /*Muestro elementos desordenados*/
            foreach(int element in vec)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine("\n");
            
            /*Se ordenan los elementos de menor a mayor*/
            for(int i = 0; i < (n - 1); i++) 
            {
                int menor = i;
                for(int j = i + 1; j < n; j++)
                {
                    if(vec[j] < vec[menor])
                    {
                        menor = j;
                    }
                }
                if(menor != i)
                {
                    int aux = vec[i];
                    vec[i] = vec[menor];
                    vec[menor] = aux;
                }
            }
            
            /*Muestro elementos ordenados*/
            foreach(int dato in vec)
            {
                Console.Write(dato + " ");
            }
            Console.ReadKey();
		}
	}
}