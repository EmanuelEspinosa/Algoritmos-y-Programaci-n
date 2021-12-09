using System;

namespace Ejercicio_3
{
	class Coordinador : Profesor
	{
		private string area; 
		public Coordinador()
		{
			
		}
		public Coordinador(int c, string m, string a) : base(m ,c)
		{
			area = a;
		}
	}
}
