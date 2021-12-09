using System;

namespace Ejercicio_6
{
	class Cliente
	{
		private int dni, turno;
		
		public Cliente()
 		{
			
 		}
		public Cliente(int dni,int turno)
 		{
 			this.dni = dni;
 			this.turno = turno;
 		}
		public int Dni
 		{
 			set{dni = value;}
 			get{return dni;}
 		}
 		public int Turno
 		{
 			get{return turno;}
 		}
	}
}
