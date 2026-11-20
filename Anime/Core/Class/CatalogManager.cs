using System.Collections.Generic;
using System.Linq;

namespace DefaultNamespace;

public class CatalogManager
{
    private static CatalogManager _istanza;
    public List<Anime> AnimeDisponibili = new List<Anime>();
    public NotificaStreaming CanaleNotifiche;

    private CatalogManager()
    {
    }

    public static CatalogManager Istanza
    {
        get
        {
            if (_istanza == null)
                _istanza = new CatalogManager();
            return _istanza;
        }
    }

    public List<Anime> Filtra(FiltroAnime criterio)
    {
        return AnimeDisponibili.Where(a => criterio(a)).ToList();
    }
}