using System;
using System.Collections.Generic;

namespace Ejercicio_2
{
	class Program
	{
		public static void Main(string[] args)
		{
			List<IComparable> personas = new List<IComparable>();
			
			personas.Add(new Persona("Emanuel", 25, 39931764));
			personas.Add(new Persona("Carmen",61,14765243));
			personas.Add(new Persona("Benjamin", 29, 37012478));
			personas.Add(new Persona("Miguel", 72, 11236547));
			             
			ordenarPorIntercambio(personas);
			foreach (Persona al in personas) {
				Console.WriteLine(al.Nombre);
			}
			Console.ReadKey();
		}
		private static void ordenarPorIntercambio(List<IComparable> datos)
		{
			int n = datos.Count;
			for(int i=0; i<(n-1); i++)
				for(int j=i+1; j<n; j++)
					if(datos[i].CompareTo(datos[j]) > 0){ 
						IComparable aux = datos[i];  
						datos[i] = datos[j];
						datos[j] = aux;
			}	
		}
	}
}