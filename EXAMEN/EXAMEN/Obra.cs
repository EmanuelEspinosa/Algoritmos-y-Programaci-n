using System;


namespace EXAMEN
{
	public class Obra
	{
		private int codigo;
        private string ubicacion;
        private string tipo;   /*casa, comercio, edificio, plaza, puente,etc…*/
        private Obrero jefeObra;
        private DateTime fechaContrato;

        public Obra()
        {

        }
        public Obra(int cod, string ubicacion, string tipo, Obrero Jefe, DateTime fecha)
        {
            codigo = cod;
            this.ubicacion = ubicacion;
            this.tipo = tipo;
            jefeObra = Jefe;
            fechaContrato = fecha;
        }
        public Obra(int cod, string ubicacion, string tipo, DateTime fecha)
        {
            codigo = cod;
            this.ubicacion = ubicacion;
            this.tipo = tipo;
            fechaContrato = fecha;
        }
        public int Codigo
        {
            set{codigo = value;}
            get{return codigo;}
        }
        public string Ubicacion
        {
            set{ubicacion = value;}
            get{return ubicacion;}
        }
        public string Tipo
        {
            set{tipo = value;}
            get{return tipo;}
        }
        public Obrero JefeObra
        {
            set{jefeObra = value;}
            get{return jefeObra;}
        }
        public DateTime FechaContrato
        {
            set{fechaContrato = value;}
            get{return fechaContrato;}
        }
        public void imprimir()
        {
            Console.WriteLine("{0} {1} {2} {3}", codigo, ubicacion,tipo, jefeObra.Apellido);
        }
	}
}
