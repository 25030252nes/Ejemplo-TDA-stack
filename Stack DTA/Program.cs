using Stack_DTA;

internal class Program
{
    private static void Main(string[] args)
    {
        Pila p = new Pila();
        p.Push(10); p.Push(20); p.Push(30);
        Console.WriteLine(p.Buscar(20));
    }
}