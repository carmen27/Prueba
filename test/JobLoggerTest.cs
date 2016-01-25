using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bellatrix;
using BellatrixBE;
namespace test
{
    [TestClass]
    public class JobLoggerTest
    {
        [TestMethod]
        public void LogMessageTest()
        {

            JobLogger objJobLogger = new JobLogger();
            JobLoggerBE objJobLoggerBE = new JobLoggerBE(); 
            string message="";
            bool message2 = true;
            bool warning = false;
            bool error = false;
            objJobLoggerBE.logError = true;
            objJobLoggerBE.logMessage = false;
            objJobLoggerBE.logToConsole = false;
            objJobLoggerBE.logToDatabase = false;
            objJobLoggerBE.logToFile = true;
            objJobLoggerBE.logWarning = false;
            bool expected = true;
            bool actual;
            actual= objJobLogger.LogMessage(message, message2, warning, error, objJobLoggerBE);
           
            Assert.AreEqual(expected,actual);
        }
    }
}
