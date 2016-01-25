using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BellatrixDA;

namespace BellatrixBA
{
    public class JobLoggerBA
    {

        public void InsertLog(string mensaje, string codigo)
        {
            JobLoggerDA objJobLoggerDA = new JobLoggerDA();
            objJobLoggerDA.InsertLog(mensaje, codigo);
        }

    }
}
