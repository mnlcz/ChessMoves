namespace EJ5;
public class Alfil : Pieza
{
    public Alfil(string posicion) : base(posicion) => Nombre = 'A';

    public override List<string> Movimientos()
    {
        var movimientos = new List<string>();
        LogicaMovimientos.DiagonalEste(movimientos, this);
        LogicaMovimientos.DiagonalOeste(movimientos, this);
        return movimientos;
    }
}