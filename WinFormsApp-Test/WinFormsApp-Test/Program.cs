namespace WinFormsApp_Test
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool i = false;
            Console.WriteLine(i);
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            List<string> args = new List<string>();
            Application.Run(new Form1());
        }
    }
}