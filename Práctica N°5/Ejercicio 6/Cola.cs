using System;
using System.Collections;

namespace Ejercicio_6
{
	class Cola
	{
		private ArrayList elementos;
 		public Cola()
 		{
 			elementos = new ArrayList();
 		}
 		public void encolar(Cliente elem)
 		{
 			elementos.Add(elem);
 		}
 		public Cliente desencolar()
 		{
 			Cliente aux;
 			int item = elementos.Count;
 			aux = (Cliente)elementos[0];
 			elementos.Remove(aux);
 			return aux;
 		}
 		public bool vacia()
 		{
 			return elementos.Count == 0; 
 		}
 		public Cliente tope()
 		{
 			int item = elementos.Count;
 			return (Cliente)elementos[0];
 		}
 		public int enEspera()
 		{
 			return elementos.Count;
 		}
	}
}
