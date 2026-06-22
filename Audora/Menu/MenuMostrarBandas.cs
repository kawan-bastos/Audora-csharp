using Audora.Modelos;
using Audora.Modelos.MusicBrainz;
using Audora.Services;

namespace Audora.Menu;

internal class MenuMostrarBandas : Menu
{
    public override async Task  Executar(Dictionary<string, Banda> registroDeBandas, Dictionary<int, Menu> menus)
    {
       await base.Executar(registroDeBandas, menus);
        Console.WriteLine(@"
████████╗░█████╗░██████╗░░█████╗░░██████╗  ░█████╗░░██████╗  ██████╗░░█████╗░███╗░░██╗██████╗░░█████╗░░██████╗
╚══██╔══╝██╔══██╗██╔══██╗██╔══██╗██╔════╝  ██╔══██╗██╔════╝  ██╔══██╗██╔══██╗████╗░██║██╔══██╗██╔══██╗██╔════╝
░░░██║░░░██║░░██║██║░░██║███████║╚█████╗░  ███████║╚█████╗░  ██████╦╝███████║██╔██╗██║██║░░██║███████║╚█████╗░
░░░██║░░░██║░░██║██║░░██║██╔══██║░╚═══██╗  ██╔══██║░╚═══██╗  ██╔══██╗██╔══██║██║╚████║██║░░██║██╔══██║░╚═══██╗
░░░██║░░░╚█████╔╝██████╔╝██║░░██║██████╔╝  ██║░░██║██████╔╝  ██████╦╝██║░░██║██║░╚███║██████╔╝██║░░██║██████╔╝
░░░╚═╝░░░░╚════╝░╚═════╝░╚═╝░░╚═╝╚═════╝░  ╚═╝░░╚═╝╚═════╝░  ╚═════╝░╚═╝░░╚═╝╚═╝░░╚══╝╚═════╝░╚═╝░░╚═╝╚═════╝░");
        Console.WriteLine("----------------------------------------------------");

        Console.Write("Qual banda vc deseja encontrar:");
        string resposta = Console.ReadLine();
        var musicBrainz = new MusicBrainz();
        ArtistaMusicBrainz pesquisa = await musicBrainz.BuscarArtista(resposta);
      

        Console.WriteLine("\n--------------------------");
        Console.WriteLine($"Nome Completo: {pesquisa.Aliases[0].Nome}");
        Console.WriteLine($"Nome Artistico: {pesquisa.Nome}");
        Console.WriteLine($"Data De Inicio: {pesquisa.DataDeInicio.Data}");
        Console.WriteLine($"Local de Origem: {pesquisa.LocalDeInicio.Nome}");
        Console.WriteLine("--------------------------");
        Console.Write("\nAperte uma tecla para Voltar ao Menu Principal:");
        Console.ReadKey();

    }

}
