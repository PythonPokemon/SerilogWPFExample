using Serilog;
using System;
using System.Windows;

namespace SerilogWPFExample
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void LogButton_Click(object sender, RoutedEventArgs e)
        {
            // Log-Nachricht erstellen
            Log.Information("Der Button wurde geklickt!");

            // Log-Level Beispiel
            Log.Debug("Debug-Nachricht: Button wurde geklickt.");
            Log.Warning("Warnung: Button wurde geklickt.");
            Log.Error("Fehler: Etwas ist schiefgelaufen.");
            Log.Fatal("Fataler Fehler: Anwendung könnte abstürzen.");
        }
    }
}
