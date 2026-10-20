namespace ZbW.ProgrammingFoundationShort.Lessons.Module01.Auftrag1_Taschenrechner;

// ============================================================
// AUFTRAG 1 – Taschenrechner (⭐ Einfach | ~15 Min.)
//
// Erstelle einen Konsolen-Taschenrechner, der zwei Zahlen und eine
// Operation einliest und das Resultat ausgibt.
//
// Anforderungen:
//   - Zahlen mit double.TryParse aus Console.ReadLine() einlesen
//   - Operationen: +, −, ×, ÷ (Eingabe: "+", "-", "*", "/")
//   - Bei Division durch 0: Fehlermeldung ausgeben
//   - Resultat mit 2 Nachkommastellen: $"{result:F2}"
//
// Starten: In Lessons/Program.cs die Zeile
//          ...Auftrag1_Taschenrechner.Taschenrechner.Start();
//          einkommentieren (alle anderen Zeilen auskommentiert lassen).
// ============================================================

public static class Taschenrechner
{
  /// <summary>
  ///   Startet den Taschenrechner auf der Konsole.
  /// </summary>
  public static void Start()
  {
    // TODO 1: Erste Zahl einlesen und prüfen
    Console.Write("Erste Zahl: ");
    if (!double.TryParse(Console.ReadLine() ?? "", out double zahl1))
    {
      Console.WriteLine("Ungültige Zahl.");
      return;
    }

    // TODO 2: Zweite Zahl einlesen (gleiche Technik wie TODO 1)
    Console.Write("Zweite Zahl: ");
    if (!double.TryParse(Console.ReadLine() ?? "", out double zahl2))
    {
      Console.WriteLine("Ungültige Zahl.");
      return;
    }

    // TODO 3: Operation einlesen (+, -, *, /)
    Console.Write("Wähle deinen Operator: + | - | * | /: ");
    string operation = Console.ReadLine() ?? "";
    if (operation != "+" && operation != "-" && operation != "*" && operation != "/")
    {
      Console.WriteLine("Ungültiger Operator.");
      return;
    }

    // TODO 4: Resultat berechnen
    double result = 0;
    if (operation == "+")
    {
      result = zahl1 + zahl2;
    }
    else if (operation == "-")
    {
      result = zahl1 - zahl2;
    }
    else if (operation == "*")
    {
      result = zahl1 * zahl2;
    }
    else if (operation == "/")
    {
      if (zahl2 == 0)
      {
        Console.WriteLine("Division durch 0 ist nicht erlaubt!");
        return;
      }
      result = zahl1 / zahl2;
    }

    // TODO 5: Ergebnis ausgeben: $"Ergebnis: {result:F2}"
    Console.WriteLine($"{result:F2}");
  }
}
