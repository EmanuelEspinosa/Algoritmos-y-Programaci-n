using System;

namespace Ejercicio_6
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.Write("Ingrese una palabra para contar sus vocales: "); 
			string palabra = Console.ReadLine(); 
			Console.Clear(); 
			Console.WriteLine("La palabra << {0} >> tiene la siguiente cantidad de vocales \n", palabra); 
			
			Console.WriteLine("A " + "E " + "I " + "O " + "U "); 
			vocales(palabra); 
			Console.ReadKey();
		}
		public static void vocales(string pal)
		{
			int [] vec = new int[5];
			
			for(int i =0; i < pal.Length; i++)
			{
				if(pal[i] == 'a')
				{
					vec[0] = vec[0]+1;
				}
				if(pal[i] == 'e')
				{
					vec[1] = vec[1]+1;
				}
				if(pal[i] == 'i')
				{
					vec[2] = vec[2]+1;
				}
				if(pal[i] == 'o')
				{
					vec[3] = vec[3]+1;
				}
				if(pal[i] == 'u')
				{
					vec[4] = vec[4]+1;
				}
			}
			foreach(int j in vec)
			{
				Console.Write(j + " ");
			}
		}
	}
}