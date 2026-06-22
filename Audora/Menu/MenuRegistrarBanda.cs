using Audora.Modelos;
using System.Globalization;

namespace Audora.Menu;

internal class MenuRegistrarBanda : Menu
{
    public override async Task Executar(Dictionary<string, Banda> registroDeBandas, Dictionary<int, Menu> menus)
    {
        string nomeDaBanda;
        do
        {
            await base.Executar(registroDeBandas, menus);
            Console.WriteLine(@"
██████╗░███████╗░██████╗░██╗░██████╗████████╗██████╗░░█████╗░██████╗░
██╔══██╗██╔════╝██╔════╝░██║██╔════╝╚══██╔══╝██╔══██╗██╔══██╗██╔══██╗
██████╔╝█████╗░░██║░░██╗░██║╚█████╗░░░░██║░░░██████╔╝███████║██████╔╝
██╔══██╗██╔══╝░░██║░░╚██╗██║░╚═══██╗░░░██║░░░██╔══██╗██╔══██║██╔══██╗
██║░░██║███████╗╚██████╔╝██║██████╔╝░░░██║░░░██║░░██║██║░░██║██║░░██║
╚═╝░░╚═╝╚══════╝░╚═════╝░╚═╝╚═════╝░░░░╚═╝░░░╚═╝░░╚═╝╚═╝░░╚═╝╚═╝░░╚═╝

██████╗░░█████╗░███╗░░██╗██████╗░░█████╗░░██████╗
██╔══██╗██╔══██╗████╗░██║██╔══██╗██╔══██╗██╔════╝
██████╦╝███████║██╔██╗██║██║░░██║███████║╚█████╗░
██╔══██╗██╔══██║██║╚████║██║░░██║██╔══██║░╚═══██╗
██████╦╝██║░░██║██║░╚███║██████╔╝██║░░██║██████╔╝
╚═════╝░╚═╝░░╚═╝╚═╝░░╚══╝╚═════╝░╚═╝░░╚═╝╚═════╝░");
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("Registro de Bandas");
            Console.Write("\nDigite o nome da banda que deseja registrar (Ou Digite 0 para Retornar ao menu inicial): ");
            nomeDaBanda = Console.ReadLine()!.Trim();
            nomeDaBanda = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(nomeDaBanda.ToLower());
            Banda banda = new Banda(nomeDaBanda);

            if (nomeDaBanda == "0")
            {
                MensagemDeRetornoAoMenu();
                return;
            }

            if (registroDeBandas.ContainsKey(nomeDaBanda))
            {
                Console.WriteLine("\nOpção inválida! Banda já existente. Tente novamente.");
                Thread.Sleep(1500);
                Console.Clear();
                continue;
            }

            registroDeBandas.Add(nomeDaBanda, banda);

            Console.WriteLine($"\nA banda {nomeDaBanda} foi registrada com sucesso!");
            Console.Write("\nDeseja registrar outra banda? Digite 1 para sim ou 0 para voltar ao menu principal: ");
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

        } while (true);



    }
};