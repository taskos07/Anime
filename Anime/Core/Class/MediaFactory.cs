using System;

namespace DefaultNamespace;

public class MediaFactory 
{
   public static Anime CreateMedia(string type, string title, double rating)
   {
      if (type == "Movie")
         return AnimeMovie.Factory(1, title, rating, 2026, 120);

      if (type == "Series")
         return AnimeSeries.Factory(2, title, rating, 2026, 3);

      throw new ArgumentException("Tipo non valido");
   }
}