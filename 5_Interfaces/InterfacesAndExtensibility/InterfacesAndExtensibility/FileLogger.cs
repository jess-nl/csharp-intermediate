using System;
using System.IO;

namespace InterfacesAndExtensibility
{
    public class FileLogger : ILogger
    {
        private readonly string _path;

        public FileLogger(string path)
        {
            _path = path;
        }

        public void LogError(string message)
        {
            Log(message, "INFO");

            //using(var streamWriter = new StreamWriter(_path, true))
            //{
            //    streamWriter.WriteLine("ERROR: " + message);
            //}
        }

        public void LogInfo(string message)
        {
            Log(message, "INFO");

            //using (var streamWriter = new StreamWriter(_path, true))
            //{
            //    streamWriter.WriteLine("ERROR: " + message);
            //}
        }

        // to make the code more DRY, we can do the following instead (another way to make it DRY would be to use enumeration):
        private void Log(string message, string messageType)
        {
            using (var streamWriter = new StreamWriter(_path, true))
            {
                streamWriter.WriteLine(messageType + ": " + message);
            }
        }
    }
}
