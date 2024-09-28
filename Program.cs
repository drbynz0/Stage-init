using System.Diagnostics;
using System.Security.Principal;

namespace winForms
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            if (!IsAdministrator())
            {
                // Si l'application n'est pas exécutée en tant qu'administrateur, la relancer avec des droits élevés
                try
                {
                    var processInfo = new ProcessStartInfo
                    {
                        FileName = Application.ExecutablePath, // Le fichier exécutable de l'application
                        UseShellExecute = true, // Utiliser l'exécution via l'interface shell
                        Verb = "runas" // Demander les privilèges d'administrateur
                    };

                    Process.Start(processInfo); // Démarrer le processus avec les droits d'administrateur
                    Application.Exit(); // Fermer l'instance actuelle qui n'est pas en mode admin
                }
                catch (Exception ex)
                {
                    MessageBox.Show("L'élévation des privilèges a échoué : " + ex.Message);
                }
            }
            else
            {
                Application.Run(new loginForm());
            }
            
        }
        static bool IsAdministrator()
        {
            using (var identity = WindowsIdentity.GetCurrent())
            {
                var principal = new WindowsPrincipal(identity);
                return principal.IsInRole(WindowsBuiltInRole.Administrator);
            }
        }
    }
}