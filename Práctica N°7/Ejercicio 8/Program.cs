using System;
using System.Collections;

namespace Ejercicio_8
{
	class Program
	{
		public static void Main(string[] args)
		{
			ArrayList listEspectadores = new ArrayList();
			ArrayList listButacas = new ArrayList();
			int cupos;
			string nombre;
			
			Console.WriteLine("***** VENTA DE ENTRADAS - CINE 'SAN MARTIN' *****\n");
			Console.Write("Ingrese la cantidad de cupos disponibles del cine: ");
			cupos = Convert.ToInt32(Console.ReadLine());						                  
			Cine cinema = new Cine("San Martin",cupos, listButacas);
			Console.Clear();
			
			try
			{
				Console.Write("Nombre del espectador: ");
				nombre = Console.ReadLine();
				while(nombre != " ")
				{
					Espectador espt = new Espectador();
					Butaca butAux = new Butaca();
					espt.name = nombre;
					Console.Write("Apellido del espectador: ");
					espt.lastName = Console.ReadLine();
					Console.Write("DNI del espectador: ");
					espt.documento = Convert.ToInt32(Console.ReadLine());
					Console.Write("N° Entrada asingada: ");
					espt.NEntrada = Convert.ToInt32(Console.ReadLine());
					listEspectadores.Add(espt);
					
					Console.Write("ingrese N° de butaca: ");
					butAux.numero = Convert.ToInt32(Console.ReadLine());
					Console.Write("Ingresar estado de la butaca: ");
					butAux.estado = Console.ReadLine();
					listButacas.Add(butAux);
					Console.Clear();
					
					if(listButacas.Count == cupos)
					{
						string motivo = "\n-----No hay cupo disponible-----\n";
						throw new sinCupoException(motivo);
					}					
					Console.Write("Nombre del espectador: ");
					nombre = Console.ReadLine();	
				}
			}
			catch(sinCupoException e)
			{
				Console.WriteLine(e.motivo);
			}
			finally
			{
				Console.WriteLine("***** LISTA DE ESPECTADORES REGISTRADOS *****\n");
				imprimir(listEspectadores);
			}
			Console.ReadKey();
		}
		public static void imprimir(ArrayList espect)
		{
			Espectador espAux = new Espectador();
			for (int i = 0; i < espect.Count; i++)
			{
				espAux = (Espectador)espect[i];
				espAux.imprmir();
				
			}
		}
	}
	class sinCupoException : Exception
	{
		public string motivo;
		
		public sinCupoException(string motivo)
		{
			this.motivo = motivo;
		}
	}
}