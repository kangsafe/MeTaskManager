using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quartz;
using Quartz.Job;
namespace MeTaskBackBackupDisk
{
    /// <summary>
    /// 同步applog任务
    /// </summary>
    public class AppLogJob : IJob
    {
        //使用Common.Logging.dll日志接口实现日志记录
        private static readonly Common.Logging.ILog logger = Common.Logging.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        /// <summary>
        /// 定时任务执行
        /// </summary>
        /// <param name="context"></param>
        public void Execute(IJobExecutionContext context)
        {
            try
            {
                logger.Info("AppLogJob 任务开始运行");

                for (int i = 0; i < 10; i++)
                {
                    logger.InfoFormat("AppLogJob 正在运行{0}", i);
                }

                logger.Info("AppLogJob 任务运行结束");
            }
            catch (Exception ex)
            {
                logger.Error("AppLogJob 运行异常", ex);
            }
        }
    }
}
