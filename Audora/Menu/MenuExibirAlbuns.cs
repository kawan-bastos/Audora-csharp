using Audora.Modelos;

namespace Audora.Menu;

internal class MenuExibirAlbuns : Menu
{
   public override void Executar(Dictionary<string, Banda> registroDeBandas, Dictionary<int, Menu> menus)
    {
        do
        {
            base.Executar(registroDeBandas, menus);
            Console.WriteLine(@"
████████╗░█████╗░██████╗░░█████╗░░██████╗  ░█████╗░░██████╗  ░█████╗░██╗░░░░░██████╗░██╗░░░██╗███╗░░██╗░██████╗
╚══██╔══╝██╔══██╗██╔══██╗██╔══██╗██╔════╝  ██╔══██╗██╔════╝  ██╔══██╗██║░░░░░██╔══██╗██║░░░██║████╗░██║██╔════╝
░░░██║░░░██║░░██║██║░░██║██║░░██║╚█████╗░  ██║░░██║╚█████╗░  ███████║██║░░░░░██████╦╝██║░░░██║██╔██╗██║╚█████╗░
░░░██║░░░██║░░██║██║░░██║██║░░██║░╚═══██╗  ██║░░██║░╚═══██╗  ██╔══██║██║░░░░░██╔══██╗██║░░░██║██║╚████║░╚═══██╗
░░░██║░░░╚█████╔╝██████╔╝╚█████╔╝██████╔╝  ╚█████╔╝██████╔╝  ██║░░██║███████╗██████╦╝╚██████╔╝██║░╚███║██████╔╝
░░░╚═╝░░░░╚════╝░╚═════╝░░╚════╝░╚═════╝░  ░╚════╝░╚═════╝░  ╚═╝░░╚═╝╚══════╝╚═════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░");
            Console.WriteLine("----------------------------------------------------");
            Console.Write("\nDe qual banda voce deseja ver os albuns (ou 0 para voltar ao menu principal): ");
            string nomeBanda = Console.ReadLine()!.Trim();

            if (nomeBanda == "0")
            {
                MensagemDeRetornoAoMenu();
                return;
            }
    
            if (registroDeBandas.ContainsKey(nomeBanda))
            {
                if (registroDeBandas[nomeBanda].Albuns.Count == 0)
                {
                    Console.WriteLine($"\nEssa banda não possui álbuns cadastrados. Tente outra banda ou registre um novo Album para {nomeBanda}.");
                    Thread.Sleep(4000);
                    continue;
                }
                Console.WriteLine($"Albuns da banda {nomeBanda}:\n");
                foreach (var album in registroDeBandas[nomeBanda].Albuns)
                {
                    Console.WriteLine($"Album: {album.Nome}\n");
                }
                Console.Write("Aperte qualquer tecla para reiniciar!");
                Console.ReadKey();

            }
            else
            {
                Console.WriteLine("\nBanda não encontrada. Tente novamente.");
                Thread.Sleep(2000);
                continue;
            }
            
        } while (true);
    }

}
