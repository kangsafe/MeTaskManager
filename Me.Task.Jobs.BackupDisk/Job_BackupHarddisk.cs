using log4net;
using Quartz;

namespace Me.Task.Jobs.BackupDisk
{
    public sealed class Job_BackupHarddisk : IJob
    {
        private readonly ILog _logger = LogManager.GetLogger(typeof(Job_BackupHarddisk));

        public void Execute(IJobExecutionContext context)
        {
            _logger.InfoFormat("Job_BackupHarddisk");
        }
    }
}
