using System;
using System.Runtime.CompilerServices; 
using PortableLog.Core.Properties;

namespace PortableLog.Core
{
    /// <summary>
    ///     A simple logging interface abstracting logging APIs.
    /// </summary>
    [PublicAPI]
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
        /// <param name="callerMemberName">Name of method or property calling this method. Will be included in log message.</param>
        void Debug(string message, [CallerMemberName] string callerMemberName = "");

        /// <summary>
        ///     Log a message object with the <see cref="F:LogLevel.Debug" /> level including
        ///     the stack trace of the <see cref="T:System.Exception" /> passed
        ///     as a parameter.
        /// </summary>
        /// <param name="message">The message object to log.</param>
        /// <param name="exception">The exception to log, including its stack trace.</param>
        /// <param name="callerMemberName">Name of method or property calling this method. Will be included in log message.</param>
        void Debug(Exception exception, object message, [CallerMemberName] string callerMemberName = "");

        /// <summary>
        ///     Log a message with the <see cref="F:LogLevel.Debug" /> level using a callback to obtain the message
        /// </summary>
        /// <remarks>
        ///     Using this method avoids the cost of creating a message and evaluating message arguments
        ///     that probably won't be logged due to loglevel settings.
        /// </remarks>
        /// <param name="formatMessageCallback">A callback used by the logger to obtain the message if log level is matched</param>
        /// <param name="callerMemberName">Name of method or property calling this method. Will be included in log message.</param>
        void Debug(Func<FormatMessageHandler, string> formatMessageCallback, [CallerMemberName] string callerMemberName = "");

        /// <summary>
        ///     Log a message with the <see cref="F:LogLevel.Debug" /> level using a callback to obtain the message
        /// </summary>
        /// <remarks>
        ///     Using this method avoids the cost of creating a message and evaluating message arguments
        ///     that probably won't be logged due to loglevel settings.
        /// </remarks>
        /// <param name="formatMessageCallback">A callback used by the logger to obtain the message if log level is matched</param>
        /// <param name="exception">The exception to log, including its stack trace.</param>
        /// <param name="callerMemberName">Name of method or property calling this method. Will be included in log message.</param>
        void Debug(Exception exception, Func<FormatMessageHandler, string> formatMessageCallback, [CallerMemberName] string callerMemberName = "");

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
        /// <param name="callerMemberName">Name of method or property calling this method. Will be included in log message.</param>
        void Debug(IFormatProvider formatProvider, Func<FormatMessageHandler, string> formatMessageCallback, [CallerMemberName] string callerMemberName = "");

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
        /// <param name="callerMemberName">Name of method or property calling this method. Will be included in log message.</param>
        void Debug(Exception exception, IFormatProvider formatProvider,
            Func<FormatMessageHandler, string> formatMessageCallback, [CallerMemberName] string callerMemberName = "");

        /// <summary>
        ///     Log a message object with the <see cref="F:LogLevel.Error" /> level.
        /// </summary>
        /// <param name="message">The message object to log.</param>
        /// <param name="callerMemberName">Name of method or property calling this method. Will be included in log message.</param>
        void Error(string message, [CallerMemberName] string callerMemberName = "");

        /// <summary>
        ///     Log a message object with the <see cref="F:LogLevel.Error" /> level including
        ///     the stack trace of the <see cref="T:System.Exception" /> passed
        ///     as a parameter.
        /// </summary>
        /// <param name="exception">The exception to log, including its stack trace.</param>
        /// <param name="message">The message object to log.</param>
        /// <param name="callerMemberName">Name of method or property calling this method. Will be included in log message.</param>
        void Error(Exception exception, object message, [CallerMemberName] string callerMemberName = "");

        /// <summary>
        ///     Log a message with the <see cref="F:LogLevel.Error" /> level using a callback to obtain the message
        /// </summary>
        /// <remarks>
        ///     Using this method avoids the cost of creating a message and evaluating message arguments
        ///     that probably won't be logged due to loglevel settings.
        /// </remarks>
        /// <param name="formatMessageCallback">A callback used by the logger to obtain the message if log level is matched</param>
        /// <param name="callerMemberName">Name of method or property calling this method. Will be included in log message.</param>
        void Error(Func<FormatMessageHandler, string> formatMessageCallback, [CallerMemberName] string callerMemberName = "");

        /// <summary>
        ///     Log a message with the <see cref="F:LogLevel.Error" /> level using a callback to obtain the message
        /// </summary>
        /// <remarks>
        ///     Using this method avoids the cost of creating a message and evaluating message arguments
        ///     that probably won't be logged due to loglevel settings.
        /// </remarks>
        /// <param name="formatMessageCallback">A callback used by the logger to obtain the message if log level is matched</param>
        /// <param name="exception">The exception to log, including its stack trace.</param>
        /// <param name="callerMemberName">Name of method or property calling this method. Will be included in log message.</param>
        void Error(Exception exception, Func<FormatMessageHandler, string> formatMessageCallback, [CallerMemberName] string callerMemberName = "");

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
        /// <param name="callerMemberName">Name of method or property calling this method. Will be included in log message.</param>
        void Error(IFormatProvider formatProvider, Func<FormatMessageHandler, string> formatMessageCallback, [CallerMemberName] string callerMemberName = "");

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
        /// <param name="callerMemberName">Name of method or property calling this method. Will be included in log message.</param>
        void Error(Exception exception, IFormatProvider formatProvider,
            Func<FormatMessageHandler, string> formatMessageCallback, [CallerMemberName] string callerMemberName = "");

        /// <summary>
        ///     Log a message object with the <see cref="F:LogLevel.Fatal" /> level.
        /// </summary>
        /// <param name="message">The message object to log.</param>
        /// <param name="callerMemberName">Name of method or property calling this method. Will be included in log message.</param>
        void Fatal(string message, [CallerMemberName] string callerMemberName = "");

        /// <summary>
        ///     Log a message object with the <see cref="F:LogLevel.Fatal" /> level including
        ///     the stack trace of the <see cref="T:System.Exception" /> passed
        ///     as a parameter.
        /// </summary>
        /// <param name="message">The message object to log.</param>
        /// <param name="exception">The exception to log, including its stack trace.</param>
        /// <param name="callerMemberName">Name of method or property calling this method. Will be included in log message.</param>
        void Fatal(Exception exception, object message, [CallerMemberName] string callerMemberName = "");

        /// <summary>
        ///     Log a message with the <see cref="F:LogLevel.Fatal" /> level using a callback to obtain the message
        /// </summary>
        /// <remarks>
        ///     Using this method avoids the cost of creating a message and evaluating message arguments
        ///     that probably won't be logged due to loglevel settings.
        /// </remarks>
        /// <param name="formatMessageCallback">A callback used by the logger to obtain the message if log level is matched</param>
        /// <param name="callerMemberName">Name of method or property calling this method. Will be included in log message.</param>
        void Fatal(Func<FormatMessageHandler, string> formatMessageCallback, [CallerMemberName] string callerMemberName = "");

        /// <summary>
        ///     Log a message with the <see cref="F:LogLevel.Fatal" /> level using a callback to obtain the message
        /// </summary>
        /// <remarks>
        ///     Using this method avoids the cost of creating a message and evaluating message arguments
        ///     that probably won't be logged due to loglevel settings.
        /// </remarks>
        /// <param name="formatMessageCallback">A callback used by the logger to obtain the message if log level is matched</param>
        /// <param name="exception">The exception to log, including its stack trace.</param>
        /// <param name="callerMemberName">Name of method or property calling this method. Will be included in log message.</param>
        void Fatal(Exception exception, Func<FormatMessageHandler, string> formatMessageCallback, [CallerMemberName] string callerMemberName = "");

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
        /// <param name="callerMemberName">Name of method or property calling this method. Will be included in log message.</param>
        void Fatal(IFormatProvider formatProvider, Func<FormatMessageHandler, string> formatMessageCallback, [CallerMemberName] string callerMemberName = "");

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
        /// <param name="callerMemberName">Name of method or property calling this method. Will be included in log message.</param>
        void Fatal(Exception exception, IFormatProvider formatProvider,
            Func<FormatMessageHandler, string> formatMessageCallback, [CallerMemberName] string callerMemberName = "");

        /// <summary>
        ///     Log a message object with the <see cref="F:LogLevel.Info" /> level.
        /// </summary>
        /// <param name="message">The message object to log.</param>
        /// <param name="callerMemberName">Name of method or property calling this method. Will be included in log message.</param>
        void Info(string message, [CallerMemberName] string callerMemberName = "");

        /// <summary>
        ///     Log a message object with the <see cref="F:LogLevel.Info" /> level including
        ///     the stack trace of the <see cref="T:System.Exception" /> passed
        ///     as a parameter.
        /// </summary>
        /// <param name="message">The message object to log.</param>
        /// <param name="exception">The exception to log, including its stack trace.</param>
        /// <param name="callerMemberName">Name of method or property calling this method. Will be included in log message.</param>
        void Info(Exception exception, object message, [CallerMemberName] string callerMemberName = "");

        /// <summary>
        ///     Log a message with the <see cref="F:LogLevel.Info" /> level using a callback to obtain the message
        /// </summary>
        /// <remarks>
        ///     Using this method avoids the cost of creating a message and evaluating message arguments
        ///     that probably won't be logged due to loglevel settings.
        /// </remarks>
        /// <param name="formatMessageCallback">A callback used by the logger to obtain the message if log level is matched</param>
        /// <param name="callerMemberName">Name of method or property calling this method. Will be included in log message.</param>
        void Info(Func<FormatMessageHandler, string> formatMessageCallback, [CallerMemberName] string callerMemberName = "");

        /// <summary>
        ///     Log a message with the <see cref="F:LogLevel.Info" /> level using a callback to obtain the message
        /// </summary>
        /// <remarks>
        ///     Using this method avoids the cost of creating a message and evaluating message arguments
        ///     that probably won't be logged due to loglevel settings.
        /// </remarks>
        /// <param name="formatMessageCallback">A callback used by the logger to obtain the message if log level is matched</param>
        /// <param name="exception">The exception to log, including its stack trace.</param>
        /// <param name="callerMemberName">Name of method or property calling this method. Will be included in log message.</param>
        void Info(Exception exception, Func<FormatMessageHandler, string> formatMessageCallback, [CallerMemberName] string callerMemberName = "");

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
        /// <param name="callerMemberName">Name of method or property calling this method. Will be included in log message.</param>
        void Info(IFormatProvider formatProvider, Func<FormatMessageHandler, string> formatMessageCallback, [CallerMemberName] string callerMemberName = "");

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
        /// <param name="callerMemberName">Name of method or property calling this method. Will be included in log message.</param>
        void Info(Exception exception, IFormatProvider formatProvider,
            Func<FormatMessageHandler, string> formatMessageCallback, [CallerMemberName] string callerMemberName = "");

        /// <summary>
        ///     Log a message object with the <see cref="F:LogLevel.Trace" /> level.
        /// </summary>
        /// <param name="message">The message object to log.</param>
        /// <param name="callerMemberName">Name of method or property calling this method. Will be included in log message.</param>
        void Trace(string message, [CallerMemberName] string callerMemberName = "");

        /// <summary>
        ///     Log a message object with the <see cref="F:LogLevel.Trace" /> level including
        ///     the stack trace of the <see cref="T:System.Exception" /> passed
        ///     as a parameter.
        /// </summary>
        /// <param name="message">The message object to log.</param>
        /// <param name="exception">The exception to log, including its stack trace.</param>
        /// <param name="callerMemberName">Name of method or property calling this method. Will be included in log message.</param>
        void Trace(Exception exception, object message, [CallerMemberName] string callerMemberName = "");

        /// <summary>
        ///     Log a message with the <see cref="F:LogLevel.Trace" /> level using a callback to obtain the message
        /// </summary>
        /// <remarks>
        ///     Using this method avoids the cost of creating a message and evaluating message arguments
        ///     that probably won't be logged due to loglevel settings.
        /// </remarks>
        /// <param name="formatMessageCallback">A callback used by the logger to obtain the message if log level is matched</param>
        /// <param name="callerMemberName">Name of method or property calling this method. Will be included in log message.</param>
        void Trace(Func<FormatMessageHandler, string> formatMessageCallback, [CallerMemberName] string callerMemberName = "");

        /// <summary>
        ///     Log a message with the <see cref="F:LogLevel.Trace" /> level using a callback to obtain the message
        /// </summary>
        /// <remarks>
        ///     Using this method avoids the cost of creating a message and evaluating message arguments
        ///     that probably won't be logged due to loglevel settings.
        /// </remarks>
        /// <param name="formatMessageCallback">A callback used by the logger to obtain the message if log level is matched</param>
        /// <param name="exception">The exception to log, including its stack trace.</param>
        /// <param name="callerMemberName">Name of method or property calling this method. Will be included in log message.</param>
        void Trace(Exception exception, Func<FormatMessageHandler, string> formatMessageCallback, [CallerMemberName] string callerMemberName = "");

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
        /// <param name="callerMemberName">Name of method or property calling this method. Will be included in log message.</param>
        void Trace(IFormatProvider formatProvider, Func<FormatMessageHandler, string> formatMessageCallback, [CallerMemberName] string callerMemberName = "");

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
        /// <param name="callerMemberName">Name of method or property calling this method. Will be included in log message.</param>
        void Trace(Exception exception, IFormatProvider formatProvider,
            Func<FormatMessageHandler, string> formatMessageCallback, [CallerMemberName] string callerMemberName = "");

        /// <summary>
        ///     Log a message object with the <see cref="F:LogLevel.Warn" /> level.
        /// </summary>
        /// <param name="message">The message object to log.</param>
        /// <param name="callerMemberName">Name of method or property calling this method. Will be included in log message.</param>
        void Warn(string message, [CallerMemberName] string callerMemberName = "");

        /// <summary>
        ///     Log a message object with the <see cref="F:LogLevel.Warn" /> level including
        ///     the stack trace of the <see cref="T:System.Exception" /> passed
        ///     as a parameter.
        /// </summary>
        /// <param name="message">The message object to log.</param>
        /// <param name="exception">The exception to log, including its stack trace.</param>
        /// <param name="callerMemberName">Name of method or property calling this method. Will be included in log message.</param>
        void Warn(Exception exception, object message, [CallerMemberName] string callerMemberName = "");

        /// <summary>
        ///     Log a message with the <see cref="F:LogLevel.Warn" /> level using a callback to obtain the message
        /// </summary>
        /// <remarks>
        ///     Using this method avoids the cost of creating a message and evaluating message arguments
        ///     that probably won't be logged due to loglevel settings.
        /// </remarks>
        /// <param name="formatMessageCallback">A callback used by the logger to obtain the message if log level is matched</param>
        /// <param name="callerMemberName">Name of method or property calling this method. Will be included in log message.</param>
        void Warn(Func<FormatMessageHandler, string> formatMessageCallback, [CallerMemberName] string callerMemberName = "");

        /// <summary>
        ///     Log a message with the <see cref="F:LogLevel.Warn" /> level using a callback to obtain the message
        /// </summary>
        /// <remarks>
        ///     Using this method avoids the cost of creating a message and evaluating message arguments
        ///     that probably won't be logged due to loglevel settings.
        /// </remarks>
        /// <param name="formatMessageCallback">A callback used by the logger to obtain the message if log level is matched</param>
        /// <param name="exception">The exception to log, including its stack trace.</param>
        /// <param name="callerMemberName">Name of method or property calling this method. Will be included in log message.</param>
        void Warn(Exception exception, Func<FormatMessageHandler, string> formatMessageCallback, [CallerMemberName] string callerMemberName = "");

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
        /// <param name="callerMemberName">Name of method or property calling this method. Will be included in log message.</param>
        void Warn(IFormatProvider formatProvider, Func<FormatMessageHandler, string> formatMessageCallback, [CallerMemberName] string callerMemberName = "");

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
        /// <param name="callerMemberName">Name of method or property calling this method. Will be included in log message.</param>
        void Warn(Exception exception, IFormatProvider formatProvider,
            Func<FormatMessageHandler, string> formatMessageCallback, [CallerMemberName] string callerMemberName = "");
    }
}