using Audora.Modelos;
using System.Globalization;

namespace Audora.Menu;

internal class MenuAvaliarAlbum : Menu
{
    public override void Executar(Dictionary<string, Banda> registroDeBandas, Dictionary<int, Menu> menus)
    {
        do
        {
            base.Executar(registroDeBandas, menus);
            Console.Clear();
            Console.WriteLine(@"
░█████╗░██╗░░░██╗░█████╗░██╗░░░░░██╗░█████╗░███╗░░██╗██████╗░░█████╗░ | ░█████╗░██╗░░░░░██████╗░██╗░░░██╗███╗░░░███╗
██╔══██╗██║░░░██║██╔══██╗██║░░░░░██║██╔══██╗████╗░██║██╔══██╗██╔══██╗ | ██╔══██╗██║░░░░░██╔══██╗██║░░░██║████╗░████║
███████║╚██╗░██╔╝███████║██║░░░░░██║███████║██╔██╗██║██║░░██║██║░░██║ | ███████║██║░░░░░██████╦╝██║░░░██║██╔████╔██║
██╔══██║░╚████╔╝░██╔══██║██║░░░░░██║██╔══██║██║╚████║██║░░██║██║░░██║ | ██╔══██║██║░░░░░██╔══██╗██║░░░██║██║╚██╔╝██║
██║░░██║░░╚██╔╝░░██║░░██║███████╗██║██║░░██║██║░╚███║██████╔╝╚█████╔╝ | ██║░░██║███████╗██████╦╝╚██████╔╝██║░╚═╝░██║
╚═╝░░╚═╝░░░╚═╝░░░╚═╝░░╚═╝╚══════╝╚═╝╚═╝░░╚═╝╚═╝░░╚══╝╚═════╝░░╚════╝░ | ╚═╝░░╚═╝╚══════╝╚═════╝░░╚═════╝░╚═╝░░░░░╚═╝");
            Console.WriteLine("----------------------------------------------------");


            foreach (string banda in registroDeBandas.Keys)
            {
                Console.WriteLine($"Banda: {banda}");
            }
            Console.Write("\nDigite o nome da banda que deseja avaliar o Album (Ou Digite 0 para Retornar ao menu inicial): ");
            string nomedaBanda = Console.ReadLine()!.Trim();
            nomedaBanda = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(nomedaBanda.ToLower());

            if (nomedaBanda == "0")
            {
                MensagemDeRetornoAoMenu();
                return;
            }

            if (registroDeBandas.ContainsKey(nomedaBanda)) 
            {                
                Banda banda = registroDeBandas[nomedaBanda];
                if (banda.Albuns.Count == 0)
                {
                    Console.WriteLine("\nEssa banda ainda não possui álbuns cadastrados para avaliação. Tente Novamente");
                    Thread.Sleep(2500);
                    continue;
                }
                Console.Write("\nBanda encontrada! Agora, escolha o álbum que deseja avaliar:");
                string albumEscolhido = Console.ReadLine()!.Trim();
                if (banda.Albuns.Any(a => a.Nome.Equals(albumEscolhido, StringComparison.OrdinalIgnoreCase)))
                {
                    Album album = banda.Albuns.First(a => a.Nome.Equals(albumEscolhido, StringComparison.OrdinalIgnoreCase));
                    Console.WriteLine($"\nÁlbum encontrado! Você escolheu avaliar o álbum: {albumEscolhido}");

                    Console.Write($"\nQue Nota esse album {albumEscolhido} merece? (Digite um número de 0 a 10): ");
                    string notaString = Console.ReadLine()!;
                    Avaliacao nota = Avaliacao.TryParse(notaString);

                    if (nota == null)
                    {
                        continue;
                    }
                

                    if (nota.Nota < 0 || nota.Nota > 10)
                    {
                        Console.WriteLine("\nNota inválida! Digite um número de 0 a 10.");
                        Thread.Sleep(1500);
                        continue;
                    }
                    album.AdicionarNota(nota);
                    Console.WriteLine($"\nAgradecemos por avaliar o Album {albumEscolhido} com a nota {nota.Nota}! Registrada com Sucesso");
                    Thread.Sleep(3000);
                    Console.Write("\nDeseja avaliar outro album? Digite 1 para sim ou 0 para voltar ao menu principal: ");
                    string resposta = Console.ReadLine()!;
                    if (resposta == "1")
                    {
                        continue;
                    }
                    else if (resposta == "0")
                    {
                        MensagemDeRetornoAoMenu();
                        return;
                    }
                    else
                    {
                        ExibirMensagemDeErro();
                        return;
                    }
                }

            }


                
            
            else
            {
                Console.Write("\nBanda não encontrada! Digite 1 para tentar novamente ou 0 para voltar ao menu Principal: ");
                string opcaoEscolhida = Console.ReadLine()!;
                if (opcaoEscolhida == "0")
                {
                    MensagemDeRetornoAoMenu();
                    return;
                }

            }


        } while (true);
            

    }
}
