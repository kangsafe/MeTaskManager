using System;
using System.Diagnostics;
using System.ServiceProcess;

namespace MeTaskBackupDisk
{
    class Program
    {
        static void Main(string[] args)
        {
            //如果传递了参数 s 就启动服务
            if (args.Length > 0 && args[0] == "s")
            {
                ServiceBase[] ServicesToRun;
                ServicesToRun = new ServiceBase[] { new BackupDiskService() };
                ServiceBase.Run(ServicesToRun);
            }
            else
            {
                Console.WriteLine("这是Windows应用程序");
                Console.WriteLine("请选择，[1]安装服务 [2]卸载服务 [3]退出");
                var rs = int.Parse(Console.ReadLine());
                string strServiceName = "syncService[数据同步服务]";
                switch (rs)
                {
                    case 1:
                        //取当前可执行文件路径，加上"s"参数，证明是从windows服务启动该程序
                        var path = Process.GetCurrentProcess().MainModule.FileName + " s";
                        Process.Start("sc", "create " + strServiceName + " binpath= \"" + path + "\" displayName= " + strServiceName + " start= auto");
                        Console.WriteLine("安装成功");
                        Console.Read();
                        break;
                    case 2:
                        Process.Start("sc", "delete " + strServiceName + "");
                        Console.WriteLine("卸载成功");
                        Console.Read();
                        break;
                    case 3: break;
                }
            }
        }
    }
}
