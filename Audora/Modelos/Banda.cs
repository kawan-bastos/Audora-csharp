namespace Audora.Modelos;

internal class Banda : IAvaliavel
{
    private List<Album> albuns = new List<Album>();
    public List<Avaliacao> notas = new();

    public Banda(string nome)
    {
        Nome = nome;
    }
    
    public string Nome { get;  }
    public double Media 
    {
        get
        {
            if (notas.Count == 0) return 0;
            else return notas.Average(a => a.Nota);
        }
    }
    public List<Album> Albuns => albuns;
    public void AdicionarAlbum(Album album)
    {
        albuns.Add(album);
    }

    public bool ValidarAlbuns(Banda banda)
    {
        if (albuns.Count == 0)
        {
            Console.WriteLine($"A banda {banda.Nome} não possui álbuns cadastrados.");
            Thread.Sleep(2000);
            return false;
        }
        return true;
    }
    public void ExibirAlbuns()
    {
        Console.WriteLine($"\nExibindo todos os albuns da banda {Nome}:");
        foreach (var album in albuns)
        {
            Console.WriteLine($"Album: {album.Nome} Com uma Duracao de {album.DuracaoTotal} segundos\n");
        }

    }

    public void AdicionarNota(Avaliacao nota)
    {
        if (nota.Nota >= 0 )
        {
            notas.Add(nota);
        }
        else if (nota.Nota < 0 || nota.Nota > 10)
        {
            Console.WriteLine("Nota inválida. A nota deve ser entre 0 e 10.");
        }
    }



}