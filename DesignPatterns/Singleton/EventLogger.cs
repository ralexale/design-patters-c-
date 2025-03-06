using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatterns.Singleton
{
    public class EventLogger
    {
        private static EventLogger _instance;
        private List<string> _eventLogs;

        private EventLogger()
        {
            _eventLogs = new List<string>();
        }


        public static EventLogger GetInstance()
        {
            if (_instance == null)
            {
                _instance = new EventLogger();
            }
            return _instance;
        }


        public void LogEvent(string message)
        {
            string timestap = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            _eventLogs.Add($"{timestap}: {message}");
        }

        public void DisplayLogs()
        {
            foreach (var log in _eventLogs)
            {
                Console.WriteLine(log);
            }
        }
    }
}
