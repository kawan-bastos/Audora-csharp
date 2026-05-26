namespace Audora.Menu;

internal class ValidacaoNumerica 
{
    public bool ExecutarValidacao(string opcaoEscolhida, out int opcaoNumerica)
    {
        if (!int.TryParse(opcaoEscolhida, out opcaoNumerica))
        {
            Console.WriteLine("\nOpção inválida! Tente novamente.");
            Thread.Sleep(1500);
            return false;
        }

        return true;
    }
}
