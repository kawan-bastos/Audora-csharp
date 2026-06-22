using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using Audora.Modelos.MusicBrainz;

namespace Audora.Services;

internal class MusicBrainz
{
    
    public async Task<ArtistaMusicBrainz> BuscarArtista(string artista)
    {
        using (HttpClient client = new HttpClient())
        {
            try
            {
                client.DefaultRequestHeaders.UserAgent.ParseAdd("Audora/1.0 (kawanbastos021@gmail.com)");
                string json = await client.GetStringAsync($"https://musicbrainz.org/ws/2/artist?query={artista}&fmt=json");
                RespostaMusicBrainz resposta = JsonSerializer.Deserialize<RespostaMusicBrainz>(json);
                return resposta?.Artistas.FirstOrDefault();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
                return null;
            }
        }
    }
}



