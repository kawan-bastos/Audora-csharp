using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Audora.Modelos.MusicBrainz;

internal class AreaMusicBrainz
{
    [JsonPropertyName("name")]
    public string Nome { get; set; }  
}
