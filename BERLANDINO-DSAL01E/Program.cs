using BERLANDINO_DSAL01E;
using BERLANDINO_DSAL01E.Database;
using BERLANDINO_DSAL01E.Database.Activities;
using BERLANDINO_DSAL01E.Exam;
using BERLANDINO_DSAL01E.Lesson_3;
using BERLANDINO_DSAL01E.Lesson_4;
using BERLANDINO_DSAL01E.Lesson_5;
using Lesson_3;
using Lesson_4;
using System.Runtime.CompilerServices;

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
            Application.Run(new User_Account_Registration());
        }
    }
}