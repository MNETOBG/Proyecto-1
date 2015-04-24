using System;

namespace Mercado
{
	public class Accesorio : Articulo
	{
		public Accesorio ()
		{
		}

		public Accesorio (string nombre, string descripcion, int codigo, double precio) : base (nombre, descripcion, codigo, precio)
		{
			
		}

		public override double Descuento ()
		{
			return ((precio * .20) - precio);
		}

		public override string ToString()
		{
			return "El accesorio " + getNombre () + " con descripcion " + getDescripcion () + ", codigo " + getCodigo () + " y precio de " + Descuento () + " fue comprado. \n"; 
		}

		//nuevo
		public override void Comprar()
		{
			Console.WriteLine ( "Compro: " + getNombre () + " con descripcion: " + getDescripcion () + " codigo " + getCodigo () + " y precio " + Descuento () + ".\n");
		}
	}
}

