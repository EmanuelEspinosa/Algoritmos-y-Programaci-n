using System;

namespace Ejercicio_4
{
	class Obra_de_Teatro : Espectaculo
	{
		private string titulo; 
		private int precio;
		
		public Obra_de_Teatro()
		{
			
		}
		public Obra_de_Teatro(string titulo, int precio, int butacas) : base(butacas)
		{
			this.titulo = titulo; 
			this.precio = precio;
		}
		public string Titulo
		{
			set{titulo = value;} 
			get{return titulo;}
		}
		public int Precio
		{
			set{precio = value;} 
			get{return precio;}
		}
	}
}
