/*
 *  Author: Troy Davis
 *  Project: Module11 - WindowsFormsDesign
 *      - Software Development Fundamentals Lesson 5
 *        -- Understanding Multiple Document Interface (MDI) Applications - exercise p127
 *            
 *  Class: IN 2017 (Advanced C#)
 *  Date: Apr 12, 2017 
 *  Revision: Original
 */

using System;
using System.Windows.Forms;

namespace MDIApplication
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ParentForm());
        }
    }
}
