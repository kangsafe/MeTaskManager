using System.ServiceProcess;
using Quartz;
using Common.Logging;
using Quartz.Impl;
using System.Configuration;
using MeTaskBackBackupDisk;

namespace MeTaskBackupDisk
{
    partial class BackupDiskService : ServiceBase
    {
        private readonly ILog logger;
        private IScheduler scheduler;
        //时间间隔
        private readonly string StrCron = ConfigurationManager.AppSettings["cron"] == null ? "* 10 * * * ?" : ConfigurationManager.AppSettings["cron"];
        public BackupDiskService()
        {
            InitializeComponent();
            //初始化
            logger = LogManager.GetLogger(this.GetType());
            //新建一个调度器工工厂
            ISchedulerFactory factory = new StdSchedulerFactory();
            //使用工厂生成一个调度器
            scheduler = factory.GetScheduler();
        }

        protected override void OnStart(string[] args)
        {
            if (!scheduler.IsStarted)
            {
                //启动调度器
                scheduler.Start();
                //新建一个任务
                IJobDetail job = JobBuilder.Create<AppLogJob>().WithIdentity("AppLogJob", "AppLogJobGroup").Build();
                //新建一个触发器
                ITrigger trigger = TriggerBuilder.Create().StartNow().WithCronSchedule(StrCron).Build();
                //将任务与触发器关联起来放到调度器中
                scheduler.ScheduleJob(job, trigger);
                logger.Info("Quarzt 数据同步服务开启");
            }
        }

        protected override void OnStop()
        {
            if (!scheduler.IsShutdown)
            {
                scheduler.Shutdown();
            }
        }

        /// <summary>
        /// 暂停
        /// </summary>
        protected override void OnPause()
        {
            scheduler.PauseAll();
            base.OnPause();
        }
        /// <summary>
        /// 继续
        /// </summary>
        protected override void OnContinue()
        {
            scheduler.ResumeAll();
            base.OnContinue();
        }
    }
}
