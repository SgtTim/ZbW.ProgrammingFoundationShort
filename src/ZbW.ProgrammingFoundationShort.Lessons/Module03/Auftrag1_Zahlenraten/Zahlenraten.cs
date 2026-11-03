namespace ZbW.ProgrammingFoundationShort.Lessons.Module03.Auftrag1_Zahlenraten;

// ============================================================
// AUFTRAG 1 – Zahlenraten (⭐ Einfach | ~15 Min.)
//
// Das Programm generiert eine Zufallszahl und der Benutzer
// versucht sie zu erraten.
//
// Anforderungen:
//   - Random-Zahl zwischen 1 und 100 generieren
//   - while-Schleife bis geraten
//   - Hinweise: "Zu klein" / "Zu gross"
//   - Versuchszähler und Glückwunsch am Ende
// ============================================================

public static class Zahlenraten
{
  public static void Start()
  {
    // TODO 1: Random-Objekt erstellen, Zufallszahl 1-100 generieren
    var random = new Random();
    int geheimzahl = random.Next(1, 101);

    // TODO 2: Variablen für Versuchszähler und geraten-Flag
    int counter = 0;
    bool geraten = false;

    // TODO 3: while-Schleife (!geraten)
    //         - Eingabe lesen
    //         - int.TryParse prüfen
    //         - Hinweis ausgeben (zu klein / zu gross / richtig)
    //         - Versuchszähler erhöhen

    while (!geraten)
    {
      Console.Write("Rate die Geheimzahl! : ");

      if (!int.TryParse(Console.ReadLine(), out int guessedNumber))
      {
        Console.WriteLine("Ungültige Eingabe");
        continue;
      }

      if (guessedNumber == geheimzahl)
      {
        geraten = true;
      }
      else if (guessedNumber > geheimzahl)
      {
        Console.WriteLine($"Die geratene Zahl: {guessedNumber} ist grösser als die Geheimzahl");
      }
      else if (guessedNumber < geheimzahl)
      {
        Console.WriteLine($"Die geratene Zahl: {guessedNumber} ist kleiner als die Geheimzahl");
      }

      counter++;
    }

    // TODO 4: Glückwunsch mit Anzahl Versuche ausgeben

    Console.WriteLine($"Herzliche Gratulation. Die Geheimzahl war: {geheimzahl}. Du hast {counter} mal geraten");
  }
}
