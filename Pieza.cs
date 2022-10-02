namespace ChessMoves;

public abstract class Pieza
{
    public string Posicion;
    public char Nombre;

    public abstract List<string> Movimientos();

    public void ListarMovimientos()
    {
        var movs = Movimientos();
        movs.ForEach(m => Console.Write($"{m} "));
        Console.WriteLine();
    }

    public Pieza(string posicion) => Posicion = posicion;
}
