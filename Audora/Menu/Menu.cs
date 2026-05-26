using Audora.Modelos;

namespace Audora.Menu;

internal abstract class Menu
{
    public static void MensagemDeRetornoAoMenu()
    {
        Console.WriteLine("\nRetornando ao menu principal...");
        Thread.Sleep(2000);
    }

    public static void ExibirLogo()
    {
        Console.WriteLine(@"                    _                 
     /\            | |                
    /  \  _   _  __| | ___  _ __ __ _ 
   / /\ \| | | |/ _` |/ _ \| '__/ _` |
  / ____ \ |_| | (_| | (_) | | | (_| |
 /_/    \_\__,_|\__,_|\___/|_|  \__,_|
                                      
                                      ");
        Console.WriteLine("Bem-vindo a Audora!");
    }

    public static void ExibirMensagemDeErro()
    {
        Console.WriteLine("Opcao Invalida retornando ao menu principal...");
        Thread.Sleep(2000);
        return;
    }

    public virtual void Executar(Dictionary<string, Banda> registroDeBandas, Dictionary<int, Menu> menus)
    {
        Console.Clear();
    }


}
