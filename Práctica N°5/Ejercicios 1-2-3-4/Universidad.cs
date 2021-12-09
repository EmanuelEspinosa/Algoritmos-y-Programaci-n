using System;
using System.Collections;

namespace Ejercicios_1_2_3_4
{
	class Universidad
	{
		/*Variables de instancia*/
 		private string nombre;
 		private ArrayList List_estudiantes;
 		private ArrayList List_docentes;
 		private ArrayList List_asignaturas;
 		
 		/*Constructores*/
 		public Universidad()
 		{
 
 		}
 		public Universidad(string nomb_facul)
 		{
 			nombre = nomb_facul;
 			List_estudiantes = new ArrayList();
 			List_docentes = new ArrayList();
 			List_asignaturas = new ArrayList();
 		}
 		/*Propiedades*/
 		public string Nombre
 		{
 			set{nombre = value;}
 			get{return nombre;}
 		}
 		/*Este método inscribe un alumno*/
 		public void inscribirAlum(Alumno estud)
 		{
 			List_estudiantes.Add(estud); 
 		}
 		/*Este método elimina la inscripcion de un alumno*/
 		public void eliminarAlum(Alumno estud)
 		{
 			List_estudiantes.Remove(estud);
 		}
 		/*Este método devuelve la cantidad de estudiantes inscriptos*/
 		public int totalInscriptos()
 		{
 			return List_estudiantes.Count;
 		}
 		/*Este método busca un alumno en la lista de alumnos. Devuelve true si lo encontro, caso contrario*/
 		/*retorna false*/
 		public bool existAlum(Alumno estud)
 		{
 			bool esta = false;
 			if(List_estudiantes.Contains(estud))
 			{
 				esta = true;
 			}
 			else
 			{
 				esta = false;
 			}
 			return esta;
 		}
 		/*Busca un alumno por su número de legajo*/
 		public Alumno VerAlumno(int leg)
 		{
 			Alumno alum;
 			alum = null;
 			foreach(Alumno elemento in List_estudiantes)
 			{
 				if(elemento.legajo == leg)
 				{
 					alum = elemento;
 					break;
 				}
 			}
 			return alum;
 		}
 		/*Con este método agrego una materia*/
 		public void AgregarMateria(Materia mat)
 		{
 			List_asignaturas.Add(mat);
 		}
 		/*Este método elimina una materia*/
 		public void ElimMateria(Materia mat) 
 		{
 			List_asignaturas.Remove(mat);
 		}
 		/*Este método retorna la cantidad de materias cargadas en el sistema*/
 		public int CantMateria()
 		{
 			return List_asignaturas.Count;
 		}
 		/*Este método busca una materia en la lista de asignaturas. Devuelve true si la encontro, caso contrario*/
 		/*retorna false*/
 		public bool ExitMateria(Materia mat)
 		{
 			bool existe = false;
 			if(List_asignaturas.Contains(mat))
 			{
 				existe = true;
 			}
 			else
 			{
 				existe = false;
 			}
 			return existe;
 		}
 		/*Este método dado un numero de codigo, devuelve la materia a la que le corresponde*/
 		public Materia ConsultMateria(int cod)
 		{
 			Materia CodAccess;
 			CodAccess = null;
 			
 			foreach(Materia item in List_asignaturas)
 			{
 				if(item.Codigo_materia == cod)
 				{
 					CodAccess = item;
 					break;
 				}
 			}
 			return CodAccess;
 		}
 		/*Este método inscribe un alumno en una materia*/
 		public void InscribirAlumno(string diahora, string materia, Alumno alumno)
 		{
 			foreach(Materia item in List_asignaturas)
 			{
 				if(item.Nombre == materia)
 				{
 					item.inscribir_alumno(alumno);
 					alumno.inscripcionACursada(diahora, materia);
 					break;
 				}
 			}
 		}
 		/*Este método agrega un profesor a la universidad*/
 		public void ContratarProfe(Profesor profe)
 		{
 			List_docentes.Add(profe);
 		}
 		/*Este método elimina un profesor*/
 		public void elimina_prof(Profesor profe)
 		{
 			List_docentes.Remove(profe);
 		}
 		/*Este método muestra la cantidad de profesores de la universidad*/
 		public void cant_prof()
 		{
 			Console.WriteLine("La cantidad de profesores de la universidad es: {0}", List_docentes.Count);
 		}
 		/*Este método retorna si un profesor pertence a la universidad*/
 		public bool profesor_pertence(Profesor prof)
 		{
 			bool pertence = false;
 			if(List_docentes.Contains(prof))
 			{
 				pertence = true;
 			}
 			else
 			{
 				pertence = false;
 			}
 			return pertence;
 		}
 		/*Este método dado un número de legajo, devuelve el profesor al que le corresponde*/
 		public Profesor ConsultProfe(int n_leg)
 		{
 			Profesor leg;
 			leg = null;
 			
 			foreach(Profesor item in List_docentes)
 			{
 				if(item.legajo_prof == n_leg)
 				{
 					leg = item;
 					break;
 				}
 			}
 			return leg;
 		}
	}
}
