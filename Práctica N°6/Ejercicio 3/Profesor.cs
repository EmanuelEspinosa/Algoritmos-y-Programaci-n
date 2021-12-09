using System;
using System.Collections;

namespace Ejercicio_3
{
	class Profesor
	{
		/*Variables de instancia*/ 
		protected ArrayList alumnos; 
		protected int cupoDisponible; 
		protected string materia;
		
		/*Constructores*/ 
		public Profesor()
		{
			
		}
		public Profesor(string m, int num)
		{
			alumnos = new ArrayList(); 
			materia = m; 
			cupoDisponible = num;
		}
		/*Propiedades*/ 
		public string Materia
		{
			set{materia = value;} 
			get{return materia;}
		}
		public int Cupo
		{
			set{cupoDisponible = value;} 
			get{return cupoDisponible;}
		}
		/*Este método da de alta a un alumno. Se pasa como parametro un objeto de la clase Alumno*/ 
		public void altaAlumno(Alumno e)
		{
			if(cupoDisponible == 0)
			{
				Console.WriteLine("no hay cupo");
			}
			else
			{
				alumnos.Add(e); 
				cupoDisponible -= 1;
			}
		}
	}
}
