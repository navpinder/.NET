using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Example_2808
{
    public partial class Example_2808 : ServiceBase
    {
        public Example_2808()
        {
            InitializeComponent();
            if (!EventLog.SourceExists("MyServicesSource"))
                System.Diagnostics.EventLog.CreateEventSource("MyServicesSource", "MyServiceLog");
            eventLog1.Source = "MyServicesSource";
            eventLog1.Log = "MyServiceLog";
        }

        protected override void OnStart(string[] args)
        {
            eventLog1.WriteEntry("Serive Started");
            System.Timers.Timer timer = new System.Timers.Timer();
            timer.Interval = 60000;
            timer.Elapsed += new System.Timers.ElapsedEventHandler(this.OnTimer);
            timer.Start();
        }

        protected void OnTimer(object sender, ElapsedEventArgs e)
        {
            eventLog1.WriteEntry("Monitoring the system and 60 secs are gone", EventLogEntryType.Information);
        }

        protected override void OnStop()
        {
            eventLog1.WriteEntry("Serive Stopped");
        }
    }
}
