using Audora.Modelos;

namespace Audora.Menu;

internal class MenuMostrarBandas : Menu
{
    public override void Executar(Dictionary<string, Banda> registroDeBandas, Dictionary<int, Menu> menus)
    {
        base.Executar(registroDeBandas, menus);
        Console.WriteLine(@"
████████╗░█████╗░██████╗░░█████╗░░██████╗  ░█████╗░░██████╗  ██████╗░░█████╗░███╗░░██╗██████╗░░█████╗░░██████╗
╚══██╔══╝██╔══██╗██╔══██╗██╔══██╗██╔════╝  ██╔══██╗██╔════╝  ██╔══██╗██╔══██╗████╗░██║██╔══██╗██╔══██╗██╔════╝
░░░██║░░░██║░░██║██║░░██║███████║╚█████╗░  ███████║╚█████╗░  ██████╦╝███████║██╔██╗██║██║░░██║███████║╚█████╗░
░░░██║░░░██║░░██║██║░░██║██╔══██║░╚═══██╗  ██╔══██║░╚═══██╗  ██╔══██╗██╔══██║██║╚████║██║░░██║██╔══██║░╚═══██╗
░░░██║░░░╚█████╔╝██████╔╝██║░░██║██████╔╝  ██║░░██║██████╔╝  ██████╦╝██║░░██║██║░╚███║██████╔╝██║░░██║██████╔╝
░░░╚═╝░░░░╚════╝░╚═════╝░╚═╝░░╚═╝╚═════╝░  ╚═╝░░╚═╝╚═════╝░  ╚═════╝░╚═╝░░╚═╝╚═╝░░╚══╝╚═════╝░╚═╝░░╚═╝╚═════╝░");
        Console.WriteLine("----------------------------------------------------");
        foreach (string banda in registroDeBandas.Keys)
        {
            Console.WriteLine($"Banda: {banda}");
        }
        Console.Write("Aperte qualquer tecla para voltar ao menu principal...");
        Console.ReadKey();
        return;
    }

}
