using Npgsql;

namespace trpoTest
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
            Application.Run(new Form1());
        }

        static string connectionString = "Host=localhost;Username=postgres;Password=postgres;Database=trpo";
        public static NpgsqlDataSource dataSource;

        static Program()
        {
            dataSource = NpgsqlDataSource.Create(connectionString);
        }
    }
}