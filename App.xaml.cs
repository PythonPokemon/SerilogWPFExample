/*
Zusätzliche Hinweise:
Live-Ansicht in der Konsole: Durch die Konfiguration WriteTo.Console() und das regelmäßige Flush wird jede Log-Nachricht in der Konsole sofort angezeigt, während die Anwendung läuft.
Serilog in der Konsole: In der Konsole selbst siehst du dann die Log-Nachrichten live, ohne auf die Datei warten zu müssen. 
 */

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
            Log.Information("Logs werden live in der Konsole angezeigt!");
        }

        
    }
}
