namespace EJ5;
public class Alfil : Pieza
{
    public Alfil(string posicion) : base(posicion) => Nombre = 'A';

    public override List<string> Movimientos()
    {
        var movimientos = new List<string>();
        Este(movimientos);
        Oeste(movimientos);
        return movimientos;
    }

    #region LOGICA
    private void Oeste(List<string> movimientos)
    {
        var (x1, y1, x2, y2) = Setup();
        foreach (var _ in Enumerable.Range(1, x1))
        {
            x1--;
            y1--;
            x2++;
            y2--;
            movimientos.Add(Conversor.Codigo(x1, y1));
            movimientos.Add(Conversor.Codigo(x2, y2));
        }
    }

    private void Este(List<string> movimientos)
    {
        var (x1, y1, x2, y2) = Setup();
        foreach (var _ in Enumerable.Range(1, x1))
        {
            x1--;
            y1++;
            x2++;
            y2++;
            movimientos.Add(Conversor.Codigo(x1, y1));
            movimientos.Add(Conversor.Codigo(x2, y2));
        }
    }

    private (int x1, int y1, int x2, int y2) Setup()
    {
        var (x, y) = Conversor.Coordenada(Posicion);
        return (x, y + 1, x, y + 1);
    }
    #endregion
}