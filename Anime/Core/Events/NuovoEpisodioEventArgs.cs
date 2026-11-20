namespace DefaultNamespace;

public delegate void NuovoEpisodioEventHandler(object sender, NuovoEpisodioEventArgs e);

public class NuovoEpisodioEventArgs : EventArgs
{
    public Episode Episodio { get; }

    public NuovoEpisodioEventArgs(Episode episodio) =>  Episodio = episodio;

}