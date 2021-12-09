using System;
using System.Collections;

namespace Ejercicio_8
{
	class Cine
	{
		private string name;
		private int cup;
		
		public Cine()
		{
			
		}
		public Cine(string name, int cup, ArrayList cButacas)
		{
			this.name = name;
			this.cup = cup;
			cButacas = new ArrayList();
		}
		public string nombre
		{
			set{name = value;}
			get{return name;}
		}
		public int cupos
		{
			set{cup = value;}
			get{return cup;}
		}
	}
}
