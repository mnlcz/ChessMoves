namespace EJ5;
public static class LogicaMovimientos
{
    public static void Norte(List<string> mov, Pieza p)
    {
        var (x, y) = Conversor.Coordenada(p.Posicion);
        var distanciaDisponible = x;
        foreach (var m in Enumerable.Range(1, distanciaDisponible))
            mov.Add(Conversor.Codigo(x - m, y + 1));
    }

    public static void Sur(List<string> mov, Pieza p)
    {
        var (x, y) = Conversor.Coordenada(p.Posicion);
        var distanciaDisponible = x;
        foreach (var m in Enumerable.Range(1, distanciaDisponible + 1))
            mov.Add(Conversor.Codigo(x + m, y + 1));
    }

    public static void Este(List<string> mov, Pieza p)
    {
        var (x, y) = Conversor.Coordenada(p.Posicion);
        var distanciaDisponible = 8 - (++y);
        foreach (var m in Enumerable.Range(1, distanciaDisponible))
            mov.Add(Conversor.Codigo(x, y + m));
    }

    public static void Oeste(List<string> mov, Pieza p)
    {
        var (x, y) = Conversor.Coordenada(p.Posicion);
        var distanciaDisponible = y;
        foreach (var m in Enumerable.Range(1, distanciaDisponible))
            mov.Add(Conversor.Codigo(x, m));
    }

    public static void DiagonalEste(List<string> mov, Pieza p)
    {
        var (x1, y1, x2, y2) = SetupDiagonales(p);
        foreach (var _ in Enumerable.Range(1, x1))
        {
            x1--;
            y1++;
            x2++;
            y2++;
            mov.Add(Conversor.Codigo(x1, y1));
            mov.Add(Conversor.Codigo(x2, y2));
        }
    }

    public static void DiagonalOeste(List<string> mov, Pieza p)
    {
        var (x1, y1, x2, y2) = SetupDiagonales(p);
        foreach (var _ in Enumerable.Range(1, x1))
        {
            x1--;
            y1--;
            x2++;
            y2--;
            mov.Add(Conversor.Codigo(x1, y1));
            mov.Add(Conversor.Codigo(x2, y2));
        }
    }

    public static void LNorte(List<string> mov, Pieza p)
    {
        var (x, y) = Conversor.Coordenada(p.Posicion);
        /* 
            __
            |
            |
         */
        CalcularMovimiento(mov, x - 2, y + 2);

        /*
            __ __
            |
        */
        CalcularMovimiento(mov, x - 1, y + 3);

        /*
            __
              |
              |
        */
        CalcularMovimiento(mov, x - 2, y);

        /*
            __ __
                |
        */
        CalcularMovimiento(mov, x - 1, y - 1);
    }

    public static void LSur(List<string> mov, Pieza p)
    {
        var (x, y) = Conversor.Coordenada(p.Posicion);
        /* 
            |
            |__
        */
        CalcularMovimiento(mov, x + 2, y + 2);

        /* 
            |__ __
        */
        CalcularMovimiento(mov, x + 1, y + 3);

        /*
              |
            __|
        */
        CalcularMovimiento(mov, x + 2, y);

        /*
            __ __|
        */
        CalcularMovimiento(mov, x + 1, y - 1);
    }

    public static void Norte1(List<string> mov, Pieza p)
    {
        var (x, y) = Conversor.Coordenada(p.Posicion);
        CalcularMovimientoSimple(mov, x - 1, y + 1);
    }

    public static void Sur1(List<string> mov, Pieza p)
    {
        var (x, y) = Conversor.Coordenada(p.Posicion);
        CalcularMovimientoSimple(mov, x + 1, y + 1);
    }

    public static void Este1(List<string> mov, Pieza p)
    {
        var (x, y) = Conversor.Coordenada(p.Posicion);
        CalcularMovimientoSimple(mov, x, y + 2);
    }

    public static void Oeste1(List<string> mov, Pieza p)
    {
        var (x, y) = Conversor.Coordenada(p.Posicion);
        CalcularMovimientoSimple(mov, x, y);
    }

    public static void DiagonalEste1(List<string> mov, Pieza p)
    {
        var (x, y) = Conversor.Coordenada(p.Posicion);
        CalcularMovimientoSimple(mov, x - 1, y + 2);
        CalcularMovimientoSimple(mov, x + 1, y + 2);
    }

    public static void DiagonalOeste1(List<string> mov, Pieza p)
    {
        var (x, y) = Conversor.Coordenada(p.Posicion);
        CalcularMovimientoSimple(mov, x - 1, y);
        CalcularMovimientoSimple(mov, x + 1, y);
    }

    #region Auxiliares
    private static (int x1, int y1, int x2, int y2) SetupDiagonales(Pieza p)
    {
        var (x, y) = Conversor.Coordenada(p.Posicion);
        return (x, y + 1, x, y + 1);
    }

    private static void CalcularMovimiento(List<string> movimientos, int x, int y)
        => movimientos.Add(Conversor.Codigo(x, y));

    private static void CalcularMovimientoSimple(List<string> movimientos, int x, int y)
    {
        if (x < 8 && x >= 0 && y < 8 && y >= 0)
            movimientos.Add(Conversor.Codigo(x, y));
    }
    #endregion
}