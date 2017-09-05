using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace Assignement_2808
{
    public partial class Service1 : ServiceBase
    {
        string data = @"D:\Data\";
        string backup = @"D:\Backup\";
        public Service1()
        {
            InitializeComponent();
            if (!EventLog.SourceExists("MyBackupServicesSource"))
                System.Diagnostics.EventLog.CreateEventSource("MyBackupServicesSource", "MyBackupServiceLog");
            eventLog1.Source = "MyBackupServicesSource";
            eventLog1.Log = "MyBackupServiceLog";
        }

        protected override void OnStart(string[] args)
        {
            eventLog1.WriteEntry("Serive Started");
            FileSystemWatcher watcher = new FileSystemWatcher();
            watcher.Path = @"D:\Data";
            watcher.IncludeSubdirectories = true;
            watcher.NotifyFilter = NotifyFilters.Attributes | NotifyFilters.CreationTime | NotifyFilters.DirectoryName | NotifyFilters.FileName | NotifyFilters.LastAccess | NotifyFilters.LastWrite | NotifyFilters.Security | NotifyFilters.Size;
            watcher.EnableRaisingEvents = true;
            watcher.Created += new FileSystemEventHandler(watcher_Created);
           // watcher.Deleted += new FileSystemEventHandler(watcher_Deleted);
            watcher.Changed += new FileSystemEventHandler(watcher_Changed);
            watcher.Renamed += new RenamedEventHandler(watcher_Renamed);
        }
        protected void watcher_Renamed(object sender, RenamedEventArgs e)
        {
            eventLog1.WriteEntry("File Renamed from "+e.OldName+" to "+e.Name);
            if (File.Exists(backup+e.OldName))
            {
                File.Delete(backup + e.OldName);
            }
            string source = data + e.Name;
            string destFile = backup + e.Name;
            System.IO.File.Copy(source, destFile, true);
            eventLog1.WriteEntry("File Renamed in backup");

        }
        protected void watcher_Changed(object sender, FileSystemEventArgs e)
        {
            eventLog1.WriteEntry("File Edited "+e.Name);
            string source = data + e.Name;
            string destFile = backup + e.Name;
            System.IO.File.Copy(source, destFile, true);
            eventLog1.WriteEntry("File Changed in backup");
        }
        /*static void watcher_Deleted(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine(e.Name + " file has been deleted");
        }*/
        protected void watcher_Created(object sender, FileSystemEventArgs e)
        {
            eventLog1.WriteEntry("File Created "+e.Name);
            string source = data + e.Name;
            string destFile = backup + e.Name;
            System.IO.File.Copy(source, destFile, true);
            eventLog1.WriteEntry("File Copied in backup");
        }

        protected override void OnStop()
        {
            eventLog1.WriteEntry("Serive Stoped");
        }

        private void eventLog1_EntryWritten(object sender, EntryWrittenEventArgs e)
        {

        }
    }
}
