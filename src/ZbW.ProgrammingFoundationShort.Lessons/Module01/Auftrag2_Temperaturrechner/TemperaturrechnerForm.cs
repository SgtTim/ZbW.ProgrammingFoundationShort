namespace ZbW.ProgrammingFoundationShort.Lessons.Module01.Auftrag2_Temperaturrechner;

// ============================================================
// AUFTRAG 2 – Temperaturrechner (⭐⭐ Mittel | ~30 Min.)
//
// Konvertiere Celsius ↔ Fahrenheit in einer WinForms-App.
//
// Anforderungen:
//   - Zwei TextBoxen (Celsius / Fahrenheit), je ein Button
//   - Formeln:  F = C × 9/5 + 32
//               C = (F − 32) × 5/9
//   - Ungültige Eingaben mit double.TryParse abfangen
//   - const double AbsoluteZero = -273.15 definieren
//     → Eingabe unter AbsoluteZero: Warnung anzeigen
// ============================================================

public partial class TemperaturrechnerForm : Form
{
  // TODO 1: Konstante für den absoluten Nullpunkt definieren
  private const double AbsoluteZero = -273.15;

  public TemperaturrechnerForm()
  {
    InitializeComponent();
  }

  // ── Celsius → Fahrenheit ────────────────────────────────────
  private void CmdCelsiusToFahrenheit_Click(object sender, EventArgs e)
  {
    // TODO 2: Wert aus TxtCelsius lesen (double.TryParse)
    //         Bei ungültiger Eingabe: MessageBox anzeigen und return
    if (!double.TryParse(TxtCelsius.Text, out double tempCelsius))
    {
      MessageBox.Show("Ungültiger Wert.");
      return;
    }

    // TODO 3: Prüfen ob Wert < AbsoluteZero
    //         → MessageBox mit Warnung, aber weiter rechnen
    if (tempCelsius < AbsoluteZero)
    {
      MessageBox.Show("Wert ist unter dem Absoluten Nullpunkt.", "Warnung!!");
    }

    // TODO 4: Formel anwenden: fahrenheit = celsius * 9.0 / 5.0 + 32
    double resultFahrenheit = tempCelsius * 9.0 / 5.0 + 32;

    // TODO 5: Ergebnis in TxtFahrenheit anzeigen ($"{fahrenheit:F2}")
    TxtFahrenheit.Text = $"{resultFahrenheit:F2}";
  }

  // ── Fahrenheit → Celsius ────────────────────────────────────
  private void CmdFahrenheitToCelsius_Click(object sender, EventArgs e)
  {
    // TODO 6: Wert aus TxtFahrenheit lesen (double.TryParse)
    //         Bei ungültiger Eingabe: MessageBox anzeigen und return
    if (!double.TryParse(TxtFahrenheit.Text, out double tempFahrenheit))
    {
      MessageBox.Show("Ungültiger Wert.");
      return;
    }

    // TODO 7: Formel anwenden: celsius = (fahrenheit - 32) * 5.0 / 9.0
    double resultCelsius = (tempFahrenheit - 32) * 5.0 / 9.0;

    // TODO 8: Prüfen ob Ergebnis < AbsoluteZero → Warnung
    if (resultCelsius < AbsoluteZero)
    {
      MessageBox.Show("Wert ist unter dem Absoluten Nullpunkt.", "Warnung!!");
    }

    // TODO 9: Ergebnis in TxtCelsius anzeigen ($"{celsius:F2}")
    TxtCelsius.Text = $"{resultCelsius:F2}";
  }
}
