using System;

namespace Ejercicio_5
{
	class Persona
	{
		private int age, dni;
 		private string name;
 		private DateTime fechaNac = new DateTime();
 		
 		public Persona()
 		{
 			
 		}
 		public Persona(string name, int dni, int age)
 		{
 			this.name = name;
 			this.age = age;
 			this.dni = dni;	
 		}
 		public Persona(string name, int dni, DateTime deNac)
 		{
 			this.name = name;
 			this.dni = dni;
 			fechaNac = deNac;
 		}
 		public string Name
 		{
 			set{name = value;}
 			get{return name;}
 		}
 		public int Age
 		{
 			set{age = value;}
 			get{return age;}
 		}
 		public int Dni
 		{
 			set{dni = value;}
 			get{return dni;}
 		}
 		public void imprimir_conDNI()
 		{
 			Console.WriteLine(name + " " + dni + " " + "("+age+")");
 		}
 		public void imprimir_conFecha()
 		{
 			Console.WriteLine(name + " " + "("+dni+")" + " " + fechaNac.ToString("dd/MM/yyyy"));
 		}
	}
}
