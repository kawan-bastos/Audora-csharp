
namespace Audora.Modelos;

internal class Avaliacao
{
    public Avaliacao(int nota)
    {
        Nota = nota;
    }

    public int Nota { get; }

    public static Avaliacao TryParse(string input)
    {
        if (int.TryParse(input, out int nota))
        {
            return new Avaliacao(nota);
        } else
        {
            Console.WriteLine("Opcao Invalida Tente Novamente");
            Thread.Sleep(2000);
            return null;
        }
        
    }
}
