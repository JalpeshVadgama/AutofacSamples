using System;

namespace MetadataRegistration
{
    public class FileLogger : ILogger
    {
        /// <summary>
        /// Logs the specified message.
        /// </summary>
        /// <param name="message">The message.</param>
        public void Log(string message)
        {
            Console.WriteLine("File logger");
            Console.WriteLine(message);
        }
    }
}