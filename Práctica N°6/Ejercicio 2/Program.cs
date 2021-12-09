using System;

namespace Ejercicio_2
{
	class Program
	{
		public static void Main(string[] args)
		{
			ClaseA impA = new ClaseA(); 
			ClaseA impB = new ClaseB(); 
			ClaseA impC = new ClaseC(); 
			ClaseA impD = new ClaseD(); 
			Console.Write("{0} {1} {2} {3}", impD, impC, impB, impA); 
			Console.ReadKey();
		}
	}
	class ClaseA
	{
		public override string ToString()
		{
			return "Clase A";
		}
	}
	class ClaseB : ClaseA
	{
		public override string ToString()
		{
			return "Clase B";
		}
	}
	class ClaseC : ClaseA
	{
		public override string ToString()
		{
			return "Clase C";
		}
	}
	class ClaseD : ClaseA
	{
		public override string ToString()
		{
			return "Clase D";
		}
	}
}