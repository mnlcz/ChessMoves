namespace EJ5;
public class Rey : Pieza
{
    public Rey(string posicion) : base(posicion) => Nombre = 'K';

    public override List<string> Movimientos()
    {
        var movimientos = new List<string>();
        LogicaMovimientos.Norte1(movimientos, this);
        LogicaMovimientos.Sur1(movimientos, this);
        LogicaMovimientos.Este1(movimientos, this);
        LogicaMovimientos.Oeste1(movimientos, this);
        LogicaMovimientos.DiagonalEste1(movimientos, this);
        LogicaMovimientos.DiagonalOeste1(movimientos, this);
        return movimientos;
    }
}