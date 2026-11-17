namespace ZbW.ProgrammingFoundationShort.Lessons.Module05.Auftrag2_WoerterbuchApp;

// ============================================================
// AUFTRAG 2 – WoerterbuchApp (⭐⭐ Mittel | ~30 Min.)
//
// Übersetzungs-App mit Dictionary<string,string>.
//
// Anforderungen:
//   - 5 Wörter vorausfüllen (Deutsch → Englisch)
//   - TxtSuche + CmdNachschlagen: TryGetValue für Übersetzung
//   - TxtKeyNeu + TxtValueNeu + CmdHinzufuegen: ContainsKey-Prüfung
//   - LstEintraege: alle Einträge anzeigen
// ============================================================

public partial class WoerterbuchAppForm : Form
{
  // TODO 1: private Dictionary<string, string> _woerterbuch = new();
  private Dictionary<string, string> _woerterbuch = new();

  public WoerterbuchAppForm()
  {
    InitializeComponent();
    // TODO 2: 5 Wörter vorab einfügen (z.B. Hund → Dog, Katze → Cat...)
    _woerterbuch.Add("Hund", "Dog");
    _woerterbuch.Add("Katze", "Cat");
    _woerterbuch.Add("Apfel", "Apple");
    _woerterbuch.Add("Kuchen", "Cake");
    _woerterbuch.Add("Auto", "Car");
    // TODO 3: AktualisiereListBox() aufrufen
    AktualisiereListBox();
  }

  private void CmdNachschlagen_Click(object sender, EventArgs e)
  {
    // TODO 4: TryGetValue für TxtSuche.Text
    //         Gefunden: LblErgebnis anzeigen
    //         Nicht gefunden: "Kein Eintrag für..."
    if (_woerterbuch.TryGetValue(TxtSuche.Text, out string searchObject))
    {
      LblErgebnis.Text = searchObject;
    }
    else
    {
      MessageBox.Show($"Keinen Eintrag für: {TxtSuche.Text} gefunden.", "Error",
                      MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
  }

  private void CmdHinzufuegen_Click(object sender, EventArgs e)
  {
    // TODO 5: Leere Felder prüfen
    // TODO 6: ContainsKey-Prüfung → Überschreiben bestätigen
    // TODO 7: _woerterbuch[key] = value;
    // TODO 8: AktualisiereListBox()
    if (TxtKeyNeu.Text == "" || TxtValueNeu.Text == "")
    {
      MessageBox.Show($"Felder dürfen nicht leer sein.", "Error",
                      MessageBoxButtons.OK, MessageBoxIcon.Error);
      return;
    }
    if (_woerterbuch.ContainsKey(TxtKeyNeu.Text))
    {
      DialogResult result = MessageBox.Show($"Schlüssel: {TxtKeyNeu.Text} ist vorhanden.\r\n\r\n" +
                                            $"Überschreiben?", "Warnung",
                                            MessageBoxButtons.YesNo,
                                            MessageBoxIcon.Warning);
      if (result == DialogResult.Yes)
      {
        _woerterbuch[TxtKeyNeu.Text] = TxtValueNeu.Text;
      }
    }
    else
    {
      _woerterbuch[TxtKeyNeu.Text] = TxtValueNeu.Text;
      AktualisiereListBox();
    }
  }

  private void AktualisiereListBox()
  {
    // TODO 9: LstEintraege befüllen aus _woerterbuch
    LstEintraege.Items.Clear();
    foreach (var pairs in _woerterbuch)
    {
      LstEintraege.Items.Add($"{pairs.Key}");
    }
  }
}
