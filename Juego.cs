namespace EJ5;

public static class Juego
{
    public static readonly char[,] Tablero = new char[8, 8];

    public static void MostrarTablero() => LogicaMostrar(Tablero);

    public static void InicializarTablero() => LogicaInicializar(Tablero);

    private static void PonerPieza(Pieza p) => LogicaPonerPieza(Tablero, p);

    public static void MostrarMovimientos(Pieza p)
    {
        Console.Write("Movimientos disponibles: ");
        p.ListarMovimientos();
        var tableroTemporal = new char[8, 8];
        LogicaInicializar(tableroTemporal);
        LogicaPonerPieza(tableroTemporal, p);
        foreach(var i in p.Movimientos())
        {
            var (x, y) = Conversor.Coordenada(i);
            tableroTemporal[x, y] = 'o';
        }
        LogicaMostrar(tableroTemporal);

    }

    public static void Mover(Pieza p, string posicion)
    {
        var (x, y) = Conversor.Coordenada(posicion);
        if (!p.Movimientos().Contains(posicion) || Tablero[x, y] != '_')
            Console.WriteLine("Movimiento invalido" + Environment.NewLine);
        else
        {
            Console.WriteLine($"Movimiento: {p.Nombre} --> {posicion}");
            (x, y) = Conversor.Coordenada(p.Posicion);
            Tablero[x, y] = '_';
            p.Posicion = posicion;
            (x, y) = Conversor.Coordenada(p.Posicion);
            Tablero[x, y] = p.Nombre;
        }
    }

    #region TESTS
    public static void TestPeon() => LogicaTest(new Peon("d2"));

    public static void TestTorre() => LogicaTest(new Torre("d4"));
    
    public static void TestCaballo() => LogicaTest(new Caballo("d4"));

    public static void TestAlfil() => LogicaTest(new Alfil("d3"));
    #endregion

    #region LOGICA
    private static void LogicaTest(Pieza p)
    {
        PonerPieza(p);
        MostrarTablero();
        Console.WriteLine($"Posicion: {p.Posicion}");
        MostrarMovimientos(p);
        if (p.Movimientos().Count > 0)
            Mover(p, p.Movimientos().First());
        MostrarTablero();
    }

    private static void LogicaMostrar(char[,] tablero)
    {
        Console.WriteLine("\n   a b c d e f g h");
        Console.WriteLine("   _______________");
        for (int i = 0; i < 8; i++)
        {
            Console.Write($"{i + 1}| ");
            for (int j = 0; j < 8; j++)
            {
                Console.Write($"{tablero[i, j]} ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }

    private static void LogicaPonerPieza(char[,] tablero, Pieza p)
    {
        var (x, y) = Conversor.Coordenada(p.Posicion);
        tablero[x, y] = p.Nombre;
    }

    private static void LogicaInicializar(char[,] tablero)
    {
        for (int i = 0; i < 8; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                tablero[i, j] = '_';
            }
        }
    }
    #endregion
}
