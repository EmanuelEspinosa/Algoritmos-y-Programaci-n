using System;

namespace Ejercicio_1
{
	class Program
	{
		public static void Main(string[] args)
		{
			Hora h = new Hora(23,30,15);
            h.imprimir();
            Console.ReadKey();
		}
	}
	class Hora
	{
		public int time, minute, second;
        public Hora()
        {

        }
        public Hora(int hora, int minuto, int segundos)
        {
            time = hora;
            minute = minuto;
            second = segundos;
        }
        public void imprimir()
        {
            Console.WriteLine("{0} HORAS, {1} MINUTOS Y {2} SEGUNDOS", time, minute, second);
        }
	}
}