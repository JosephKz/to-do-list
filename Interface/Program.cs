using System;
using toDoList;
using System.Windows.Forms;

namespace Interface
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
            var manager = new taskManager();
            Application.Run(new Form1());
        }
    }
}