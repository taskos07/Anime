using System;

namespace DefaultNamespace;

public class MediaFactory 
{
   public static Anime CreateMedia(string type, string title, double rating)
   {
      if (type == "Movie")
         return AnimeMovie.FactoryMovie("movie-1", title, (float)rating, 2026, 120);

      if (type == "Series")
         return AnimeSeries.FactorySeries("series-1", title, (float)rating, 2026, 3);

      throw new ArgumentException("Tipo non valido");
   }
}