/*
 *  Author: Troy Davis
 *  Project: Module11 - WindowsFormsDesign
 *      - Software Development Fundamentals Lesson 5
 *        -- Understanding Windows Services - exercise p132
 *        
 *  NOTE: see https://www.stevefenton.co.uk/2015/06/add-visual-studio-command-prompt-to-visual-studio-2015/
 *      - shows how to add the VS 2015 Cmd Prompt to Tools
 *        -- unfortunately didn't help since you must "Run As Administrator" and VS2015 doesn't give this option   
 *      
 *  Class: IN 2017 (Advanced C#)
 *  Date: Apr 12, 2017 
 *  Revision: Original
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace FirstService
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
            ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[]
            {
                new FirstService()
            };
            ServiceBase.Run(ServicesToRun);
        }
    }
}
