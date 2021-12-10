using System;
using System.Collections;

namespace Proyecto_Farmacia
{
	class Program
	{
		public static void Main(string[] args)
		{
			Farmacia farmacia = new Farmacia("Del Sur");
			bool sigue;
			do
			{
				try
				{
					sigue = false;
					menu();
					int opcion = int.Parse(Console.ReadLine());
					Console.Clear();
					while(opcion != 0)
					{
						switch (opcion) 
						{
							case 1:
								VenderMedicamento(farmacia);
								break;
							case 2:
								Console.Write("Ingrese número de ticket de la venta: ");
								int t = int.Parse(Console.ReadLine());
								Console.Clear();
								eliminoVenta(farmacia, t);
								break;
							case 3:
								Console.WriteLine(porcentVentas(farmacia));
								break;
							case 4 :
								Console.Write("Ingrese una droga: ");
								string droga = Console.ReadLine().ToUpper();
								Console.Clear();
								ListaDeVentas(farmacia, droga);
								break;
							case 5:
								AgregarEmpleado(farmacia);
								break;
							case 6:
								Console.Write("Ingrese N° Dni del empleado: ");
								int dni = int.Parse(Console.ReadLine());
								Console.Clear();
								borrarEmpleado(farmacia, dni);
								break;
							case 7:
								ListaDeEmpleados(farmacia);
								break;
							case 8:
								ListVen(farmacia);
								break;
							default:
								Console.WriteLine("INGRESO UNA OPCIÓN INCORRECTA INTENTELO NUEVAMENTE\n");
								break;
						}
						menu();
						opcion = int.Parse(Console.ReadLine());
						Console.Clear();
					}
				}
				catch (FormatException) 
				{
					Console.Clear();
					Console.WriteLine("DEBE INGRESAR UN CARACTER NUMERICO\n");
					sigue = true;
				}
			} 
			while (sigue);
			Console.WriteLine("PROGRAMA FINALIZADO");
			Console.ReadKey(true);
		}
		
		
//--------------------------------- MENU -----------------------------------------------------------------------------------------------------------------

		public static void menu()
		{
			Console.WriteLine("***************************** FARMACIA DEL SUR *****************************");
			Console.WriteLine();
			Console.WriteLine("1) Agregar una venta de medicamento");
			Console.WriteLine("2) Eliminar venta de medicamento");
			Console.WriteLine("3) Porcentaje de ventas realizadas en la primer quincena por obra social");
			Console.WriteLine("4) Lista de ventas de una droga dada");
			Console.WriteLine("5) Agregar empleado");
			Console.WriteLine("6) Borrar empleado");
			Console.WriteLine("7) Listado de empleados");
			Console.WriteLine("8) Lista de ventas sin repeticiones");
			Console.WriteLine("0) Para finalizar");
			Console.WriteLine();
			Console.WriteLine("******************************************************************************");
			Console.Write("Ingrese una opción del menu: ");
		}
		
		
//--------------------------------- OPCION 1 -----------------------------------------------------------------------------------------------------------------

		public static void VenderMedicamento(Farmacia farm)
		{	
			try 
			{
				string nombreComer = "", Droga = "", Obrasoc = "";
				int codEmple = 0, NTicket = 0, año = 0, mes = 0, dia = 0, hora = 0, min = 0, seg = 0;
				float importe = 0;
				Venta venta = null;		
				Console.WriteLine("1) Venta aleatoria");
				Console.WriteLine("2) Ingresar venta por teclado\n");
				Console.Write("Ingrese una opción: ");
				int opcion = int.Parse(Console.ReadLine());
				
				if(farm.cantidadEm() != 0)
				{
					switch (opcion) {
					case 1:
						Random random = new Random();
						string[] nomComer = new string[]{"TAFIROL","GENIOL","IBUPIRAC","VOLTAREN"};
						string[] droga = new string[]{"PARACETAMOL","IBUPROFENO", "DICLOFENAC"};
						string[] OSocial = new string[]{"IOMA", "SWISS MEDICAL", "OSDE", "IOSFA", "PARTICULAR"};
						nombreComer = nomComer[random.Next(0,nomComer.Length)];
						Droga = droga[random.Next(0,droga.Length)];
						Obrasoc = OSocial[random.Next(0,OSocial.Length)];
						codEmple = random.Next(1000,4900);
						NTicket = random.Next(15000,900000);
						DateTime fecha = new DateTime(2021,9,random.Next(1,30),random.Next(0,23),random.Next(0,59),random.Next(0,59));
						importe = random.Next(100,500);
						venta = new Venta(nombreComer,Droga,Obrasoc,codEmple,NTicket,fecha,importe);
						farm.agregarVenta(venta);
						Console.Clear();
						Console.WriteLine("Venta realizada con éxito\n");
						break;
					case 2:
						Console.Clear();
						Console.Write("Ingrese nombre comercial del medicamento: ");
						nombreComer = Console.ReadLine().ToUpper();
						Console.Write("Ingrese droga del medicamento: ");
						Droga = Console.ReadLine().ToUpper();
						Console.Write("Si la venta es por Obra Social ingrese nombre de la misma, si no la palabra 'PARTICULAR': ");
						Obrasoc = Console.ReadLine().ToUpper();
						Console.Write("Ingrese código del empleado que realizo la venta: ");
						codEmple = int.Parse(Console.ReadLine());
						Console.Write("Ingrese número de ticket factura: ");
						NTicket = int.Parse(Console.ReadLine());
						Console.Write("Año: ");
						año = int.Parse(Console.ReadLine());
						Console.Write("Mes: ");
						mes = int.Parse(Console.ReadLine());
						Console.Write("Día: ");	
						dia = int.Parse(Console.ReadLine());
						Console.Write("Hora: ");
						hora = int.Parse(Console.ReadLine());
						Console.Write("Minutos: ");
						min = int.Parse(Console.ReadLine());
						Console.Write("Segundos: ");
						seg = int.Parse(Console.ReadLine());
						DateTime fechaVenta = new DateTime(año, mes, dia, hora, min, seg);
						Console.Write("Ingrese el importe de la compra: ");
						importe = float.Parse(Console.ReadLine());
						venta = new Venta(nombreComer, Droga, Obrasoc, codEmple, NTicket, fechaVenta, importe);
						farm.agregarVenta(venta);
						Console.Clear();
						Console.WriteLine("Venta realizada con éxito\n");
						break;
					default:
						Console.Clear();
						Console.WriteLine("Ingreso una opcion invalida. Intentelo nuevamente\n");
						break;
					}
				}
				else
				{
					const string motivo = "ERROR: No se pudo realizar la venta, ya que no hay ningun empleado que la pueda gestionar";
					throw new sinEmpleadosException(motivo);
				}
				
			} 
			catch (sinEmpleadosException e) 
			{
				Console.Clear();
				Console.WriteLine(e.motivo + "\n");
			}	
		}
		
		
//--------------------------------- OPCION 2 -----------------------------------------------------------------------------------------------------------------

		public static void eliminoVenta(Farmacia farm, int ticket)
		{
			farm.eliminarVenta(ticket);
		}		
		
		
//--------------------------------- OPCION 3 -----------------------------------------------------------------------------------------------------------------

		public static string porcentVentas(Farmacia farm)
		{
			float totalOSocial = 0, totalVentas = 0, totalsocial = 0, totalV = 0;
			int mes = 0, año = 0;
			
			if(farm.cantidadVentas() != 0)
			{
				foreach (Venta item in farm.todasVentas())
				{
					mes = item.FechaHora.Month;   año = item.FechaHora.Year;
					if(item.ObraSocial != "PARTICULAR")
					{
						if(item.FechaHora.Day >= 1 && item.FechaHora.Day <= 15)      //Primera quincena del mes de septiembre (mes 9). 
						{
							totalOSocial += item.Importe;
							totalsocial++;
						}
					}
					totalVentas += item.Importe;
					totalV++;
				}
				float porcentaje = (totalOSocial / totalVentas) * 100;
				float porc = (totalsocial / totalV) * 100;
			
				return "INFORMACIÓN --> MES: "+mes+", AÑO: "+año+"\n"+
				"EL PORCENTAJE DE VENTAS (RESPECTO A CANTIDAD) CON OBRA SOCIAL DE LA PRIMER QUINCENA ES: "+ (int)porc+"%\n"+
				"EL PORCENTAJE DE VENTAS (RESPECTO A IMPORTE) CON OBRA SOCIAL DE LA PRIMER QUINCENA ES: "+ (int)porcentaje + "%\n";				
			}
			return "NO HAY VENTAS CARGADAS EN EL SISTEMA\n";
		}		

		
//--------------------------------- OPCION 4 -----------------------------------------------------------------------------------------------------------------		

		public static void ListaDeVentas(Farmacia farm, string droga)
		{
			bool flag = false;
			if(farm.cantidadVentas() != 0)
			{
				foreach (Venta element in farm.todasVentas())
				{
					if(element.Droga == droga)
					{
						Console.WriteLine(element + "\n");
						flag = true;
					}
						
				}
				if(!flag)
					Console.WriteLine("NO SE REGISTRAN VENTAS DE MEDICAMENTOS CON LA DROGA INGRESADA\n");
			}
			else
				Console.WriteLine("NO HAY VENTAS CARGADAS EN EL SISTEMA\n");
		}
		

//--------------------------------- OPCION 5 -----------------------------------------------------------------------------------------------------------------		

		public static void AgregarEmpleado(Farmacia farm)
		{
			string nombre = "", apellido = "", codigoID = "";
			int dni = 0;
			Empleado empleado = null;
			Console.WriteLine("1) Agregar aleatoriamente");
			Console.WriteLine("2) Agregar por teclado\n");
			Console.Write("Ingrese una opción: ");
			int opcion = int.Parse(Console.ReadLine());	
			switch (opcion) {
				case 1:
					Random random = new Random();
					string[] nombres = new string[]{"Sebastian", "Marta", "Federico", "Alejandro", "Sebastian", "Graciela", "Isabel", "Ana"};
					string[] apellidos = new string[]{"Gonzalez", "Ruiz", "Perez", "Garcia", "Acosta", "Souza", "Alvarez", "Ortiz"};
					nombre = nombres[random.Next(0,nombres.Length)];
					apellido = apellidos[random.Next(0, apellidos.Length)];
					dni = random.Next(25000000, 42000000);
					codigoID = generarIDempleado(nombre, apellido, dni);
					empleado = new Empleado(nombre, apellido, dni, codigoID);
					farm.agregarEmp(empleado);
					Console.Clear();
					Console.WriteLine("Empleado agregado con éxito\n");
					break;
				case 2:
					Console.Clear();
					Console.Write("Ingrese nombre del empleado: ");
					nombre = Console.ReadLine();
					Console.Write("Ingresar apellido del empleado: ");
					apellido = Console.ReadLine();
					Console.Write("Ingrese N° Dni del empleado: ");
					dni = int.Parse(Console.ReadLine());
					codigoID = generarIDempleado(nombre, apellido,  dni);
					empleado = new Empleado(nombre, apellido, dni, codigoID);
					farm.agregarEmp(empleado);
					Console.Clear();
					Console.WriteLine("Empleado agregado con éxito\n");
					break;
				default:
					Console.Clear();
					Console.WriteLine("Ingreso una opción incorrecta. Intentelo nuevamente\n");
					break;		
			}	
		}
		

//--------------------------------- OPCION 6 -----------------------------------------------------------------------------------------------------------------	

		public static void borrarEmpleado(Farmacia farm, int dni)
		{
			bool esta = false;
			try 
			{
				foreach (Empleado item in farm.todosEmp()) 
				{
					if(item.Dni == dni)
					{
						esta = true;
						farm.eliminarEmp(item);
						break;
					}		
				}
				if(esta)
					Console.WriteLine("EMPLEADO BORRADO DEL SISTEMA CON ÉXITO\n");
				if(!esta)
				{
					const string motivo = "NO SE ENCONTRO EL EMPLEADO CON EL DNI INGRESADO\n";
					throw new DniInexistenteException(motivo);
				}		
			} 
			catch (DniInexistenteException e) 
			{
				Console.WriteLine(e.motivo);	
			}
		}


//--------------------------------- OPCION 7 -----------------------------------------------------------------------------------------------------------------		

		public static void ListaDeEmpleados(Farmacia farm)
		{
			if(farm.cantidadEm() != 0)
			{
				foreach (var element in farm.todosEmp())
				{
					Console.WriteLine(element + "\n");
				}
			}
			else
				Console.WriteLine("NO HAY EMPLEADOS CARGADOS EN EL SISTEMA\n");
		}
		

//--------------------------------- OPCION 8 -----------------------------------------------------------------------------------------------------------------		
		
		public static void ListVen(Farmacia farm)
		{
			/*ACLARACIÓN: Se utiliza un ArrayList para guardar los elementos sin repeticiones, aunque se podria haber usado
			 otra estructura de datos, como puede ser una lista generica, un arreglo, una lista simplemente enlazada, etc. 
			 Vale aclararlo, ya que el usuario que utilice las clases no sabe en que tipo de estructura de datos se van a 
			 almacenar los objetos dentro de estas, lo unico que conoce de las clases son sus metodos y el tipo de dato que 
	         estos retornan*/
			ArrayList listaSinRepeticiones = new ArrayList();
			bool esta = false;
			if(farm.cantidadVentas() != 0)
			{
				for (int i = 0; i < farm.cantidadVentas(); i++) 
				{
					Venta v = farm.verVenta(i);
					if(listaSinRepeticiones.Count == 0)
						listaSinRepeticiones.Add(v);
					else
					{
						foreach (Venta item in listaSinRepeticiones) 
						{
							if(item.NroTicketFactura == v.NroTicketFactura)
							{
								esta = true;
								break;
							}
							esta = false;
						}
						if(!esta)
							listaSinRepeticiones.Add(v);
					}	   
				}
				
				foreach (var item in listaSinRepeticiones) 
				{
					Console.WriteLine(item + "\n");
				}
			}
			else
				Console.WriteLine("NO HAY VENTAS CARGADAS EN EL SISTEMA\n");
		}
		
//--------------------------------------------------------------------------------------------------------------------------------------------------		
		
		public static string generarIDempleado(string nombre, string apellido,  int Dni)
		{
			string nomb = nombre.Substring(0,2).ToUpper();
			string apell = apellido.Substring(apellido.Length - 2).ToUpper();
			string Dni1parte = Dni.ToString().Substring(0,4);
			string Dni2parte = Dni.ToString().Substring(4,4);
			return nomb + Dni1parte + apell + Dni2parte;
		}
				
		
//--------------------------------------------------------------------------------------------------------------------------------------------------				
	}
	
}