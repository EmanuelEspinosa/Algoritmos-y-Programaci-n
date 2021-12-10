using System;

namespace Proyecto_Farmacia
{
	public class sinEmpleadosException : Exception
	{
		public string motivo;
		public sinEmpleadosException(string motivo)
		{
			this.motivo = motivo;
		}
	}
}
