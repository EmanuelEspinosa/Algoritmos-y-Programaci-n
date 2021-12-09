using System;

namespace Trabajo_Práctico_Final_Emanuel_Espinosa
{
	public class sinTecnicoException : Exception
	{
		public string motivo;
        public sinTecnicoException(string motivo)
        {
            this.motivo = motivo;
        }
	}
}
