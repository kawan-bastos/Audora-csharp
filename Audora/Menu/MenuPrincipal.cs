using Audora.Modelos;

namespace Audora.Menu;

internal class MenuPrincipal : Menu
{
   public override void Executar(Dictionary<string, Banda> registroDeBandas, Dictionary<int, Menu> menus)
    {
        int opcaoEscolhidaNumerica;
        string opcaoEscolhida;
        do
        {
            base.Executar(registroDeBandas, menus);
            ExibirLogo(); 
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Digite 1 para Registrar uma banda");
            Console.WriteLine("Digite 2 para Mostrar todas as bandas");
            Console.WriteLine("Digite 3 para Registrar um Album a Banda");
            Console.WriteLine("Digite 4 para Avaliar uma banda");
            Console.WriteLine("Digite 5 para Avaliar um álbum");
            Console.WriteLine("Digite 6 para Exibir todos os Albuns de uma Banda");
            Console.WriteLine("Digite 7 para Exibir detalhes de uma Banda");
            Console.WriteLine("Digite 0 para Sair");
            Console.WriteLine("--------------------------------");

            Console.Write("\nDigite a sua opção:");
            opcaoEscolhida = Console.ReadLine()!;
            ValidacaoNumerica validacao = new();
            if (!validacao.ExecutarValidacao(opcaoEscolhida, out opcaoEscolhidaNumerica))
            {
                continue;
            }          
            if (menus.ContainsKey(opcaoEscolhidaNumerica))
            {
                Menu menuOpcaoEscolhida = menus[opcaoEscolhidaNumerica];
                menuOpcaoEscolhida.Executar(registroDeBandas, menus);
            } 
            else if (opcaoEscolhidaNumerica == 0)
            {
                Console.WriteLine("Obrigado por usar o Audora!");
                Thread.Sleep(1500);
                break;
            }
            else
            {
                ExibirMensagemDeErro();
                continue;
            }
        } while (true);

    }
}
