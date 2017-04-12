﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace FirstService
{
    public partial class FirstService : ServiceBase
    {
        public FirstService()
        {
            InitializeComponent();
            if (!EventLog.SourceExists("FirstService"))
            {
                EventLog.CreateEventSource("FirstService", "Application");
            }
            eventLog1.Source = "FirstService";
            eventLog1.Log = "Application";
        }

        protected override void OnStart(string[] args)
        {
            eventLog1.WriteEntry("FirstService: OnStart() - starting the service", EventLogEntryType.Information, 1001);
        }

        protected override void OnStop()
        {
            eventLog1.WriteEntry("FirstService: OnStop() - stopping the service", EventLogEntryType.Information, 1001);
        }
        protected override void OnPause()
        {
            eventLog1.WriteEntry("FirstService: OnPause() - pausing the service", EventLogEntryType.Information, 1001);
        }
        protected override void OnContinue()
        {
            eventLog1.WriteEntry("FirstService: OnContinue() - continuing the service", EventLogEntryType.Information, 1001);
        }
        protected override void OnShutdown()
        {
            eventLog1.WriteEntry("FirstService: OnShutdown() - shutting down the service", EventLogEntryType.Information, 1001);
        }
    }
}
