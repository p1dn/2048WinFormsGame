namespace _2048WinFormsGame
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new WelcomeForm());
        }
    }
}