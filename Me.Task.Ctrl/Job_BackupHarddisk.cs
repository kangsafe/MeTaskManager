using log4net;
using Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Me.Task.Ctrl
{
    public sealed class Job_BackupHarddisk : IJob
    {
        private readonly ILog _logger = LogManager.GetLogger(typeof(Job_BackupHarddisk));

        public void Execute(IJobExecutionContext context)
        {
            _logger.InfoFormat("TestJob测试");
        }
    }
}
