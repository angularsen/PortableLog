using System;
using PortableLog.Core.Properties;

namespace PortableLog.Core
{
    /// <summary>
    ///     Ignores all log messages.
    /// </summary>
    [PublicAPI]
    public sealed class NoOpLogger : AbstractLogger
    {
        /// <summary>
        ///     Always returns <see langword="false" />.
        /// </summary>
        public override bool IsDebugEnabled
        {
            get { return false; }
        }

        /// <summary>
        ///     Always returns <see langword="false" />.
        /// </summary>
        public override bool IsErrorEnabled
        {
            get { return false; }
        }

        /// <summary>
        ///     Always returns <see langword="false" />.
        /// </summary>
        public override bool IsFatalEnabled
        {
            get { return false; }
        }

        /// <summary>
        ///     Always returns <see langword="false" />.
        /// </summary>
        public override bool IsInfoEnabled
        {
            get { return false; }
        }

        /// <summary>
        ///     Always returns <see langword="false" />.
        /// </summary>
        public override bool IsTraceEnabled
        {
            get { return false; }
        }

        /// <summary>
        ///     Always returns <see langword="false" />.
        /// </summary>
        public override bool IsWarnEnabled
        {
            get { return false; }
        }

        protected override void Write(LogLevel level, object message, Exception exception, string callerMemberName)
        {
            // Do nothing. Should never be called since all levels are disabled anyway.
        }
    }
}