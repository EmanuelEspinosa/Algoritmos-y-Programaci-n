using System;
using System.Collections;

namespace Ejercicio_5
{
	class Program
	{
		public static void Main(string[] args)
		{
			ArrayList lista_personas = new ArrayList();
 			string nombre;
 			int dni, dia, mes, año, opcion;
 			Console.WriteLine("Seleccione una de las siguientes opciones");
 			Console.WriteLine("1) INGRESAR NOMBRE, EDAD, DNI");
 			Console.WriteLine("2) INGRESAR NOMBRE, EDAD, FECHA DE NACIMIENTO");
 			opcion = Convert.ToInt32(Console.ReadLine());
 			if(opcion == 1)
 			{
 				Console.Write("Ingrese el nombre de la persona a registrar: ");
 				nombre = Console.ReadLine();
 				while(nombre != " ")
 				{
 					Persona people = new Persona();
 					people.Name = nombre;
 					Console.Write("Ingrese DNI: ");
 					people.Dni = Convert.ToInt32(Console.ReadLine()); Console.Write("Ingrese edad: ");
 					people.Age = Convert.ToInt32(Console.ReadLine());
 					lista_personas.Add(people);
 					Console.Write("Ingrese el nombre de la persona a registrar: ");
 					nombre = Console.ReadLine();
 				}
 				Console.Clear();
 				Persona peopleAux = new Persona();
 				for(int i = 0; i < lista_personas.Count; i++)
 				{
 					peopleAux = (Persona)lista_personas[i];
 					Console.Write(i + 1 + ")");
 					peopleAux.imprimir_conDNI();
 				}
 			}
 			if(opcion == 2)
 			{
 				Console.Write("Ingrese el nombre de la persona a registrar: ");
 				nombre = Console.ReadLine();
 				while(nombre != " ")
 				{
 					Console.Write("Ingrese DNI: ");
 					dni = Convert.ToInt32(Console.ReadLine());
 					Console.Write("Ingrese el año de nacimiento: ");
 					año = Convert.ToInt32(Console.ReadLine());
 					Console.Write("Ingrese el mes de nacimiento: ");
 					mes = Convert.ToInt32(Console.ReadLine());
 					Console.Write("Ingrese día de nacimiento: ");
 					dia = Convert.ToInt32(Console.ReadLine());
 					DateTime fecha = new DateTime(año, mes, dia);
 					Persona people2 = new Persona(nombre, dni, fecha);
 					lista_personas.Add(people2);
 					Console.Write("Ingrese el nombre de la persona a registrar: ");
 					nombre = Console.ReadLine();
 				}
 				Console.Clear();
 				Persona peopleAux2 = new Persona();
 				for(int j = 0; j < lista_personas.Count; j++)
 				{
 					peopleAux2 = (Persona)lista_personas[j];
 					Console.Write(j + 1 + ")");
 					peopleAux2.imprimir_conFecha();
 				}
 			}
 			Console.ReadKey();
		}
	}
}