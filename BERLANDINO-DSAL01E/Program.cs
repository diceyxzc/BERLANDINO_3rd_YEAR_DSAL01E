using BERLANDINO_DSAL01E;
using BERLANDINO_DSAL01E.Exam;
using BERLANDINO_DSAL01E.Lesson_3;
using BERLANDINO_DSAL01E.Lesson_4;
using BERLANDINO_DSAL01E.Lesson_5;
using Lesson_3;
using Lesson_4;

namespace BERLANDINO_DSAL01E
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
            Application.Run(new L4_Activity3());
        }
    }
}