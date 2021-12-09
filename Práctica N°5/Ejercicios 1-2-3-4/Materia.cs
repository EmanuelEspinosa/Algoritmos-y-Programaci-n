using System;
using System.Collections;

namespace Ejercicios_1_2_3_4
{
	class Materia
	{
		/*Variables de instancia*/
 		private string nombre;
 		private int codigo_materia;
 		private ArrayList Lista_alumnos = new ArrayList();
 		private Profesor profe;
 		
 		/*Constructores*/
 		public Materia()
 		{
 			
 		}
 		public Materia(string name, int cod)
 		{
 			nombre = name;
 			codigo_materia = cod;
 			Lista_alumnos = new ArrayList();
 			profe = new Profesor();
 		}
 				
 		/*Propiedades*/
 		public string Nombre
 		{
 			set{nombre = value;}
 			get{return nombre;}
 		}
 		public int Codigo_materia
 		{
 			set{codigo_materia = value;}
 			get{return codigo_materia;}
 		}
 		/*Este método asigna un profeso*/
 		public void asignar_profe(Profesor prof)
 		{
 			profe = prof;
 		}
 		/*Este método devuelve los datos del profesor*/
 		public Profesor VerProfe()
 		{
 			return profe;
 		}
 		/*Este método desvincula el profesor*/
 		public void desvincularProfe(Profesor prof)
 		{
 			if(prof.legajo_prof == profe.legajo_prof)
 			{
 				profe = null;
 			}
 		}
 		/*Este método inscribe a un alumno*/
 		public void inscribir_alumno(Alumno al)
 		{
 			Lista_alumnos.Add(al);
 		}
 		/*Este método da de baja la inscripcion de un alumno*/
 		public void borrarAlum(Alumno al)
 		{
 			Lista_alumnos.Remove(al);
 		}
 		/*Este método devuelve la cantidad de alumnos inscriptos*/
 		public int cant_Alumnos()
 		{
 			return Lista_alumnos.Count; 
 		}
 		/*Este método busca un alumno en la lista de alumnos. Devuelve true si los encontro, caso contrario*/
 		/*retorna false*/
 		public bool esAlum(Alumno al)
 		{
 			bool aparece = false;
 			if(Lista_alumnos.Contains(al))
 			{
 				aparece = true;
 			}
 			else
 			{
 				aparece = false;
 			}
 			return aparece;
 		}
	}
}
