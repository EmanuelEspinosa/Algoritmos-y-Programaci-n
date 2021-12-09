using System;

namespace Ejercicio_1
{
	class Persona
	{
		/*Variables de instancia*/ 
		protected int age,dni; 
		protected string name; 
		protected DateTime fechaNacimiento = new DateTime();
		
		/*Construtores*/ 
		public Persona()
		{
			
		}
		public Persona(string name, int age, int dni)
		{
			this.name = name; 
			this.age = age; 
			this.dni = dni;
		}
		public Persona(string name, int age, DateTime Nac)
		{
			this.name = name; 
			this.age = age; 
			fechaNacimiento = Nac;
		}
		
		/*Propiedades*/ 
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
	}
}
