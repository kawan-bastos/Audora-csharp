# Audora

Audora e uma aplicacao console em C#/.NET criada para estudar organizacao de projetos, menus, classes, colecoes, consumo de API e desserializacao de JSON.

O projeto simula um sistema musical onde o usuario pode registrar bandas, cadastrar albuns, avaliar bandas e albuns, consultar detalhes e pesquisar artistas usando a API publica da MusicBrainz.

## Tecnologias

- C#
- .NET 8
- Aplicacao console
- HttpClient
- System.Text.Json
- API MusicBrainz

## Como Executar

Na raiz do repositorio, entre na pasta do projeto e execute:

```bash
cd Audora
dotnet run
```

Tambem e possivel abrir a solucao pelo Visual Studio e executar o projeto por la.

## Funcionalidades Atuais

- Registrar bandas em memoria.
- Registrar albuns para uma banda.
- Avaliar bandas.
- Avaliar albuns.
- Exibir albuns cadastrados para uma banda.
- Exibir detalhes de uma banda.
- Pesquisar artistas/bandas na API MusicBrainz.
- Mostrar informacoes vindas da API, como nome artistico, nome alternativo, data de inicio e local de origem.

## Estrutura do Projeto

```text
Audora/
  Program.cs
  GlobalUsings.cs

  Menu/
    Menu.cs
    MenuPrincipal.cs
    MenuRegistrarBanda.cs
    MenuMostrarBandas.cs
    MenuRegistrarAlbum.cs
    MenuAvaliarBanda.cs
    MenuAvaliarAlbum.cs
    MenuExibirAlbuns.cs
    MenuExibirDetalhes.cs
    ValidacaoNumerica.cs

  Modelos/
    Album.cs
    Avaliacao.cs
    Banda.cs
    IAvaliavel.cs
    Musica.cs

    MusicBrainz/
      ArtistaMusicBrainz.cs
      RespostaMusicBrainz.cs
      AreaMusicBrainz.cs
      LifeMusicBrainz.cs
      AliasesMusicBrainz.cs

  Services/
    MusicBrainz.cs
```

## Como o Projeto Funciona

O `Program.cs` cria alguns dados iniciais, monta o dicionario de menus e inicia o `MenuPrincipal`.

O `MenuPrincipal` mostra as opcoes para o usuario e redireciona para o menu escolhido. Cada opcao do menu fica em uma classe propria dentro da pasta `Menu`.

As classes da pasta `Modelos` representam os dados principais do sistema, como `Banda`, `Album`, `Musica` e `Avaliacao`.

As classes dentro de `Modelos/MusicBrainz` representam o formato do JSON recebido da API MusicBrainz. Elas existem para ajudar o `JsonSerializer` a transformar a resposta da API em objetos C#.

A classe `Services/MusicBrainz.cs` e responsavel por conversar com a API externa. Ela usa `HttpClient`, envia o `User-Agent`, recebe o JSON e transforma a resposta em objetos do projeto.

## Fluxo da Busca na MusicBrainz

Quando o usuario escolhe pesquisar uma banda:

1. `MenuMostrarBandas` pergunta o nome do artista.
2. O nome digitado e enviado para o service `MusicBrainz`.
3. O service monta a URL da API.
4. O `HttpClient` faz a requisicao.
5. A resposta JSON e desserializada para `RespostaMusicBrainz`.
6. O primeiro artista encontrado e retornado para o menu.
7. O menu exibe as informacoes no console.

## Mudancas Futuras

- Tratar quando a API nao encontrar nenhum artista.
- Tratar campos nulos vindos da MusicBrainz, como aliases, data de inicio ou local de origem.
- Corrigir nomes com espaco, acento ou caracteres especiais usando tratamento de URL.
- Exibir mais de um resultado da busca e permitir que o usuario escolha o artista correto.
- Melhorar a exibicao dos dados da MusicBrainz no console.
- Separar melhor dados cadastrados localmente e dados vindos da API.
- Salvar bandas, albuns e avaliacoes em arquivo ou banco de dados.
- Criar testes para as classes principais.
- Reaproveitar melhor o `HttpClient` em vez de criar uma nova instancia a cada busca.
- Adicionar tratamento de erros mais especifico para falhas de internet, resposta vazia ou limite da API.

## Observacoes

Atualmente os dados cadastrados ficam apenas em memoria. Quando o programa e fechado, bandas, albuns e avaliacoes adicionados durante a execucao sao perdidos.

A integracao com a MusicBrainz depende de internet e respeita as regras da API, incluindo o uso de `User-Agent`.
