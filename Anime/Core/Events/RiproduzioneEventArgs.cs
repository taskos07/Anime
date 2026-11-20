using System;

namespace DefaultNamespace;

public class RiproduzioneEventArgs
{
    public string Titolo  { get; set; }
    public DateTime Data { get; set; }

    public RiproduzioneEventArgs(string titolo, DateTime data)
    {
        Titolo = titolo;
        Data = data;
    }
}