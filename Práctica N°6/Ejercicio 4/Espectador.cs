using System;

namespace Ejercicio_4
{
	class Espectador
	{
		private string nombre, apellido; 
		private int dni; 
		private Entrada entrada;
		
		public Espectador()
		{
			
		}
		public Espectador(string nombre, string apellido, int dni, Entrada entrada)
		{
			this.nombre = nombre; 
			this.apellido = apellido; 
			this.dni = dni; 
			this.entrada = entrada;
		}
		public string Nombre
		{
			set{nombre = value;} 
			get{return nombre;}
		}
		public string Apellido
		{
			set{apellido = value;} 
			get{return nombre;}
		}
		public int Dni
		{
			set{dni = value;} 
			get{return dni;}
		}
		public Entrada Consultar_Entrada()
		{
			return entrada;
		}
	}
}
