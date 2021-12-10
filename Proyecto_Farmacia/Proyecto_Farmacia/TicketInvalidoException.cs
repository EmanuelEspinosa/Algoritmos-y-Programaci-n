using System;

namespace Proyecto_Farmacia
{
	public class TicketInvalidoException : Exception
	{
		public string motivo;
		public TicketInvalidoException(string motivo)
		{
			this.motivo = motivo;
		}
	}
}