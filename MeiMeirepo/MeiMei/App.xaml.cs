using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using MeiMei.Model;

namespace MeiMei
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
           // Database.SetInitializer<MeiMeiContext>(new CreateDatabaseIfNotExists<MeiMeiContext>());
            //Logger("Заппуск программы ...");
        }

        public void Logger(String lines)
        {

            // Write the string to a file.append mode is enabled so that the log
            // lines get appended to  test.txt than wiping content and writing the log

            //System.IO.StreamWriter file = new System.IO.StreamWriter("e:\\test.txt", true);
            //file.WriteLine(lines);

            //file.Close();

        }
        protected override void OnStartup(StartupEventArgs e)
        {
            //this.CheckAccess();
            base.OnStartup(e);
        }
    }
}
