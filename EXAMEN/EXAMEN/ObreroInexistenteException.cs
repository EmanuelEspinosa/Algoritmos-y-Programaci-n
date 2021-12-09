using System;

namespace EXAMEN
{
	public class ObreroInexistenteException : Exception
	{
		public string motivo;
        public ObreroInexistenteException(string motivo)
        {
            this.motivo = motivo;
        }
	}
}
