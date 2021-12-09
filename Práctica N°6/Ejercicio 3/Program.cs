using System;

namespace Ejercicio_3
{
	class Program
	{
		public static void Main(string[] args)
		{
			Coordinador coord = new Coordinador(5, "Algoritmos", "informatica"); 
			string nombre; 
			int cont_cupos = -1, cont_t = 0, cont_O = 0; 
			double result;
			
			Console.Write("Ingrese nombre del alumno: "); 
			nombre = Console.ReadLine(); 
			while(nombre != " ")
			{
				Alumno alum = new Alumno(); 
				alum.Nombre = nombre; 
				Console.Write("Ingrese apellido del alumno: "); 
				alum.Apellido = Console.ReadLine(); 
				Console.Write("Ingrese legajo del alumno: "); 
				alum.Legajo = Convert.ToInt32(Console.ReadLine()); 
				Console.Write("Ingrese calificacion promedio del alumno: "); 
				alum.verProm = Convert.ToDouble(Console.ReadLine()); 
				coord.altaAlumno(alum);
				
				if(coord.Cupo == 0)
				{
					cont_cupos++;
				}
				if(alum.verProm > 8)
				{
					cont_O++;
				}
				cont_t++;
				Console.Write("Ingrese nombre del alumno: "); 
				nombre = Console.ReadLine();
			}
			Console.Clear(); 
			result = (cont_O * 100) / cont_t; 
			Console.WriteLine("La cantidad de alumnos que no pudieron inscribirse es: {0}\n",cont_cupos); 
			Console.WriteLine("El porcentaje de alumnos con promedio mayor a 8 es: {0} %", result);
			
			Console.ReadKey();
		}
	}
}