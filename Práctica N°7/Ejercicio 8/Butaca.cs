using System;

namespace Ejercicio_8
{
	class Butaca
	{
		private int nro;
		private string est;
		
		public Butaca()
		{
			
		}
		public Butaca(int nro, string est)
		{
			this.nro = nro;
			this.est = est;
		}
		public int numero
		{
			set{nro = value;}
			get{return nro;}
		}
		public string estado
		{
			set{est = value;}
			get{return est;}
		}
	}
}
