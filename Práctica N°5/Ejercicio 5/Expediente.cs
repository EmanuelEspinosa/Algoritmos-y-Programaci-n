using System;

namespace Ejercicio_5
{
	class Expediente
	{
		/*Variables de instancia*/
 		private int numero;
 		private string titular, tramite;
 		private DateTime fechaPresentacion;
 		
 		/*Constructores*/
 		public Expediente()
 		{
 			
 		}
 		public Expediente(int numero, string titular, string tramite, DateTime fechaPresentacion) 
 		{
 			this.numero = numero;
 			this.titular = titular;
 			this.tramite = tramite;
 			this.fechaPresentacion = fechaPresentacion;
 		}
 		/*Propiedades*/
		public int Numero
 		{
 			set{numero = value;}
 			get{return numero;}
 		}
 		public string Titular
 		{
 			set{titular = value;}
 			get{return titular;}
 		}
 		public string Tramite
 		{
 			set{tramite = value;}
 			get{return tramite;}
 		}
 		public DateTime FechaPresentacion
 		{
 			set{fechaPresentacion = value;}
 			get{return fechaPresentacion;}
 		}
	}
}
