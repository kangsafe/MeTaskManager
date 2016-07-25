using Quartz;
using Quartz.Impl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using Topshelf;

namespace Me.Task.Ctrl
{
    partial class ServiceRuner : ServiceControl, ServiceSuspend
    {
        private readonly IScheduler scheduler;

        public ServiceRuner()
        {
            scheduler = StdSchedulerFactory.GetDefaultScheduler();
        }

        public bool Continue(HostControl hostControl)
        {
            scheduler.ResumeAll();
            return true;
        }

        public bool Pause(HostControl hostControl)
        {
            scheduler.PauseAll();
            return true;
        }

        public bool Start(HostControl hostControl)
        {
            scheduler.Start();
            return true;
        }

        public bool Stop(HostControl hostControl)
        {
            scheduler.Shutdown(false);
            return true;
        }
    }
}
