namespace DefaultNamespace;

public class FiltraAnno
{
    private int annoMinimo;

    public FiltraAnno(int annoMinimo)
    {
        this.annoMinimo = annoMinimo;
    }
    public bool FiltraAnnoMinimo (Anime a) 
    => a.AnnoUscita >= this.annoMinimo;
}