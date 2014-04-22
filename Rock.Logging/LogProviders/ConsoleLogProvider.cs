﻿using System;
using System.Threading.Tasks;

namespace Rock.Logging
{
    public class ConsoleLogProvider : FormattableLogProvider
    {
        public ConsoleLogProvider(ILogFormatterFactory logFormatterFactory)
            : base(logFormatterFactory)
        {
        }

        protected override Task Write(LogEntry entry, string formattedLogEntry)
        {
            Console.WriteLine(formattedLogEntry);
            return CompletedTask;
        }
    }
}