using System;
using Avalonia.Media.Imaging;
using Avalonia.Platform;

namespace DefaultNamespace;

public delegate bool FiltroAnime(Anime a);
public abstract class Anime : IComparable<Anime>, IEquatable<Anime>
{
    public string Id {get; protected set;}
    public string Titolo {get; protected set;}
    public float Valutazione {get; protected set;}
    public int AnnoUscita {get; protected set;}

    public Bitmap Copertina() => new(AssetLoader.Open(new Uri(AssetLoader.Exists(new Uri($"avares://Anime/Assets/{Id}.png")) ? $"avares://Anime/Assets/{Id}.png" : "avares://Anime/Assets/Icon.png")));

    protected Anime(string id, string titolo, float valutazione, int annoUscita)
    {
        Id = id;
        Titolo = titolo;
        Valutazione = valutazione;
        AnnoUscita = annoUscita;
    }
    
    public int CompareTo(Anime? other)
    {
        if (other is null) return 1;
        int result = Valutazione.CompareTo(other.Valutazione);
        if (result != 0) return result;
        return string.Compare(Titolo, other.Titolo, StringComparison.Ordinal);
    }
    public bool Equals(Anime? other)
    {
        if (other is null) return false;
        return Id == other.Id || Titolo == other.Titolo;

    }
}