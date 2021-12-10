using System;
using System.Collections;

namespace Proyecto_Farmacia
{
	public class Farmacia
	{
		ArrayList Empleados;
		ArrayList Ventas;
		string nombre;
		
//--------------------------------------------------------------		
		public Farmacia(string nombre)
		{
			this.nombre = nombre;
			Empleados = new ArrayList();
			Ventas = new ArrayList();
		}

//--------------------------------------------------------------		
		public void agregarVenta(Venta unaVenta)
		{
			Ventas.Add(unaVenta);
		}

//--------------------------------------------------------------		
		public void eliminarVenta(int ticket)
		{
			bool encontre = false;
			try 
			{
				foreach (Venta item in Ventas)
				{
					if(item.NroTicketFactura == ticket)
					{
						Ventas.Remove(item);
						encontre = true;
						break;
					}	
				}
				if(encontre)
					Console.WriteLine("VENTA ELIMINADA CON ÉXITO.\n");
				if(!encontre)
				{
					const string motivo = "NRO DE TICKET INVÁLIDO\n";
					throw new TicketInvalidoException(motivo);
				}
			}  
			catch (TicketInvalidoException e) 
			{
				Console.WriteLine(e. motivo);	
			}
		}

//--------------------------------------------------------------		
		public Venta verVenta(int index)
		{
			return (Venta)Ventas[index];
		}
//--------------------------------------------------------------		
		public ArrayList todasVentas()
		{
			return Ventas;
		}
		
//--------------------------------------------------------------
		public int cantidadVentas()
		{
			return Ventas.Count;
		}
		
//--------------------------------------------------------------
		public void agregarEmp(Empleado em)
		{
			Empleados.Add(em);
		}
		
//--------------------------------------------------------------
		public void eliminarEmp(Empleado em)
		{
			Empleados.Remove(em);
		}

//--------------------------------------------------------------		
		public Empleado verEmp(int index)
		{
			return (Empleado)Empleados[index];
		}
		
//--------------------------------------------------------------
		public ArrayList todosEmp()
		{
			return Empleados;
		}
		
//--------------------------------------------------------------		
		public int cantidadEm()
		{
			return Empleados.Count;
		}
		
//--------------------------------------------------------------		
	}
}