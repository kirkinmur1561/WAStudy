using System.Collections.Generic;
using WAN5CP.Services;

namespace WAN5CP.Models.Services
{
    public static class RAM_LoggerS
    {
        private static List<LoggerS> logs = new List<LoggerS>();

        public static void Add(LoggerS log) =>
            logs.Add(log);

        public static IEnumerable<LoggerS> GetLogs() =>
            logs;
    }
}