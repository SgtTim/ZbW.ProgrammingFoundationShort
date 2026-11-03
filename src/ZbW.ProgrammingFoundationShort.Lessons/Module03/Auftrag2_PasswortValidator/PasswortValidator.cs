namespace ZbW.ProgrammingFoundationShort.Lessons.Module03.Auftrag2_PasswortValidator;

// ============================================================
// AUFTRAG 2 – PasswortValidator (⭐⭐ Mittel | ~30 Min.)
//
// Validiert ein Passwort und fordert erneute Eingabe per do-while.
//
// Anforderungen:
//   - do-while-Schleife: solange Passwort ungültig
//   - gültig: mindestens 8 Zeichen UND mindestens eine Ziffer
//   - Ziffer mit foreach über die Zeichen + char.IsDigit(...) suchen
//   - Fehlermeldung: was fehlt
// ============================================================

public static class PasswortValidator
{
  public static void Start()
  {
    // TODO 1: string passwort; bool gueltig;
    //         do { ... } while (!gueltig);
    string passwort;
    bool gueltig = false;
    const int minPasswortLaenge = 8;

    do
    {
      // TODO 2: In der Schleife Passwort einlesen (Console.ReadLine() ?? "")
      Console.Write("Gib ein gültiges Passwort ein mit 8 Zeichen, davon mind. 1 Zahl: ");
      passwort = Console.ReadLine() ?? "";

      // TODO 3: bool hatZiffer = false;
      //         foreach (char zeichen in passwort) → char.IsDigit(zeichen) prüfen
      bool hatZiffer = false;

      foreach (char zeichen in passwort)
      {
        if (char.IsDigit(zeichen))
        {
          hatZiffer = true;
          break;
        }
      }

      // TODO 4: gueltig berechnen und konkrete Fehlermeldung ausgeben
      if (passwort.Length >= minPasswortLaenge && hatZiffer)
      {
        gueltig = true;
      }
      else
      {
        Console.WriteLine("Das Passwort ist ungültig weil:");
        if (!hatZiffer) { Console.WriteLine("Das Passwort hat keine Ziffer"); }
        if (passwort.Length < minPasswortLaenge) { Console.WriteLine($"Das Passwort ist zu kurz. Es hat nur: {passwort.Length} Zeichen"); }
      }
    } while (!gueltig);

    // TODO 5: Nach der Schleife Erfolgsmeldung ausgeben
    Console.WriteLine($"Das Passwort: {passwort} ist gültig!");
  }
}
