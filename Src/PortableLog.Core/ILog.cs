using System;

namespace PortableLog.Core
{
    /// <summary>
    ///     A simple logging interface abstracting logging APIs.
    /// </summary>
    public interface ILog
    {
        /// <summary>
        ///     Checks if this logger is enabled for the <see cref="F:LogLevel.Debug" /> level.
        /// </summary>
        bool IsDebugEnabled { get; }

        /// <summary>
        ///     Checks if this logger is enabled for the <see cref="F:LogLevel.Error" /> level.
        /// </summary>
        bool IsErrorEnabled { get; }

        /// <summary>
        ///     Checks if this logger is enabled for the <see cref="F:LogLevel.Fatal" /> level.
        /// </summary>
        bool IsFatalEnabled { get; }

        /// <summary>
        ///     Checks if this logger is enabled for the <see cref="F:LogLevel.Info" /> level.
        /// </summary>
        bool IsInfoEnabled { get; }

        /// <summary>
        ///     Checks if this logger is enabled for the <see cref="F:LogLevel.Trace" /> level.
        /// </summary>
        bool IsTraceEnabled { get; }

        /// <summary>
        ///     Checks if this logger is enabled for the <see cref="F:LogLevel.Warn" /> level.
        /// </summary>
        bool IsWarnEnabled { get; }

        /// <summary>
        ///     Log a message object with the <see cref="F:LogLevel.Debug" /> level.
        /// </summary>
        /// <param name="message">The message object to log.</param>
        void Debug(object message);

        /// <summary>
        ///     Log a message object with the <see cref="F:LogLevel.Debug" /> level including
        ///     the stack trace of the <see cref="T:System.Exception" /> passed
        ///     as a parameter.
        /// </summary>
        /// <param name="message">The message object to log.</param>
        /// <param name="exception">The exception to log, including its stack trace.</param>
        void Debug(Exception exception, object message);

        /// <summary>
        ///     Log a message with the <see cref="F:LogLevel.Debug" /> level using a callback to obtain the message
        /// </summary>
        /// <remarks>
        ///     Using this method avoids the cost of creating a message and evaluating message arguments
        ///     that probably won't be logged due to loglevel settings.
        /// </remarks>
        /// <param name="formatMessageCallback">A callback used by the logger to obtain the message if log level is matched</param>
        void Debug(Func<FormatMessageHandler, string> formatMessageCallback);

        /// <summary>
        ///     Log a message with the <see cref="F:LogLevel.Debug" /> level using a callback to obtain the message
        /// </summary>
        /// <remarks>
        ///     Using this method avoids the cost of creating a message and evaluating message arguments
        ///     that probably won't be logged due to loglevel settings.
        /// </remarks>
        /// <param name="formatMessageCallback">A callback used by the logger to obtain the message if log level is matched</param>
        /// <param name="exception">The exception to log, including its stack trace.</param>
        void Debug(Exception exception, Func<FormatMessageHandler, string> formatMessageCallback);

        /// <summary>
        ///     Log a message with the <see cref="F:LogLevel.Debug" /> level using a callback to obtain the message
        /// </summary>
        /// <remarks>
        ///     Using this method avoids the cost of creating a message and evaluating message arguments
        ///     that probably won't be logged due to loglevel settings.
        /// </remarks>
        /// <param name="formatProvider">
        ///     An <see cref="T:System.IFormatProvider" /> that supplies culture-specific formatting
        ///     information.
        /// </param>
        /// <param name="formatMessageCallback">A callback used by the logger to obtain the message if log level is matched</param>
        void Debug(IFormatProvider formatProvider, Func<FormatMessageHandler, string> formatMessageCallback);

        /// <summary>
        ///     Log a message with the <see cref="F:LogLevel.Debug" /> level using a callback to obtain the message
        /// </summary>
        /// <remarks>
        ///     Using this method avoids the cost of creating a message and evaluating message arguments
        ///     that probably won't be logged due to loglevel settings.
        /// </remarks>
        /// <param name="formatProvider">
        ///     An <see cref="T:System.IFormatProvider" /> that supplies culture-specific formatting
        ///     information.
        /// </param>
        /// <param name="formatMessageCallback">A callback used by the logger to obtain the message if log level is matched</param>
        /// <param name="exception">The exception to log, including its stack Debug.</param>
        void Debug(Exception exception, IFormatProvider formatProvider,
            Func<FormatMessageHandler, string> formatMessageCallback);

        /// <summary>
        ///     Log a message with the <see cref="F:LogLevel.Debug" /> level.
        /// </summary>
        /// <param name="format">
        ///     The format of the message object to log.
        ///     <see cref="M:System.String.Format(System.String,System.Object[])" />
        /// </param>
        /// <param name="args">the list of format arguments</param>
        void DebugFormat(string format, params object[] args);

        /// <summary>
        ///     Log a message with the <see cref="F:LogLevel.Debug" /> level.
        /// </summary>
        /// <param name="format">
        ///     The format of the message object to log.
        ///     <see cref="M:System.String.Format(System.String,System.Object[])" />
        /// </param>
        /// <param name="exception">The exception to log.</param>
        /// <param name="args">the list of format arguments</param>
        void DebugFormat(Exception exception, string format, params object[] args);

        /// <summary>
        ///     Log a message with the <see cref="F:LogLevel.Debug" /> level.
        /// </summary>
        /// <param name="formatProvider">
        ///     An <see cref="T:System.IFormatProvider" /> that supplies culture-specific formatting
        ///     information.
        /// </param>
        /// <param name="format">
        ///     The format of the message object to log.
        ///     <see cref="M:System.String.Format(System.String,System.Object[])" />
        /// </param>
        /// <param name="args" />
        void DebugFormat(IFormatProvider formatProvider, string format, params object[] args);

        /// <summary>
        ///     Log a message with the <see cref="F:LogLevel.Debug" /> level.
        /// </summary>
        /// <param name="formatProvider">
        ///     An <see cref="T:System.IFormatProvider" /> that supplies culture-specific formatting
        ///     information.
        /// </param>
        /// <param name="format">
        ///     The format of the message object to log.
        ///     <see cref="M:System.String.Format(System.String,System.Object[])" />
        /// </param>
        /// <param name="exception">The exception to log.</param>
        /// <param name="args" />
        void DebugFormat(Exception exception, IFormatProvider formatProvider, string format, params object[] args);

        /// <summary>
        ///     Log a message object with the <see cref="F:LogLevel.Error" /> level.
        /// </summary>
        /// <param name="message">The message object to log.</param>
        void Error(object message);

        /// <summary>
        ///     Log a message object with the <see cref="F:LogLevel.Error" /> level including
        ///     the stack trace of the <see cref="T:System.Exception" /> passed
        ///     as a parameter.
        /// </summary>
        /// <param name="message">The message object to log.</param>
        /// <param name="exception">The exception to log, including its stack trace.</param>
        void Error(Exception exception, object message);

        /// <summary>
        ///     Log a message with the <see cref="F:LogLevel.Error" /> level using a callback to obtain the message
        /// </summary>
        /// <remarks>
        ///     Using this method avoids the cost of creating a message and evaluating message arguments
        ///     that probably won't be logged due to loglevel settings.
        /// </remarks>
        /// <param name="formatMessageCallback">A callback used by the logger to obtain the message if log level is matched</param>
        void Error(Func<FormatMessageHandler, string> formatMessageCallback);

        /// <summary>
        ///     Log a message with the <see cref="F:LogLevel.Error" /> level using a callback to obtain the message
        /// </summary>
        /// <remarks>
        ///     Using this method avoids the cost of creating a message and evaluating message arguments
        ///     that probably won't be logged due to loglevel settings.
        /// </remarks>
        /// <param name="formatMessageCallback">A callback used by the logger to obtain the message if log level is matched</param>
        /// <param name="exception">The exception to log, including its stack trace.</param>
        void Error(Exception exception, Func<FormatMessageHandler, string> formatMessageCallback);

        /// <summary>
        ///     Log a message with the <see cref="F:LogLevel.Error" /> level using a callback to obtain the message
        /// </summary>
        /// <remarks>
        ///     Using this method avoids the cost of creating a message and evaluating message arguments
        ///     that probably won't be logged due to loglevel settings.
        /// </remarks>
        /// <param name="formatProvider">
        ///     An <see cref="T:System.IFormatProvider" /> that supplies culture-specific formatting
        ///     information.
        /// </param>
        /// <param name="formatMessageCallback">A callback used by the logger to obtain the message if log level is matched</param>
        void Error(IFormatProvider formatProvider, Func<FormatMessageHandler, string> formatMessageCallback);

        /// <summary>
        ///     Log a message with the <see cref="F:LogLevel.Error" /> level using a callback to obtain the message
        /// </summary>
        /// <remarks>
        ///     Using this method avoids the cost of creating a message and evaluating message arguments
        ///     that probably won't be logged due to loglevel settings.
        /// </remarks>
        /// <param name="formatProvider">
        ///     An <see cref="T:System.IFormatProvider" /> that supplies culture-specific formatting
        ///     information.
        /// </param>
        /// <param name="formatMessageCallback">A callback used by the logger to obtain the message if log level is matched</param>
        /// <param name="exception">The exception to log, including its stack Error.</param>
        void Error(Exception exception, IFormatProvider formatProvider,
            Func<FormatMessageHandler, string> formatMessageCallback);

        /// <summary>
        ///     Log a message with the <see cref="F:LogLevel.Error" /> level.
        /// </summary>
        /// <param name="format">
        ///     The format of the message object to log.
        ///     <see cref="M:System.String.Format(System.String,System.Object[])" />
        /// </param>
        /// <param name="args">the list of format arguments</param>
        void ErrorFormat(string format, params object[] args);

        /// <summary>
        ///     Log a message with the <see cref="F:LogLevel.Error" /> level.
        /// </summary>
        /// <param name="format">
        ///     The format of the message object to log.
        ///     <see cref="M:System.String.Format(System.String,System.Object[])" />
        /// </param>
        /// <param name="exception">The exception to log.</param>
        /// <param name="args">the list of format arguments</param>
        void ErrorFormat(Exception exception, string format, params object[] args);

        /// <summary>
        ///     Log a message with the <see cref="F:LogLevel.Error" /> level.
        /// </summary>
        /// <param name="formatProvider">
        ///     An <see cref="T:System.IFormatProvider" /> that supplies culture-specific formatting
        ///     information.
        /// </param>
        /// <param name="format">
        ///     The format of the message object to log.
        ///     <see cref="M:System.String.Format(System.String,System.Object[])" />
        /// </param>
        /// <param name="args" />
        void ErrorFormat(IFormatProvider formatProvider, string format, params object[] args);

        /// <summary>
        ///     Log a message with the <see cref="F:LogLevel.Error" /> level.
        /// </summary>
        /// <param name="formatProvider">
        ///     An <see cref="T:System.IFormatProvider" /> that supplies culture-specific formatting
        ///     information.
        /// </param>
        /// <param name="format">
        ///     The format of the message object to log.
        ///     <see cref="M:System.String.Format(System.String,System.Object[])" />
        /// </param>
        /// <param name="exception">The exception to log.</param>
        /// <param name="args" />
        void ErrorFormat(Exception exception, IFormatProvider formatProvider, string format, params object[] args);

        /// <summary>
        ///     Log a message object with the <see cref="F:LogLevel.Fatal" /> level.
        /// </summary>
        /// <param name="message">The message object to log.</param>
        void Fatal(object message);

        /// <summary>
        ///     Log a message object with the <see cref="F:LogLevel.Fatal" /> level including
        ///     the stack trace of the <see cref="T:System.Exception" /> passed
        ///     as a parameter.
        /// </summary>
        /// <param name="message">The message object to log.</param>
        /// <param name="exception">The exception to log, including its stack trace.</param>
        void Fatal(Exception exception, object message);

        /// <summary>
        ///     Log a message with the <see cref="F:LogLevel.Fatal" /> level using a callback to obtain the message
        /// </summary>
        /// <remarks>
        ///     Using this method avoids the cost of creating a message and evaluating message arguments
        ///     that probably won't be logged due to loglevel settings.
        /// </remarks>
        /// <param name="formatMessageCallback">A callback used by the logger to obtain the message if log level is matched</param>
        void Fatal(Func<FormatMessageHandler, string> formatMessageCallback);

        /// <summary>
        ///     Log a message with the <see cref="F:LogLevel.Fatal" /> level using a callback to obtain the message
        /// </summary>
        /// <remarks>
        ///     Using this method avoids the cost of creating a message and evaluating message arguments
        ///     that probably won't be logged due to loglevel settings.
        /// </remarks>
        /// <param name="formatMessageCallback">A callback used by the logger to obtain the message if log level is matched</param>
        /// <param name="exception">The exception to log, including its stack trace.</param>
        void Fatal(Exception exception, Func<FormatMessageHandler, string> formatMessageCallback);

        /// <summary>
        ///     Log a message with the <see cref="F:LogLevel.Fatal" /> level using a callback to obtain the message
        /// </summary>
        /// <remarks>
        ///     Using this method avoids the cost of creating a message and evaluating message arguments
        ///     that probably won't be logged due to loglevel settings.
        /// </remarks>
        /// <param name="formatProvider">
        ///     An <see cref="T:System.IFormatProvider" /> that supplies culture-specific formatting
        ///     information.
        /// </param>
        /// <param name="formatMessageCallback">A callback used by the logger to obtain the message if log level is matched</param>
        void Fatal(IFormatProvider formatProvider, Func<FormatMessageHandler, string> formatMessageCallback);

        /// <summary>
        ///     Log a message with the <see cref="F:LogLevel.Fatal" /> level using a callback to obtain the message
        /// </summary>
        /// <remarks>
        ///     Using this method avoids the cost of creating a message and evaluating message arguments
        ///     that probably won't be logged due to loglevel settings.
        /// </remarks>
        /// <param name="formatProvider">
        ///     An <see cref="T:System.IFormatProvider" /> that supplies culture-specific formatting
        ///     information.
        /// </param>
        /// <param name="formatMessageCallback">A callback used by the logger to obtain the message if log level is matched</param>
        /// <param name="exception">The exception to log, including its stack Fatal.</param>
        void Fatal(Exception exception, IFormatProvider formatProvider,
            Func<FormatMessageHandler, string> formatMessageCallback);

        /// <summary>
        ///     Log a message with the <see cref="F:LogLevel.Fatal" /> level.
        /// </summary>
        /// <param name="format">
        ///     The format of the message object to log.
        ///     <see cref="M:System.String.Format(System.String,System.Object[])" />
        /// </param>
        /// <param name="args">the list of format arguments</param>
        void FatalFormat(string format, params object[] args);

        /// <summary>
        ///     Log a message with the <see cref="F:LogLevel.Fatal" /> level.
        /// </summary>
        /// <param name="format">
        ///     The format of the message object to log.
        ///     <see cref="M:System.String.Format(System.String,System.Object[])" />
        /// </param>
        /// <param name="exception">The exception to log.</param>
        /// <param name="args">the list of format arguments</param>
        void FatalFormat(Exception exception, string format, params object[] args);

        /// <summary>
        ///     Log a message with the <see cref="F:LogLevel.Fatal" /> level.
        /// </summary>
        /// <param name="formatProvider">
        ///     An <see cref="T:System.IFormatProvider" /> that supplies culture-specific formatting
        ///     information.
        /// </param>
        /// <param name="format">
        ///     The format of the message object to log.
        ///     <see cref="M:System.String.Format(System.String,System.Object[])" />
        /// </param>
        /// <param name="args" />
        void FatalFormat(IFormatProvider formatProvider, string format, params object[] args);

        /// <summary>
        ///     Log a message with the <see cref="F:LogLevel.Fatal" /> level.
        /// </summary>
        /// <param name="formatProvider">
        ///     An <see cref="T:System.IFormatProvider" /> that supplies culture-specific formatting
        ///     information.
        /// </param>
        /// <param name="format">
        ///     The format of the message object to log.
        ///     <see cref="M:System.String.Format(System.String,System.Object[])" />
        /// </param>
        /// <param name="exception">The exception to log.</param>
        /// <param name="args" />
        void FatalFormat(Exception exception, IFormatProvider formatProvider, string format, params object[] args);

        /// <summary>
        ///     Log a message object with the <see cref="F:LogLevel.Info" /> level.
        /// </summary>
        /// <param name="message">The message object to log.</param>
        void Info(object message);

        /// <summary>
        ///     Log a message object with the <see cref="F:LogLevel.Info" /> level including
        ///     the stack trace of the <see cref="T:System.Exception" /> passed
        ///     as a parameter.
        /// </summary>
        /// <param name="message">The message object to log.</param>
        /// <param name="exception">The exception to log, including its stack trace.</param>
        void Info(Exception exception, object message);

        /// <summary>
        ///     Log a message with the <see cref="F:LogLevel.Info" /> level using a callback to obtain the message
        /// </summary>
        /// <remarks>
        ///     Using this method avoids the cost of creating a message and evaluating message arguments
        ///     that probably won't be logged due to loglevel settings.
        /// </remarks>
        /// <param name="formatMessageCallback">A callback used by the logger to obtain the message if log level is matched</param>
        void Info(Func<FormatMessageHandler, string> formatMessageCallback);

        /// <summary>
        ///     Log a message with the <see cref="F:LogLevel.Info" /> level using a callback to obtain the message
        /// </summary>
        /// <remarks>
        ///     Using this method avoids the cost of creating a message and evaluating message arguments
        ///     that probably won't be logged due to loglevel settings.
        /// </remarks>
        /// <param name="formatMessageCallback">A callback used by the logger to obtain the message if log level is matched</param>
        /// <param name="exception">The exception to log, including its stack trace.</param>
        void Info(Exception exception, Func<FormatMessageHandler, string> formatMessageCallback);

        /// <summary>
        ///     Log a message with the <see cref="F:LogLevel.Info" /> level using a callback to obtain the message
        /// </summary>
        /// <remarks>
        ///     Using this method avoids the cost of creating a message and evaluating message arguments
        ///     that probably won't be logged due to loglevel settings.
        /// </remarks>
        /// <param name="formatProvider">
        ///     An <see cref="T:System.IFormatProvider" /> that supplies culture-specific formatting
        ///     information.
        /// </param>
        /// <param name="formatMessageCallback">A callback used by the logger to obtain the message if log level is matched</param>
        void Info(IFormatProvider formatProvider, Func<FormatMessageHandler, string> formatMessageCallback);

        /// <summary>
        ///     Log a message with the <see cref="F:LogLevel.Info" /> level using a callback to obtain the message
        /// </summary>
        /// <remarks>
        ///     Using this method avoids the cost of creating a message and evaluating message arguments
        ///     that probably won't be logged due to loglevel settings.
        /// </remarks>
        /// <param name="formatProvider">
        ///     An <see cref="T:System.IFormatProvider" /> that supplies culture-specific formatting
        ///     information.
        /// </param>
        /// <param name="formatMessageCallback">A callback used by the logger to obtain the message if log level is matched</param>
        /// <param name="exception">The exception to log, including its stack Info.</param>
        void Info(Exception exception, IFormatProvider formatProvider,
            Func<FormatMessageHandler, string> formatMessageCallback);

        /// <summary>
        ///     Log a message with the <see cref="F:LogLevel.Info" /> level.
        /// </summary>
        /// <param name="format">
        ///     The format of the message object to log.
        ///     <see cref="M:System.String.Format(System.String,System.Object[])" />
        /// </param>
        /// <param name="args">the list of format arguments</param>
        void InfoFormat(string format, params object[] args);

        /// <summary>
        ///     Log a message with the <see cref="F:LogLevel.Info" /> level.
        /// </summary>
        /// <param name="format">
        ///     The format of the message object to log.
        ///     <see cref="M:System.String.Format(System.String,System.Object[])" />
        /// </param>
        /// <param name="exception">The exception to log.</param>
        /// <param name="args">the list of format arguments</param>
        void InfoFormat(Exception exception, string format, params object[] args);

        /// <summary>
        ///     Log a message with the <see cref="F:LogLevel.Info" /> level.
        /// </summary>
        /// <param name="formatProvider">
        ///     An <see cref="T:System.IFormatProvider" /> that supplies culture-specific formatting
        ///     information.
        /// </param>
        /// <param name="format">
        ///     The format of the message object to log.
        ///     <see cref="M:System.String.Format(System.String,System.Object[])" />
        /// </param>
        /// <param name="args" />
        void InfoFormat(IFormatProvider formatProvider, string format, params object[] args);

        /// <summary>
        ///     Log a message with the <see cref="F:LogLevel.Info" /> level.
        /// </summary>
        /// <param name="formatProvider">
        ///     An <see cref="T:System.IFormatProvider" /> that supplies culture-specific formatting
        ///     information.
        /// </param>
        /// <param name="format">
        ///     The format of the message object to log.
        ///     <see cref="M:System.String.Format(System.String,System.Object[])" />
        /// </param>
        /// <param name="exception">The exception to log.</param>
        /// <param name="args" />
        void InfoFormat(Exception exception, IFormatProvider formatProvider, string format, params object[] args);

        /// <summary>
        ///     Log a message object with the <see cref="F:LogLevel.Trace" /> level.
        /// </summary>
        /// <param name="message">The message object to log.</param>
        void Trace(object message);

        /// <summary>
        ///     Log a message object with the <see cref="F:LogLevel.Trace" /> level including
        ///     the stack trace of the <see cref="T:System.Exception" /> passed
        ///     as a parameter.
        /// </summary>
        /// <param name="message">The message object to log.</param>
        /// <param name="exception">The exception to log, including its stack trace.</param>
        void Trace(Exception exception, object message);

        /// <summary>
        ///     Log a message with the <see cref="F:LogLevel.Trace" /> level using a callback to obtain the message
        /// </summary>
        /// <remarks>
        ///     Using this method avoids the cost of creating a message and evaluating message arguments
        ///     that probably won't be logged due to loglevel settings.
        /// </remarks>
        /// <param name="formatMessageCallback">A callback used by the logger to obtain the message if log level is matched</param>
        void Trace(Func<FormatMessageHandler, string> formatMessageCallback);

        /// <summary>
        ///     Log a message with the <see cref="F:LogLevel.Trace" /> level using a callback to obtain the message
        /// </summary>
        /// <remarks>
        ///     Using this method avoids the cost of creating a message and evaluating message arguments
        ///     that probably won't be logged due to loglevel settings.
        /// </remarks>
        /// <param name="formatMessageCallback">A callback used by the logger to obtain the message if log level is matched</param>
        /// <param name="exception">The exception to log, including its stack trace.</param>
        void Trace(Exception exception, Func<FormatMessageHandler, string> formatMessageCallback);

        /// <summary>
        ///     Log a message with the <see cref="F:LogLevel.Trace" /> level using a callback to obtain the message
        /// </summary>
        /// <remarks>
        ///     Using this method avoids the cost of creating a message and evaluating message arguments
        ///     that probably won't be logged due to loglevel settings.
        /// </remarks>
        /// <param name="formatProvider">
        ///     An <see cref="T:System.IFormatProvider" /> that supplies culture-specific formatting
        ///     information.
        /// </param>
        /// <param name="formatMessageCallback">A callback used by the logger to obtain the message if log level is matched</param>
        void Trace(IFormatProvider formatProvider, Func<FormatMessageHandler, string> formatMessageCallback);

        /// <summary>
        ///     Log a message with the <see cref="F:LogLevel.Trace" /> level using a callback to obtain the message
        /// </summary>
        /// <remarks>
        ///     Using this method avoids the cost of creating a message and evaluating message arguments
        ///     that probably won't be logged due to loglevel settings.
        /// </remarks>
        /// <param name="formatProvider">
        ///     An <see cref="T:System.IFormatProvider" /> that supplies culture-specific formatting
        ///     information.
        /// </param>
        /// <param name="formatMessageCallback">A callback used by the logger to obtain the message if log level is matched</param>
        /// <param name="exception">The exception to log, including its stack trace.</param>
        void Trace(Exception exception, IFormatProvider formatProvider,
            Func<FormatMessageHandler, string> formatMessageCallback);

        /// <summary>
        ///     Log a message with the <see cref="F:LogLevel.Trace" /> level.
        /// </summary>
        /// <param name="format">
        ///     The format of the message object to log.
        ///     <see cref="M:System.String.Format(System.String,System.Object[])" />
        /// </param>
        /// <param name="args">the list of format arguments</param>
        void TraceFormat(string format, params object[] args);

        /// <summary>
        ///     Log a message with the <see cref="F:LogLevel.Trace" /> level.
        /// </summary>
        /// <param name="format">
        ///     The format of the message object to log.
        ///     <see cref="M:System.String.Format(System.String,System.Object[])" />
        /// </param>
        /// <param name="exception">The exception to log.</param>
        /// <param name="args">the list of format arguments</param>
        void TraceFormat(Exception exception, string format, params object[] args);

        /// <summary>
        ///     Log a message with the <see cref="F:LogLevel.Trace" /> level.
        /// </summary>
        /// <param name="formatProvider">
        ///     An <see cref="T:System.IFormatProvider" /> that supplies culture-specific formatting
        ///     information.
        /// </param>
        /// <param name="format">
        ///     The format of the message object to log.
        ///     <see cref="M:System.String.Format(System.String,System.Object[])" />
        /// </param>
        /// <param name="args" />
        void TraceFormat(IFormatProvider formatProvider, string format, params object[] args);

        /// <summary>
        ///     Log a message with the <see cref="F:LogLevel.Trace" /> level.
        /// </summary>
        /// <param name="formatProvider">
        ///     An <see cref="T:System.IFormatProvider" /> that supplies culture-specific formatting
        ///     information.
        /// </param>
        /// <param name="format">
        ///     The format of the message object to log.
        ///     <see cref="M:System.String.Format(System.String,System.Object[])" />
        /// </param>
        /// <param name="exception">The exception to log.</param>
        /// <param name="args" />
        void TraceFormat(Exception exception, IFormatProvider formatProvider, string format, params object[] args);

        /// <summary>
        ///     Log a message object with the <see cref="F:LogLevel.Warn" /> level.
        /// </summary>
        /// <param name="message">The message object to log.</param>
        void Warn(object message);

        /// <summary>
        ///     Log a message object with the <see cref="F:LogLevel.Warn" /> level including
        ///     the stack trace of the <see cref="T:System.Exception" /> passed
        ///     as a parameter.
        /// </summary>
        /// <param name="message">The message object to log.</param>
        /// <param name="exception">The exception to log, including its stack trace.</param>
        void Warn(Exception exception, object message);

        /// <summary>
        ///     Log a message with the <see cref="F:LogLevel.Warn" /> level using a callback to obtain the message
        /// </summary>
        /// <remarks>
        ///     Using this method avoids the cost of creating a message and evaluating message arguments
        ///     that probably won't be logged due to loglevel settings.
        /// </remarks>
        /// <param name="formatMessageCallback">A callback used by the logger to obtain the message if log level is matched</param>
        void Warn(Func<FormatMessageHandler, string> formatMessageCallback);

        /// <summary>
        ///     Log a message with the <see cref="F:LogLevel.Warn" /> level using a callback to obtain the message
        /// </summary>
        /// <remarks>
        ///     Using this method avoids the cost of creating a message and evaluating message arguments
        ///     that probably won't be logged due to loglevel settings.
        /// </remarks>
        /// <param name="formatMessageCallback">A callback used by the logger to obtain the message if log level is matched</param>
        /// <param name="exception">The exception to log, including its stack trace.</param>
        void Warn(Exception exception, Func<FormatMessageHandler, string> formatMessageCallback);

        /// <summary>
        ///     Log a message with the <see cref="F:LogLevel.Warn" /> level using a callback to obtain the message
        /// </summary>
        /// <remarks>
        ///     Using this method avoids the cost of creating a message and evaluating message arguments
        ///     that probably won't be logged due to loglevel settings.
        /// </remarks>
        /// <param name="formatProvider">
        ///     An <see cref="T:System.IFormatProvider" /> that supplies culture-specific formatting
        ///     information.
        /// </param>
        /// <param name="formatMessageCallback">A callback used by the logger to obtain the message if log level is matched</param>
        void Warn(IFormatProvider formatProvider, Func<FormatMessageHandler, string> formatMessageCallback);

        /// <summary>
        ///     Log a message with the <see cref="F:LogLevel.Warn" /> level using a callback to obtain the message
        /// </summary>
        /// <remarks>
        ///     Using this method avoids the cost of creating a message and evaluating message arguments
        ///     that probably won't be logged due to loglevel settings.
        /// </remarks>
        /// <param name="formatProvider">
        ///     An <see cref="T:System.IFormatProvider" /> that supplies culture-specific formatting
        ///     information.
        /// </param>
        /// <param name="formatMessageCallback">A callback used by the logger to obtain the message if log level is matched</param>
        /// <param name="exception">The exception to log, including its stack Warn.</param>
        void Warn(Exception exception, IFormatProvider formatProvider,
            Func<FormatMessageHandler, string> formatMessageCallback);

        /// <summary>
        ///     Log a message with the <see cref="F:LogLevel.Warn" /> level.
        /// </summary>
        /// <param name="format">
        ///     The format of the message object to log.
        ///     <see cref="M:System.String.Format(System.String,System.Object[])" />
        /// </param>
        /// <param name="args">the list of format arguments</param>
        void WarnFormat(string format, params object[] args);

        /// <summary>
        ///     Log a message with the <see cref="F:LogLevel.Warn" /> level.
        /// </summary>
        /// <param name="format">
        ///     The format of the message object to log.
        ///     <see cref="M:System.String.Format(System.String,System.Object[])" />
        /// </param>
        /// <param name="exception">The exception to log.</param>
        /// <param name="args">the list of format arguments</param>
        void WarnFormat(Exception exception, string format, params object[] args);

        /// <summary>
        ///     Log a message with the <see cref="F:LogLevel.Warn" /> level.
        /// </summary>
        /// <param name="formatProvider">
        ///     An <see cref="T:System.IFormatProvider" /> that supplies culture-specific formatting
        ///     information.
        /// </param>
        /// <param name="format">
        ///     The format of the message object to log.
        ///     <see cref="M:System.String.Format(System.String,System.Object[])" />
        /// </param>
        /// <param name="args" />
        void WarnFormat(IFormatProvider formatProvider, string format, params object[] args);

        /// <summary>
        ///     Log a message with the <see cref="F:LogLevel.Warn" /> level.
        /// </summary>
        /// <param name="formatProvider">
        ///     An <see cref="T:System.IFormatProvider" /> that supplies culture-specific formatting
        ///     information.
        /// </param>
        /// <param name="format">
        ///     The format of the message object to log.
        ///     <see cref="M:System.String.Format(System.String,System.Object[])" />
        /// </param>
        /// <param name="exception">The exception to log.</param>
        /// <param name="args" />
        void WarnFormat(Exception exception, IFormatProvider formatProvider, string format, params object[] args);
    }
}