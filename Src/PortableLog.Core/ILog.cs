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
        void Debug(object message, Exception exception);

        /// <summary>
        ///     Log a message with the <see cref="F:LogLevel.Debug" /> level using a callback to obtain the message
        /// </summary>
        /// <remarks>
        ///     Using this method avoids the cost of creating a message and evaluating message arguments
        ///     that probably won't be logged due to loglevel settings.
        /// </remarks>
        /// <param name="formatMessageCallback">A callback used by the logger to obtain the message if log level is matched</param>
        void Debug(Action<FormatMessageHandler> formatMessageCallback);

        /// <summary>
        ///     Log a message with the <see cref="F:LogLevel.Debug" /> level using a callback to obtain the message
        /// </summary>
        /// <remarks>
        ///     Using this method avoids the cost of creating a message and evaluating message arguments
        ///     that probably won't be logged due to loglevel settings.
        /// </remarks>
        /// <param name="formatMessageCallback">A callback used by the logger to obtain the message if log level is matched</param>
        /// <param name="exception">The exception to log, including its stack trace.</param>
        void Debug(Action<FormatMessageHandler> formatMessageCallback, Exception exception);

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
        void Debug(IFormatProvider formatProvider, Action<FormatMessageHandler> formatMessageCallback);

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
        void Debug(IFormatProvider formatProvider, Action<FormatMessageHandler> formatMessageCallback,
            Exception exception);

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
        void DebugFormat(string format, Exception exception, params object[] args);

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
        void DebugFormat(IFormatProvider formatProvider, string format, Exception exception, params object[] args);

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
        void Error(object message, Exception exception);

        /// <summary>
        ///     Log a message with the <see cref="F:LogLevel.Error" /> level using a callback to obtain the message
        /// </summary>
        /// <remarks>
        ///     Using this method avoids the cost of creating a message and evaluating message arguments
        ///     that probably won't be logged due to loglevel settings.
        /// </remarks>
        /// <param name="formatMessageCallback">A callback used by the logger to obtain the message if log level is matched</param>
        void Error(Action<FormatMessageHandler> formatMessageCallback);

        /// <summary>
        ///     Log a message with the <see cref="F:LogLevel.Error" /> level using a callback to obtain the message
        /// </summary>
        /// <remarks>
        ///     Using this method avoids the cost of creating a message and evaluating message arguments
        ///     that probably won't be logged due to loglevel settings.
        /// </remarks>
        /// <param name="formatMessageCallback">A callback used by the logger to obtain the message if log level is matched</param>
        /// <param name="exception">The exception to log, including its stack trace.</param>
        void Error(Action<FormatMessageHandler> formatMessageCallback, Exception exception);

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
        void Error(IFormatProvider formatProvider, Action<FormatMessageHandler> formatMessageCallback);

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
        void Error(IFormatProvider formatProvider, Action<FormatMessageHandler> formatMessageCallback,
            Exception exception);

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
        void ErrorFormat(string format, Exception exception, params object[] args);

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
        void ErrorFormat(IFormatProvider formatProvider, string format, Exception exception, params object[] args);

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
        void Fatal(object message, Exception exception);

        /// <summary>
        ///     Log a message with the <see cref="F:LogLevel.Fatal" /> level using a callback to obtain the message
        /// </summary>
        /// <remarks>
        ///     Using this method avoids the cost of creating a message and evaluating message arguments
        ///     that probably won't be logged due to loglevel settings.
        /// </remarks>
        /// <param name="formatMessageCallback">A callback used by the logger to obtain the message if log level is matched</param>
        void Fatal(Action<FormatMessageHandler> formatMessageCallback);

        /// <summary>
        ///     Log a message with the <see cref="F:LogLevel.Fatal" /> level using a callback to obtain the message
        /// </summary>
        /// <remarks>
        ///     Using this method avoids the cost of creating a message and evaluating message arguments
        ///     that probably won't be logged due to loglevel settings.
        /// </remarks>
        /// <param name="formatMessageCallback">A callback used by the logger to obtain the message if log level is matched</param>
        /// <param name="exception">The exception to log, including its stack trace.</param>
        void Fatal(Action<FormatMessageHandler> formatMessageCallback, Exception exception);

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
        void Fatal(IFormatProvider formatProvider, Action<FormatMessageHandler> formatMessageCallback);

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
        void Fatal(IFormatProvider formatProvider, Action<FormatMessageHandler> formatMessageCallback,
            Exception exception);

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
        void FatalFormat(string format, Exception exception, params object[] args);

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
        void FatalFormat(IFormatProvider formatProvider, string format, Exception exception, params object[] args);

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
        void Info(object message, Exception exception);

        /// <summary>
        ///     Log a message with the <see cref="F:LogLevel.Info" /> level using a callback to obtain the message
        /// </summary>
        /// <remarks>
        ///     Using this method avoids the cost of creating a message and evaluating message arguments
        ///     that probably won't be logged due to loglevel settings.
        /// </remarks>
        /// <param name="formatMessageCallback">A callback used by the logger to obtain the message if log level is matched</param>
        void Info(Action<FormatMessageHandler> formatMessageCallback);

        /// <summary>
        ///     Log a message with the <see cref="F:LogLevel.Info" /> level using a callback to obtain the message
        /// </summary>
        /// <remarks>
        ///     Using this method avoids the cost of creating a message and evaluating message arguments
        ///     that probably won't be logged due to loglevel settings.
        /// </remarks>
        /// <param name="formatMessageCallback">A callback used by the logger to obtain the message if log level is matched</param>
        /// <param name="exception">The exception to log, including its stack trace.</param>
        void Info(Action<FormatMessageHandler> formatMessageCallback, Exception exception);

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
        void Info(IFormatProvider formatProvider, Action<FormatMessageHandler> formatMessageCallback);

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
        void Info(IFormatProvider formatProvider, Action<FormatMessageHandler> formatMessageCallback,
            Exception exception);

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
        void InfoFormat(string format, Exception exception, params object[] args);

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
        void InfoFormat(IFormatProvider formatProvider, string format, Exception exception, params object[] args);

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
        void Trace(object message, Exception exception);

        /// <summary>
        ///     Log a message with the <see cref="F:LogLevel.Trace" /> level using a callback to obtain the message
        /// </summary>
        /// <remarks>
        ///     Using this method avoids the cost of creating a message and evaluating message arguments
        ///     that probably won't be logged due to loglevel settings.
        /// </remarks>
        /// <param name="formatMessageCallback">A callback used by the logger to obtain the message if log level is matched</param>
        void Trace(Action<FormatMessageHandler> formatMessageCallback);

        /// <summary>
        ///     Log a message with the <see cref="F:LogLevel.Trace" /> level using a callback to obtain the message
        /// </summary>
        /// <remarks>
        ///     Using this method avoids the cost of creating a message and evaluating message arguments
        ///     that probably won't be logged due to loglevel settings.
        /// </remarks>
        /// <param name="formatMessageCallback">A callback used by the logger to obtain the message if log level is matched</param>
        /// <param name="exception">The exception to log, including its stack trace.</param>
        void Trace(Action<FormatMessageHandler> formatMessageCallback, Exception exception);

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
        void Trace(IFormatProvider formatProvider, Action<FormatMessageHandler> formatMessageCallback);

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
        void Trace(IFormatProvider formatProvider, Action<FormatMessageHandler> formatMessageCallback,
            Exception exception);

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
        void TraceFormat(string format, Exception exception, params object[] args);

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
        void TraceFormat(IFormatProvider formatProvider, string format, Exception exception, params object[] args);

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
        void Warn(object message, Exception exception);

        /// <summary>
        ///     Log a message with the <see cref="F:LogLevel.Warn" /> level using a callback to obtain the message
        /// </summary>
        /// <remarks>
        ///     Using this method avoids the cost of creating a message and evaluating message arguments
        ///     that probably won't be logged due to loglevel settings.
        /// </remarks>
        /// <param name="formatMessageCallback">A callback used by the logger to obtain the message if log level is matched</param>
        void Warn(Action<FormatMessageHandler> formatMessageCallback);

        /// <summary>
        ///     Log a message with the <see cref="F:LogLevel.Warn" /> level using a callback to obtain the message
        /// </summary>
        /// <remarks>
        ///     Using this method avoids the cost of creating a message and evaluating message arguments
        ///     that probably won't be logged due to loglevel settings.
        /// </remarks>
        /// <param name="formatMessageCallback">A callback used by the logger to obtain the message if log level is matched</param>
        /// <param name="exception">The exception to log, including its stack trace.</param>
        void Warn(Action<FormatMessageHandler> formatMessageCallback, Exception exception);

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
        void Warn(IFormatProvider formatProvider, Action<FormatMessageHandler> formatMessageCallback);

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
        void Warn(IFormatProvider formatProvider, Action<FormatMessageHandler> formatMessageCallback,
            Exception exception);

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
        void WarnFormat(string format, Exception exception, params object[] args);

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
        void WarnFormat(IFormatProvider formatProvider, string format, Exception exception, params object[] args);
    }
}