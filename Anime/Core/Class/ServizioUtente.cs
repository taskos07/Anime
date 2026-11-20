using System;

namespace DefaultNamespace;

public delegate void NotificaStreaming(string messaggio);

public class ServizioUtente
{
    public string NomeUtente { get; init; }
    
    public ServizioUtente(string nomeUtente)
    {
        NomeUtente = nomeUtente;
    }

    public void RiceviNotifica(string msg)
    {
        Console.WriteLine($"{NomeUtente} ha ricevuto: {msg}");
    }
}