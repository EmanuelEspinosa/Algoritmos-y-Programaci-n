using System;
using System.Collections;

namespace Trabajo_Práctico_Final_Emanuel_Espinosa
{
	public class Cliente : Persona
	{
		/*VARIABLES DE INSTANCIA*/
		private string plan, nombTec = "NO TEC ASIG ZONA", location,motBaja, ClientCode, modoPago;        
        private double price;
        private DateTime highDate,lowDate;
        
        /*CONSTRUCTORES*/
        public Cliente()
        {

        }
        public Cliente(string nombre, string apellido, int dni, string localidad, string plan, string modoPago, string Code, DateTime fecha) : base(nombre,apellido,dni)
        {
            
			ClientCode = Code;
            location = localidad;
            this.plan = plan;
            this.modoPago = modoPago;           
            highDate = fecha;            
        }
        public Cliente (string nombre, string apellido, int dni, string localidad, string plan, string modoPago, double precio, string nameTec, string code, DateTime fecha) : base(nombre,apellido,dni)
        {
            location = localidad;
            ClientCode = code;
            this.plan = plan;
            this.modoPago = modoPago;
            price = precio;
            nombTec = nameTec;
            highDate = fecha;
        }
        public Cliente(string nombre,string apellido, int dni, string Code, DateTime fecha, string motivo): base(nombre,apellido,dni)
        {
            ClientCode = Code;
            lowDate = fecha;
            motBaja = motivo;
        }
        
        /*PROPIEDADES*/
        public string CodigoCliente
        {
            set{ClientCode = value;}
            get{return ClientCode;}
        }
        public string Localidad
        {
            set{location = value;}
            get{return location;}
        }
        public string tipoDePlan
        {
            set{plan = value;}
            get{return plan;}
        }
        public string formaPago
        {
            set{modoPago = value;}
            get{return modoPago;}
        }
        public double Precio
        {
            set{price = value;}
            get{return price;}
        }
        public string nombreTecnico
        {
            set{nombTec = value;}
            get{return nombTec;}
        }
        public string motivoBaja
        {
            set{motBaja = value;}
            get{return motBaja;}
        }
        public DateTime fechaAlta
        {
            set{highDate = value;}
            get{return highDate;}
        }
        public DateTime fechaBaja
        {
            set{lowDate = value;}
            get{return lowDate;}
        }
        
        /*METODOS*/
        public string asignarTecnico(ArrayList listTec)
        {
            Tecnico tecAux = new Tecnico();
            for(int i = 0; i < listTec.Count; i++)
            {
                tecAux = (Tecnico)listTec[i];
                if(location == tecAux.zonaAsignada)
                {
                    nombTec = tecAux.Nombre + " " + tecAux.Apellido;
                }
            }
            return nombTec;
        }
        public double asignarPrecio(ArrayList listPlanes)
        {
            Plan planelegido = new Plan();
            for(int t = 0; t < listPlanes.Count; t++)
            {
                planelegido = (Plan)listPlanes[t];
                if(plan == planelegido.nombrePlan)
                {
                    if(modoPago == "EFECTIVO")
                    {
                        price = planelegido.precioPlan;
                    }
                    if(modoPago == "DEBITO")
                    {
                        price = planelegido.precioPlan * 0.85;
                    }
                }
            }
            return price;
        }
        public void imprimir()
        {
            string codCLi = name.Substring(0,2) + "-" +documentNumber.ToString() + "-" + lastName.Substring(lastName.Length-2,2);
            Console.WriteLine("{0} | {1}| {2}|{3}| {4} | {5}|${6}|{7}| {8}|{9}|",codCLi,name.PadRight(12,' '),lastName.PadRight(12,' '),documentNumber,location.PadRight(16,' '),plan.PadRight(9,' '),price.ToString().PadRight(6,' '),modoPago.PadRight(8,' '), nombTec.PadRight(18,' '),highDate.ToString("dd/MM/yyyy"));
        }
        public void imprimir2()
        {
            string codCLi = name.Substring(0,2) + "-" +documentNumber.ToString() + "-" + lastName.Substring(lastName.Length-2,2);
            Console.WriteLine("{0} | {1}| {2}|{3}|{4}| {5}|", codCLi, name.PadRight(12,' '), lastName.PadRight(12,' '),documentNumber,lowDate.ToString("dd/MM/yyyy"), motBaja.PadRight(40,' '));
        }
	}
}
