using System;
using System.Collections;

namespace Ejercicios_1_2_3_4
{
	class Profesor
	{
		/*Se declaran las variables de instancia*/
 		private string nombre_prof;
 		private int Legajo_prof, dni_prof;
 		private ArrayList materias_prof = new ArrayList();
 		
 		/*Constructores*/
 		public Profesor()
 		{
 			
 		}
 		public Profesor(string nomb, int doc, int leg)
 		{
 			nombre_prof = nomb;
 			dni_prof = doc;
 			Legajo_prof = leg;
 			materias_prof = new ArrayList();
 		}
 		/*Propiedades*/
 		public string Nombre_prof
 		{
 			set{nombre_prof = value;}
 			get{return nombre_prof;}
 		} 
 		public int Dni_prof
 		{
 			set{dni_prof = value;}
 			get{return dni_prof;}
 		}
 		public int legajo_prof
 		{
 			set{Legajo_prof = value;}
 			get{return Legajo_prof;}
 		}
 		/*Este método imprime los datos de los profesores*/
 		public void imprimir()
 		{
 			Console.WriteLine("El profesor: {0} con DNI: {1} cuenta con el legajo N°: {2}", nombre_prof, dni_prof, Legajo_prof);
 		}
 		/*Este método agrega una materia al profesor*/
 		public void agregar_Materia(Mat_dic_prof mat)
 		{
 			materias_prof.Add(mat);
 		}
 		/*Este método da de baja una materia que se le haya asignado al profesor*/
 		public void eliminar_mat(string materia_bor)
 		{
 			int i = 0;
 			bool continua = true;
 			Mat_dic_prof valor;
 			
 			while((i < materias_prof.Count) & (continua))
 			{
 				valor = (Mat_dic_prof)materias_prof[i];
 				if(valor.Nomb_materia == materia_bor)
 				{
 					materias_prof.Remove(valor);
 					continua = false;
 				}
 				i++;
 			}
 			if(continua)
 			{
 				Console.WriteLine("No se encontro la materia");
 			}
 		}
 		/*Este método retorna si una materia a dictar está asociada a un profesor*/
 		public bool dictadoDeCurso(string materia)
 		{
 			bool existe = false;
 			foreach(Mat_dic_prof t in materias_prof)
 			{
 				if(t.Nomb_materia == materia)
 				{
 					existe = true;
 				}
 				else
 				{
 					existe = false;
 				}

 			}
 			return existe;
 		}
 		/*Este método devuelve la cantidad de materias a la que está asociado el profesor*/
 		public int cant_materias()
 		{
 			return materias_prof.Count;
 		}
 		/*En este método dado un número de código, devuelve la materia a la que le corresponde */
 		public Mat_dic_prof ConsultarMateria(int nrocodigo)
 		{
 			Mat_dic_prof codmat;
 			codmat = null;
 			foreach (Mat_dic_prof element in materias_prof)
 			{
 				if(element.Cod_materia == nrocodigo)
 				{
 					codmat = element;
 					break;
 				}
 			}
 			return codmat;
 		}
	}
}
