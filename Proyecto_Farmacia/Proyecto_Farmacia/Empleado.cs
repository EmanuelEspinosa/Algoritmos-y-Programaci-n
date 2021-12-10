using System;

namespace Proyecto_Farmacia
{
	public class Empleado
	{
		string nombre, apellido, codEmpleado;
		int dni;

//--------------------------------------------------------------------------------------		
		public Empleado(string nombre, string apellido, int dni, string codEmpleado)
		{
			this.nombre = nombre;
			this.apellido = apellido;
			this.dni = dni;
			this.codEmpleado = codEmpleado;
		}

//--------------------------------------------------------------------------------------		
		public string Nombre
		{
			get { return nombre; }
			set { nombre = value;}
		}
		
//--------------------------------------------------------------------------------------
		public string Apellido
		{
			get { return apellido; }
			set { apellido = value; }
		}

//--------------------------------------------------------------------------------------		
		public int Dni
		{
			get { return dni; }
			set { dni = value; }
		}

//--------------------------------------------------------------------------------------		
		public string CodEmpleado
		{
			get { return codEmpleado; }
			set { codEmpleado = value; }
		}
	
//--------------------------------------------------------------------------------------		
		public override string ToString()
		{
			return string.Format("Nombre: {0}\nApellido: {1}\nDni: {2}\nCodigo Empleado: {3}", nombre, apellido, dni, codEmpleado);
		}
		
//--------------------------------------------------------------------------------------		
	}
}
