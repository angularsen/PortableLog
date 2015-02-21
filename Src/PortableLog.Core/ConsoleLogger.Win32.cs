using System;

namespace PortableLog.Core
{
    public class ConsoleLogger : AbstractLogger
    {
        private readonly string _loggerName;

        public ConsoleLogger(string loggerName)
        {
            _loggerName = loggerName;
        }

        /// <summary>
        ///     Gets a value indicating whether this instance is debug enabled.
        /// </summary>
        /// <value>
        ///     <c>true</c> if this instance is debug enabled; otherwise, <c>false</c>.
        /// </value>
        public override bool IsDebugEnabled
        {
            get { return true; }
        }

        /// <summary>
        ///     Gets a value indicating whether this instance is error enabled.
        /// </summary>
        /// <value>
        ///     <c>true</c> if this instance is error enabled; otherwise, <c>false</c>.
        /// </value>
        public override bool IsErrorEnabled
        {
            get { return true; }
        }

        /// <summary>
        ///     Gets a value indicating whether this instance is fatal enabled.
        /// </summary>
        /// <value>
        ///     <c>true</c> if this instance is fatal enabled; otherwise, <c>false</c>.
        /// </value>
        public override bool IsFatalEnabled
        {
            get { return true; }
        }

        /// <summary>
        ///     Gets a value indicating whether this instance is info enabled.
        /// </summary>
        /// <value>
        ///     <c>true</c> if this instance is info enabled; otherwise, <c>false</c>.
        /// </value>
        public override bool IsInfoEnabled
        {
            get { return true; }
        }

        /// <summary>
        ///     Gets a value indicating whether this instance is trace enabled.
        /// </summary>
        /// <value>
        ///     <c>true</c> if this instance is trace enabled; otherwise, <c>false</c>.
        /// </value>
        public override bool IsTraceEnabled
        {
            get { return true; }
        }

        /// <summary>
        ///     Gets a value indicating whether this instance is warn enabled.
        /// </summary>
        /// <value>
        ///     <c>true</c> if this instance is warn enabled; otherwise, <c>false</c>.
        /// </value>
        public override bool IsWarnEnabled
        {
            get { return true; }
        }

        protected override void Write(LogLevel level, object message, Exception exception, string callerMemberName)
        {
            Console.WriteLine("{0} {1} {2}{3}", level.ToString().PadLeft(5), _loggerName.PadLeft(15), message,
                exception == null ? string.Empty : "\n---\n" + exception);
        }
    }
}