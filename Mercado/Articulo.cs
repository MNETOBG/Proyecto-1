using System;

namespace Mercado
{
	public class Articulo
	{
		public string nombre, descripcion;
		public int codigo;
		public double precio;

		public Articulo ()
		{
		}

		public Articulo (string nombre, string descripcion, int codigo, double precio)
		{
			this.nombre = nombre;
			this.descripcion = descripcion;
			this.codigo = codigo;
			this.precio = precio;
		}

		public void setNombre(string nombre)
		{
			this.nombre = nombre;
		}

		public string getNombre()
		{
			return nombre;
		}

		public void setDescripcion(string descripcion)
		{
			this.descripcion = descripcion;
		}

		public string getDescripcion()
		{
			return descripcion;
		}

		public void setCodigo(int codigo)
		{
			this.codigo = codigo;
		}

		public int getCodigo()
		{
			return codigo;
		}

		public void setPrecio(double precio)
		{
			this.precio = precio;
		}

		public double getPrecio()
		{
			return precio;
		}

		public virtual double Descuento()
		{
			return precio;
		}
			
		public override string ToString()
		{
			return " " + getNombre () + " " + getDescripcion () + " " + getCodigo () + " " + getPrecio (); 
		}

		//nuevo
		public virtual void Comprar()
		{
			Console.WriteLine (" " + getNombre () + " " + getDescripcion () + " " + getCodigo () + " " + Descuento()); 
		}
	}
}

