using System;

namespace Trabajo_Práctico_Final_Emanuel_Espinosa
{
	public class Plan
	{
		/*VARIABLES DE INSTANCIA*/
		private string nombPlan, description;
    	private double precPlan;
    	
    	/*CONSTRUCTORES*/
    	public Plan()
    	{

    	}
    	public Plan(string nombre, double precio, string description)
    	{
        	nombPlan = nombre;
        	precPlan = precio;
        	this.description = description;
    	}
    	
    	/*PROPIEDADES*/
    	public string nombrePlan
    	{
        	set{nombPlan = value;}
        	get{return nombPlan;}
    	}
    	public double precioPlan
    	{
        	set{precPlan = value;}
        	get{return precPlan;}
    	}
    	public string Descripcion
    	{
        	set{description = value;}
        	get{return description;}
    	}
    	
    	/*METODOS*/
    	public void imprimirPlanEfectivo()
    	{
        	Console.WriteLine(" |{0}|${1}| {2}|",nombPlan.PadRight(9,' '), precPlan.ToString().PadRight(6,' '), description.PadRight(60,' '));
    	}
    	public void imprimirPlanTarjeta()
    	{
        	Console.WriteLine(" |{0}|${1}| {2}|",nombPlan.PadRight(9,' '), (precPlan * 0.85).ToString().PadRight(6,' '), description.PadRight(60,' '));
    	}
	}
}
