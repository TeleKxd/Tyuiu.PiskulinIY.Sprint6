using Tyuiu.PiskulinIY.Sprint6.Task2.V12.Lib;
namespace Tyuiu.PiskulinIY.Sprint6.Task2.V12
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
            Application.Run(new FormmMain());
        }
    }
}