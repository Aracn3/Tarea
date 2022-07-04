using System;
namespace TareaCartas
{
	public class Mazo : Carta
	{

		public List<Carta> mazoCartas { get; set; } = new List<Carta>();
		public List<Carta> monton { get; set; } = new List<Carta>();

		public Mazo()

		{

			mazoCartas.Add(new Carta { numero = 1, palo = "basto" });
			mazoCartas.Add(new Carta { numero = 2, palo = "basto" });
			mazoCartas.Add(new Carta { numero = 3, palo = "basto" });
			mazoCartas.Add(new Carta { numero = 4, palo = "basto" });
			mazoCartas.Add(new Carta { numero = 5, palo = "basto" });
			mazoCartas.Add(new Carta { numero = 6, palo = "basto" });
			mazoCartas.Add(new Carta { numero = 7, palo = "basto" });
			mazoCartas.Add(new Carta { numero = 10, palo = "basto" });
			mazoCartas.Add(new Carta { numero = 11, palo = "basto" });
			mazoCartas.Add(new Carta { numero = 12, palo = "basto" });

			mazoCartas.Add(new Carta { numero = 1, palo = "copas" });
			mazoCartas.Add(new Carta { numero = 2, palo = "copas" });
			mazoCartas.Add(new Carta { numero = 3, palo = "copas" });
			mazoCartas.Add(new Carta { numero = 4, palo = "copas" });
			mazoCartas.Add(new Carta { numero = 5, palo = "copas" });
			mazoCartas.Add(new Carta { numero = 6, palo = "copas" });
			mazoCartas.Add(new Carta { numero = 7, palo = "copas" });
			mazoCartas.Add(new Carta { numero = 10, palo = "copas" });
			mazoCartas.Add(new Carta { numero = 11, palo = "copas" });
			mazoCartas.Add(new Carta { numero = 12, palo = "copas" });

			mazoCartas.Add(new Carta { numero = 1, palo = "oros" });
			mazoCartas.Add(new Carta { numero = 2, palo = "oros" });
			mazoCartas.Add(new Carta { numero = 3, palo = "oros" });
			mazoCartas.Add(new Carta { numero = 4, palo = "oros" });
			mazoCartas.Add(new Carta { numero = 5, palo = "oros" });
			mazoCartas.Add(new Carta { numero = 6, palo = "oros" });
			mazoCartas.Add(new Carta { numero = 7, palo = "oros" });
			mazoCartas.Add(new Carta { numero = 10, palo = "oros" });
			mazoCartas.Add(new Carta { numero = 11, palo = "oros" });
			mazoCartas.Add(new Carta { numero = 12, palo = "oros" });

			mazoCartas.Add(new Carta { numero = 1, palo = "espadas" });
			mazoCartas.Add(new Carta { numero = 2, palo = "espada" });
			mazoCartas.Add(new Carta { numero = 3, palo = "espada" });
			mazoCartas.Add(new Carta { numero = 4, palo = "espada" });
			mazoCartas.Add(new Carta { numero = 5, palo = "espada" });
			mazoCartas.Add(new Carta { numero = 6, palo = "espada" });
			mazoCartas.Add(new Carta { numero = 7, palo = "espada" });
			mazoCartas.Add(new Carta { numero = 10, palo = "espada" });
			mazoCartas.Add(new Carta { numero = 11, palo = "espada" });
			mazoCartas.Add(new Carta { numero = 12, palo = "espada" });









		}


		public void MostrarBaraja()
		{
			foreach (Carta carta in mazoCartas)
			{
				Console.WriteLine($"{carta.numero} de {carta.palo}");

			}


		}

		public void MostrarMonton()
		{
            if (monton.Count > 0)
            {
				Console.WriteLine("***********");
				Console.WriteLine("Las cartas en tu monton son: ");
				foreach (Carta carta in monton)
				{
					
					Console.WriteLine(carta.numero + carta.palo);

				}
			}
            else
            {
				Console.WriteLine("Lo siento... todavia no hay ninguna carta en tu monton!");
            }
            


		}

		public void Barajar()
		{
			mazoCartas = mazoCartas.OrderBy(item => new Random().Next()).ToList();

		}

		public void SiguienteCarta()
		{
            if (mazoCartas.Count > 0)
            {
				Console.Write(mazoCartas[0]);

			}
            else
            {
				Console.WriteLine("No hay mas cartas en el mazo!");
				Console.WriteLine("(revise el monton o reinicie el juego");
            }

		}

        public void CartasDisponibles() => Console.WriteLine($"Cartas disponibles: {mazoCartas.Count}");


		// Dado un número de cartas que nos pidan, le devolveremos ese 
		// número de cartas (piensa que puedes devolver). En caso
		//de que haya menos cartas que las pedidas, no devolveremos nada pero debemos indicárselo al usuario.
		
		public void DarCartas(int cantidad)

		{
			int aux = cantidad;
            if (mazoCartas.Count<cantidad)
            {
				Console.WriteLine($"Esa cantidad no esta disponible.");

						            }
            else
            {
				Console.WriteLine("Estas son las cartas: ");
		    
		    
		    for (int i = 0; i < aux; i++)
                {

					Carta x = mazoCartas[0];

					Console.WriteLine($"{x.numero} de {x.palo}");
					mazoCartas.Remove(x);
					monton.Add(x);
				}

			}

		}
		
		
    }
}

