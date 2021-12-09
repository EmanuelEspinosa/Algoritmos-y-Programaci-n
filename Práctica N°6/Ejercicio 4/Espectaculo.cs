using System;
using System.Collections;

namespace Ejercicio_4
{
	class Espectaculo
	{
		protected int butacas; 
		protected ArrayList Espectadores;
		
		public Espectaculo()
		{
			
		}
		public Espectaculo(int butacas)
		{
			this.butacas = butacas; 
			Espectadores = new ArrayList();
		}
		public int Butacas
		{
			set{butacas = value;} 
			get{return butacas;}
		}
		public void VenderEntrada(Espectador unEsp)
		{
			if(butacas == 0)
			{
				Console.WriteLine("No hay entradas disponibles");
			}
			else
			{
				Espectadores.Add(unEsp); 
				butacas--;
			}
			
		}
		public ArrayList lista_espectadores()
		{
			return Espectadores;
		}
	}
}
