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