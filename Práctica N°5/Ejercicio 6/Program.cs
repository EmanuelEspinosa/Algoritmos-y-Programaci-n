using System;

namespace Ejercicio_6
{
	class Program
	{
		public static void Main(string[] args)
		{
			string opcion;
 			int serv, dni, cont1=0, cont2=0;
 			Cliente Client1,Client2;
 			Cola col1 = new Cola();
 			Cola col2 = new Cola();
 			menu();
 			opcion = Console.ReadLine();
 			Console.Clear();
 			while(opcion != "F")
 			{
 				if(opcion == "C")
 				{
 					Console.WriteLine("Cod. 0150 - Seguro Vivienda\nCod. 0170 - Seguro Automóvil"); 
 					Console.WriteLine("Ingrese el número de servicio: ");
 					serv = Convert.ToInt32(Console.ReadLine());
 					Console.Clear();
 					if(serv == 0150)
 					{
 						Console.WriteLine("Ingrese el DNI del cliente: ");
 						dni = Convert.ToInt32(Console.ReadLine());
 						cont1++;
 						Client1 = new Cliente(dni, cont1);
 						col1.encolar(Client1);
 					}
 					if(serv == 0170)
 					{
 						Console.WriteLine("Ingrese el DNI del cliente: ");
 						dni = Convert.ToInt32(Console.ReadLine());
 						cont2++;
 						Client2 = new Cliente(dni,cont2);
 						col2.encolar(Client2);
 					}
 					if(serv != 0150 && serv != 0170)
 					{
 						Console.WriteLine("Ingreso un número de servicio equivocado\nINTENTELO NUEVAMENTE");
 					}
 				}
 				if(opcion == "A")
 				{
 					Console.WriteLine("Ingrese el número de servicio: ");
 					serv = Convert.ToInt32(Console.ReadLine());
 					if(serv == 0150)
 					{
 						if(!col1.vacia())
 						{
 							Client1 = col1.desencolar();
 							Console.WriteLine("..............................................");
 							Console.WriteLine("TURNO : A {0}", Client1.Turno);
 							Console.WriteLine("..............................................\n");
 							Console.WriteLine("Quedan {0} clientes en espera\n",col1.enEspera());
 						}
 					}
 					if(serv == 0170)
 					{
 						if(!col2.vacia())
 						{
 							Client2 = col2.desencolar();
 							Console.WriteLine("..............................................");
 							Console.WriteLine("TURNO : A {0}",Client2.Turno);
 							Console.WriteLine("..............................................\n");
 							Console.WriteLine("Quedan {0} clientes en espera\n",col2.enEspera());
 						}
 					}
 				}
 				menu();
 				opcion = Console.ReadLine();
 				Console.Clear();
 			}
 			Console.ReadKey();
		}
		public static void menu()
		{
			Console.WriteLine("INGRESE UNA DE LAS SIGUIENTES OPCIONES: ");
 			Console.WriteLine("'C' para cargar un nuevo cliente");
 			Console.WriteLine("'A' para anteder un cliente"); 
 			Console.WriteLine("'F' para finalizar" );
		}
	}
}