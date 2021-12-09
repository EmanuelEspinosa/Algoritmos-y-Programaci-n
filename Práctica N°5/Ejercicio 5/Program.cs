using System;

namespace Ejercicio_5
{
	class Program
	{
		public static void Main(string[] args)
		{
			Pila pila, PilaAux;
 			string titular, tipo, respuesta;
 			int numero, dia, mes, año;
 			DateTime fechaP;
 			Expediente ex;
 			
 			pila = new Pila();
 			
 			Console.WriteLine("¿Hay expedientes para ingresar? s/n");
 			respuesta = Console.ReadLine();
 			while(respuesta == "s")
 			{
 				Console.Write("Ingrese el titular: ");
 				titular = Console.ReadLine();
 				Console.Write("Ingrese número de tramite: ");
 				numero = Convert.ToInt32(Console.ReadLine());
 				Console.Write("Ingrese el tipo de tramite: ");
 				tipo = Console.ReadLine();
 				Console.WriteLine("ingrese fecha de ingreso: dia, mes y año por separado y en ese orden: ");
 				dia = Convert.ToInt32(Console.ReadLine());
 				mes = Convert.ToInt32(Console.ReadLine());
 				año = Convert.ToInt32(Console.ReadLine());
 				fechaP = new DateTime(año, mes, dia);
 				ex = new Expediente(numero, titular, tipo, fechaP);
 				pila.apilar(ex);
 				Console.WriteLine("¿Hay expedientes para ingresar? s/n");
 				respuesta = Console.ReadLine();
 			}
 			Console.Clear();
 			bool audiencia = false;
 			PilaAux = new Pila();
 			while(!pila.vacia())
 			{
 				ex = pila.desapilar();
 				if(ex.Tramite == "audiencia")
 				{
 					if(ex.Titular == "Gabriela Turco")
 					{
 						if(ex.FechaPresentacion.Month == 3)
 						{
 							audiencia = true;
 							break;
 						}
 					}
 				}
 				PilaAux.apilar(ex);
 			}
 			while(!PilaAux.vacia())
 			{
 				ex = PilaAux.desapilar();
 				pila.apilar(ex);
 			}
 			if(audiencia)
 			{
 				Console.WriteLine("Hay una audiencia de Gabriela Turco del mes de marzo ingresada\n");
 				Console.WriteLine(" TRAMITES REALIZADOS << FEBRERO >>\n");
 				while(!pila.vacia())
 				{
 					ex = pila.desapilar();
 					if(ex.Titular == "Gabriela Turco")
 					{
 						if(ex.FechaPresentacion.Month == 2)
 						{
 							Console.WriteLine("Expediente Nro. {0} despachado, a nombre de {1}, sobre {2}",ex.Numero, ex.Titular, ex.Tramite);
 						}
 					}
 				}
 			}
 			else
 			{
 				Console.WriteLine("NO hay una audiencia de Gabriela Turco del mes de marzo ingresada");
 			}
 			Console.ReadKey();
		}
	}
}