public class AnimeMovie : Anime
{
    public int DurataMinuti {get; protected set;}
    protected AnimeMovie(string id, string titolo, float valutazione, int annoUscita, int durataMinuti) 
        : base(id, titolo, valutazione, annoUscita)
    {
    DurataMinuti = durataMinuti;  
    }

    public static AnimeMovie FactoryMovie(string id, string titolo, float valutazione, int annoUscita)
    {
        AnimeMovie a = new AnimeMovie(id, titolo, valutazione, annoUscita, durataMinuti);
        CatalogManager.Istanza.AnimeDisponibili.Add(a);
        return a;
    }
    
   
}