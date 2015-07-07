using System;

namespace MetadataRegistration
{
    public class DatabaseLogger : ILogger
    {
        /// <summary>
        /// Logs the specified message.
        /// </summary>
        /// <param name="message">The message.</param>
        public void Log(string message)
        {
            Console.WriteLine("Database Logger");
            Console.WriteLine(message);
        }
    }
}