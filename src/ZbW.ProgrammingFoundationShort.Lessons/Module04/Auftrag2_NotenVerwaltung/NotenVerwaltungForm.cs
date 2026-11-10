namespace ZbW.ProgrammingFoundationShort.Lessons.Module04.Auftrag2_NotenVerwaltung;

// ============================================================
// AUFTRAG 2 – NotenVerwaltung (⭐⭐ Mittel | ~30 Min.)
//
// Verwaltet bis zu 10 Noten in einem double[]-Array.
//
// Anforderungen:
//   - TxtNote: Note (1.0–6.0) eingeben, CmdHinzufuegen: Note ins Array
//   - Zähler _anzahl für belegte Plätze, Button deaktivieren, wenn voll
//   - Methoden MIT Parametern: Average/Best/Worst(double[] noten, int anzahl)
//   - LblNoten: Noten sortiert als Komma-Liste (Kopie mit Array.Copy, dann Array.Sort)
//   - LblStats: Durchschnitt, beste und schlechteste Note
// ============================================================

public partial class NotenVerwaltungForm : Form
{
  // TODO 1: Felder deklarieren
  private double[] _noten = new double[10];
  private int _anzahl = 0;

  public NotenVerwaltungForm()
  {
    InitializeComponent();
  }

  private void CmdHinzufuegen_Click(object sender, EventArgs e)
  {
    // TODO 2: Note validieren (double.TryParse, 1.0–6.0)
    if (!double.TryParse(TxtNote.Text, out double note))
    {
      MessageBox.Show("Ungültige Noteneingabe!", "Error",
                      MessageBoxButtons.OK, MessageBoxIcon.Error);
      return;
    }
    if (note > 6.0 || note < 1.0)
    {
      MessageBox.Show("Ungültige Note! Muss im Bereich 1.0 - 6.0 sein.", "Error",
                      MessageBoxButtons.OK, MessageBoxIcon.Error);
      return;
    }

    // TODO 3: Note ins Array schreiben und _anzahl erhöhen
    _noten[_anzahl] = note;
    _anzahl++;

    // TODO 4: Wenn voll: CmdHinzufuegen.Enabled = false;
    if (_anzahl > _noten.Length - 1)
    {
      CmdHinzufuegen.Enabled = false;
    }

    // TODO 5: Anzeige aktualisieren (sortierte Kopie + Statistik
    double[] copyNoten = new double[_anzahl];
    Array.Copy(_noten, copyNoten, _anzahl);
    copyNoten.Sort();

    LblNoten.Text = "";

    for (int i = 0; i < _anzahl; i++)
    {
      if (i == _anzahl - 1)
      {
        LblNoten.Text += $"{copyNoten[i]:F1}";
      }
      else
      {
        LblNoten.Text += $"{copyNoten[i]:F1}, ";
      }
    }

    LblStats.Text = "";
    LblStats.Text = $"Durchschnitt: {Average(_noten, _anzahl):F1}, Beste: {Best(_noten):F1}, Schlechteste: {Worst(_noten):F1}";
  }

  private double Average(double[] noten, int anzahl)
  {
    // TODO: Durchschnitt der ersten "anzahl" Noten
    double summe = 0.0;
    foreach (double element in noten)
    {
      summe += element;
    }
    return summe / anzahl;
  }

  private double Best(double[] noten)
  {
    // TODO: Höchste Note finden
    double höchsteNote = double.MinValue;
    foreach (double element in noten)
    {
      if (element > höchsteNote)
      {
        höchsteNote = element;
      }
    }
    return höchsteNote;
  }

  private double Worst(double[] noten)
  {
    // TODO: Niedrigste Note finden
    double niedrigsteNote = double.MaxValue;
    foreach (double element in noten)
    {
      if (element < niedrigsteNote)
      {
        niedrigsteNote = element;
      }
    }
    return niedrigsteNote;
  }
}
