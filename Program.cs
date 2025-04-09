namespace CSHARP25040903
{
    internal static class Program
    {
        internal const string ConnectionString = 
            "server=(localdb)\\MSSQLLocalDB;" +
            "database=peopledb;";

        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new DbCrudForm());
        }
    }
}