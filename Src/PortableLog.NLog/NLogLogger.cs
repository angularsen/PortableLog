using System;
using PortableLog.Core;
using PortableLog.NLog.Properties;
using NLogLib = NLog;

namespace PortableLog.NLog
{
    [PublicAPI]
    public sealed class NLogLogger : AbstractLogger
    {
        private static readonly Type DeclaringType = typeof (NLogLogger);
        private readonly NLogLib.Logger _logger;

        static NLogLogger()
        {
        }

        internal NLogLogger(NLogLib.Logger logger)
        {
            _logger = logger;
        }

        public override bool IsDebugEnabled
        {
            get { return _logger.IsDebugEnabled; }
        }

        public override bool IsErrorEnabled
        {
            get { return _logger.IsErrorEnabled; }
        }

        public override bool IsFatalEnabled
        {
            get { return _logger.IsFatalEnabled; }
        }

        public override bool IsInfoEnabled
        {
            get { return _logger.IsInfoEnabled; }
        }

        public override bool IsTraceEnabled
        {
            get { return _logger.IsTraceEnabled; }
        }

        public override bool IsWarnEnabled
        {
            get { return _logger.IsWarnEnabled; }
        }

        protected override void Write(LogLevel logLevel, object message, Exception exception,
            string callerMemberName)
        {

            var logEvent = new NLogLib.LogEventInfo(GetLevel(logLevel), _logger.Name, null, "{0}", new[]
            {
                message
            }, exception);

            _logger.Log(DeclaringType, logEvent);
        }

        private static NLogLib.LogLevel GetLevel(LogLevel logLevel)
        {
            switch (logLevel)
            {
                case LogLevel.All:
                    return NLogLib.LogLevel.Trace;
                case LogLevel.Trace:
                    return NLogLib.LogLevel.Trace;
                case LogLevel.Debug:
                    return NLogLib.LogLevel.Debug;
                case LogLevel.Info:
                    return NLogLib.LogLevel.Info;
                case LogLevel.Warn:
                    return NLogLib.LogLevel.Warn;
                case LogLevel.Error:
                    return NLogLib.LogLevel.Error;
                case LogLevel.Fatal:
                    return NLogLib.LogLevel.Fatal;
                case LogLevel.Off:
                    return NLogLib.LogLevel.Off;
                default:
                    throw new ArgumentOutOfRangeException("logLevel", logLevel, @"unknown log level");
            }
        }
    }
}