using System;

namespace Ejercicio_3
{
	class Alumno
	{
		/*Variables de instancia*/ 
		private string nombre,apellido; 
		private int legajo; 
		private double promedio;
		
		/*Constructores*/ 
		public Alumno()
		{
			
		}
		public Alumno(int L, string n, string a, double pr)
		{
			nombre = n; 
			apellido = a; 
			legajo = L; 
			promedio = pr;
		}
		/*Propiedades*/ 
		public string Nombre
		{
			set{nombre = value;} 
			get{return nombre;}
		}
		public string Apellido
		{
			set{apellido = value;} 
			get{return apellido;}
		}
		public int Legajo
		{
			set{legajo = value;} 
			get{return legajo;}
		}
		public double verProm
		{
			set{promedio = value;} 
			get{return promedio;}
		}
		public bool mejorPromedioQue(Alumno otroA)
		{
			if(promedio > otroA.promedio)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
	}
}
