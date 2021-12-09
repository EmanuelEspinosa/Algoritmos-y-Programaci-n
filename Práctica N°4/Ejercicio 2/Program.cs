using System;

namespace Ejercicio_2
{
	class Program
	{
		public static void Main(string[] args)
		{
			Hora h = new Hora(23,30,15);
            Hora h2 = new Hora("14:25:47");
            h.imprimir();
            h2.imprimir();
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
        public Hora(string clock)
        {
            string[] stringSepa = clock.Split(':');
            time=int.Parse(stringSepa[0]);
            minute=int.Parse(stringSepa[1]);
            second=int.Parse(stringSepa[2]);

        }
        public void imprimir()
        {
            Console.WriteLine("{0} HORAS, {1} MINUTOS Y {2} SEGUNDOS", time, minute, second);
        }
    }
}