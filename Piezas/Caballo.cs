using ChessMoves.Extras;
namespace ChessMoves.Piezas;

public class Caballo : Pieza
{
    public Caballo(string posicion) : base(posicion) => Nombre = 'C';

    public override List<string> Movimientos()
    {
        var movimientos = new List<string>();
        LogicaMovimientos.LNorte(movimientos, this);
        LogicaMovimientos.LSur(movimientos, this);
        return movimientos;
    }
}