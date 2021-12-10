using System;

namespace Proyecto_Farmacia
{
	public class Venta
	{
		string nombreComercial, droga, obraSocial;
		int codEmpleado, nroTicketFactura;
		DateTime fechaHora;
		float importe;

//--------------------------------------------------------------------------------------------------------------------------------------------------------------------		
		public Venta(string nombreComercial, string droga, string obraSocial, int codEmpleado, int nroTicketFactura, DateTime fechaHora, float importe)
		{
			this.nombreComercial = nombreComercial;
			this.droga = droga;
			this.obraSocial = obraSocial;
			this.codEmpleado = codEmpleado;
			this.nroTicketFactura = nroTicketFactura;
			this.fechaHora = fechaHora;
			this.importe = importe;
		}

//--------------------------------------------------------------------------------------------------------------------------------------------------------------------		
		public string NombreComercial {
			get { return nombreComercial; }
			set { nombreComercial = value; }
		}

//--------------------------------------------------------------------------------------------------------------------------------------------------------------------
		public string Droga {
			get { return droga; }
			set { droga = value; }
		}

//--------------------------------------------------------------------------------------------------------------------------------------------------------------------
		public string ObraSocial {
			get { return obraSocial; }
			set { obraSocial = value; }
		}

//--------------------------------------------------------------------------------------------------------------------------------------------------------------------
		public int CodEmpleado {
			get { return codEmpleado; }
			set { codEmpleado = value; }
		}

//--------------------------------------------------------------------------------------------------------------------------------------------------------------------
		public int NroTicketFactura {
			get { return nroTicketFactura; }
			set { nroTicketFactura = value; }
		}

//--------------------------------------------------------------------------------------------------------------------------------------------------------------------
		public DateTime FechaHora {
			get { return fechaHora; }
			set { fechaHora = value; }
		}

//--------------------------------------------------------------------------------------------------------------------------------------------------------------------
		public float Importe {
			get { return importe; }
			set { importe = value; }
		}

//--------------------------------------------------------------------------------------------------------------------------------------------------------------------
		public override string ToString()
		{
			return string.Format("NombreComercial: {0}\nDroga: {1}\nObraSocial: {2}\nCodEmpleado: {3}\nNroTicketFactura: {4}\nFechaHora: {5}\nImporte: ${6}", nombreComercial, droga, obraSocial, codEmpleado, nroTicketFactura, fechaHora, importe);
		}

//--------------------------------------------------------------------------------------------------------------------------------------------------------------------		
	}
}