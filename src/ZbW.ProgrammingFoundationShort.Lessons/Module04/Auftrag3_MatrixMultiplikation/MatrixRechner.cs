namespace ZbW.ProgrammingFoundationShort.Lessons.Module04.Auftrag3_MatrixMultiplikation;

// ============================================================
// AUFTRAG 3 – MatrixMultiplikation (⭐⭐⭐ Erweitert | ~30 Min.)
//
// Multipliziert zwei 2×2-Matrizen.
//
// Anforderungen:
//   - Methode int[,] Multiply(int[,] a, int[,] b)
//   - Formel: c[i,j] = Summe(a[i,k] * b[k,j])
//   - Start() mit zwei Beispielmatrizen und Ausgabe
// ============================================================

public static class MatrixRechner
{
  public static void Start()
  {
    // TODO 1: Zwei 2×2-Matrizen definieren
    int[,] a = { {1, 2}, {3, 4} };
    int[,] b = { {5, 6}, {7, 8} };

    // TODO 2: Multiply aufrufen und Ergebnis ausgeben
    int[,] result = Multiply(a, b);
    foreach (int element in result)
    {
      Console.WriteLine($"{element}");
    }
  }

  public static int[,] Multiply(int[,] a, int[,] b)
  {
    // TODO: 2×2 Matrix-Multiplikation implementieren
    int[,] result = new int[2, 2];
    //       for i in 0..1: for j in 0..1: for k in 0..1: result[i,j] += a[i,k]*b[k,j]
    for (int i = 0; i <= a.GetUpperBound(0); i++)
    {
      for (int j = 0; j <= a.GetUpperBound(0); j++)
      {
        for (int k = 0; k <= a.GetUpperBound(0); k++)
        {
          result[i, j] += a[i, k] * b[k, j];
        }
      }
    }
    return result;
    // throw new NotImplementedException("TODO: Multiply implementieren");
  }
}
