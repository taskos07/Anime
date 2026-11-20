using System;

namespace DefaultNamespace;

internal static class CoreSample
{
    private static bool SoloCapolavori(Anime anime) => anime.Valutazione >= 8.5f;

    public static void Run()
    {
        AnimeMovie.FactoryMovie("goldrake", "Goldrake", 8.2f, 1975, 120);
        AnimeSeries.FactorySeries("attack-on-titan", "Attack on Titan", 9.1f, 2013, 4);
        AnimeMovie.FactoryMovie("demon-slayer", "Demon Slayer", 8.7f, 2019, 120);

        Console.WriteLine("Capolavori");
        foreach (var anime in CatalogManager.Istanza.Filtra(SoloCapolavori))
            Console.WriteLine(anime.Titolo);

        var filtroAnno = new FiltraAnno(2010);
        Console.WriteLine("Dal 2010");
        foreach (var anime in CatalogManager.Istanza.Filtra(filtroAnno.FiltraAnnoMinimo))
            Console.WriteLine(anime.Titolo);

        var marco = new ServizioUtente("Marco");
        var sara = new ServizioUtente("Sara");

        NotificaStreaming? notifiche = marco.RiceviNotifica;
        notifiche += sara.RiceviNotifica;
        notifiche?.Invoke("Nuovo episodio di Goldrake disponibile!");
        notifiche -= marco.RiceviNotifica;
        notifiche?.Invoke("Nuovo episodio di Goldrake disponibile!");
    }
}
