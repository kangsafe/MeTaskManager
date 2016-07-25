using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Me.Task.Ctrl
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            log4net.Config.XmlConfigurator.ConfigureAndWatch(new FileInfo(AppDomain.CurrentDomain.BaseDirectory + "log4net.config"));
            //string xml = "";
            
            //log4net.Config.XmlConfigurator.Configure();
        }
    }
}
