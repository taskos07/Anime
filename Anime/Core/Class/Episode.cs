public class Episode
{
    public int NumStagione {get; protected set;}
    public int NumEpisodio {get; protected set;}
    public string Titolo {get; protected set;}
    public float DurataMinuti {get; protected set;}
    private Episode(int numStagione, int numEpisodio, string titolo, float durataMinuti)
    {
        NumStagione = numStagione;
        NumEpisodio = numEpisodio;
        Titolo = titolo;
        DurataMinuti = durataMinuti;
    }
}