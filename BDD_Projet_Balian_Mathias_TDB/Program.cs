namespace BDD_Projet_Balian_Mathias_TDB
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Connexion_Inscription());
        }
    }
}