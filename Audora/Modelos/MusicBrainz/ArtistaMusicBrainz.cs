using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Audora.Services;

namespace Audora.Modelos.MusicBrainz;

internal class ArtistaMusicBrainz
{
    
    [JsonPropertyName("name")]
    public string Nome { get; set; }
    
    [JsonPropertyName("life-span")]
    public LifeMusicBrainz DataDeInicio { get; set; }
    [JsonPropertyName("begin-area")]
    public AreaMusicBrainz LocalDeInicio { get; set; }
    [JsonPropertyName("aliases")]
    public List<AliasesMusicBrainz> Aliases { get; set; }


}


