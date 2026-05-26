
using Audora.Modelos;

namespace Audora.Menu;

internal class MenuRegistrarAlbum : Menu
{
   public override void Executar(Dictionary<string, Banda> registroDeBandas, Dictionary<int, Menu> menus)
    {
        do
        {
            base.Executar(registroDeBandas, menus);
            Console.WriteLine(@"
██████╗░███████╗░██████╗░██╗░██████╗████████╗██████╗░░█████╗░  ██████╗░███████╗
██╔══██╗██╔════╝██╔════╝░██║██╔════╝╚══██╔══╝██╔══██╗██╔══██╗  ██╔══██╗██╔════╝
██████╔╝█████╗░░██║░░██╗░██║╚█████╗░░░░██║░░░██████╔╝██║░░██║  ██║░░██║█████╗░░
██╔══██╗██╔══╝░░██║░░╚██╗██║░╚═══██╗░░░██║░░░██╔══██╗██║░░██║  ██║░░██║██╔══╝░░
██║░░██║███████╗╚██████╔╝██║██████╔╝░░░██║░░░██║░░██║╚█████╔╝  ██████╔╝███████╗
╚═╝░░╚═╝╚══════╝░╚═════╝░╚═╝╚═════╝░░░░╚═╝░░░╚═╝░░╚═╝░╚════╝░  ╚═════╝░╚══════╝

░█████╗░██╗░░░░░██████╗░██╗░░░██╗███╗░░░███╗░██████╗
██╔══██╗██║░░░░░██╔══██╗██║░░░██║████╗░████║██╔════╝
███████║██║░░░░░██████╦╝██║░░░██║██╔████╔██║╚█████╗░
██╔══██║██║░░░░░██╔══██╗██║░░░██║██║╚██╔╝██║░╚═══██╗
██║░░██║███████╗██████╦╝╚██████╔╝██║░╚═╝░██║██████╔╝
╚═╝░░╚═╝╚══════╝╚═════╝░░╚═════╝░╚═╝░░░░░╚═╝╚═════╝░");
            Console.WriteLine("----------------------------------------------------");

            Console.WriteLine("\n");
            foreach (string banda in registroDeBandas.Keys)
            {
                Console.WriteLine($"Banda: {banda}");
            }
            Console.Write("\nDigite o nome da Banda que deseja registrar um album (ou 0 para voltar ao menu principal): ");
            string nomeDaBanda = Console.ReadLine()!.Trim();

            if (nomeDaBanda == "0")
            {
                MensagemDeRetornoAoMenu();
                return;
            }
            if (!registroDeBandas.ContainsKey(nomeDaBanda))
            {
                Console.Write("\nBanda nao encontrada. Digite 1 para tentar novamente ou 0 para voltar ao menu principal:");
                string opcaoEscolhida = Console.ReadLine()!;
                if (opcaoEscolhida == "0")
                {
                    MensagemDeRetornoAoMenu();
                    break;
                }
                else if (opcaoEscolhida == "1")
                {
                    continue;
                }
                else
                {
                    ExibirMensagemDeErro();
                    return;
                }
            }

            if (registroDeBandas.ContainsKey(nomeDaBanda))
            {
                Banda banda = registroDeBandas[nomeDaBanda];
                Console.WriteLine("Banda Encontrada Com Sucesso");
                Thread.Sleep(2000);
                Console.Write("\nDigite o Nome do Album que Deseja inserir: ");
                string nomeDoAlbum = Console.ReadLine()!.Trim();
                Album album = new Album(nomeDoAlbum);
                banda.AdicionarAlbum(album);
                Console.WriteLine($"\nRegistrando o album {nomeDoAlbum} para a banda {nomeDaBanda}...");
                Thread.Sleep(2000);
                Console.WriteLine($"Album: {nomeDoAlbum} adicionado com sucesso");
                Thread.Sleep(1000);
                Console.Write("\nDigite 1 registrar um novo album ou 0 para voltar ao menu principal:");
                string opcaoEscolhida = Console.ReadLine()!;
                if (opcaoEscolhida == "0")
                {
                    MensagemDeRetornoAoMenu();
                    break;
                }
                else if (opcaoEscolhida == "1")
                {
                    continue;
                }
                else
                {
                    ExibirMensagemDeErro();
                    return;
                }

            }
        } while (true);
    }

}
