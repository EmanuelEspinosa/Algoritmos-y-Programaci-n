using System;
using System.Collections;

namespace Ejercicios_1_2_3_4
{
	class Alumno
	{
		/*Variables de instancia*/
 		private string nombre;
 		private int Legajo, dni;
 		private ArrayList lista_horarios;
 		
 		public Alumno()
 		{
 			
 		}
 		public Alumno(string nombAlum, int doc, int legaj)
 		{
 			nombre = nombAlum;
 			dni = doc;
 			Legajo = legaj;
 			lista_horarios = new ArrayList();
 		}
 		/*Propiedades*/
 		public string Nombre
 		{
 			set{nombre = value;}
 			get{return nombre;}
 		}
 		public int Dni
 		{
 			set{dni = value;}
 			get{return dni;}
 		}
 		public int legajo
 		{
 			set{Legajo = value;}
 			get{return Legajo;}
 		}
 		/*Este método imprime los datos los alumnos*/
 		public void imprimir()
 		{
 			Console.WriteLine("El alumno: {0} con DNI: {1} cuenta con el legajo N°: {2}", nombre, dni, Legajo);
 		}
 		/*Este método le avisa al alumno si un horario está o no disponible, en el caso que se quiera*/
 		/*inscribir a dos materias el mismo día y hora*/
 		public void inscripcionACursada(string diahora, string materia)
 		{
 			string dia, hora;
 			bool no_disponible = false;
 			string[] p = diahora.Split(new char[] {'-'});
 			dia = p[0];
 			hora = p[1];
 			foreach(Horario valor in lista_horarios)
 			{
 				if(dia == valor.Dias)
 				{
 					if(hora == valor.HorarioDeCur)
 					{
 						no_disponible = true;
 						break;
 					}
 				}
 			}
 			if(!no_disponible)
 			{
 				Horario agrego_mat = new Horario(dia, hora, materia);
 				lista_horarios.Add(agrego_mat);
 			}
 			else
 			{
 				Console.WriteLine("{0} horario no disponible", diahora);
 			}
 		}
 		/*Este método da de baja una materia*/
 		public void eliminar_Materia(string mat)
 		{
 			int t = 0;
 			bool continua = true;
			Horario item;
 			while((t < lista_horarios.Count) & (continua))
 			{
 				item = (Horario)lista_horarios[t];
 				if(item.Materia == mat)
 				{
 					lista_horarios.Remove(item);
 					continua = false;
 				}
 				t++;
 			}
 			if(!continua)
 			{
 				Console.WriteLine("No se encontro la materia");
 			}
 		}
 		/*Este método imprime el listado de horarios*/
 		public void ListadoDeHorarios()
 		{
 			Console.WriteLine("HORA    MATERIA");
 			foreach(Horario item in lista_horarios)
 			{
 				Console.WriteLine("{0}    {1}", item.HorarioDeCur, item.Materia);
 			}
 		}
 		/*Este método retorna el nombre de la materia dado un día y una hora específicos*/
 		public string ver_mat(string diahora)
 		{
 			string dia, hora;
 			string [] frag = diahora.Split(new char[] {'-'});
 			string nom = "";
 			
 			dia = frag[0];
 			hora = frag[1];
 			
 			foreach(Horario element in lista_horarios)
 			{
 				if(dia == element.Dias)
 				{
 					if(hora == element.HorarioDeCur)
 					{
 						nom = element.Materia;
 						break;
 					}
 				}
 			}
 			return nom;
 		}
 		/*Este método retorna la cantidad de materias a la que se inscribió el alumno*/
 		public int Cant_materias()
 		{
 			ArrayList materias_aux = new ArrayList();
 
 			foreach(Horario item in lista_horarios)
 			{
 				if(!materias_aux.Contains(item.Materia))
 				{
 					materias_aux.Add(item.Materia);
 				}
 			}
 			return materias_aux.Count;
 		}
 		/*Este método muestra el listado de las materias a las que se inscribió el alumno*/
 		public void Listado_materias()
 		{
 			ArrayList list_mat = new ArrayList();
 			foreach(Horario elem in lista_horarios)
 			{
 				if(!list_mat.Contains(elem.Materia))
 				{
 					list_mat.Add(elem.Materia);
 				}
 			}
 			Console.WriteLine("Materias: ");
 			foreach(string nombre in list_mat)
 			{
 				Console.WriteLine(" {0}", nombre);
 			}
 		}
	}
}
