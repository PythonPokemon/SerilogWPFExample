using Serilog;
using System;
using System.Windows;

namespace SerilogWPFExample
{
    public partial class App : Application
    {
        public App()
        {
            // Serilog konfigurieren: Logs in die Konsole und eine Datei schreiben
            Log.Logger = new LoggerConfiguration()
                .WriteTo.Console()
                .WriteTo.File("log.txt", rollingInterval: RollingInterval.Day) // Log-Datei wird täglich rotiert
                .CreateLogger();

            // Beispiel-Log-Nachricht, um Serilog zu testen
            Log.Information("Anwendung gestartet.");

        }

        protected override void OnExit(ExitEventArgs e)
        {
            Log.CloseAndFlush(); // Logger beim Beenden freigeben
            base.OnExit(e);
        }

    }
}
