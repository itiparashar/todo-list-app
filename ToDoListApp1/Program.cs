namespace ToDoListApp1
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        // Main entry point
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            // Initlize the win form app
            ApplicationConfiguration.Initialize();
            // this will run in loop
            Application.Run(new Form1());
            // Nothing below this line will execute
        }
    }
}