using System;

namespace PortableLog.Core
{
    /// <summary>
    ///     Provides base implementation suitable for almost all logger adapters
    /// </summary>
    public abstract class AbstractLogger : ILog
    {
        /// <summary>
        ///     Holds the method for writing a message to the log system.
        /// </summary>
        private readonly WriteHandler _write;

        /// <summary>
        ///     Creates a new logger instance using <see cref="WriteInternal" /> for
        ///     writing log events to the underlying log system.
        /// </summary>
        protected AbstractLogger()
        {
            _write = WriteInternal;
        }

        /// <summary>
        ///     Use this constructor to specify a different method than <see cref="WriteInternal" />
        ///     for writing log events to the underlying log system.
        /// </summary>
        /// <remarks>
        ///     Usually this is not necessary.
        /// </remarks>
        protected AbstractLogger(WriteHandler write)
        {
            _write = write;
        }

        /// <summary>
        ///     Checks if this logger is enabled for the <see cref="LogLevel.Debug" /> level.
        /// </summary>
        /// <remarks>
        ///     Override this in your derived class to comply with the underlying logging system
        /// </remarks>
        public abstract bool IsDebugEnabled { get; }

        /// <summary>
        ///     Checks if this logger is enabled for the <see cref="LogLevel.Error" /> level.
        /// </summary>
        /// <remarks>
        ///     Override this in your derived class to comply with the underlying logging system
        /// </remarks>
        public abstract bool IsErrorEnabled { get; }

        /// <summary>
        ///     Checks if this logger is enabled for the <see cref="LogLevel.Fatal" /> level.
        /// </summary>
        /// <remarks>
        ///     Override this in your derived class to comply with the underlying logging system
        /// </remarks>
        public abstract bool IsFatalEnabled { get; }

        /// <summary>
        ///     Checks if this logger is enabled for the <see cref="LogLevel.Info" /> level.
        /// </summary>
        /// <remarks>
        ///     Override this in your derived class to comply with the underlying logging system
        /// </remarks>
        public abstract bool IsInfoEnabled { get; }

        /// <summary>
        ///     Checks if this logger is enabled for the <see cref="LogLevel.Trace" /> level.
        /// </summary>
        /// <remarks>
        ///     Override this in your derived class to comply with the underlying logging system
        /// </remarks>
        public abstract bool IsTraceEnabled { get; }

        /// <summary>
        ///     Checks if this logger is enabled for the <see cref="LogLevel.Warn" /> level.
        /// </summary>
        /// <remarks>
        ///     Override this in your derived class to comply with the underlying logging system
        /// </remarks>
        public abstract bool IsWarnEnabled { get; }

        /// <summary>
        ///     Log a message object with the <see cref="LogLevel.Trace" /> level.
        /// </summary>
        /// <param name="message">The message object to log.</param>
        public virtual void Trace(object message)
        {
            if (IsTraceEnabled)
                _write(LogLevel.Trace, message, null);
        }

        /// <summary>
        ///     Log a message with the <see cref="LogLevel.Trace" /> level using a callback to obtain the message
        /// </summary>
        /// <remarks>
        ///     Using this method avoids the cost of creating a message and evaluating message arguments
        ///     that probably won't be logged due to loglevel settings.
        /// </remarks>
        /// <param name="formatMessageCallback">A callback used by the logger to obtain the message if log level is matched</param>
        public virtual void Trace(Func<FormatMessageHandler, string> formatMessageCallback)
        {
            if (IsTraceEnabled)
                _write(LogLevel.Trace, new CallbackStringFormatter(formatMessageCallback), null);
        }

        /// <summary>
        ///     Log a message with the <see cref="LogLevel.Trace" /> level using a callback to obtain the message
        /// </summary>
        /// <remarks>
        ///     Using this method avoids the cost of creating a message and evaluating message arguments
        ///     that probably won't be logged due to loglevel settings.
        /// </remarks>
        /// <param name="formatProvider">An <see cref="IFormatProvider" /> that supplies culture-specific formatting information.</param>
        /// <param name="formatMessageCallback">A callback used by the logger to obtain the message if log level is matched</param>
        public virtual void Trace(IFormatProvider formatProvider,
            Func<FormatMessageHandler, string> formatMessageCallback)
        {
            if (IsTraceEnabled)
                _write(LogLevel.Trace, new CallbackStringFormatter(formatProvider, formatMessageCallback),
                    null);
        }

        /// <summary>
        ///     Log a message with the <see cref="LogLevel.Trace" /> level.
        /// </summary>
        /// <param name="formatProvider">An <see cref="IFormatProvider" /> that supplies culture-specific formatting information.</param>
        /// <param name="format">The format of the message object to log.<see cref="string.Format(string,object[])" /> </param>
        /// <param name="args"></param>
        public virtual void TraceFormat(IFormatProvider formatProvider, string format, params object[] args)
        {
            if (IsTraceEnabled)
                _write(LogLevel.Trace, new StringFormatter(formatProvider, format, args), null);
        }

        /// <summary>
        ///     Log a message with the <see cref="LogLevel.Trace" /> level.
        /// </summary>
        /// <param name="format">The format of the message object to log.<see cref="string.Format(string,object[])" /> </param>
        /// <param name="args">the list of format arguments</param>
        public virtual void TraceFormat(string format, params object[] args)
        {
            if (IsTraceEnabled)
                _write(LogLevel.Trace, new StringFormatter(null, format, args), null);
        }

        /// <summary>
        ///     Log a message object with the <see cref="LogLevel.Debug" /> level.
        /// </summary>
        /// <param name="message">The message object to log.</param>
        public virtual void Debug(object message)
        {
            if (IsDebugEnabled)
                _write(LogLevel.Debug, message, null);
        }

        /// <summary>
        ///     Log a message with the <see cref="LogLevel.Debug" /> level using a callback to obtain the message
        /// </summary>
        /// <remarks>
        ///     Using this method avoids the cost of creating a message and evaluating message arguments
        ///     that probably won't be logged due to loglevel settings.
        /// </remarks>
        /// <param name="formatMessageCallback">A callback used by the logger to obtain the message if log level is matched</param>
        public virtual void Debug(Func<FormatMessageHandler, string> formatMessageCallback)
        {
            if (IsDebugEnabled)
                _write(LogLevel.Debug, new CallbackStringFormatter(formatMessageCallback), null);
        }

        /// <summary>
        ///     Log a message with the <see cref="LogLevel.Debug" /> level using a callback to obtain the message
        /// </summary>
        /// <remarks>
        ///     Using this method avoids the cost of creating a message and evaluating message arguments
        ///     that probably won't be logged due to loglevel settings.
        /// </remarks>
        /// <param name="formatProvider">An <see cref="IFormatProvider" /> that supplies culture-specific formatting information.</param>
        /// <param name="formatMessageCallback">A callback used by the logger to obtain the message if log level is matched</param>
        public virtual void Debug(IFormatProvider formatProvider,
            Func<FormatMessageHandler, string> formatMessageCallback)
        {
            if (IsDebugEnabled)
                _write(LogLevel.Debug, new CallbackStringFormatter(formatProvider, formatMessageCallback),
                    null);
        }

        /// <summary>
        ///     Log a message with the <see cref="LogLevel.Debug" /> level.
        /// </summary>
        /// <param name="formatProvider">An <see cref="IFormatProvider" /> that supplies culture-specific formatting information.</param>
        /// <param name="format">The format of the message object to log.<see cref="string.Format(string,object[])" /> </param>
        /// <param name="args"></param>
        public virtual void DebugFormat(IFormatProvider formatProvider, string format, params object[] args)
        {
            if (IsDebugEnabled)
                _write(LogLevel.Debug, new StringFormatter(formatProvider, format, args), null);
        }

        /// <summary>
        ///     Log a message with the <see cref="LogLevel.Debug" /> level.
        /// </summary>
        /// <param name="format">The format of the message object to log.<see cref="string.Format(string,object[])" /> </param>
        /// <param name="args">the list of format arguments</param>
        public virtual void DebugFormat(string format, params object[] args)
        {
            if (IsDebugEnabled)
                _write(LogLevel.Debug, new StringFormatter(null, format, args), null);
        }

        /// <summary>
        ///     Log a message object with the <see cref="LogLevel.Info" /> level.
        /// </summary>
        /// <param name="message">The message object to log.</param>
        public virtual void Info(object message)
        {
            if (IsInfoEnabled)
                _write(LogLevel.Info, message, null);
        }

        /// <summary>
        ///     Log a message with the <see cref="LogLevel.Info" /> level using a callback to obtain the message
        /// </summary>
        /// <remarks>
        ///     Using this method avoids the cost of creating a message and evaluating message arguments
        ///     that probably won't be logged due to loglevel settings.
        /// </remarks>
        /// <param name="formatMessageCallback">A callback used by the logger to obtain the message if log level is matched</param>
        public virtual void Info(Func<FormatMessageHandler, string> formatMessageCallback)
        {
            if (IsInfoEnabled)
                _write(LogLevel.Info, new CallbackStringFormatter(formatMessageCallback), null);
        }

        /// <summary>
        ///     Log a message with the <see cref="LogLevel.Info" /> level using a callback to obtain the message
        /// </summary>
        /// <remarks>
        ///     Using this method avoids the cost of creating a message and evaluating message arguments
        ///     that probably won't be logged due to loglevel settings.
        /// </remarks>
        /// <param name="formatProvider">An <see cref="IFormatProvider" /> that supplies culture-specific formatting information.</param>
        /// <param name="formatMessageCallback">A callback used by the logger to obtain the message if log level is matched</param>
        public virtual void Info(IFormatProvider formatProvider,
            Func<FormatMessageHandler, string> formatMessageCallback)
        {
            if (IsInfoEnabled)
                _write(LogLevel.Info, new CallbackStringFormatter(formatProvider, formatMessageCallback),
                    null);
        }

        /// <summary>
        ///     Log a message with the <see cref="LogLevel.Info" /> level.
        /// </summary>
        /// <param name="formatProvider">An <see cref="IFormatProvider" /> that supplies culture-specific formatting information.</param>
        /// <param name="format">The format of the message object to log.<see cref="string.Format(string,object[])" /> </param>
        /// <param name="args"></param>
        public virtual void InfoFormat(IFormatProvider formatProvider, string format, params object[] args)
        {
            if (IsInfoEnabled)
                _write(LogLevel.Info, new StringFormatter(formatProvider, format, args), null);
        }

        /// <summary>
        ///     Log a message with the <see cref="LogLevel.Info" /> level.
        /// </summary>
        /// <param name="format">The format of the message object to log.<see cref="string.Format(string,object[])" /> </param>
        /// <param name="args">the list of format arguments</param>
        public virtual void InfoFormat(string format, params object[] args)
        {
            if (IsInfoEnabled)
                _write(LogLevel.Info, new StringFormatter(null, format, args), null);
        }

        /// <summary>
        ///     Log a message object with the <see cref="LogLevel.Warn" /> level.
        /// </summary>
        /// <param name="message">The message object to log.</param>
        public virtual void Warn(object message)
        {
            if (IsWarnEnabled)
                _write(LogLevel.Warn, message, null);
        }

        /// <summary>
        ///     Log a message with the <see cref="LogLevel.Warn" /> level using a callback to obtain the message
        /// </summary>
        /// <remarks>
        ///     Using this method avoids the cost of creating a message and evaluating message arguments
        ///     that probably won't be logged due to loglevel settings.
        /// </remarks>
        /// <param name="formatMessageCallback">A callback used by the logger to obtain the message if log level is matched</param>
        public virtual void Warn(Func<FormatMessageHandler, string> formatMessageCallback)
        {
            if (IsWarnEnabled)
                _write(LogLevel.Warn, new CallbackStringFormatter(formatMessageCallback), null);
        }

        /// <summary>
        ///     Log a message with the <see cref="LogLevel.Warn" /> level using a callback to obtain the message
        /// </summary>
        /// <remarks>
        ///     Using this method avoids the cost of creating a message and evaluating message arguments
        ///     that probably won't be logged due to loglevel settings.
        /// </remarks>
        /// <param name="formatProvider">An <see cref="IFormatProvider" /> that supplies culture-specific formatting information.</param>
        /// <param name="formatMessageCallback">A callback used by the logger to obtain the message if log level is matched</param>
        public virtual void Warn(IFormatProvider formatProvider,
            Func<FormatMessageHandler, string> formatMessageCallback)
        {
            if (IsWarnEnabled)
                _write(LogLevel.Warn, new CallbackStringFormatter(formatProvider, formatMessageCallback),
                    null);
        }

        /// <summary>
        ///     Log a message with the <see cref="LogLevel.Warn" /> level.
        /// </summary>
        /// <param name="formatProvider">An <see cref="IFormatProvider" /> that supplies culture-specific formatting Warnrmation.</param>
        /// <param name="format">The format of the message object to log.<see cref="string.Format(string,object[])" /> </param>
        /// <param name="args"></param>
        public virtual void WarnFormat(IFormatProvider formatProvider, string format, params object[] args)
        {
            if (IsWarnEnabled)
                _write(LogLevel.Warn, new StringFormatter(formatProvider, format, args), null);
        }

        /// <summary>
        ///     Log a message with the <see cref="LogLevel.Warn" /> level.
        /// </summary>
        /// <param name="format">The format of the message object to log.<see cref="string.Format(string,object[])" /> </param>
        /// <param name="args">the list of format arguments</param>
        public virtual void WarnFormat(string format, params object[] args)
        {
            if (IsWarnEnabled)
                _write(LogLevel.Warn, new StringFormatter(null, format, args), null);
        }

        /// <summary>
        ///     Log a message object with the <see cref="LogLevel.Error" /> level.
        /// </summary>
        /// <param name="message">The message object to log.</param>
        public virtual void Error(object message)
        {
            if (IsErrorEnabled)
                _write(LogLevel.Error, message, null);
        }

        /// <summary>
        ///     Log a message with the <see cref="LogLevel.Error" /> level using a callback to obtain the message
        /// </summary>
        /// <remarks>
        ///     Using this method avoids the cost of creating a message and evaluating message arguments
        ///     that probably won't be logged due to loglevel settings.
        /// </remarks>
        /// <param name="formatMessageCallback">A callback used by the logger to obtain the message if log level is matched</param>
        public virtual void Error(Func<FormatMessageHandler, string> formatMessageCallback)
        {
            if (IsErrorEnabled)
                _write(LogLevel.Error, new CallbackStringFormatter(formatMessageCallback), null);
        }

        /// <summary>
        ///     Log a message with the <see cref="LogLevel.Error" /> level using a callback to obtain the message
        /// </summary>
        /// <remarks>
        ///     Using this method avoids the cost of creating a message and evaluating message arguments
        ///     that probably won't be logged due to loglevel settings.
        /// </remarks>
        /// <param name="formatProvider">An <see cref="IFormatProvider" /> that supplies culture-specific formatting information.</param>
        /// <param name="formatMessageCallback">A callback used by the logger to obtain the message if log level is matched</param>
        public virtual void Error(IFormatProvider formatProvider,
            Func<FormatMessageHandler, string> formatMessageCallback)
        {
            if (IsErrorEnabled)
                _write(LogLevel.Error, new CallbackStringFormatter(formatProvider, formatMessageCallback),
                    null);
        }

        /// <summary>
        ///     Log a message with the <see cref="LogLevel.Error" /> level.
        /// </summary>
        /// <param name="formatProvider">An <see cref="IFormatProvider" /> that supplies culture-specific formatting Errorrmation.</param>
        /// <param name="format">The format of the message object to log.<see cref="string.Format(string,object[])" /> </param>
        /// <param name="args"></param>
        public virtual void ErrorFormat(IFormatProvider formatProvider, string format, params object[] args)
        {
            if (IsErrorEnabled)
                _write(LogLevel.Error, new StringFormatter(formatProvider, format, args), null);
        }

        /// <summary>
        ///     Log a message with the <see cref="LogLevel.Error" /> level.
        /// </summary>
        /// <param name="format">The format of the message object to log.<see cref="string.Format(string,object[])" /> </param>
        /// <param name="args">the list of format arguments</param>
        public virtual void ErrorFormat(string format, params object[] args)
        {
            if (IsErrorEnabled)
                _write(LogLevel.Error, new StringFormatter(null, format, args), null);
        }

        /// <summary>
        ///     Log a message object with the <see cref="LogLevel.Fatal" /> level.
        /// </summary>
        /// <param name="message">The message object to log.</param>
        public virtual void Fatal(object message)
        {
            if (IsFatalEnabled)
                _write(LogLevel.Fatal, message, null);
        }

        /// <summary>
        ///     Log a message with the <see cref="LogLevel.Fatal" /> level using a callback to obtain the message
        /// </summary>
        /// <remarks>
        ///     Using this method avoids the cost of creating a message and evaluating message arguments
        ///     that probably won't be logged due to loglevel settings.
        /// </remarks>
        /// <param name="formatMessageCallback">A callback used by the logger to obtain the message if log level is matched</param>
        public virtual void Fatal(Func<FormatMessageHandler, string> formatMessageCallback)
        {
            if (IsFatalEnabled)
                _write(LogLevel.Fatal, new CallbackStringFormatter(formatMessageCallback), null);
        }

        /// <summary>
        ///     Log a message with the <see cref="LogLevel.Fatal" /> level using a callback to obtain the message
        /// </summary>
        /// <remarks>
        ///     Using this method avoids the cost of creating a message and evaluating message arguments
        ///     that probably won't be logged due to loglevel settings.
        /// </remarks>
        /// <param name="formatProvider">An <see cref="IFormatProvider" /> that supplies culture-specific formatting information.</param>
        /// <param name="formatMessageCallback">A callback used by the logger to obtain the message if log level is matched</param>
        public virtual void Fatal(IFormatProvider formatProvider,
            Func<FormatMessageHandler, string> formatMessageCallback)
        {
            if (IsFatalEnabled)
                _write(LogLevel.Fatal, new CallbackStringFormatter(formatProvider, formatMessageCallback),
                    null);
        }

        /// <summary>
        ///     Log a message with the <see cref="LogLevel.Fatal" /> level.
        /// </summary>
        /// <param name="formatProvider">An <see cref="IFormatProvider" /> that supplies culture-specific formatting Fatalrmation.</param>
        /// <param name="format">The format of the message object to log.<see cref="string.Format(string,object[])" /> </param>
        /// <param name="args"></param>
        public virtual void FatalFormat(IFormatProvider formatProvider, string format, params object[] args)
        {
            if (IsFatalEnabled)
                _write(LogLevel.Fatal, new StringFormatter(formatProvider, format, args), null);
        }

        /// <summary>
        ///     Log a message with the <see cref="LogLevel.Fatal" /> level.
        /// </summary>
        /// <param name="format">The format of the message object to log.<see cref="string.Format(string,object[])" /> </param>
        /// <param name="args">the list of format arguments</param>
        public virtual void FatalFormat(string format, params object[] args)
        {
            if (IsFatalEnabled)
                _write(LogLevel.Fatal, new StringFormatter(null, format, args), null);
        }

        /// <summary>
        ///     Log a message object with the <see cref="LogLevel.Trace" /> level including
        ///     the stack trace of the <see cref="Exception" /> passed
        ///     as a parameter.
        /// </summary>
        /// <param name="message">The message object to log.</param>
        /// <param name="exception">The exception to log, including its stack trace.</param>
        public virtual void Trace(Exception exception, object message)
        {
            if (IsTraceEnabled)
                _write(LogLevel.Trace, message, exception);
        }

        /// <summary>
        ///     Log a message with the <see cref="LogLevel.Trace" /> level using a callback to obtain the message
        /// </summary>
        /// <remarks>
        ///     Using this method avoids the cost of creating a message and evaluating message arguments
        ///     that probably won't be logged due to loglevel settings.
        /// </remarks>
        /// <param name="formatMessageCallback">A callback used by the logger to obtain the message if log level is matched</param>
        /// <param name="exception">The exception to log, including its stack trace.</param>
        public virtual void Trace(Exception exception, Func<FormatMessageHandler, string> formatMessageCallback)
        {
            if (IsTraceEnabled)
                _write(LogLevel.Trace, new CallbackStringFormatter(formatMessageCallback), exception);
        }

        /// <summary>
        ///     Log a message with the <see cref="LogLevel.Trace" /> level using a callback to obtain the message
        /// </summary>
        /// <remarks>
        ///     Using this method avoids the cost of creating a message and evaluating message arguments
        ///     that probably won't be logged due to loglevel settings.
        /// </remarks>
        /// <param name="formatProvider">An <see cref="IFormatProvider" /> that supplies culture-specific formatting information.</param>
        /// <param name="formatMessageCallback">A callback used by the logger to obtain the message if log level is matched</param>
        /// <param name="exception">The exception to log, including its stack trace.</param>
        public virtual void Trace(Exception exception, IFormatProvider formatProvider,
            Func<FormatMessageHandler, string> formatMessageCallback)
        {
            if (IsTraceEnabled)
                _write(LogLevel.Trace, new CallbackStringFormatter(formatProvider, formatMessageCallback),
                    exception);
        }

        /// <summary>
        ///     Log a message with the <see cref="LogLevel.Trace" /> level.
        /// </summary>
        /// <param name="formatProvider">An <see cref="IFormatProvider" /> that supplies culture-specific formatting information.</param>
        /// <param name="format">The format of the message object to log.<see cref="string.Format(string,object[])" /> </param>
        /// <param name="exception">The exception to log.</param>
        /// <param name="args"></param>
        public virtual void TraceFormat(Exception exception, IFormatProvider formatProvider, string format,
            params object[] args)
        {
            if (IsTraceEnabled)
                _write(LogLevel.Trace, new StringFormatter(formatProvider, format, args), exception);
        }

        /// <summary>
        ///     Log a message with the <see cref="LogLevel.Trace" /> level.
        /// </summary>
        /// <param name="format">The format of the message object to log.<see cref="string.Format(string,object[])" /> </param>
        /// <param name="exception">The exception to log.</param>
        /// <param name="args">the list of format arguments</param>
        public virtual void TraceFormat(Exception exception, string format, params object[] args)
        {
            if (IsTraceEnabled)
                _write(LogLevel.Trace, new StringFormatter(null, format, args), exception);
        }

        /// <summary>
        ///     Log a message object with the <see cref="LogLevel.Debug" /> level including
        ///     the stack Debug of the <see cref="Exception" /> passed
        ///     as a parameter.
        /// </summary>
        /// <param name="message">The message object to log.</param>
        /// <param name="exception">The exception to log, including its stack Debug.</param>
        public virtual void Debug(Exception exception, object message)
        {
            if (IsDebugEnabled)
                _write(LogLevel.Debug, message, exception);
        }

        /// <summary>
        ///     Log a message with the <see cref="LogLevel.Debug" /> level using a callback to obtain the message
        /// </summary>
        /// <remarks>
        ///     Using this method avoids the cost of creating a message and evaluating message arguments
        ///     that probably won't be logged due to loglevel settings.
        /// </remarks>
        /// <param name="formatMessageCallback">A callback used by the logger to obtain the message if log level is matched</param>
        /// <param name="exception">The exception to log, including its stack Debug.</param>
        public virtual void Debug(Exception exception, Func<FormatMessageHandler, string> formatMessageCallback)
        {
            if (IsDebugEnabled)
                _write(LogLevel.Debug, new CallbackStringFormatter(formatMessageCallback), exception);
        }

        /// <summary>
        ///     Log a message with the <see cref="LogLevel.Debug" /> level using a callback to obtain the message
        /// </summary>
        /// <remarks>
        ///     Using this method avoids the cost of creating a message and evaluating message arguments
        ///     that probably won't be logged due to loglevel settings.
        /// </remarks>
        /// <param name="formatProvider">An <see cref="IFormatProvider" /> that supplies culture-specific formatting information.</param>
        /// <param name="formatMessageCallback">A callback used by the logger to obtain the message if log level is matched</param>
        /// <param name="exception">The exception to log, including its stack Debug.</param>
        public virtual void Debug(Exception exception, IFormatProvider formatProvider,
            Func<FormatMessageHandler, string> formatMessageCallback)
        {
            if (IsDebugEnabled)
                _write(LogLevel.Debug, new CallbackStringFormatter(formatProvider, formatMessageCallback),
                    exception);
        }

        /// <summary>
        ///     Log a message with the <see cref="LogLevel.Debug" /> level.
        /// </summary>
        /// <param name="formatProvider">An <see cref="IFormatProvider" /> that supplies culture-specific formatting information.</param>
        /// <param name="format">The format of the message object to log.<see cref="string.Format(string,object[])" /> </param>
        /// <param name="exception">The exception to log.</param>
        /// <param name="args"></param>
        public virtual void DebugFormat(Exception exception, IFormatProvider formatProvider, string format,
            params object[] args)
        {
            if (IsDebugEnabled)
                _write(LogLevel.Debug, new StringFormatter(formatProvider, format, args), exception);
        }

        /// <summary>
        ///     Log a message with the <see cref="LogLevel.Debug" /> level.
        /// </summary>
        /// <param name="format">The format of the message object to log.<see cref="string.Format(string,object[])" /> </param>
        /// <param name="exception">The exception to log.</param>
        /// <param name="args">the list of format arguments</param>
        public virtual void DebugFormat(Exception exception, string format, params object[] args)
        {
            if (IsDebugEnabled)
                _write(LogLevel.Debug, new StringFormatter(null, format, args), exception);
        }

        /// <summary>
        ///     Log a message object with the <see cref="LogLevel.Info" /> level including
        ///     the stack Info of the <see cref="Exception" /> passed
        ///     as a parameter.
        /// </summary>
        /// <param name="message">The message object to log.</param>
        /// <param name="exception">The exception to log, including its stack Info.</param>
        public virtual void Info(Exception exception, object message)
        {
            if (IsInfoEnabled)
                _write(LogLevel.Info, message, exception);
        }

        /// <summary>
        ///     Log a message with the <see cref="LogLevel.Info" /> level using a callback to obtain the message
        /// </summary>
        /// <remarks>
        ///     Using this method avoids the cost of creating a message and evaluating message arguments
        ///     that probably won't be logged due to loglevel settings.
        /// </remarks>
        /// <param name="formatMessageCallback">A callback used by the logger to obtain the message if log level is matched</param>
        /// <param name="exception">The exception to log, including its stack Info.</param>
        public virtual void Info(Exception exception, Func<FormatMessageHandler, string> formatMessageCallback)
        {
            if (IsInfoEnabled)
                _write(LogLevel.Info, new CallbackStringFormatter(formatMessageCallback), exception);
        }

        /// <summary>
        ///     Log a message with the <see cref="LogLevel.Info" /> level using a callback to obtain the message
        /// </summary>
        /// <remarks>
        ///     Using this method avoids the cost of creating a message and evaluating message arguments
        ///     that probably won't be logged due to loglevel settings.
        /// </remarks>
        /// <param name="formatProvider">An <see cref="IFormatProvider" /> that supplies culture-specific formatting information.</param>
        /// <param name="formatMessageCallback">A callback used by the logger to obtain the message if log level is matched</param>
        /// <param name="exception">The exception to log, including its stack Info.</param>
        public virtual void Info(Exception exception, IFormatProvider formatProvider,
            Func<FormatMessageHandler, string> formatMessageCallback)
        {
            if (IsInfoEnabled)
                _write(LogLevel.Info, new CallbackStringFormatter(formatProvider, formatMessageCallback),
                    exception);
        }

        /// <summary>
        ///     Log a message with the <see cref="LogLevel.Info" /> level.
        /// </summary>
        /// <param name="formatProvider">An <see cref="IFormatProvider" /> that supplies culture-specific formatting information.</param>
        /// <param name="format">The format of the message object to log.<see cref="string.Format(string,object[])" /> </param>
        /// <param name="exception">The exception to log.</param>
        /// <param name="args"></param>
        public virtual void InfoFormat(Exception exception, IFormatProvider formatProvider, string format,
            params object[] args)
        {
            if (IsInfoEnabled)
                _write(LogLevel.Info, new StringFormatter(formatProvider, format, args), exception);
        }

        /// <summary>
        ///     Log a message with the <see cref="LogLevel.Info" /> level.
        /// </summary>
        /// <param name="format">The format of the message object to log.<see cref="string.Format(string,object[])" /> </param>
        /// <param name="exception">The exception to log.</param>
        /// <param name="args">the list of format arguments</param>
        public virtual void InfoFormat(Exception exception, string format, params object[] args)
        {
            if (IsInfoEnabled)
                _write(LogLevel.Info, new StringFormatter(null, format, args), exception);
        }

        /// <summary>
        ///     Log a message object with the <see cref="LogLevel.Warn" /> level including
        ///     the stack Warn of the <see cref="Exception" /> passed
        ///     as a parameter.
        /// </summary>
        /// <param name="message">The message object to log.</param>
        /// <param name="exception">The exception to log, including its stack Warn.</param>
        public virtual void Warn(Exception exception, object message)
        {
            if (IsWarnEnabled)
                _write(LogLevel.Warn, message, exception);
        }

        /// <summary>
        ///     Log a message with the <see cref="LogLevel.Warn" /> level using a callback to obtain the message
        /// </summary>
        /// <remarks>
        ///     Using this method avoids the cost of creating a message and evaluating message arguments
        ///     that probably won't be logged due to loglevel settings.
        /// </remarks>
        /// <param name="formatMessageCallback">A callback used by the logger to obtain the message if log level is matched</param>
        /// <param name="exception">The exception to log, including its stack Warn.</param>
        public virtual void Warn(Exception exception, Func<FormatMessageHandler, string> formatMessageCallback)
        {
            if (IsWarnEnabled)
                _write(LogLevel.Warn, new CallbackStringFormatter(formatMessageCallback), exception);
        }

        /// <summary>
        ///     Log a message with the <see cref="LogLevel.Warn" /> level using a callback to obtain the message
        /// </summary>
        /// <remarks>
        ///     Using this method avoids the cost of creating a message and evaluating message arguments
        ///     that probably won't be logged due to loglevel settings.
        /// </remarks>
        /// <param name="formatProvider">An <see cref="IFormatProvider" /> that supplies culture-specific formatting information.</param>
        /// <param name="formatMessageCallback">A callback used by the logger to obtain the message if log level is matched</param>
        /// <param name="exception">The exception to log, including its stack Warn.</param>
        public virtual void Warn(Exception exception, IFormatProvider formatProvider,
            Func<FormatMessageHandler, string> formatMessageCallback)
        {
            if (IsWarnEnabled)
                _write(LogLevel.Warn, new CallbackStringFormatter(formatProvider, formatMessageCallback),
                    exception);
        }

        /// <summary>
        ///     Log a message with the <see cref="LogLevel.Warn" /> level.
        /// </summary>
        /// <param name="formatProvider">An <see cref="IFormatProvider" /> that supplies culture-specific formatting Warnrmation.</param>
        /// <param name="format">The format of the message object to log.<see cref="string.Format(string,object[])" /> </param>
        /// <param name="exception">The exception to log.</param>
        /// <param name="args"></param>
        public virtual void WarnFormat(Exception exception, IFormatProvider formatProvider, string format,
            params object[] args)
        {
            if (IsWarnEnabled)
                _write(LogLevel.Warn, new StringFormatter(formatProvider, format, args), exception);
        }

        /// <summary>
        ///     Log a message with the <see cref="LogLevel.Warn" /> level.
        /// </summary>
        /// <param name="format">The format of the message object to log.<see cref="string.Format(string,object[])" /> </param>
        /// <param name="exception">The exception to log.</param>
        /// <param name="args">the list of format arguments</param>
        public virtual void WarnFormat(Exception exception, string format, params object[] args)
        {
            if (IsWarnEnabled)
                _write(LogLevel.Warn, new StringFormatter(null, format, args), exception);
        }

        /// <summary>
        ///     Log a message object with the <see cref="LogLevel.Error" /> level including
        ///     the stack Error of the <see cref="Exception" /> passed
        ///     as a parameter.
        /// </summary>
        /// <param name="message">The message object to log.</param>
        /// <param name="exception">The exception to log, including its stack Error.</param>
        public virtual void Error(Exception exception, object message)
        {
            if (IsErrorEnabled)
                _write(LogLevel.Error, message, exception);
        }

        /// <summary>
        ///     Log a message with the <see cref="LogLevel.Error" /> level using a callback to obtain the message
        /// </summary>
        /// <remarks>
        ///     Using this method avoids the cost of creating a message and evaluating message arguments
        ///     that probably won't be logged due to loglevel settings.
        /// </remarks>
        /// <param name="formatMessageCallback">A callback used by the logger to obtain the message if log level is matched</param>
        /// <param name="exception">The exception to log, including its stack Error.</param>
        public virtual void Error(Exception exception, Func<FormatMessageHandler, string> formatMessageCallback)
        {
            if (IsErrorEnabled)
                _write(LogLevel.Error, new CallbackStringFormatter(formatMessageCallback), exception);
        }

        /// <summary>
        ///     Log a message with the <see cref="LogLevel.Error" /> level using a callback to obtain the message
        /// </summary>
        /// <remarks>
        ///     Using this method avoids the cost of creating a message and evaluating message arguments
        ///     that probably won't be logged due to loglevel settings.
        /// </remarks>
        /// <param name="formatProvider">An <see cref="IFormatProvider" /> that supplies culture-specific formatting information.</param>
        /// <param name="formatMessageCallback">A callback used by the logger to obtain the message if log level is matched</param>
        /// <param name="exception">The exception to log, including its stack Error.</param>
        public virtual void Error(Exception exception, IFormatProvider formatProvider,
            Func<FormatMessageHandler, string> formatMessageCallback)
        {
            if (IsErrorEnabled)
                _write(LogLevel.Error, new CallbackStringFormatter(formatProvider, formatMessageCallback),
                    exception);
        }

        /// <summary>
        ///     Log a message with the <see cref="LogLevel.Error" /> level.
        /// </summary>
        /// <param name="formatProvider">An <see cref="IFormatProvider" /> that supplies culture-specific formatting Errorrmation.</param>
        /// <param name="format">The format of the message object to log.<see cref="string.Format(string,object[])" /> </param>
        /// <param name="exception">The exception to log.</param>
        /// <param name="args"></param>
        public virtual void ErrorFormat(Exception exception, IFormatProvider formatProvider, string format,
            params object[] args)
        {
            if (IsErrorEnabled)
                _write(LogLevel.Error, new StringFormatter(formatProvider, format, args), exception);
        }

        /// <summary>
        ///     Log a message with the <see cref="LogLevel.Error" /> level.
        /// </summary>
        /// <param name="format">The format of the message object to log.<see cref="string.Format(string,object[])" /> </param>
        /// <param name="exception">The exception to log.</param>
        /// <param name="args">the list of format arguments</param>
        public virtual void ErrorFormat(Exception exception, string format, params object[] args)
        {
            if (IsErrorEnabled)
                _write(LogLevel.Error, new StringFormatter(null, format, args), exception);
        }

        /// <summary>
        ///     Log a message object with the <see cref="LogLevel.Fatal" /> level including
        ///     the stack Fatal of the <see cref="Exception" /> passed
        ///     as a parameter.
        /// </summary>
        /// <param name="message">The message object to log.</param>
        /// <param name="exception">The exception to log, including its stack Fatal.</param>
        public virtual void Fatal(Exception exception, object message)
        {
            if (IsFatalEnabled)
                _write(LogLevel.Fatal, message, exception);
        }

        /// <summary>
        ///     Log a message with the <see cref="LogLevel.Fatal" /> level using a callback to obtain the message
        /// </summary>
        /// <remarks>
        ///     Using this method avoids the cost of creating a message and evaluating message arguments
        ///     that probably won't be logged due to loglevel settings.
        /// </remarks>
        /// <param name="formatMessageCallback">A callback used by the logger to obtain the message if log level is matched</param>
        /// <param name="exception">The exception to log, including its stack Fatal.</param>
        public virtual void Fatal(Exception exception, Func<FormatMessageHandler, string> formatMessageCallback)
        {
            if (IsFatalEnabled)
                _write(LogLevel.Fatal, new CallbackStringFormatter(formatMessageCallback), exception);
        }

        /// <summary>
        ///     Log a message with the <see cref="LogLevel.Fatal" /> level using a callback to obtain the message
        /// </summary>
        /// <remarks>
        ///     Using this method avoids the cost of creating a message and evaluating message arguments
        ///     that probably won't be logged due to loglevel settings.
        /// </remarks>
        /// <param name="formatProvider">An <see cref="IFormatProvider" /> that supplies culture-specific formatting information.</param>
        /// <param name="formatMessageCallback">A callback used by the logger to obtain the message if log level is matched</param>
        /// <param name="exception">The exception to log, including its stack Fatal.</param>
        public virtual void Fatal(Exception exception, IFormatProvider formatProvider,
            Func<FormatMessageHandler, string> formatMessageCallback)
        {
            if (IsFatalEnabled)
                _write(LogLevel.Fatal, new CallbackStringFormatter(formatProvider, formatMessageCallback),
                    exception);
        }

        /// <summary>
        ///     Log a message with the <see cref="LogLevel.Fatal" /> level.
        /// </summary>
        /// <param name="formatProvider">An <see cref="IFormatProvider" /> that supplies culture-specific formatting Fatalrmation.</param>
        /// <param name="format">The format of the message object to log.<see cref="string.Format(string,object[])" /> </param>
        /// <param name="exception">The exception to log.</param>
        /// <param name="args"></param>
        public virtual void FatalFormat(Exception exception, IFormatProvider formatProvider, string format,
            params object[] args)
        {
            if (IsFatalEnabled)
                _write(LogLevel.Fatal, new StringFormatter(formatProvider, format, args), exception);
        }

        /// <summary>
        ///     Log a message with the <see cref="LogLevel.Fatal" /> level.
        /// </summary>
        /// <param name="format">The format of the message object to log.<see cref="string.Format(string,object[])" /> </param>
        /// <param name="exception">The exception to log.</param>
        /// <param name="args">the list of format arguments</param>
        public virtual void FatalFormat(Exception exception, string format, params object[] args)
        {
            if (IsFatalEnabled)
                _write(LogLevel.Fatal, new StringFormatter(null, format, args), exception);
        }

        /// <summary>
        ///     Actually sends the message to the underlying log system.
        /// </summary>
        /// <param name="level">the level of this log event.</param>
        /// <param name="message">the message to log</param>
        /// <param name="exception">the exception to log (may be null)</param>
        protected abstract void WriteInternal(LogLevel level, object message, Exception exception);

        /// <summary>
        ///     Represents a method responsible for writing a message to the log system.
        /// </summary>
        protected delegate void WriteHandler(LogLevel level, object message, Exception exception);
    }
}