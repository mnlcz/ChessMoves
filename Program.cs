using EJ5;

Juego.InicializarTablero();
Console.Write("Pieza a testear -> (P)eon - (T)orre - (C)aballo - (A)lfil - (Q)ueen - K(ing) <--: ");
Action test = Console.ReadLine()?.ToUpper()[0] switch
{
    'P' => Juego.TestPeon,
    'T' => Juego.TestTorre,
    'C' => Juego.TestCaballo,
    'A' => Juego.TestAlfil,
    'Q' => Juego.TestReina,
    'K' => Juego.TestRey,
    _ => () => Console.WriteLine("Opcion invalida."),
};
test();
