using System;

namespace Ejercicios_1_2_3_4
{
	class Horario
 	{
 		private string dias, horarioDeCur, materia;
 		
 		public Horario(string dia_cur, string hora_cur, string mat_cur)
 		{
 			dias = dia_cur;
 			horarioDeCur = hora_cur;
 			materia = mat_cur;
 		}
 		public string Dias
 		{
 			set{dias = value;}
 			get{return dias;}
 		}
 		public string HorarioDeCur
 		{
 			set{horarioDeCur = value;}
 			get{return horarioDeCur;}
 		}
 		public string Materia
 		{
 			set{materia = value;}
 			get{return materia;}
 		}
 	}
}
