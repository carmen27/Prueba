using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BellatrixBE
{
    public class JobLoggerBE
    {

        private static bool _logToFile;
        private static bool _logToConsole;
        private static bool _logMessage;
        private static bool _logWarning;
        private static bool _logError;
        private static bool LogToDatabase;


        public bool logError
        {
            get { return _logError; }
            set { _logError = value; }
        }
        public bool logMessage
        {
            get { return _logMessage; }
            set { _logMessage = value; }
        }
        public bool logWarning
        {
            get { return _logWarning; }
            set { _logWarning = value; }
        }
        public bool logToFile
        {
            get { return _logToFile; }
            set { _logToFile = value; }
        }

        public bool logToConsole
        {
            get { return _logToConsole; }
            set { _logToConsole = value; }
        }
        public bool logToDatabase
        {
            get { return LogToDatabase; }
            set { LogToDatabase = value; }
        }
    }
}
