using System;

namespace Ejercicio_3___Ejercicio_4
{
	class Persona
	{
		private int age, doc;
		private string name;
		
		public Persona()
		{
			
		}
		public Persona(string name, int age, int doc)
		{
			this.name = name;
			this.age = age;
			this.doc = doc;
		}
		public string nombre
		{
			set{name = value;}
			get{return name;}
		}
		public int edad
		{
			set{age = value;}
			get{return age;}
		}
		public int dni
		{
			set{doc = value;}
			get{return doc;}
		}
		public void imprimir()
		{
			Console.WriteLine(name + " " + "("+age+")" + " " + " " + doc);
		}
	}
}
