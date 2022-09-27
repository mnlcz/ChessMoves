namespace EJ5;
public class Caballo : Pieza
{
    public Caballo(string posicion) : base(posicion) => Nombre = 'C';

    public override List<string> Movimientos()
    {
        var movimientos = new List<string>();
        Norte(movimientos);
        Sur(movimientos);
        return movimientos;
    }

    #region LOGICA
    private void Sur(List<string> movimientos)
    {
        var (x, y) = Conversor.Coordenada(Posicion);
        /* 
            |
            |__
        */
        CalcularMovimiento(movimientos, x + 2, y + 2);

        /* 
            |__ __
        */
        CalcularMovimiento(movimientos, x + 1, y + 3);

        /*
              |
            __|
        */
        CalcularMovimiento(movimientos, x + 2, y);

        /*
            __ __|
        */
        CalcularMovimiento(movimientos, x + 1, y - 1);
    }

    private void Norte(List<string> movimientos)
    {
        var (x, y) = Conversor.Coordenada(Posicion);
        /* 
            __
            |
            |
         */
        CalcularMovimiento(movimientos, x - 2, y + 2);

        /*
            __ __
            |
        */
        CalcularMovimiento(movimientos, x - 1, y + 3);

        /*
            __
              |
              |
        */
        CalcularMovimiento(movimientos, x - 2, y);

        /*
            __ __
                |
        */
        CalcularMovimiento(movimientos, x - 1, y - 1);
    }

    private static void CalcularMovimiento(List<string> movimientos, int x, int y)
        => movimientos.Add(Conversor.Codigo(x, y));
    #endregion
}