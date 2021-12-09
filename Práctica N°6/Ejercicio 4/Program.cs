using System;

namespace Ejercicio_4
{
	class Program
	{
		public static void Main(string[] args)
		{
			Obra_de_Teatro obra = new Obra_de_Teatro("El Fantasma de la Opera", 300, 3); 
			string respuesta; 
			int entradas_solicitadas = 0; 
			Console.WriteLine("Agregar espectadores (S/n): "); 
			respuesta = Console.ReadLine().ToUpper(); 
			while(respuesta == "S")
			{
				Console.WriteLine("nombre: "); 
				string nombre = Console.ReadLine(); 
				Console.WriteLine("Apellido"); 
				string apellido = Console.ReadLine(); 
				System.Console.WriteLine("Dni: "); 
				int doc = Convert.ToInt32(Console.ReadLine());
				Entrada entrada = new Entrada(obra.Titulo, obra.Precio, obra.lista_espectadores().Count + 1); 
				Espectador x = new Espectador(nombre, apellido, doc, entrada); 
				obra.VenderEntrada(x);
				entradas_solicitadas++; 
				Console.WriteLine("Agregar espectadores (S/n): "); 
				respuesta = Console.ReadLine().ToUpper();
			}
			int entradasVendidas = obra.lista_espectadores().Count; 
			int recaudacionFinal = entradasVendidas * obra.Precio; 
			Console.WriteLine("Cantidad de entradas solicitadas: {0}\nCantidad de entradas vendidas: {1}\nRecaudacion final: {2}", entradas_solicitadas, entradasVendidas, recaudacionFinal);
			Console.ReadKey();
		}
	}
}