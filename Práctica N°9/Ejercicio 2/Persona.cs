using System;
using System.Collections.Generic;

namespace Ejercicio_2
{
	public class Persona : IComparable
	{
		private int edad, dni;
		private string nombApell;
		
		public Persona()
		{
			
		}
		public Persona(string nombApell, int edad, int dni)
		{
			this.edad = edad;
			this.dni = dni;
			this.nombApell = nombApell;
		}
		public int Edad
		{
			set{edad = value;}
			get{return edad;}
		}
		public int Dni
		{
			set{dni = value;}
			get{return dni;}
		}
		public string Nombre
		{
			set{nombApell = value;}
			get{return nombApell;}
		}
		public int CompareTo(object otro){
			if(this.Dni < ((Persona)otro).Dni)
					return -1;
			else
				if(this.Dni > ((Persona)otro).Dni)  
					return 1;
				else
					return 0;
		}
	}
}
