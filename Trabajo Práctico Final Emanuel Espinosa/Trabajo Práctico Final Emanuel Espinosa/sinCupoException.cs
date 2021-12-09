using System;

namespace Trabajo_Práctico_Final_Emanuel_Espinosa
{
	public class sinCupoException : Exception
	{
		public string motivo;
        public sinCupoException(string motivo)
        {
            this.motivo = motivo;
        }
	}
}
