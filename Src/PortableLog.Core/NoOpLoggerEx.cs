using System;

namespace PortableLog.Core
{
    /// <summary>
    ///     Silently ignores all log messages.
    /// </summary>
    public sealed class NoOpLoggerEx : ILogEx
    {
        /// <summary>
        ///     Always returns <see langword="false" />.
        /// </summary>
        public bool IsDebugEnabled
        {
            get { return false; }
        }

        /// <summary>
        ///     Always returns <see langword="false" />.
        /// </summary>
        public bool IsErrorEnabled
        {
            get { return false; }
        }

        /// <summary>
        ///     Always returns <see langword="false" />.
        /// </summary>
        public bool IsFatalEnabled
        {
            get { return false; }
        }

        /// <summary>
        ///     Always returns <see langword="false" />.
        /// </summary>
        public bool IsInfoEnabled
        {
            get { return false; }
        }

        /// <summary>
        ///     Always returns <see langword="false" />.
        /// </summary>
        public bool IsTraceEnabled
        {
            get { return false; }
        }

        /// <summary>
        ///     Always returns <see langword="false" />.
        /// </summary>
        public bool IsWarnEnabled
        {
            get { return false; }
        }

        /// <summary>
        ///     Ignores message.
        /// </summary>
        /// <param name="message"></param>
        public void Trace(object message)
        {
            // NOP - no operation
        }

        /// <summary>
        ///     Ignores message.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="exception"></param>
        public void Trace(Exception exception, object message)
        {
            // NOP - no operation
        }

        /// <summary>
        ///     Ignores message.
        /// </summary>
        /// <param name="formatMessageCallback">A callback used by the logger to obtain the message if log level is matched</param>
        public void Trace(Func<FormatMessageHandler, string> formatMessageCallback)
        {
            // NOP - no operation
        }

        /// <summary>
        ///     Ignores message.
        /// </summary>
        /// <param name="formatMessageCallback">A callback used by the logger to obtain the message if log level is matched</param>
        /// <param name="exception">The exception to log, including its stack trace.</param>
        public void Trace(Exception exception, Func<FormatMessageHandler, string> formatMessageCallback)
        {
            // NOP - no operation
        }

        /// <summary>
        ///     Ignores message.
        /// </summary>
        /// <param name="formatProvider">An <see cref="IFormatProvider" /> that supplies culture-specific formatting information.</param>
        /// <param name="formatMessageCallback">A callback used by the logger to obtain the message if log level is matched</param>
        public void Trace(IFormatProvider formatProvider, Func<FormatMessageHandler, string> formatMessageCallback)
        {
            // NOP - no operation
        }

        /// <summary>
        ///     Ignores message.
        /// </summary>
        /// <param name="formatProvider">An <see cref="IFormatProvider" /> that supplies culture-specific formatting information.</param>
        /// <param name="formatMessageCallback">A callback used by the logger to obtain the message if log level is matched</param>
        /// <param name="exception">The exception to log, including its stack trace.</param>
        public void Trace(Exception exception, IFormatProvider formatProvider,
            Func<FormatMessageHandler, string> formatMessageCallback)
        {
            // NOP - no operation
        }

        /// <summary>
        ///     Ignores message.
        /// </summary>
        /// <param name="format">The format of the message object to log.<see cref="string.Format(string,object[])" /> </param>
        /// <param name="args"></param>
        public void TraceFormat(string format, params object[] args)
        {
            // NOP - no operation
        }

        /// <summary>
        ///     Ignores message.
        /// </summary>
        /// <param name="format">The format of the message object to log.<see cref="string.Format(string,object[])" /> </param>
        /// <param name="exception">The exception to log.</param>
        /// <param name="args">the list of message format arguments</param>
        public void TraceFormat(Exception exception, string format, params object[] args)
        {
            // NOP - no operation
        }

        /// <summary>
        ///     Ignores message.
        /// </summary>
        /// <param name="formatProvider">An <see cref="IFormatProvider" /> that supplies culture-specific formatting information.</param>
        /// <param name="format">The format of the message object to log.<see cref="string.Format(string,object[])" /> </param>
        /// <param name="args">the list of message format arguments</param>
        public void TraceFormat(IFormatProvider formatProvider, string format, params object[] args)
        {
            // NOP - no operation
        }

        /// <summary>
        ///     Ignores message.
        /// </summary>
        /// <param name="formatProvider">An <see cref="IFormatProvider" /> that supplies culture-specific formatting information.</param>
        /// <param name="format">The format of the message object to log.<see cref="string.Format(string,object[])" /> </param>
        /// <param name="exception">The exception to log.</param>
        /// <param name="args">the list of message format arguments</param>
        public void TraceFormat(Exception exception, IFormatProvider formatProvider, string format, params object[] args)
        {
            // NOP - no operation
        }

        /// <summary>
        ///     Ignores message.
        /// </summary>
        /// <param name="message"></param>
        public void Debug(object message)
        {
            // NOP - no operation
        }

        /// <summary>
        ///     Ignores message.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="exception"></param>
        public void Debug(Exception exception, object message)
        {
            // NOP - no operation
        }

        /// <summary>
        ///     Ignores message.
        /// </summary>
        /// <param name="formatMessageCallback">A callback used by the logger to obtain the message if log level is matched</param>
        public void Debug(Func<FormatMessageHandler, string> formatMessageCallback)
        {
            // NOP - no operation
        }

        /// <summary>
        ///     Ignores message.
        /// </summary>
        /// <param name="formatMessageCallback">A callback used by the logger to obtain the message if log level is matched</param>
        /// <param name="exception">The exception to log, including its stack Debug.</param>
        public void Debug(Exception exception, Func<FormatMessageHandler, string> formatMessageCallback)
        {
            // NOP - no operation
        }

        /// <summary>
        ///     Ignores message.
        /// </summary>
        /// <param name="formatProvider">An <see cref="IFormatProvider" /> that supplies culture-specific formatting information.</param>
        /// <param name="formatMessageCallback">A callback used by the logger to obtain the message if log level is matched</param>
        public void Debug(IFormatProvider formatProvider, Func<FormatMessageHandler, string> formatMessageCallback)
        {
            // NOP - no operation
        }

        /// <summary>
        ///     Ignores message.
        /// </summary>
        /// <param name="formatProvider">An <see cref="IFormatProvider" /> that supplies culture-specific formatting information.</param>
        /// <param name="formatMessageCallback">A callback used by the logger to obtain the message if log level is matched</param>
        /// <param name="exception">The exception to log, including its stack Debug.</param>
        public void Debug(Exception exception, IFormatProvider formatProvider,
            Func<FormatMessageHandler, string> formatMessageCallback)
        {
            // NOP - no operation
        }

        /// <summary>
        ///     Ignores message.
        /// </summary>
        /// <param name="format">The format of the message object to log.<see cref="string.Format(string,object[])" /> </param>
        /// <param name="args"></param>
        public void DebugFormat(string format, params object[] args)
        {
            // NOP - no operation
        }

        /// <summary>
        ///     Ignores message.
        /// </summary>
        /// <param name="format">The format of the message object to log.<see cref="string.Format(string,object[])" /> </param>
        /// <param name="exception">The exception to log.</param>
        /// <param name="args">the list of message format arguments</param>
        public void DebugFormat(Exception exception, string format, params object[] args)
        {
            // NOP - no operation
        }

        /// <summary>
        ///     Ignores message.
        /// </summary>
        /// <param name="formatProvider">An <see cref="IFormatProvider" /> that supplies culture-specific formatting information.</param>
        /// <param name="format">The format of the message object to log.<see cref="string.Format(string,object[])" /> </param>
        /// <param name="args">the list of message format arguments</param>
        public void DebugFormat(IFormatProvider formatProvider, string format, params object[] args)
        {
            // NOP - no operation
        }

        /// <summary>
        ///     Ignores message.
        /// </summary>
        /// <param name="formatProvider">An <see cref="IFormatProvider" /> that supplies culture-specific formatting information.</param>
        /// <param name="format">The format of the message object to log.<see cref="string.Format(string,object[])" /> </param>
        /// <param name="exception">The exception to log.</param>
        /// <param name="args">the list of message format arguments</param>
        public void DebugFormat(Exception exception, IFormatProvider formatProvider, string format, params object[] args)
        {
            // NOP - no operation
        }

        /// <summary>
        ///     Ignores message.
        /// </summary>
        /// <param name="message"></param>
        public void Info(object message)
        {
            // NOP - no operation
        }

        /// <summary>
        ///     Ignores message.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="exception"></param>
        public void Info(Exception exception, object message)
        {
            // NOP - no operation
        }

        /// <summary>
        ///     Ignores message.
        /// </summary>
        /// <param name="formatMessageCallback">A callback used by the logger to obtain the message if log level is matched</param>
        public void Info(Func<FormatMessageHandler, string> formatMessageCallback)
        {
            // NOP - no operation
        }

        /// <summary>
        ///     Ignores message.
        /// </summary>
        /// <param name="formatMessageCallback">A callback used by the logger to obtain the message if log level is matched</param>
        /// <param name="exception">The exception to log, including its stack Info.</param>
        public void Info(Exception exception, Func<FormatMessageHandler, string> formatMessageCallback)
        {
            // NOP - no operation
        }

        /// <summary>
        ///     Ignores message.
        /// </summary>
        /// <param name="formatProvider">An <see cref="IFormatProvider" /> that supplies culture-specific formatting information.</param>
        /// <param name="formatMessageCallback">A callback used by the logger to obtain the message if log level is matched</param>
        public void Info(IFormatProvider formatProvider, Func<FormatMessageHandler, string> formatMessageCallback)
        {
            // NOP - no operation
        }

        /// <summary>
        ///     Ignores message.
        /// </summary>
        /// <param name="formatProvider">An <see cref="IFormatProvider" /> that supplies culture-specific formatting information.</param>
        /// <param name="formatMessageCallback">A callback used by the logger to obtain the message if log level is matched</param>
        /// <param name="exception">The exception to log, including its stack Info.</param>
        public void Info(Exception exception, IFormatProvider formatProvider,
            Func<FormatMessageHandler, string> formatMessageCallback)
        {
            // NOP - no operation
        }

        /// <summary>
        ///     Ignores message.
        /// </summary>
        /// <param name="format">The format of the message object to log.<see cref="string.Format(string,object[])" /> </param>
        /// <param name="args"></param>
        public void InfoFormat(string format, params object[] args)
        {
            // NOP - no operation
        }

        /// <summary>
        ///     Ignores message.
        /// </summary>
        /// <param name="format">The format of the message object to log.<see cref="string.Format(string,object[])" /> </param>
        /// <param name="exception">The exception to log.</param>
        /// <param name="args">the list of message format arguments</param>
        public void InfoFormat(Exception exception, string format, params object[] args)
        {
            // NOP - no operation
        }

        /// <summary>
        ///     Ignores message.
        /// </summary>
        /// <param name="formatProvider">An <see cref="IFormatProvider" /> that supplies culture-specific formatting information.</param>
        /// <param name="format">The format of the message object to log.<see cref="string.Format(string,object[])" /> </param>
        /// <param name="args">the list of message format arguments</param>
        public void InfoFormat(IFormatProvider formatProvider, string format, params object[] args)
        {
            // NOP - no operation
        }

        /// <summary>
        ///     Ignores message.
        /// </summary>
        /// <param name="formatProvider">An <see cref="IFormatProvider" /> that supplies culture-specific formatting information.</param>
        /// <param name="format">The format of the message object to log.<see cref="string.Format(string,object[])" /> </param>
        /// <param name="exception">The exception to log.</param>
        /// <param name="args">the list of message format arguments</param>
        public void InfoFormat(Exception exception, IFormatProvider formatProvider, string format, params object[] args)
        {
            // NOP - no operation
        }

        /// <summary>
        ///     Ignores message.
        /// </summary>
        /// <param name="message"></param>
        public void Warn(object message)
        {
            // NOP - no operation
        }

        /// <summary>
        ///     Ignores message.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="exception"></param>
        public void Warn(Exception exception, object message)
        {
            // NOP - no operation
        }

        /// <summary>
        ///     Ignores message.
        /// </summary>
        /// <param name="formatMessageCallback">A callback used by the logger to obtain the message if log level is matched</param>
        public void Warn(Func<FormatMessageHandler, string> formatMessageCallback)
        {
            // NOP - no operation
        }

        /// <summary>
        ///     Ignores message.
        /// </summary>
        /// <param name="formatMessageCallback">A callback used by the logger to obtain the message if log level is matched</param>
        /// <param name="exception">The exception to log, including its stack Warn.</param>
        public void Warn(Exception exception, Func<FormatMessageHandler, string> formatMessageCallback)
        {
            // NOP - no operation
        }

        /// <summary>
        ///     Ignores message.
        /// </summary>
        /// <param name="formatProvider">An <see cref="IFormatProvider" /> that supplies culture-specific formatting information.</param>
        /// <param name="formatMessageCallback">A callback used by the logger to obtain the message if log level is matched</param>
        public void Warn(IFormatProvider formatProvider, Func<FormatMessageHandler, string> formatMessageCallback)
        {
            // NOP - no operation
        }

        /// <summary>
        ///     Ignores message.
        /// </summary>
        /// <param name="formatProvider">An <see cref="IFormatProvider" /> that supplies culture-specific formatting information.</param>
        /// <param name="formatMessageCallback">A callback used by the logger to obtain the message if log level is matched</param>
        /// <param name="exception">The exception to log, including its stack Warn.</param>
        public void Warn(Exception exception, IFormatProvider formatProvider,
            Func<FormatMessageHandler, string> formatMessageCallback)
        {
            // NOP - no operation
        }

        /// <summary>
        ///     Ignores message.
        /// </summary>
        /// <param name="format">The format of the message object to log.<see cref="string.Format(string,object[])" /> </param>
        /// <param name="args"></param>
        public void WarnFormat(string format, params object[] args)
        {
            // NOP - no operation
        }

        /// <summary>
        ///     Ignores message.
        /// </summary>
        /// <param name="format">The format of the message object to log.<see cref="string.Format(string,object[])" /> </param>
        /// <param name="exception">The exception to log.</param>
        /// <param name="args">the list of message format arguments</param>
        public void WarnFormat(Exception exception, string format, params object[] args)
        {
            // NOP - no operation
        }

        /// <summary>
        ///     Ignores message.
        /// </summary>
        /// <param name="formatProvider">An <see cref="IFormatProvider" /> that supplies culture-specific formatting Warnrmation.</param>
        /// <param name="format">The format of the message object to log.<see cref="string.Format(string,object[])" /> </param>
        /// <param name="args">the list of message format arguments</param>
        public void WarnFormat(IFormatProvider formatProvider, string format, params object[] args)
        {
            // NOP - no operation
        }

        /// <summary>
        ///     Ignores message.
        /// </summary>
        /// <param name="formatProvider">An <see cref="IFormatProvider" /> that supplies culture-specific formatting Warnrmation.</param>
        /// <param name="format">The format of the message object to log.<see cref="string.Format(string,object[])" /> </param>
        /// <param name="exception">The exception to log.</param>
        /// <param name="args">the list of message format arguments</param>
        public void WarnFormat(Exception exception, IFormatProvider formatProvider, string format, params object[] args)
        {
            // NOP - no operation
        }

        /// <summary>
        ///     Ignores message.
        /// </summary>
        /// <param name="message"></param>
        public void Error(object message)
        {
            // NOP - no operation
        }

        /// <summary>
        ///     Ignores message.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="exception"></param>
        public void Error(Exception exception, object message)
        {
            // NOP - no operation
        }

        /// <summary>
        ///     Ignores message.
        /// </summary>
        /// <param name="formatMessageCallback">A callback used by the logger to obtain the message if log level is matched</param>
        public void Error(Func<FormatMessageHandler, string> formatMessageCallback)
        {
            // NOP - no operation
        }

        /// <summary>
        ///     Ignores message.
        /// </summary>
        /// <param name="formatMessageCallback">A callback used by the logger to obtain the message if log level is matched</param>
        /// <param name="exception">The exception to log, including its stack Error.</param>
        public void Error(Exception exception, Func<FormatMessageHandler, string> formatMessageCallback)
        {
            // NOP - no operation
        }

        /// <summary>
        ///     Ignores message.
        /// </summary>
        /// <param name="formatProvider">An <see cref="IFormatProvider" /> that supplies culture-specific formatting information.</param>
        /// <param name="formatMessageCallback">A callback used by the logger to obtain the message if log level is matched</param>
        public void Error(IFormatProvider formatProvider, Func<FormatMessageHandler, string> formatMessageCallback)
        {
            // NOP - no operation
        }

        /// <summary>
        ///     Ignores message.
        /// </summary>
        /// <param name="formatProvider">An <see cref="IFormatProvider" /> that supplies culture-specific formatting information.</param>
        /// <param name="formatMessageCallback">A callback used by the logger to obtain the message if log level is matched</param>
        /// <param name="exception">The exception to log, including its stack Error.</param>
        public void Error(Exception exception, IFormatProvider formatProvider,
            Func<FormatMessageHandler, string> formatMessageCallback)
        {
            // NOP - no operation
        }

        /// <summary>
        ///     Ignores message.
        /// </summary>
        /// <param name="format">The format of the message object to log.<see cref="string.Format(string,object[])" /> </param>
        /// <param name="args"></param>
        public void ErrorFormat(string format, params object[] args)
        {
            // NOP - no operation
        }

        /// <summary>
        ///     Ignores message.
        /// </summary>
        /// <param name="format">The format of the message object to log.<see cref="string.Format(string,object[])" /> </param>
        /// <param name="exception">The exception to log.</param>
        /// <param name="args">the list of message format arguments</param>
        public void ErrorFormat(Exception exception, string format, params object[] args)
        {
            // NOP - no operation
        }

        /// <summary>
        ///     Ignores message.
        /// </summary>
        /// <param name="formatProvider">An <see cref="IFormatProvider" /> that supplies culture-specific formatting Errorrmation.</param>
        /// <param name="format">The format of the message object to log.<see cref="string.Format(string,object[])" /> </param>
        /// <param name="args">the list of message format arguments</param>
        public void ErrorFormat(IFormatProvider formatProvider, string format, params object[] args)
        {
            // NOP - no operation
        }

        /// <summary>
        ///     Ignores message.
        /// </summary>
        /// <param name="formatProvider">An <see cref="IFormatProvider" /> that supplies culture-specific formatting Errorrmation.</param>
        /// <param name="format">The format of the message object to log.<see cref="string.Format(string,object[])" /> </param>
        /// <param name="exception">The exception to log.</param>
        /// <param name="args">the list of message format arguments</param>
        public void ErrorFormat(Exception exception, IFormatProvider formatProvider, string format, params object[] args)
        {
            // NOP - no operation
        }

        /// <summary>
        ///     Ignores message.
        /// </summary>
        /// <param name="message"></param>
        public void Fatal(object message)
        {
            // NOP - no operation
        }

        /// <summary>
        ///     Ignores message.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="exception"></param>
        public void Fatal(Exception exception, object message)
        {
            // NOP - no operation
        }

        /// <summary>
        ///     Ignores message.
        /// </summary>
        /// <param name="formatMessageCallback">A callback used by the logger to obtain the message if log level is matched</param>
        public void Fatal(Func<FormatMessageHandler, string> formatMessageCallback)
        {
            // NOP - no operation
        }

        /// <summary>
        ///     Ignores message.
        /// </summary>
        /// <param name="formatMessageCallback">A callback used by the logger to obtain the message if log level is matched</param>
        /// <param name="exception">The exception to log, including its stack Fatal.</param>
        public void Fatal(Exception exception, Func<FormatMessageHandler, string> formatMessageCallback)
        {
            // NOP - no operation
        }

        /// <summary>
        ///     Ignores message.
        /// </summary>
        /// <param name="formatProvider">An <see cref="IFormatProvider" /> that supplies culture-specific formatting information.</param>
        /// <param name="formatMessageCallback">A callback used by the logger to obtain the message if log level is matched</param>
        public void Fatal(IFormatProvider formatProvider, Func<FormatMessageHandler, string> formatMessageCallback)
        {
            // NOP - no operation
        }

        /// <summary>
        ///     Ignores message.
        /// </summary>
        /// <param name="formatProvider">An <see cref="IFormatProvider" /> that supplies culture-specific formatting information.</param>
        /// <param name="formatMessageCallback">A callback used by the logger to obtain the message if log level is matched</param>
        /// <param name="exception">The exception to log, including its stack Fatal.</param>
        public void Fatal(Exception exception, IFormatProvider formatProvider,
            Func<FormatMessageHandler, string> formatMessageCallback)
        {
            // NOP - no operation
        }

        /// <summary>
        ///     Ignores message.
        /// </summary>
        /// <param name="format">The format of the message object to log.<see cref="string.Format(string,object[])" /> </param>
        /// <param name="args"></param>
        public void FatalFormat(string format, params object[] args)
        {
            // NOP - no operation
        }

        /// <summary>
        ///     Ignores message.
        /// </summary>
        /// <param name="format">The format of the message object to log.<see cref="string.Format(string,object[])" /> </param>
        /// <param name="exception">The exception to log.</param>
        /// <param name="args">the list of message format arguments</param>
        public void FatalFormat(Exception exception, string format, params object[] args)
        {
            // NOP - no operation
        }

        /// <summary>
        ///     Ignores message.
        /// </summary>
        /// <param name="formatProvider">An <see cref="IFormatProvider" /> that supplies culture-specific formatting Fatalrmation.</param>
        /// <param name="format">The format of the message object to log.<see cref="string.Format(string,object[])" /> </param>
        /// <param name="args">the list of message format arguments</param>
        public void FatalFormat(IFormatProvider formatProvider, string format, params object[] args)
        {
            // NOP - no operation
        }

        /// <summary>
        ///     Ignores message.
        /// </summary>
        /// <param name="formatProvider">An <see cref="IFormatProvider" /> that supplies culture-specific formatting Fatalrmation.</param>
        /// <param name="format">The format of the message object to log.<see cref="string.Format(string,object[])" /> </param>
        /// <param name="exception">The exception to log.</param>
        /// <param name="args">the list of message format arguments</param>
        public void FatalFormat(Exception exception, IFormatProvider formatProvider, string format, params object[] args)
        {
            // NOP - no operation
        }

        public void DebugEx(object message, string callerName = "")
        {
        }

        public void DebugFormatEx(string format, object[] args, string callerName = "")
        {
        }

        public void ErrorEx(object message, string callerName = "")
        {
        }

        public void ErrorEx(Exception exception, string message, string callerName = "")
        {
        }

        public void ErrorFormatEx(string format, object[] args, string callerName = "")
        {
        }

        public void InfoEx(object message, string callerName = "")
        {
        }

        public void InfoFormatEx(string format, object[] args, string callerName = "")
        {
        }

        public void TraceEx(object message, string callerName = "")
        {
        }

        public void TraceFormatEx(string format, object[] args, string callerMemberName = "")
        {
        }

        public void WarnEx(object message, string callerName = "")
        {
        }

        public void WarnEx(Exception exception, string message, string callerName = "")
        {
        }

        public void WarnFormatEx(string format, object[] args, string callerName = "")
        {
        }

        public void WarnFormatEx(Exception exception, string format, object[] args, string callerMemberName = "")
        {
        }
    }
}