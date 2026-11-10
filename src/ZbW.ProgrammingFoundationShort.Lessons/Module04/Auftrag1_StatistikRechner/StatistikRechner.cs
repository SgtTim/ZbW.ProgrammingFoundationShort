namespace ZbW.ProgrammingFoundationShort.Lessons.Module04.Auftrag1_StatistikRechner;

// ============================================================
// AUFTRAG 1 – StatistikRechner (⭐ Einfach | ~15 Min.)
//
// Liest 5 Zahlen ein und berechnet Minimum, Maximum, Durchschnitt.
//
// Anforderungen:
//   - int[5]-Array per Konsoleneingabe befüllen
//   - Methoden: Minimum(int[]), Maximum(int[]), Average(int[])
//   - Ergebnis ausgeben
// ============================================================

public static class StatistikRechner
{
  const int MaxNumberOfInputs = 5;
  public static void Start()
  {
    // TODO 1: int[5]-Array deklarieren
    //         5 Zahlen einlesen und im Array speichern
    int[] numberInput = new int[MaxNumberOfInputs];
    for (int i = 0; i < numberInput.Length; i++)
    {
      Console.Write($"Enter Number {i + 1}: ");
      if (!int.TryParse(Console.ReadLine(), out int number))
      {
        Console.WriteLine("Invalid Input. Must be a valid Integer.");
        i--;
        continue;
      }
      numberInput[i] = number;
    }

    // TODO 2: Methoden aufrufen und Ergebnis ausgeben
    Console.WriteLine($"Min: {Minimum(numberInput)}, Max: {Maximum(numberInput)}, Avg: {Average(numberInput):F2}");
  }

  public static int Minimum(int[] zahlen)
  {
    // TODO: Kleinste Zahl finden (Schleife, kein LINQ)
    int minimumNumber = int.MaxValue;
    for (int i = 0; i < zahlen.Length; i++)
    {
      if (zahlen[i] < minimumNumber)
      {
        minimumNumber = zahlen[i];
      }
    }
    return minimumNumber;
    // throw new NotImplementedException("TODO: Minimum implementieren");
  }

  public static int Maximum(int[] zahlen)
  {
    // TODO: Grösste Zahl finden (Schleife, kein LINQ)
    int maximumNumber = int.MinValue;
    for (int i = 0; i < zahlen.Length; i++)
    {
      if (zahlen[i] > maximumNumber)
      {
        maximumNumber = zahlen[i];
      }
    }
    return maximumNumber;
    //throw new NotImplementedException("TODO: Maximum implementieren");
  }

  public static double Average(int[] zahlen)
  {
    // TODO: Durchschnitt berechnen (Summe / Länge)
    double average = 0;
    for (int i = 0; i < zahlen.Length; i++)
    {
      average += zahlen[i];
    }
    return average / zahlen.Length;
    //throw new NotImplementedException("TODO: Average implementieren");
  }
}
