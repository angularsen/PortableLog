using System;
using System.Runtime.CompilerServices;
using PortableLog.Core;
using NLogLib = NLog;

namespace PortableLog.NLog
{
    /// <summary>
    ///     NLog adapter for <see cref="ILogEx" />.
    /// </summary>
    /// <remarks>
    ///     NLog is a .NET logging library designed with simplicity and flexibility in mind.
    ///     http://www.nlog-project.org/
    /// </remarks>
    public class NLogLogger : AbstractLogger, ILogEx
    {
        private static readonly Type DeclaringType = typeof (NLogLogger);
        private readonly NLogLib.Logger _logger;

        static NLogLogger()
        {
        }

        /// <summary>
        ///     Constructor
        /// </summary>
        protected internal NLogLogger(NLogLib.Logger logger)
        {
            _logger = logger;
        }

        /// <summary>
        ///     Gets a value indicating whether this instance is debug enabled.
        /// </summary>
        /// <value>
        ///     <c>true</c> if this instance is debug enabled; otherwise, <c>false</c>.
        /// </value>
        public override bool IsDebugEnabled
        {
            get { return _logger.IsDebugEnabled; }
        }

        /// <summary>
        ///     Gets a value indicating whether this instance is error enabled.
        /// </summary>
        /// <value>
        ///     <c>true</c> if this instance is error enabled; otherwise, <c>false</c>.
        /// </value>
        public override bool IsErrorEnabled
        {
            get { return _logger.IsErrorEnabled; }
        }

        /// <summary>
        ///     Gets a value indicating whether this instance is fatal enabled.
        /// </summary>
        /// <value>
        ///     <c>true</c> if this instance is fatal enabled; otherwise, <c>false</c>.
        /// </value>
        public override bool IsFatalEnabled
        {
            get { return _logger.IsFatalEnabled; }
        }

        /// <summary>
        ///     Gets a value indicating whether this instance is info enabled.
        /// </summary>
        /// <value>
        ///     <c>true</c> if this instance is info enabled; otherwise, <c>false</c>.
        /// </value>
        public override bool IsInfoEnabled
        {
            get { return _logger.IsInfoEnabled; }
        }

        /// <summary>
        ///     Gets a value indicating whether this instance is trace enabled.
        /// </summary>
        /// <value>
        ///     <c>true</c> if this instance is trace enabled; otherwise, <c>false</c>.
        /// </value>
        public override bool IsTraceEnabled
        {
            get { return _logger.IsTraceEnabled; }
        }

        /// <summary>
        ///     Gets a value indicating whether this instance is warn enabled.
        /// </summary>
        /// <value>
        ///     <c>true</c> if this instance is warn enabled; otherwise, <c>false</c>.
        /// </value>
        public override bool IsWarnEnabled
        {
            get { return _logger.IsWarnEnabled; }
        }

        /// <summary>
        ///     Log a message object with the <see cref="F:Common.Logging.LogLevel.Debug" /> level.
        /// </summary>
        /// <param name="message">The message object to log.</param>
        public override void Debug(object message)
        {
            if (!IsDebugEnabled)
                return;
            WriteInternal(LogLevel.Debug, message, null);
        }

        /// <summary>
        ///     Log a message object with the <see cref="F:Common.Logging.LogLevel.Debug" /> level including
        ///     the stack Debug of the <see cref="T:System.Exception" /> passed
        ///     as a parameter.
        /// </summary>
        /// <param name="message">The message object to log.</param>
        /// <param name="exception">The exception to log, including its stack Debug.</param>
        public override void Debug(object message, Exception exception)
        {
            if (!IsDebugEnabled)
                return;
            WriteInternal(LogLevel.Debug, message, exception);
        }

        /// <summary>
        ///     Log a message with the <see cref="F:Common.Logging.LogLevel.Debug" /> level using a callback to obtain the message
        /// </summary>
        /// <remarks>
        ///     Using this method avoids the cost of creating a message and evaluating message arguments
        ///     that probably won't be logged due to loglevel settings.
        /// </remarks>
        /// <param name="formatMessageCallback">A callback used by the logger to obtain the message if log level is matched</param>
        public override void Debug(Action<FormatMessageHandler> formatMessageCallback)
        {
            if (!IsDebugEnabled)
                return;
            WriteInternal(LogLevel.Debug, new FormatMessageCallbackFormattedMessage(formatMessageCallback), null);
        }

        /// <summary>
        ///     Log a message with the <see cref="F:Common.Logging.LogLevel.Debug" /> level using a callback to obtain the message
        /// </summary>
        /// <remarks>
        ///     Using this method avoids the cost of creating a message and evaluating message arguments
        ///     that probably won't be logged due to loglevel settings.
        /// </remarks>
        /// <param name="formatMessageCallback">A callback used by the logger to obtain the message if log level is matched</param>
        /// <param name="exception">The exception to log, including its stack Debug.</param>
        public override void Debug(Action<FormatMessageHandler> formatMessageCallback, Exception exception)
        {
            if (!IsDebugEnabled)
                return;
            WriteInternal(LogLevel.Debug, new FormatMessageCallbackFormattedMessage(formatMessageCallback), exception);
        }

        /// <summary>
        ///     Log a message with the <see cref="F:Common.Logging.LogLevel.Debug" /> level using a callback to obtain the message
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
        public override void Debug(IFormatProvider formatProvider, Action<FormatMessageHandler> formatMessageCallback)
        {
            if (!IsDebugEnabled)
                return;
            WriteInternal(LogLevel.Debug,
                new FormatMessageCallbackFormattedMessage(formatProvider, formatMessageCallback), null);
        }

        /// <summary>
        ///     Log a message with the <see cref="F:Common.Logging.LogLevel.Debug" /> level using a callback to obtain the message
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
        public override void Debug(IFormatProvider formatProvider, Action<FormatMessageHandler> formatMessageCallback,
            Exception exception)
        {
            if (!IsDebugEnabled)
                return;
            WriteInternal(LogLevel.Debug,
                new FormatMessageCallbackFormattedMessage(formatProvider, formatMessageCallback), exception);
        }

        /// <summary>
        ///     Log a message object with the <see cref="F:Common.Logging.LogLevel.Debug" /> level.
        /// </summary>
        /// <param name="message">The message object to log.</param>
        /// <param name="callerName"></param>
        public void DebugEx(object message, [CallerMemberName] string callerName = "")
        {
            if (!IsDebugEnabled)
                return;
            WriteInternal(LogLevel.Debug, callerName + ": " + message, null);
        }

        /// <summary>
        ///     Log a message with the <see cref="F:Common.Logging.LogLevel.Debug" /> level.
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
        public override void DebugFormat(IFormatProvider formatProvider, string format, params object[] args)
        {
            if (!IsDebugEnabled)
                return;
            WriteInternal(LogLevel.Debug, new StringFormatFormattedMessage(formatProvider, format, args), null);
        }

        /// <summary>
        ///     Log a message with the <see cref="F:Common.Logging.LogLevel.Debug" /> level.
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
        public override void DebugFormat(IFormatProvider formatProvider, string format, Exception exception,
            params object[] args)
        {
            if (!IsDebugEnabled)
                return;
            WriteInternal(LogLevel.Debug, new StringFormatFormattedMessage(formatProvider, format, args), exception);
        }

        /// <summary>
        ///     Log a message with the <see cref="F:Common.Logging.LogLevel.Debug" /> level.
        /// </summary>
        /// <param name="format">
        ///     The format of the message object to log.
        ///     <see cref="M:System.String.Format(System.String,System.Object[])" />
        /// </param>
        /// <param name="args">the list of format arguments</param>
        public override void DebugFormat(string format, params object[] args)
        {
            if (!IsDebugEnabled)
                return;
            WriteInternal(LogLevel.Debug, new StringFormatFormattedMessage(null, format, args), null);
        }

        /// <summary>
        ///     Log a message with the <see cref="F:Common.Logging.LogLevel.Debug" /> level.
        /// </summary>
        /// <param name="format">
        ///     The format of the message object to log.
        ///     <see cref="M:System.String.Format(System.String,System.Object[])" />
        /// </param>
        /// <param name="exception">The exception to log.</param>
        /// <param name="args">the list of format arguments</param>
        public override void DebugFormat(string format, Exception exception, params object[] args)
        {
            if (!IsDebugEnabled)
                return;
            WriteInternal(LogLevel.Debug, new StringFormatFormattedMessage(null, format, args), exception);
        }

        /// <summary>
        ///     Log a message with the <see cref="F:Common.Logging.LogLevel.Debug" /> level.
        /// </summary>
        /// <param name="format">
        ///     The format of the message object to log.
        ///     <see cref="M:System.String.Format(System.String,System.Object[])" />
        /// </param>
        /// <param name="args">the list of format arguments</param>
        /// <param name="callerName"></param>
        public void DebugFormatEx(string format, object[] args, [CallerMemberName] string callerName = "")
        {
            if (!IsDebugEnabled)
                return;
            WriteInternal(LogLevel.Debug, new StringFormatFormattedMessage(null, callerName + ": " + format, args), null);
        }

        /// <summary>
        ///     Log a message object with the <see cref="F:Common.Logging.LogLevel.Error" /> level.
        /// </summary>
        /// <param name="message">The message object to log.</param>
        public override void Error(object message)
        {
            if (!IsErrorEnabled)
                return;
            WriteInternal(LogLevel.Error, message, null);
        }

        /// <summary>
        ///     Log a message object with the <see cref="F:Common.Logging.LogLevel.Error" /> level including
        ///     the stack Error of the <see cref="T:System.Exception" /> passed
        ///     as a parameter.
        /// </summary>
        /// <param name="message">The message object to log.</param>
        /// <param name="exception">The exception to log, including its stack Error.</param>
        public override void Error(object message, Exception exception)
        {
            if (!IsErrorEnabled)
                return;
            WriteInternal(LogLevel.Error, message, exception);
        }

        /// <summary>
        ///     Log a message with the <see cref="F:Common.Logging.LogLevel.Error" /> level using a callback to obtain the message
        /// </summary>
        /// <remarks>
        ///     Using this method avoids the cost of creating a message and evaluating message arguments
        ///     that probably won't be logged due to loglevel settings.
        /// </remarks>
        /// <param name="formatMessageCallback">A callback used by the logger to obtain the message if log level is matched</param>
        public override void Error(Action<FormatMessageHandler> formatMessageCallback)
        {
            if (!IsErrorEnabled)
                return;
            WriteInternal(LogLevel.Error, new FormatMessageCallbackFormattedMessage(formatMessageCallback), null);
        }

        /// <summary>
        ///     Log a message with the <see cref="F:Common.Logging.LogLevel.Error" /> level using a callback to obtain the message
        /// </summary>
        /// <remarks>
        ///     Using this method avoids the cost of creating a message and evaluating message arguments
        ///     that probably won't be logged due to loglevel settings.
        /// </remarks>
        /// <param name="formatMessageCallback">A callback used by the logger to obtain the message if log level is matched</param>
        /// <param name="exception">The exception to log, including its stack Error.</param>
        public override void Error(Action<FormatMessageHandler> formatMessageCallback, Exception exception)
        {
            if (!IsErrorEnabled)
                return;
            WriteInternal(LogLevel.Error, new FormatMessageCallbackFormattedMessage(formatMessageCallback), exception);
        }

        /// <summary>
        ///     Log a message with the <see cref="F:Common.Logging.LogLevel.Error" /> level using a callback to obtain the message
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
        public override void Error(IFormatProvider formatProvider, Action<FormatMessageHandler> formatMessageCallback)
        {
            if (!IsErrorEnabled)
                return;
            WriteInternal(LogLevel.Error,
                new FormatMessageCallbackFormattedMessage(formatProvider, formatMessageCallback), null);
        }

        /// <summary>
        ///     Log a message with the <see cref="F:Common.Logging.LogLevel.Error" /> level using a callback to obtain the message
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
        public override void Error(IFormatProvider formatProvider, Action<FormatMessageHandler> formatMessageCallback,
            Exception exception)
        {
            if (!IsErrorEnabled)
                return;
            WriteInternal(LogLevel.Error,
                new FormatMessageCallbackFormattedMessage(formatProvider, formatMessageCallback), exception);
        }

        /// <summary>
        ///     Log a message object with the <see cref="F:Common.Logging.LogLevel.Error" /> level.
        /// </summary>
        /// <param name="message">The message object to log.</param>
        /// <param name="callerName"></param>
        public void ErrorEx(object message, [CallerMemberName] string callerName = "")
        {
            if (!IsErrorEnabled)
                return;
            WriteInternal(LogLevel.Error, callerName + ": " + message, null);
        }

        public void ErrorEx(object message, Exception exception, [CallerMemberName] string callerName = "")
        {
            if (!IsErrorEnabled)
                return;
            WriteInternal(LogLevel.Error, callerName + ": " + message, exception);
        }

        /// <summary>
        ///     Log a message with the <see cref="F:Common.Logging.LogLevel.Error" /> level.
        /// </summary>
        /// <param name="formatProvider">
        ///     An <see cref="T:System.IFormatProvider" /> that supplies culture-specific formatting
        ///     Errorrmation.
        /// </param>
        /// <param name="format">
        ///     The format of the message object to log.
        ///     <see cref="M:System.String.Format(System.String,System.Object[])" />
        /// </param>
        /// <param name="args" />
        public override void ErrorFormat(IFormatProvider formatProvider, string format, params object[] args)
        {
            if (!IsErrorEnabled)
                return;
            WriteInternal(LogLevel.Error, new StringFormatFormattedMessage(formatProvider, format, args), null);
        }

        /// <summary>
        ///     Log a message with the <see cref="F:Common.Logging.LogLevel.Error" /> level.
        /// </summary>
        /// <param name="formatProvider">
        ///     An <see cref="T:System.IFormatProvider" /> that supplies culture-specific formatting
        ///     Errorrmation.
        /// </param>
        /// <param name="format">
        ///     The format of the message object to log.
        ///     <see cref="M:System.String.Format(System.String,System.Object[])" />
        /// </param>
        /// <param name="exception">The exception to log.</param>
        /// <param name="args" />
        public override void ErrorFormat(IFormatProvider formatProvider, string format, Exception exception,
            params object[] args)
        {
            if (!IsErrorEnabled)
                return;
            WriteInternal(LogLevel.Error, new StringFormatFormattedMessage(formatProvider, format, args), exception);
        }

        /// <summary>
        ///     Log a message with the <see cref="F:Common.Logging.LogLevel.Error" /> level.
        /// </summary>
        /// <param name="format">
        ///     The format of the message object to log.
        ///     <see cref="M:System.String.Format(System.String,System.Object[])" />
        /// </param>
        /// <param name="args">the list of format arguments</param>
        public override void ErrorFormat(string format, params object[] args)
        {
            if (!IsErrorEnabled)
                return;
            WriteInternal(LogLevel.Error, new StringFormatFormattedMessage(null, format, args), null);
        }

        /// <summary>
        ///     Log a message with the <see cref="F:Common.Logging.LogLevel.Error" /> level.
        /// </summary>
        /// <param name="format">
        ///     The format of the message object to log.
        ///     <see cref="M:System.String.Format(System.String,System.Object[])" />
        /// </param>
        /// <param name="exception">The exception to log.</param>
        /// <param name="args">the list of format arguments</param>
        public override void ErrorFormat(string format, Exception exception, params object[] args)
        {
            if (!IsErrorEnabled)
                return;
            WriteInternal(LogLevel.Error, new StringFormatFormattedMessage(null, format, args), exception);
        }

        /// <summary>
        ///     Log a message with the <see cref="F:Common.Logging.LogLevel.Info" /> level.
        /// </summary>
        /// <param name="format">
        ///     The format of the message object to log.
        ///     <see cref="M:System.String.Format(System.String,System.Object[])" />
        /// </param>
        /// <param name="args">the list of format arguments</param>
        /// <param name="callerName"></param>
        public void ErrorFormatEx(string format, object[] args, [CallerMemberName] string callerName = "")
        {
            if (!IsErrorEnabled)
                return;
            WriteInternal(LogLevel.Error, new StringFormatFormattedMessage(null, callerName + ": " + format, args), null);
        }

        /// <summary>
        ///     Log a message object with the <see cref="F:Common.Logging.LogLevel.Fatal" /> level.
        /// </summary>
        /// <param name="message">The message object to log.</param>
        public override void Fatal(object message)
        {
            if (!IsFatalEnabled)
                return;
            WriteInternal(LogLevel.Fatal, message, null);
        }

        /// <summary>
        ///     Log a message object with the <see cref="F:Common.Logging.LogLevel.Fatal" /> level including
        ///     the stack Fatal of the <see cref="T:System.Exception" /> passed
        ///     as a parameter.
        /// </summary>
        /// <param name="message">The message object to log.</param>
        /// <param name="exception">The exception to log, including its stack Fatal.</param>
        public override void Fatal(object message, Exception exception)
        {
            if (!IsFatalEnabled)
                return;
            WriteInternal(LogLevel.Fatal, message, exception);
        }

        /// <summary>
        ///     Log a message with the <see cref="F:Common.Logging.LogLevel.Fatal" /> level using a callback to obtain the message
        /// </summary>
        /// <remarks>
        ///     Using this method avoids the cost of creating a message and evaluating message arguments
        ///     that probably won't be logged due to loglevel settings.
        /// </remarks>
        /// <param name="formatMessageCallback">A callback used by the logger to obtain the message if log level is matched</param>
        public override void Fatal(Action<FormatMessageHandler> formatMessageCallback)
        {
            if (!IsFatalEnabled)
                return;
            WriteInternal(LogLevel.Fatal, new FormatMessageCallbackFormattedMessage(formatMessageCallback), null);
        }

        /// <summary>
        ///     Log a message with the <see cref="F:Common.Logging.LogLevel.Fatal" /> level using a callback to obtain the message
        /// </summary>
        /// <remarks>
        ///     Using this method avoids the cost of creating a message and evaluating message arguments
        ///     that probably won't be logged due to loglevel settings.
        /// </remarks>
        /// <param name="formatMessageCallback">A callback used by the logger to obtain the message if log level is matched</param>
        /// <param name="exception">The exception to log, including its stack Fatal.</param>
        public override void Fatal(Action<FormatMessageHandler> formatMessageCallback, Exception exception)
        {
            if (!IsFatalEnabled)
                return;
            WriteInternal(LogLevel.Fatal, new FormatMessageCallbackFormattedMessage(formatMessageCallback), exception);
        }

        /// <summary>
        ///     Log a message with the <see cref="F:Common.Logging.LogLevel.Fatal" /> level using a callback to obtain the message
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
        public override void Fatal(IFormatProvider formatProvider, Action<FormatMessageHandler> formatMessageCallback)
        {
            if (!IsFatalEnabled)
                return;
            WriteInternal(LogLevel.Fatal,
                new FormatMessageCallbackFormattedMessage(formatProvider, formatMessageCallback), null);
        }

        /// <summary>
        ///     Log a message with the <see cref="F:Common.Logging.LogLevel.Fatal" /> level using a callback to obtain the message
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
        public override void Fatal(IFormatProvider formatProvider, Action<FormatMessageHandler> formatMessageCallback,
            Exception exception)
        {
            if (!IsFatalEnabled)
                return;
            WriteInternal(LogLevel.Fatal,
                new FormatMessageCallbackFormattedMessage(formatProvider, formatMessageCallback), exception);
        }

        /// <summary>
        ///     Log a message with the <see cref="F:Common.Logging.LogLevel.Fatal" /> level.
        /// </summary>
        /// <param name="formatProvider">
        ///     An <see cref="T:System.IFormatProvider" /> that supplies culture-specific formatting
        ///     Fatalrmation.
        /// </param>
        /// <param name="format">
        ///     The format of the message object to log.
        ///     <see cref="M:System.String.Format(System.String,System.Object[])" />
        /// </param>
        /// <param name="args" />
        public override void FatalFormat(IFormatProvider formatProvider, string format, params object[] args)
        {
            if (!IsFatalEnabled)
                return;
            WriteInternal(LogLevel.Fatal, new StringFormatFormattedMessage(formatProvider, format, args), null);
        }

        /// <summary>
        ///     Log a message with the <see cref="F:Common.Logging.LogLevel.Fatal" /> level.
        /// </summary>
        /// <param name="formatProvider">
        ///     An <see cref="T:System.IFormatProvider" /> that supplies culture-specific formatting
        ///     Fatalrmation.
        /// </param>
        /// <param name="format">
        ///     The format of the message object to log.
        ///     <see cref="M:System.String.Format(System.String,System.Object[])" />
        /// </param>
        /// <param name="exception">The exception to log.</param>
        /// <param name="args" />
        public override void FatalFormat(IFormatProvider formatProvider, string format, Exception exception,
            params object[] args)
        {
            if (!IsFatalEnabled)
                return;
            WriteInternal(LogLevel.Fatal, new StringFormatFormattedMessage(formatProvider, format, args), exception);
        }

        /// <summary>
        ///     Log a message with the <see cref="F:Common.Logging.LogLevel.Fatal" /> level.
        /// </summary>
        /// <param name="format">
        ///     The format of the message object to log.
        ///     <see cref="M:System.String.Format(System.String,System.Object[])" />
        /// </param>
        /// <param name="args">the list of format arguments</param>
        public override void FatalFormat(string format, params object[] args)
        {
            if (!IsFatalEnabled)
                return;
            WriteInternal(LogLevel.Fatal, new StringFormatFormattedMessage(null, format, args), null);
        }

        /// <summary>
        ///     Log a message with the <see cref="F:Common.Logging.LogLevel.Fatal" /> level.
        /// </summary>
        /// <param name="format">
        ///     The format of the message object to log.
        ///     <see cref="M:System.String.Format(System.String,System.Object[])" />
        /// </param>
        /// <param name="exception">The exception to log.</param>
        /// <param name="args">the list of format arguments</param>
        public override void FatalFormat(string format, Exception exception, params object[] args)
        {
            if (!IsFatalEnabled)
                return;
            WriteInternal(LogLevel.Fatal, new StringFormatFormattedMessage(null, format, args), exception);
        }

        /// <summary>
        ///     Log a message object with the <see cref="F:Common.Logging.LogLevel.Info" /> level.
        /// </summary>
        /// <param name="message">The message object to log.</param>
        public override void Info(object message)
        {
            if (!IsInfoEnabled)
                return;
            WriteInternal(LogLevel.Info, message, null);
        }

        /// <summary>
        ///     Log a message object with the <see cref="F:Common.Logging.LogLevel.Info" /> level including
        ///     the stack Info of the <see cref="T:System.Exception" /> passed
        ///     as a parameter.
        /// </summary>
        /// <param name="message">The message object to log.</param>
        /// <param name="exception">The exception to log, including its stack Info.</param>
        public override void Info(object message, Exception exception)
        {
            if (!IsInfoEnabled)
                return;
            WriteInternal(LogLevel.Info, message, exception);
        }

        /// <summary>
        ///     Log a message with the <see cref="F:Common.Logging.LogLevel.Info" /> level using a callback to obtain the message
        /// </summary>
        /// <remarks>
        ///     Using this method avoids the cost of creating a message and evaluating message arguments
        ///     that probably won't be logged due to loglevel settings.
        /// </remarks>
        /// <param name="formatMessageCallback">A callback used by the logger to obtain the message if log level is matched</param>
        public override void Info(Action<FormatMessageHandler> formatMessageCallback)
        {
            if (!IsInfoEnabled)
                return;
            WriteInternal(LogLevel.Info, new FormatMessageCallbackFormattedMessage(formatMessageCallback), null);
        }

        /// <summary>
        ///     Log a message with the <see cref="F:Common.Logging.LogLevel.Info" /> level using a callback to obtain the message
        /// </summary>
        /// <remarks>
        ///     Using this method avoids the cost of creating a message and evaluating message arguments
        ///     that probably won't be logged due to loglevel settings.
        /// </remarks>
        /// <param name="formatMessageCallback">A callback used by the logger to obtain the message if log level is matched</param>
        /// <param name="exception">The exception to log, including its stack Info.</param>
        public override void Info(Action<FormatMessageHandler> formatMessageCallback, Exception exception)
        {
            if (!IsInfoEnabled)
                return;
            WriteInternal(LogLevel.Info, new FormatMessageCallbackFormattedMessage(formatMessageCallback), exception);
        }

        /// <summary>
        ///     Log a message with the <see cref="F:Common.Logging.LogLevel.Info" /> level using a callback to obtain the message
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
        public override void Info(IFormatProvider formatProvider, Action<FormatMessageHandler> formatMessageCallback)
        {
            if (!IsInfoEnabled)
                return;
            WriteInternal(LogLevel.Info,
                new FormatMessageCallbackFormattedMessage(formatProvider, formatMessageCallback), null);
        }

        /// <summary>
        ///     Log a message with the <see cref="F:Common.Logging.LogLevel.Info" /> level using a callback to obtain the message
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
        public override void Info(IFormatProvider formatProvider, Action<FormatMessageHandler> formatMessageCallback,
            Exception exception)
        {
            if (!IsInfoEnabled)
                return;
            WriteInternal(LogLevel.Info,
                new FormatMessageCallbackFormattedMessage(formatProvider, formatMessageCallback), exception);
        }

        /// <summary>
        ///     Log a message object with the <see cref="F:Common.Logging.LogLevel.Info" /> level.
        /// </summary>
        /// <param name="message">The message object to log.</param>
        /// <param name="callerName"></param>
        public void InfoEx(object message, [CallerMemberName] string callerName = "")
        {
            if (!IsInfoEnabled)
                return;
            WriteInternal(LogLevel.Info, callerName + ": " + message, null);
        }

        /// <summary>
        ///     Log a message with the <see cref="F:Common.Logging.LogLevel.Info" /> level.
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
        public override void InfoFormat(IFormatProvider formatProvider, string format, params object[] args)
        {
            if (!IsInfoEnabled)
                return;
            WriteInternal(LogLevel.Info, new StringFormatFormattedMessage(formatProvider, format, args), null);
        }

        /// <summary>
        ///     Log a message with the <see cref="F:Common.Logging.LogLevel.Info" /> level.
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
        public override void InfoFormat(IFormatProvider formatProvider, string format, Exception exception,
            params object[] args)
        {
            if (!IsInfoEnabled)
                return;
            WriteInternal(LogLevel.Info, new StringFormatFormattedMessage(formatProvider, format, args), exception);
        }

        /// <summary>
        ///     Log a message with the <see cref="F:Common.Logging.LogLevel.Info" /> level.
        /// </summary>
        /// <param name="format">
        ///     The format of the message object to log.
        ///     <see cref="M:System.String.Format(System.String,System.Object[])" />
        /// </param>
        /// <param name="args">the list of format arguments</param>
        public override void InfoFormat(string format, params object[] args)
        {
            if (!IsInfoEnabled)
                return;
            WriteInternal(LogLevel.Info, new StringFormatFormattedMessage(null, format, args), null);
        }

        /// <summary>
        ///     Log a message with the <see cref="F:Common.Logging.LogLevel.Info" /> level.
        /// </summary>
        /// <param name="format">
        ///     The format of the message object to log.
        ///     <see cref="M:System.String.Format(System.String,System.Object[])" />
        /// </param>
        /// <param name="exception">The exception to log.</param>
        /// <param name="args">the list of format arguments</param>
        public override void InfoFormat(string format, Exception exception, params object[] args)
        {
            if (!IsInfoEnabled)
                return;
            WriteInternal(LogLevel.Info, new StringFormatFormattedMessage(null, format, args), exception);
        }

        /// <summary>
        ///     Log a message with the <see cref="F:Common.Logging.LogLevel.Info" /> level.
        /// </summary>
        /// <param name="format">
        ///     The format of the message object to log.
        ///     <see cref="M:System.String.Format(System.String,System.Object[])" />
        /// </param>
        /// <param name="args">the list of format arguments</param>
        /// <param name="callerName"></param>
        public void InfoFormatEx(string format, object[] args, [CallerMemberName] string callerName = "")
        {
            if (!IsInfoEnabled)
                return;
            WriteInternal(LogLevel.Info, new StringFormatFormattedMessage(null, callerName + ": " + format, args), null);
        }

        /// <summary>
        ///     Log a message object with the <see cref="F:Common.Logging.LogLevel.Trace" /> level.
        /// </summary>
        /// <param name="message">The message object to log.</param>
        public override void Trace(object message)
        {
            if (!IsTraceEnabled)
                return;
            WriteInternal(LogLevel.Trace, message, null);
        }

        /// <summary>
        ///     Log a message object with the <see cref="F:Common.Logging.LogLevel.Trace" /> level including
        ///     the stack trace of the <see cref="T:System.Exception" /> passed
        ///     as a parameter.
        /// </summary>
        /// <param name="message">The message object to log.</param>
        /// <param name="exception">The exception to log, including its stack trace.</param>
        public override void Trace(object message, Exception exception)
        {
            if (!IsTraceEnabled)
                return;
            WriteInternal(LogLevel.Trace, message, exception);
        }

        /// <summary>
        ///     Log a message with the <see cref="F:Common.Logging.LogLevel.Trace" /> level using a callback to obtain the message
        /// </summary>
        /// <remarks>
        ///     Using this method avoids the cost of creating a message and evaluating message arguments
        ///     that probably won't be logged due to loglevel settings.
        /// </remarks>
        /// <param name="formatMessageCallback">A callback used by the logger to obtain the message if log level is matched</param>
        public override void Trace(Action<FormatMessageHandler> formatMessageCallback)
        {
            if (!IsTraceEnabled)
                return;
            WriteInternal(LogLevel.Trace, new FormatMessageCallbackFormattedMessage(formatMessageCallback), null);
        }

        /// <summary>
        ///     Log a message with the <see cref="F:Common.Logging.LogLevel.Trace" /> level using a callback to obtain the message
        /// </summary>
        /// <remarks>
        ///     Using this method avoids the cost of creating a message and evaluating message arguments
        ///     that probably won't be logged due to loglevel settings.
        /// </remarks>
        /// <param name="formatMessageCallback">A callback used by the logger to obtain the message if log level is matched</param>
        /// <param name="exception">The exception to log, including its stack trace.</param>
        public override void Trace(Action<FormatMessageHandler> formatMessageCallback, Exception exception)
        {
            if (!IsTraceEnabled)
                return;
            WriteInternal(LogLevel.Trace, new FormatMessageCallbackFormattedMessage(formatMessageCallback), exception);
        }

        /// <summary>
        ///     Log a message with the <see cref="F:Common.Logging.LogLevel.Trace" /> level using a callback to obtain the message
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
        public override void Trace(IFormatProvider formatProvider, Action<FormatMessageHandler> formatMessageCallback)
        {
            if (!IsTraceEnabled)
                return;
            WriteInternal(LogLevel.Trace,
                new FormatMessageCallbackFormattedMessage(formatProvider, formatMessageCallback), null);
        }

        /// <summary>
        ///     Log a message with the <see cref="F:Common.Logging.LogLevel.Trace" /> level using a callback to obtain the message
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
        public override void Trace(IFormatProvider formatProvider, Action<FormatMessageHandler> formatMessageCallback,
            Exception exception)
        {
            if (!IsTraceEnabled)
                return;
            WriteInternal(LogLevel.Trace,
                new FormatMessageCallbackFormattedMessage(formatProvider, formatMessageCallback), exception);
        }

        /// <summary>
        ///     Log a message object with the <see cref="F:Common.Logging.LogLevel.Trace" /> level.
        /// </summary>
        /// <param name="message">The message object to log.</param>
        /// <param name="callerName"></param>
        public void TraceEx(object message, [CallerMemberName] string callerName = "")
        {
            if (!IsTraceEnabled)
                return;
            WriteInternal(LogLevel.Trace, callerName + ": " + message, null);
        }

        /// <summary>
        ///     Log a message with the <see cref="F:Common.Logging.LogLevel.Trace" /> level.
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
        public override void TraceFormat(IFormatProvider formatProvider, string format, params object[] args)
        {
            if (!IsTraceEnabled)
                return;
            WriteInternal(LogLevel.Trace, new StringFormatFormattedMessage(formatProvider, format, args), null);
        }

        /// <summary>
        ///     Log a message with the <see cref="F:Common.Logging.LogLevel.Trace" /> level.
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
        public override void TraceFormat(IFormatProvider formatProvider, string format, Exception exception,
            params object[] args)
        {
            if (!IsTraceEnabled)
                return;
            WriteInternal(LogLevel.Trace, new StringFormatFormattedMessage(formatProvider, format, args), exception);
        }

        /// <summary>
        ///     Log a message with the <see cref="F:Common.Logging.LogLevel.Trace" /> level.
        /// </summary>
        /// <param name="format">
        ///     The format of the message object to log.
        ///     <see cref="M:System.String.Format(System.String,System.Object[])" />
        /// </param>
        /// <param name="args">the list of format arguments</param>
        public override void TraceFormat(string format, params object[] args)
        {
            if (!IsTraceEnabled)
                return;
            WriteInternal(LogLevel.Trace, new StringFormatFormattedMessage(null, format, args), null);
        }

        /// <summary>
        ///     Log a message with the <see cref="F:Common.Logging.LogLevel.Trace" /> level.
        /// </summary>
        /// <param name="format">
        ///     The format of the message object to log.
        ///     <see cref="M:System.String.Format(System.String,System.Object[])" />
        /// </param>
        /// <param name="exception">The exception to log.</param>
        /// <param name="args">the list of format arguments</param>
        public new virtual void TraceFormat(string format, Exception exception, params object[] args)
        {
            if (!IsTraceEnabled)
                return;
            WriteInternal(LogLevel.Trace, new StringFormatFormattedMessage(null, format, args), exception);
        }

        /// <summary>
        ///     Log a message object with the <see cref="F:Common.Logging.LogLevel.Warn" /> level.
        /// </summary>
        /// <param name="message">The message object to log.</param>
        public override void Warn(object message)
        {
            if (!IsWarnEnabled)
                return;
            WriteInternal(LogLevel.Warn, message, null);
        }


        /// <summary>
        ///     Log a message object with the <see cref="F:Common.Logging.LogLevel.Warn" /> level including
        ///     the stack Warn of the <see cref="T:System.Exception" /> passed
        ///     as a parameter.
        /// </summary>
        /// <param name="message">The message object to log.</param>
        /// <param name="exception">The exception to log, including its stack Warn.</param>
        public override void Warn(object message, Exception exception)
        {
            if (!IsWarnEnabled)
                return;
            WriteInternal(LogLevel.Warn, message, exception);
        }

        /// <summary>
        ///     Log a message with the <see cref="F:Common.Logging.LogLevel.Warn" /> level using a callback to obtain the message
        /// </summary>
        /// <remarks>
        ///     Using this method avoids the cost of creating a message and evaluating message arguments
        ///     that probably won't be logged due to loglevel settings.
        /// </remarks>
        /// <param name="formatMessageCallback">A callback used by the logger to obtain the message if log level is matched</param>
        public override void Warn(Action<FormatMessageHandler> formatMessageCallback)
        {
            if (!IsWarnEnabled)
                return;
            WriteInternal(LogLevel.Warn, new FormatMessageCallbackFormattedMessage(formatMessageCallback), null);
        }

        /// <summary>
        ///     Log a message with the <see cref="F:Common.Logging.LogLevel.Warn" /> level using a callback to obtain the message
        /// </summary>
        /// <remarks>
        ///     Using this method avoids the cost of creating a message and evaluating message arguments
        ///     that probably won't be logged due to loglevel settings.
        /// </remarks>
        /// <param name="formatMessageCallback">A callback used by the logger to obtain the message if log level is matched</param>
        /// <param name="exception">The exception to log, including its stack Warn.</param>
        public override void Warn(Action<FormatMessageHandler> formatMessageCallback, Exception exception)
        {
            if (!IsWarnEnabled)
                return;
            WriteInternal(LogLevel.Warn, new FormatMessageCallbackFormattedMessage(formatMessageCallback), exception);
        }

        /// <summary>
        ///     Log a message with the <see cref="F:Common.Logging.LogLevel.Warn" /> level using a callback to obtain the message
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
        public override void Warn(IFormatProvider formatProvider, Action<FormatMessageHandler> formatMessageCallback)
        {
            if (!IsWarnEnabled)
                return;
            WriteInternal(LogLevel.Warn,
                new FormatMessageCallbackFormattedMessage(formatProvider, formatMessageCallback), null);
        }

        /// <summary>
        ///     Log a message with the <see cref="F:Common.Logging.LogLevel.Warn" /> level using a callback to obtain the message
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
        public override void Warn(IFormatProvider formatProvider, Action<FormatMessageHandler> formatMessageCallback,
            Exception exception)
        {
            if (!IsWarnEnabled)
                return;
            WriteInternal(LogLevel.Warn,
                new FormatMessageCallbackFormattedMessage(formatProvider, formatMessageCallback), exception);
        }

        /// <summary>
        ///     Log a message object with the <see cref="F:Common.Logging.LogLevel.Warn" /> level.
        /// </summary>
        /// <param name="message">The message object to log.</param>
        /// <param name="callerName"></param>
        public void WarnEx(object message, [CallerMemberName] string callerName = "")
        {
            if (!IsWarnEnabled)
                return;
            WriteInternal(LogLevel.Warn, callerName + ": " + message, null);
        }

        public void WarnEx(object message, Exception exception, [CallerMemberName] string callerName = "")
        {
            if (!IsWarnEnabled)
                return;
            WriteInternal(LogLevel.Warn, callerName + ": " + message, exception);
        }

        /// <summary>
        ///     Log a message with the <see cref="F:Common.Logging.LogLevel.Warn" /> level.
        /// </summary>
        /// <param name="formatProvider">
        ///     An <see cref="T:System.IFormatProvider" /> that supplies culture-specific formatting
        ///     Warnrmation.
        /// </param>
        /// <param name="format">
        ///     The format of the message object to log.
        ///     <see cref="M:System.String.Format(System.String,System.Object[])" />
        /// </param>
        /// <param name="args" />
        public override void WarnFormat(IFormatProvider formatProvider, string format, params object[] args)
        {
            if (!IsWarnEnabled)
                return;
            WriteInternal(LogLevel.Warn, new StringFormatFormattedMessage(formatProvider, format, args), null);
        }

        /// <summary>
        ///     Log a message with the <see cref="F:Common.Logging.LogLevel.Warn" /> level.
        /// </summary>
        /// <param name="formatProvider">
        ///     An <see cref="T:System.IFormatProvider" /> that supplies culture-specific formatting
        ///     Warnrmation.
        /// </param>
        /// <param name="format">
        ///     The format of the message object to log.
        ///     <see cref="M:System.String.Format(System.String,System.Object[])" />
        /// </param>
        /// <param name="exception">The exception to log.</param>
        /// <param name="args" />
        public override void WarnFormat(IFormatProvider formatProvider, string format, Exception exception,
            params object[] args)
        {
            if (!IsWarnEnabled)
                return;
            WriteInternal(LogLevel.Warn, new StringFormatFormattedMessage(formatProvider, format, args), exception);
        }

        /// <summary>
        ///     Log a message with the <see cref="F:Common.Logging.LogLevel.Warn" /> level.
        /// </summary>
        /// <param name="format">
        ///     The format of the message object to log.
        ///     <see cref="M:System.String.Format(System.String,System.Object[])" />
        /// </param>
        /// <param name="args">the list of format arguments</param>
        public override void WarnFormat(string format, params object[] args)
        {
            if (!IsWarnEnabled)
                return;
            WriteInternal(LogLevel.Warn, new StringFormatFormattedMessage(null, format, args), null);
        }

        /// <summary>
        ///     Log a message with the <see cref="F:Common.Logging.LogLevel.Warn" /> level.
        /// </summary>
        /// <param name="format">
        ///     The format of the message object to log.
        ///     <see cref="M:System.String.Format(System.String,System.Object[])" />
        /// </param>
        /// <param name="exception">The exception to log.</param>
        /// <param name="args">the list of format arguments</param>
        public override void WarnFormat(string format, Exception exception, params object[] args)
        {
            if (!IsWarnEnabled)
                return;
            WriteInternal(LogLevel.Warn, new StringFormatFormattedMessage(null, format, args), exception);
        }

        /// <summary>
        ///     Log a message with the <see cref="F:Common.Logging.LogLevel.Warn" /> level.
        /// </summary>
        /// <param name="format">
        ///     The format of the message object to log.
        ///     <see cref="M:System.String.Format(System.String,System.Object[])" />
        /// </param>
        /// <param name="args">the list of format arguments</param>
        /// <param name="callerName"></param>
        public void WarnFormatEx(string format, object[] args, [CallerMemberName] string callerName = "")
        {
            if (!IsWarnEnabled)
                return;
            WriteInternal(LogLevel.Warn, new StringFormatFormattedMessage(null, callerName + ": " + format, args), null);
        }

        /// <summary>
        ///     Actually sends the message to the underlying log system.
        /// </summary>
        /// <param name="logLevel">the level of this log event.</param>
        /// <param name="message">the message to log</param>
        /// <param name="exception">the exception to log (may be null)</param>
        protected override void WriteInternal(LogLevel logLevel, object message, Exception exception)
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