using EJ5;

Juego.InicializarTablero();
Console.Write("Pieza a testear -> (P)eon - (T)orre - (C)aballo - (A)lfil <--: ");
Action test = Console.ReadLine()?[0] switch
{
    'P' => Juego.TestPeon,
    'T' => Juego.TestTorre,
    'C' => Juego.TestCaballo,
    'A' => Juego.TestAlfil,
    _ => () => Console.WriteLine("Opcion invalida."),
};
test();
