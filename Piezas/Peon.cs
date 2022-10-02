using ChessMoves.Extras;
namespace ChessMoves.Piezas;

public class Peon : Pieza
{
    public Peon(string posicion) : base(posicion) => Nombre = 'P';

    public override List<string> Movimientos()
    {
        var movimientos = new List<string>();
        LogicaMovimientos.Norte1(movimientos, this);
        return movimientos;
    }
}
