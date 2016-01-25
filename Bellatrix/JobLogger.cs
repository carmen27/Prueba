using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BellatrixBA;
using BellatrixBE;
using System.IO;

namespace Bellatrix
{
  public   class JobLogger
    {

     //private bool _initialized -- variable no se utiliza;

    // message de tipo booll no puede tener el mismo nombre del tipo string
    public  void LogMessage(string message,bool message2,bool warning,
                                  bool error, JobLoggerBE objJobLoggerBE)
    {
        int t = 0;
        string l = "";
        JobLoggerBA objJobLoggerBA = new JobLoggerBA();
        FileStream fs = File.Create(System.Configuration.ConfigurationManager.AppSettings["LogFileDirectory"]+"LogFile.txt");

        if(message.Trim()==null||message.Length==0)
        {
           return;
        }

       
        //if (!objJobLoggerBE.logToConsole && !objJobLoggerBE.logToFile && !objJobLoggerBE.logToDatabase)
        //{
        //   throw new Exception("Invalid configuration");
        //}
        //if ((!objJobLoggerBE.logError && !objJobLoggerBE.logMessage && !objJobLoggerBE.logWarning) || (!message2 && !warning && !error))
        //{
        //   throw new Exception("Erroror Warning or Message must be specified");
        //}

        if (message2 && objJobLoggerBE.logMessage)
        {
            t=1;
        }
        if (error && objJobLoggerBE.logError)
        {
            t=2;
        }
        if (warning && objJobLoggerBE.logWarning)
        {
            t=3;
        }
      
        if (message.Trim () !="" || t!=0)
        {
           objJobLoggerBA.InsertLog(message, t.ToString());
        }

        //if
        //(!File.Exists(System.Configuration.ConfigurationManager.AppSettings["LogFileDirectory"]+"LogFile"+DateTime.Now.ToShortDateString()+".txt"))
        //{
        //  l=File.ReadAllText(System.Configuration.ConfigurationManager.AppSettings["LogFileDirectory"]+"LogFile"+DateTime.Now.ToShortDateString()+".txt");
        //}
        if (error && objJobLoggerBE.logError)
        {
          l= l+DateTime.Now.ToShortDateString()+message;
        }
        if (warning && objJobLoggerBE.logWarning)
        {
          l=l+DateTime.Now.ToShortDateString()+message;
        }
        if (message2 && objJobLoggerBE.logMessage)
        {
          l=l+DateTime.Now.ToShortDateString()+message;
        }

        File.WriteAllText(System.Configuration.ConfigurationManager.AppSettings[
        "LogFileDirectory"]+"LogFile"+DateTime.Now.ToShortDateString()+".txt",l);

        if (error && objJobLoggerBE.logError)
        {
          Console.ForegroundColor=ConsoleColor.Red;
        }
        if (warning && objJobLoggerBE.logWarning)
        {
          Console.ForegroundColor=ConsoleColor.Yellow;
        }
        if (message2 && objJobLoggerBE.logMessage)
        {
          Console.ForegroundColor=ConsoleColor.White;
        }
        Console.WriteLine(DateTime.Now.ToShortDateString()+message);
      }
    }
}
