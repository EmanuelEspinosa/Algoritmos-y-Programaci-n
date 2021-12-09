using System;
using System.Collections;

namespace Ejercicio_1
{
	class Program
	{
		public static void Main(string[] args)
		{
			ArrayList lista_alum = new ArrayList(); 
			string nombre; 
			int dia, mes, año, edad; 
			double prom; 
			menu(); 
			int opcion = Convert.ToInt32(Console.ReadLine()); 
			if(opcion == 1)
			{
				Console.WriteLine("La carga de los datos finalzia con 'espacio vacio' + 'intro'"); 
				Console.Write("Ingrese nombre del alumno a registrar: "); 
				nombre = Console.ReadLine(); 
				while(nombre != " ")
				{
					Alumno estudiante = new Alumno(); 
					estudiante.Name = nombre; 
					Console.Write("Ingrese edad del alumno: "); 
					estudiante.Age = Convert.ToInt32(Console.ReadLine()); 
					Console.Write("Ingrese DNI del alumno: "); 
					estudiante.Dni = Convert.ToInt32(Console.ReadLine()); 
					Console.Write("Ingrese promedio de calificaciones del alumno: "); 
					estudiante.Promedio = Convert.ToDouble(Console.ReadLine()); 
					lista_alum.Add(estudiante); 
					Console.Write("Ingrese nombre del alumno a registrar: "); 
					nombre = Console.ReadLine();
				}
				Console.Clear(); 
				Alumno alumAux = new Alumno();
				for(int i = 0; i < lista_alum.Count; i++)
				{
					alumAux = (Alumno)lista_alum[i]; 
					Console.Write(i + 1 + ") " + "ALUMNO: "); 
					alumAux.imprimir_conDNI();
				}
			}
			if(opcion == 2)
			{
				Console.WriteLine("La carga de los datos finalzia con 'espacio vacio' + 'intro'");
				Console.Write("Ingrese nombre del alumno a registrar: "); 
				nombre = Console.ReadLine(); 
				while(nombre != " ")
				{
					Console.Write("Ingrese edad del alumno: "); 
					edad = Convert.ToInt32(Console.ReadLine()); 
					Console.WriteLine("Ingrese fecha de nacimiento: Año/mes/dia: "); 
					año = Convert.ToInt32(Console.ReadLine()); 
					mes = Convert.ToInt32(Console.ReadLine()); 
					dia = Convert.ToInt32(Console.ReadLine()); 
					Console.Write("Ingrese promedio de calificaciones del alumno: "); 
					prom = Convert.ToDouble(Console.ReadLine()); 
					DateTime fecha = new DateTime(año, mes, dia); 
					Alumno estudiante1 = new Alumno(nombre, edad, fecha, prom); 
					lista_alum.Add(estudiante1); 
					Console.Write("Ingrese nombre del alumno a registrar: "); 
					nombre = Console.ReadLine();
				}
				Console.Clear(); 
				Alumno estud1Aux = new Alumno(); 
				for(int i = 0; i < lista_alum.Count; i++)
				{
					estud1Aux = (Alumno)lista_alum[i]; 
					Console.Write(i + 1 + ") " + "ALUMNO: "); 
					estud1Aux.imprimir_conFecha();
				}
			}
			Console.ReadKey();
		}
		public static void menu()
		{
			Console.WriteLine("SELECCIONE UNA DE LAS SIGUIENTES OPCIONES"); 
			Console.WriteLine("1) Ingresar nombre, edad, DNI, promedio");
			Console.WriteLine("2) Ingresar nombre, edad, fecha de nacimiento, promedio\n");
		}
	}
}