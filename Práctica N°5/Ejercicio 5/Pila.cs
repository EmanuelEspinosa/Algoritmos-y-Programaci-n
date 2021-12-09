using System;
using System.Collections;

namespace Ejercicio_5
{
	class Pila
	{
		/*Variable de instancia*/
 		private ArrayList elementos;
 		
 		/*Constructor*/
 		public Pila()
 		{
 			elementos = new ArrayList();
 		}
 		public void apilar(Expediente elem)
 		{
 			elementos.Add(elem);
 		}
 		public Expediente desapilar()
 		{
 			Expediente aux;
 			int tam = elementos.Count;
 			aux = (Expediente)elementos[tam - 1];
 			elementos.Remove(aux); return aux;
 		}
 		public bool vacia()
 		{
 			return elementos.Count == 0;
 		}
 		public Expediente tope()
 		{
 			int tam = elementos.Count;
 			return (Expediente)elementos[tam - 1];
 		}
		 

	}
}
