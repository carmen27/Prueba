using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using BellatrixBE;

namespace Bellatrix
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string message="Hola";
            bool message2=true ;
            bool warning=false ;
            bool error=false ;
            JobLoggerBE objJobLoggerBE=new JobLoggerBE();
            JobLogger ObjJobLogger=new JobLogger();
            ObjJobLogger.LogMessage(message,message2,warning,
                                      error,  objJobLoggerBE);
            Console.Read();
     
        }
    }
}
