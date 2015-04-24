using System;

namespace Mercado
{
	public class Consola : Articulo
	{
		public Consola ()
		{
		}

		public Consola (string nombre, string descripcion, int codigo, double precio) : base (nombre, descripcion, codigo, precio)
		{

		}

		public override double Descuento ()
		{
			return ((precio * .10) - precio);
		}

		public override string ToString()
		{
			return "La consola " + getNombre () + " con descripcion " + getDescripcion () + ", codigo " + getCodigo () + " y precio de " + Descuento () + " fue comprado. \n";
		}

		//Nuevo
		public override void Comprar()
		{
			Console.WriteLine ( "Compro: " + getNombre () + " con descripcion: " + getDescripcion () + " codigo " + getCodigo () + " y precio " + Descuento () + ".\n");
		}
	}
}

