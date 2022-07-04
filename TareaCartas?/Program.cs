using TareaCartas;

Mazo mazo = new Mazo();

Console.WriteLine("Bienvenido a el juego de cartas!");
int x = 0;

while (x!= 7)
{
    Console.WriteLine("Elija una de las siguientes opciones:");
    Console.WriteLine("");
    Console.WriteLine("1 - Barajar");
    Console.WriteLine("2 - Mostrar siguiente carta");
    Console.WriteLine("3 - Mostrar cartas disponibles");
    Console.WriteLine("4 - Dar cartas");
    Console.WriteLine("5 - Mostrar cartas del monton");
    Console.WriteLine("6 - Mostrar baraja");
    Console.WriteLine("7 - Salir");

    x = int.Parse(Console.ReadLine());

    switch(x)
    {
        case 1:
            mazo.Barajar();
            break;
        case 2:
            mazo.SiguienteCarta();
            break;
        case 3:
            mazo.CartasDisponibles();
            break;
        case 4:
            Console.WriteLine("Cuantas cartas quiere?");
            int aux = int.Parse(Console.ReadLine());
            mazo.DarCartas(aux);
            break;
        case 5:
            mazo.MostrarMonton();
            break;
        case 6:
            mazo.MostrarBaraja();
            break;

    }
}
if (x == 7)
{
    Console.WriteLine("Fin");
}





