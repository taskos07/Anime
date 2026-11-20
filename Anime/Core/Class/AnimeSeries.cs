using System.Collections.Generic;
using DefaultNamespace;

namespace DefaultNamespace;

public class AnimeSeries : Anime
{
    public int NumStagioni {get; protected set;}
    public event NuovoEpisodioEventHandler? EpisodioAggiunto;
    protected AnimeSeries(string id, string titolo, float valutazione, int annoUscita, int numStagioni) 
        : base(id, titolo, valutazione, annoUscita)
    {
    NumStagioni = numStagioni;  
    }
    public List<Episode> Episodi {get; protected set;} = new List<Episode>();
    public void AggiungiEpisodio(Episode episodio)
    {
        Episodi.Add(episodio);
        EpisodioAggiunto?.Invoke(this, new NuovoEpisodioEventArgs(episodio));
    }
    public Episode this [int numStagione, int numEpisodio]
    {
        get
        {
         foreach (Episode ep in Episodi)
         {
            if (ep.NumStagione == numStagione && ep.NumEpisodio == numEpisodio)
            {
                return ep;
            }
         }
         throw new EpisodeNotFoundException($"Episodio non trovato: Stagione {numStagione}, Episodio {numEpisodio}");
    }
 }
    public static AnimeSeries FactorySeries(string id, string titolo, float valutazione, int annoUscita, int numStagioni)
    {
        AnimeSeries a = new AnimeSeries(id, titolo, valutazione, annoUscita, numStagioni);
        CatalogManager.Istanza.AnimeDisponibili.Add(a);
        return a;
    }

    
    
} 