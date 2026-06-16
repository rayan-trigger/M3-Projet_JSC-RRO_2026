// Fichier: Program.cs
// Description: Point d'entrée de l'application. Initialise la configuration
// et démarre le formulaire principal.
using System.Security.Cryptography.X509Certificates;

namespace M3_RRO_JSC
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new FrmMain());
            Application.Run();
        }
    }
}