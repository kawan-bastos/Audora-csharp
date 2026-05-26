
using Audora.Menu;
using Audora.Modelos;


Banda Nirvana = new Banda("Nirvana");   
Nirvana.AdicionarNota(new Avaliacao(10));
Nirvana.AdicionarNota(new Avaliacao(10));
Nirvana.AdicionarNota(new Avaliacao(7));
Nirvana.AdicionarNota(new Avaliacao(9));
Nirvana.AdicionarNota(new Avaliacao(8));
Banda Eagles = new Banda("Eagles");
;
Dictionary<int, Menu> menus = new();
menus.Add(1, new MenuRegistrarBanda());
menus.Add(2, new MenuMostrarBandas());
menus.Add(3, new MenuRegistrarAlbum());
menus.Add(4, new MenuAvaliarBanda());
menus.Add(5, new MenuAvaliarAlbum());
menus.Add(6, new MenuExibirAlbuns());
menus.Add(7, new MenuExibirDetalhes());

Dictionary<string, Banda > registroDeBandas = new(StringComparer.OrdinalIgnoreCase);
registroDeBandas.Add(Nirvana.Nome, Nirvana);
registroDeBandas.Add(Eagles.Nome, Eagles);

MenuPrincipal menuPrincipal = new MenuPrincipal();
menuPrincipal.Executar(registroDeBandas, menus); 


