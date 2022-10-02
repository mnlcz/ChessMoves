namespace EJ5;
public class Reina : Pieza
{
    public Reina(string posicion) : base(posicion) => Nombre = 'Q';

    public override List<string> Movimientos()
    {
        var movimientos = new List<string>();
        LogicaMovimientos.Norte(movimientos, this);
        LogicaMovimientos.Sur(movimientos, this);
        LogicaMovimientos.Este(movimientos, this);
        LogicaMovimientos.Oeste(movimientos, this);
        LogicaMovimientos.DiagonalEste(movimientos, this);
        LogicaMovimientos.DiagonalOeste(movimientos, this);
        return movimientos;
    }
}