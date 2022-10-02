using ChessMoves.Extras;
namespace ChessMoves.Piezas;

public class Torre : Pieza
{
    public Torre(string posicion) : base(posicion) => Nombre = 'T';

    public override List<string> Movimientos()
    {
        var movimientos = new List<string>();
        LogicaMovimientos.Norte(movimientos, this);
        LogicaMovimientos.Sur(movimientos, this);
        LogicaMovimientos.Este(movimientos, this);
        LogicaMovimientos.Oeste(movimientos, this);
        return movimientos;
    }
}
