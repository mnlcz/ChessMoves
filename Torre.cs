namespace EJ5;

public class Torre : Pieza
{
    public Torre(string posicion) : base(posicion) => Nombre = 'T';

    public override List<string> Movimientos()
    {
        var movimientos = new List<string>();
        Norte(movimientos);
        Sur(movimientos);
        Este(movimientos);
        Oeste(movimientos);
        return movimientos;
    }

    #region LOGICA
    private void Norte(List<string> mov)
    {
        var (x, y) = Conversor.Coordenada(Posicion);
        var distanciaDisponible = x;
        foreach (var m in Enumerable.Range(1, distanciaDisponible))
            mov.Add(Conversor.Codigo(x - m, y + 1));
    }

    private void Sur(List<string> mov)
    {
        var (x, y) = Conversor.Coordenada(Posicion);
        var distanciaDisponible = x;
        foreach (var m in Enumerable.Range(1, distanciaDisponible + 1))
            mov.Add(Conversor.Codigo(x + m, y + 1));
    }

    private void Este(List<string> mov)
    {
        var (x, y) = Conversor.Coordenada(Posicion);
        var distanciaDisponible = 8 - (++y);
        foreach (var m in Enumerable.Range(1, distanciaDisponible))
            mov.Add(Conversor.Codigo(x, y + m));
    }

    private void Oeste(List<string> mov)
    {
        var (x, y) = Conversor.Coordenada(Posicion);
        var distanciaDisponible = y;
        foreach (var m in Enumerable.Range(1, distanciaDisponible))
            mov.Add(Conversor.Codigo(x, m));
    }
    #endregion
}
