using System;

namespace Ejercicio_4
{
	class Entrada
	{
		private int numero; 
		private double precio; 
		string titulo;
		
		public Entrada()
		{
			
		}
		
		public Entrada(string titulo, double precio, int numero)
		{
			this.titulo = titulo; 
			this.precio = precio; 
			this.numero = numero;
		}
		public string Titulo
		{
			set{titulo = value;} 
			get{return titulo;}
		}
		public double Precio
		{
			set{precio = value;} 
			get{return precio;}
		}
		public int Numero
		{
			set{numero = value;} 
			get{return numero;}
		}
	}
}
