using System;

namespace Ejercicio_1
{
	class Alumno : Persona
	{
		private double promedio;
		
		public Alumno()
		{
			
		}
		public Alumno(string nombre, int edad, int doc, double promedio) : base(nombre, edad, doc)
		{
			this.promedio = promedio;
		}
		public Alumno(string nombre, int edad, DateTime fecNac, double promedio) : base(nombre, edad, fecNac)
		{
			this.promedio = promedio;
		}
		public double Promedio
		{
			set{promedio = value;} 
			get{return promedio;}
		}
		public void imprimir_conDNI()
		{
			Console.WriteLine("{0} ({1}) {2} {3}", name, age, dni, promedio);
		}
		public void imprimir_conFecha()
		{
			Console.WriteLine("{0} ({1}) {2} {3}", name, age, fechaNacimiento.ToString("dd/MM/yyyy"), promedio);
		}
	}
}
