using System.IO;
using System;

namespace Mercado
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int i = 0;

			StreamWriter escribir;
			escribir = new StreamWriter("ProyectoBautistaMauricio.txt", true);

			//Videojuego vid1 = new Videojuego ("Gran Turismo", "Clasificacion E", 32567, 999.99d);
			//Accesorio acc1 = new Accesorio ("Headset", "Sony", 567443, 350.50d);
			//Consola con1 = new Consola ("PlayStation", "Sony",53278, 4999.99d );
			Articulo vid2 = new Videojuego ();
			Articulo acc2 = new Accesorio ();
			Articulo con2 = new Consola ();
			//Compra com1 = new Compra ();


			//nuevo
			Articulo[] art = new Articulo[3];
			art [0] = new Accesorio ("Headset", "Sony", 567443, 350.50d);
			art [1] = new Videojuego ("Gran Turismo", "Clasificacion E", 32567, 999.99d);
			art [2] = new Consola ("PlayStation", "Sony",53278, 4999.99d);
		
			//com1.setAccesorio (acc1);
			//com1.setConsola (con1);
			//com1.setVideojuego (vid1);
			escribir.WriteLine (art [0].Comprar());

			do {
				
				Console.WriteLine ("Que producto desea comprar?\n" +
				"1)Accesorio\n" +
				"2)Videojuego\n" +
				"3)Consola");
				i = Convert.ToInt32 (Console.ReadLine ());

			} while(i < 1 || i > 3);


				switch (i)
				{
				case 1:
					{ 
						Console.WriteLine("Ingrese el nombre del accesorio:");
					    acc2.setNombre( Console.ReadLine());
						Console.WriteLine("Ingrese una descripcion del accesorio:");
					    acc2.setDescripcion(Console.ReadLine());
						Console.WriteLine("Ingrese el codigo del accesorio:");
						acc2.setCodigo(Convert.ToInt32(Console.ReadLine()));
						Console.WriteLine("Ingrese el precio del accesorio:");
						acc2.setPrecio(Convert.ToDouble(Console.ReadLine()));

					art [0].Comprar ();
					art [1].Comprar ();
					art [2].Comprar ();

					Console.WriteLine ("\n Ademas se compro " + acc2.ToString());
					escribir.WriteLine ("\n Ademas se compro " + acc2.ToString());

					//Console.WriteLine (com1.ToString() + "\n Ademas se compro " + acc2.ToString());
					//escribir.WriteLine(com1.ToString() + "\n Ademas se compro " + acc2.ToString());
					
						escribir.Close();

					}
					break;
				case 2:
					{
							Console.WriteLine("Ingrese el nombre del videojuego:");
							vid2.setNombre(Console.ReadLine());
							Console.WriteLine("Ingrese una descripcion del videojuego:");
					        vid2.setDescripcion(Console.ReadLine());
							Console.WriteLine("Ingrese el codigo del videojuego:");
					     	vid2.setCodigo(Convert.ToInt32(Console.ReadLine()));
					 		Console.WriteLine("Ingrese el precio del videojuego:");
					    	vid2.setPrecio(Convert.ToDouble(Console.ReadLine()));

					art [0].Comprar ();
					art [1].Comprar ();
					art [2].Comprar ();

					Console.WriteLine ("\n Ademas se compro " + vid2.ToString());
					escribir.WriteLine ("\n Ademas se compro " + vid2.ToString());

					//Console.WriteLine (com1.ToString() + "\n Ademas se compro " + vid2.ToString());
					//escribir.WriteLine(com1.ToString() + "\n Ademas se compro " + vid2.ToString());
					escribir.Close();
					}
					break;

			case 3:
				{
					Console.WriteLine("Ingrese el nombre del consola:");
					con2.setNombre(Console.ReadLine());
					Console.WriteLine("Ingrese una descripcion del consola:");
					con2.setDescripcion(Console.ReadLine());
					Console.WriteLine("Ingrese el codigo del consola:");
					con2.setCodigo(Convert.ToInt32(Console.ReadLine()));
					Console.WriteLine("Ingrese el precio del consola:");
					con2.setPrecio(Convert.ToDouble(Console.ReadLine()));

					art [0].Comprar ();
					art [1].Comprar ();
					art [2].Comprar ();

					Console.WriteLine ("\n Ademas se compro " + con2.ToString());
					escribir.WriteLine ("\n Ademas se compro " + con2.ToString());

					//Console.WriteLine (com1.ToString() + "\n Ademas se compro " + con2.ToString());
					//escribir.WriteLine(com1.ToString() + "\n Ademas se compro " + con2.ToString());
					escribir.Close();
				}
				break;

				}

			Console.WriteLine("Gracias\n");
		}
	}
}
