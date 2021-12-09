using System;

namespace Ejercicio_1___C
{
	class Program
	{
		public static void Main(string[] args)
		{
			/*ORDENAMIENTO POR INSERCIÓN*/
			
			int[] vec = new int[]{12,3,8,6,2,9,10,-3,0,5};
            int n = vec.Length ;
            
            /*Muestro elementos desordenados*/
            foreach (int elementos in vec)
            {
            	Console.Write(elementos + " ");
            }
            Console.WriteLine("\n");
            
            /*Se ordenan los elementos de menor a mayor*/
            for(int i = 0; i < n; i++)
            {
            	int j = i;
            	int aux = vec[i];
            	
            	while((j > 0) && (aux < vec[j - 1]))
            	{
            		vec[j] = vec[j - 1];
            		j--;
            	}
            	vec[j] = aux;            	      
            }
            
            /*Se muestran los elementos ordenados*/
            foreach (int element in vec)
            {
            	Console.Write(element + " ");
            }
            Console.ReadKey();
		}
	}
}