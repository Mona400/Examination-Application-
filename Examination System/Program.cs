namespace Exam_System
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
            // Application.Run(new Questions());
           //Application.Run(new Students());
            //Application.Run(new Subjects());
           // Application.Run(new Exams());
            Application.Run(new Home());
           // Application.Run(new Login());
        }
    }
}