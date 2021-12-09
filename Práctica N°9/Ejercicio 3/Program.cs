using System;
using System.Collections;

namespace Ejercicio_3
{
	class Program
	{
		public static void Main(string[] args)
		{
			ArrayList colec = new ArrayList();
			string n;
			Console.WriteLine("Ingrese números hasta ingresar ' '(espacio vacio) + <intro>: ");
			n = Console.ReadLine();
			while(n != " ")
			{
				colec.Add(n);
				n = Console.ReadLine();				
			}
			Console.Clear();
			
			/*Muestro coleccion original*/
			foreach (var t in colec) 
			{
				Console.Write(" {0} ", t);
			}
			Console.WriteLine("\n");
			
			/*Muestro colección ordenada y sin repetidos*/
			ArrayList colecAux = sinRep(colec);
			if(colecAux.Count > 0)
			{
				foreach (var element in colecAux) 
				{
					Console.Write(" {0} ",element);
				}
			}
			Console.ReadKey();	
		}		
		public static ArrayList sinRep(ArrayList list)
		{
			var listAux = new ArrayList();
			
			for(int i = 1; i < list.Count; i++)
			{
				string x = (string)list[i];
	
				if(!listAux.Contains(x))
				   listAux.Add(x);
			}
			listAux.Sort();
			return listAux;	
		}
		
	}
}