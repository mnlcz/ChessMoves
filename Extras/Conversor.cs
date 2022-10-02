namespace ChessMoves.Extras;

public static class Conversor
{
    // Pre: @codigo valido
    public static (int x, int y) Coordenada(string codigo)
    {
        var y = codigo[0] switch
        {
            'a' => 0,
            'b' => 1,
            'c' => 2,
            'd' => 3,
            'e' => 4,
            'f' => 5,
            'g' => 6,
            _ => 7,
        };
        var x = (int)char.GetNumericValue(codigo[1]) - 1;
        return (x, y);
    }

    public static string Codigo(int x, int y)
    {
        var codigo = "";
        switch (y)
        {
            case 1:
                codigo += 'a';
                break;
            case 2:
                codigo += 'b';
                break;
            case 3:
                codigo += 'c';
                break;
            case 4:
                codigo += 'd';
                break;
            case 5:
                codigo += 'e';
                break;
            case 6:
                codigo += 'f';
                break;
            case 7:
                codigo += 'g';
                break;
            case 8:
                codigo += 'h';
                break;
        }
        codigo += x + 1; // !! funca pero es raro.
        return codigo;
    }
}
