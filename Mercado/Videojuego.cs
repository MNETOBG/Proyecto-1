using System;

namespace Mercado
{
	public class Videojuego : Articulo
	{
		public Videojuego ()
		{
		}

		public Videojuego (string nombre, string descripcion, int codigo, double precio) : base (nombre, descripcion, codigo, precio)
		{

		}

		public override double Descuento ()
		{
			return ((precio * .25) - precio);
		}

		public override string ToString()
		{
			return "El videojuego " + getNombre () + " con descripcion " + getDescripcion () + ", codigo " + getCodigo () + " y precio de " + Descuento() + " fue comprado. \n";
		}
		
		//nuevo
		public override void Comprar()
		{
			Console.WriteLine ( "Compro: " + getNombre () + " con descripcion: " + getDescripcion () + " codigo " + getCodigo () + " y precio " + Descuento () + ".\n");
		}
	}
}

