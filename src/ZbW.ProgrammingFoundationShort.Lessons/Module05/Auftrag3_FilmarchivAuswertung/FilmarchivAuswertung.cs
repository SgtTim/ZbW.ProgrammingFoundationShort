using System.Security.Cryptography.X509Certificates;

namespace ZbW.ProgrammingFoundationShort.Lessons.Module05.Auftrag3_FilmarchivAuswertung;

// ============================================================
// AUFTRAG 3 – FilmarchivAuswertung (⭐⭐⭐ Erweitert | ~30 Min.)
//
// Wertet ein Filmarchiv mit Dictionary, foreach und if aus.
// LINQ ist nur Bonus und wird hier nicht vorausgesetzt.
//
// Anforderungen:
//   - Dictionary<string, int>: Film → Erscheinungsjahr
//   - Alle Filme mit foreach ausgeben
//   - Filme ab 2000 mit foreach + if ausgeben
//   - Frühstes/spätestes Jahr und Anzahl Filme nach 2010 zählen
//   - Bonus: Dieselben Auswertungen mit LINQ lösen
// ============================================================

public static class FilmarchivAuswertung
{
  public static void Start()
  {
    // TODO 1: Dictionary mit 8 Filmen anlegen
    //         "The Shawshank Redemption" → 1994, "The Dark Knight" → 2008, ...
    Dictionary<string, int> _movies = new();
    _movies["The Shawshank Redemption"] = 1994;
    _movies["The Dark Knigt"] = 2008;
    _movies["Starwars: Episode 1"] = 1999;
    _movies["Starwars: Episode 2"] = 2002;
    _movies["Starwars: Episode 3"] = 2005;
    _movies["Starwars: Episode 4"] = 1977;
    _movies["Starwars: Episode 5"] = 1980;
    _movies["Starwars: Episode 6"] = 1983;
    _movies["Test1 over 2010"] = 2010;
    _movies["Test2 over 2010"] = 2020;

    // TODO 2: Mit foreach und if auswerten:
    //         - Alle Filme ausgeben
    //         - Alle Filme ab 2000 ausgeben
    //         - Frühstes Erscheinungsjahr bestimmen
    //         - Spätestes Erscheinungsjahr bestimmen
    //         - Anzahl Filme nach 2010 zählen
    PrintMovies();
    PrintMoviesFiltered();
    int countOver2010 = CountMovies();
    // TODO 3: Ergebnisse ausgeben
    Console.WriteLine("-----Ausgabe-----");
    Console.WriteLine($"Frühestes Erscheinungsjahr: {_movies.Values.Min()}");
    Console.WriteLine($"Spätestes Erscheinungsjahr: {_movies.Values.Max()}");
    Console.WriteLine($"Anzahl Filme nach 2010: {countOver2010}\n");
    // BONUS: Dieselben Auswertungen zusätzlich mit LINQ formulieren.
    var moviesFrom2000 = _movies
          .Where(_movies => _movies.Value >= 2000)
          .OrderBy(_movies => _movies.Value);

    var oldestMovie = _movies
          .Where(_movies => _movies.Value == )
    Console.WriteLine("-----Ausgabe mit Linq-----");
    foreach (var keyPair in moviesFrom2000)
    {
      Console.WriteLine($"{keyPair.Key} ({keyPair.Value})");
    }
    //var moviesFrom2000 = movies
    //    .Where(movie => movie.Value >= 2000)
    //    .OrderBy(movie => movie.Value);
    //foreach (KeyValuePair<string, int> movie in moviesFrom2000)
    //{
    //  Console.WriteLine($"{movie.Key} ({movie.Value})");
    //}


    void PrintMovies()
    {
      Console.WriteLine("-----Alle Filme-----");
      Console.WriteLine("  Jahr  |  Titel\n");
      foreach (var pair in _movies)
      {
        Console.WriteLine($"  {pair.Value}  |  {pair.Key}");
      }
      Console.WriteLine("-------Ende--------\n");
    }

    void PrintMoviesFiltered()
    {
      Console.WriteLine("-----Filme ab 2000-----");
      Console.WriteLine("  Jahr  |  Titel\n");
      foreach (var pair in _movies)
      {
        if (pair.Value >= 2000)
        {
          Console.WriteLine($"  {pair.Value}  |  {pair.Key}");
        }
      }
      Console.WriteLine("-----Ende---------\n");
    }

    int CountMovies()
    {
      int count = 0;
      foreach (var pair in _movies)
      {
        if (pair.Value > 2010)
        {
          count++;
        }
      }
      return count;
    }
  }
}
