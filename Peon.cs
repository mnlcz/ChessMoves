namespace EJ5
{
    public class Peon : Pieza
    {
        public Peon(string posicion) : base(posicion) => Nombre = 'P';

        public override List<string> Movimientos()
        {
            var movimientos = new List<string>();
            var x = Conversor.Coordenada(Posicion).x - 1;
            var y = Conversor.Coordenada(Posicion).y + 1; // !!
            if (x < 8 && x >= 0 && y < 8 && y >= 0)
                movimientos.Add(Conversor.Codigo(x, y));
            return movimientos;
        }
    }
}
