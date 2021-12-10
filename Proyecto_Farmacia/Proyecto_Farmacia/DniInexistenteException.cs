using System;

namespace Proyecto_Farmacia
{
	public class DniInexistenteException : Exception
	{
		public string motivo;
		public DniInexistenteException(string motivo)
		{
			this.motivo = motivo;
		}
	}
}