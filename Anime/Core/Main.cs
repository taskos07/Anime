static bool SoloCapolavori(Anime a) => a.Valutazione >= 8.5;

static void Main()
{
    CatalogManager.Singleton.Catalogo = new List<Anime>
    {
        new Anime("Goldrake", 1975, 8.2),
        new Anime("Attack on Titan", 2013, 9.1),
        new Anime("Demon Slayer", 2019, 8.7)
    };
    Console.WriteLine("Capolavori");
    foreach (var a in CatalogManager.Singleton.Filtra(SoloCapolavori))
        Console.WriteLine(a.Titolo);

    FiltroAnno f = new FiltroAnno(2010);
    Console.WriteLine("Dal 2010");
    foreach (var a in CatalogManager.Singleton.Filtra(f.FiltraPerAnno))
        Console.WriteLine(a.Titolo);

    Console.WriteLine("Notifiche");
    ServizioUtente marco = new ServizioUtente("Marco");
    ServizioUtente sara = new ServizioUtente("Sara");

    NotificaStreaming canaleNotifiche = marco.RiceviNotifica;
    canaleNotifiche += sara.RiceviNotifica;
    canaleNotifiche("Nuovo episodio di Goldrake disponibile!");

    Console.WriteLine("Senza Marco");
    canaleNotifiche -= marco.RiceviNotifica;
    canaleNotifiche?.Invoke("Nuovo episodio di Goldrake disponibile!");
    
    static void OnNuovoEpisodio(NuovoEpisodioEventArgs e)
    {
       string titolo_serie  
    }
}
