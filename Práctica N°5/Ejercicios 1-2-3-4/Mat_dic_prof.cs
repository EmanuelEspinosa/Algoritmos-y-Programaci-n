using System;

namespace Ejercicios_1_2_3_4
{
	class  Mat_dic_prof
	{
		/*Se declaran las variables de instancia*/
 		private string nomb_materia; 
 		private int cod_materia;
 		
 		/*Constructores*/
 		public Mat_dic_prof()
 		{
 			
 		}
 		public Mat_dic_prof(string nombre_mat, int cod)
 		{
 			nomb_materia = nombre_mat;
 			cod_materia = cod;
 		}
 		/*Propiedades*/
		public string Nomb_materia
 		{
 			set{nomb_materia = value;}
 			get{return nomb_materia;}
 		}
 		public int Cod_materia
 		{
 			set{cod_materia = value;}
 			get{return cod_materia;}
 		}
	}
}
