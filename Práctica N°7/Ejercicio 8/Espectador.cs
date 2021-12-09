using System;

namespace Ejercicio_8
{
	class Espectador
	{
		private string nombre, apellido;
		private int dni, nEntrada;
		
		public Espectador()
		{
			
		}
		public Espectador(string nombre, string apellido, int dni, int nEntrada)
		{
			this.nombre = nombre;
			this.apellido = apellido;
			this.dni = dni;
			this.nEntrada = nEntrada;
		}
		public string name
		{
			set{nombre = value;}
			get{return nombre;}
		}
		public string lastName
		{
			set{apellido = value;}
			get{return apellido;}
		}
		public int documento
		{
			set{dni = value;}
			get{return dni;}
		}
		public int NEntrada
		{
			set{nEntrada = value;}
			get{return nEntrada;}
		}
		public void imprmir()
		{
			Console.WriteLine("{0} {1} ({2}) N° Entrada : {3}", name, lastName, dni, nEntrada);
		}
	}
}
