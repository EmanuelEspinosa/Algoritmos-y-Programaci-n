using System;

namespace Ejercicio_3___2_Forma
{
	class Program
	{
		public static void Main(string[] args)
		{
			string pal1,pal2; 
			int j, tam; 
			bool son;
			
			Console.WriteLine("Ingrese las dos palabras a comparar: "); 
			pal1=Console.ReadLine();
			
			pal2 = Console.ReadLine(); 
			if(pal1.Length == pal2.Length)
			{
				son = true; 
				tam = pal1.Length; 
				j = tam - 1; //Ultima posición de la palabra
				
				for(int t=0; t < tam; t++)
				{
					if(pal1[t] != pal2[j])
					{
						son = false; 
						break;
					}
					else
					{
						j--;
					}
				}
				if(son)
				{
					System.Console.WriteLine("\n SON PALÍNDROMOS");
				}
				else
				{
					System.Console.WriteLine("\n NO SON PALÍNDROMOS");
				}
			}
			else
			{
				System.Console.WriteLine("\n NO SON PALÍNDROMOS, YA QUE TIENEN DISTINTA CANTIDAD DE CARACTERES");
			}
			Console.ReadKey();	
		}
	}
}