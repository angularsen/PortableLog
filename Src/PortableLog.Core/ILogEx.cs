using System;
using System.Runtime.CompilerServices;

namespace PortableLog.Core
{
    public interface ILogEx : ILog
    {
        /// <summary>
        ///     Log a message object with the <see cref="F:LogLevel.Debug" /> level.
        /// </summary>
        /// <param name="message">The message object to log.</param>
        /// <param name="callerMemberName">Name of method or property calling this method. Will be included in log message.</param>
        void DebugEx(object message, [CallerMemberName] string callerMemberName = "");

        /// <summary>
        ///     Log a message with the <see cref="F:LogLevel.Debug" /> level.
        /// </summary>
        /// <param name="format">
        ///     The format of the message object to log.
        ///     <see cref="M:System.String.Format(System.String,System.Object[])" />
        /// </param>
        /// <param name="args">the list of format arguments</param>
        /// <param name="callerMemberName">Name of method or property calling this method. Will be included in log message.</param>
        void DebugFormatEx(string format, object[] args, [CallerMemberName] string callerMemberName = "");

        /// <summary>
        ///     Log a message object with the <see cref="F:LogLevel.Error" /> level.
        /// </summary>
        /// <param name="message">The message object to log.</param>
        /// <param name="callerMemberName">Name of method or property calling this method. Will be included in log message.</param>
        void ErrorEx(object message, [CallerMemberName] string callerMemberName = "");

        /// <summary>
        ///     Log a message with the <see cref="F:LogLevel.Error" /> level.
        /// </summary>
        /// <param name="exception">The exception to log, including its stack trace.</param>
        /// <param name="message">The message object to log.</param>
        /// <param name="callerMemberName">Name of method or property calling this method. Will be included in log message.</param>
        void ErrorEx(Exception exception, object message, [CallerMemberName] string callerMemberName = "");

        /// <summary>
        ///     Log a message with the <see cref="F:LogLevel.Error" /> level.
        /// </summary>
        /// <param name="format">
        ///     The format of the message object to log.
        ///     <see cref="M:System.String.Format(System.String,System.Object[])" />
        /// </param>
        /// <param name="args">the list of format arguments</param>
        /// <param name="callerMemberName">Name of method or property calling this method. Will be included in log message.</param>
        void ErrorFormatEx(string format, object[] args, [CallerMemberName] string callerMemberName = "");

        /// <summary>
        ///     Log a message object with the <see cref="F:LogLevel.Info" /> level.
        /// </summary>
        /// <param name="message">The message object to log.</param>
        /// <param name="callerMemberName">Name of method or property calling this method. Will be included in log message.</param>
        void InfoEx(object message, [CallerMemberName] string callerMemberName = "");

        /// <summary>
        ///     Log a message with the <see cref="F:LogLevel.Info" /> level.
        /// </summary>
        /// <param name="format">
        ///     The format of the message object to log.
        ///     <see cref="M:System.String.Format(System.String,System.Object[])" />
        /// </param>
        /// <param name="args">the list of format arguments</param>
        /// <param name="callerMemberName">Name of method or property calling this method. Will be included in log message.</param>
        void InfoFormatEx(string format, object[] args, [CallerMemberName] string callerMemberName = "");


        /// <summary>
        ///     Log a message object with the <see cref="F:LogLevel.Trace" /> level.
        /// </summary>
        /// <param name="message">The message object to log.</param>
        /// <param name="callerMemberName">Name of method or property calling this method. Will be included in log message.</param>
        void TraceEx(object message, [CallerMemberName] string callerMemberName = "");

        /// <summary>
        ///     Log a message with the <see cref="F:LogLevel.Trace" /> level.
        /// </summary>
        /// <param name="format">
        ///     The format of the message object to log.
        ///     <see cref="M:System.String.Format(System.String,System.Object[])" />
        /// </param>
        /// <param name="args">the list of format arguments</param>
        /// <param name="callerMemberName">Name of method or property calling this method. Will be included in log message.</param>
        void TraceFormatEx(string format, object[] args, [CallerMemberName] string callerMemberName = "");

        /// <summary>
        ///     Log a message object with the <see cref="F:LogLevel.Warn" /> level.
        /// </summary>
        /// <param name="message">The message object to log.</param>
        /// <param name="callerMemberName">Name of method or property calling this method. Will be included in log message.</param>
        void WarnEx(object message, [CallerMemberName] string callerMemberName = "");

        /// <summary>
        ///     Log a message with the <see cref="F:LogLevel.Warn" /> level.
        /// </summary>
        /// <param name="exception">The exception to log, including its stack trace.</param>
        /// <param name="message">The message object to log.</param>
        /// <param name="callerMemberName">Name of method or property calling this method. Will be included in log message.</param>
        void WarnEx(Exception exception, object message, [CallerMemberName] string callerMemberName = "");

        /// <summary>
        ///     Log a message with the <see cref="F:LogLevel.Warn" /> level.
        /// </summary>
        /// <param name="format">
        ///     The format of the message object to log.
        ///     <see cref="M:System.String.Format(System.String,System.Object[])" />
        /// </param>
        /// <param name="args">the list of format arguments</param>
        /// <param name="callerMemberName">Name of method or property calling this method. Will be included in log message.</param>
        void WarnFormatEx(string format, object[] args, [CallerMemberName] string callerMemberName = "");

        /// <summary>
        ///     Log a message with the <see cref="F:LogLevel.Warn" /> level.
        /// </summary>
        /// <param name="format">
        ///     The format of the message object to log.
        ///     <see cref="M:System.String.Format(System.String,System.Object[])" />
        /// </param>
        /// <param name="exception">The exception to log.</param>
        /// <param name="args">the list of format arguments</param>
        /// <param name="callerMemberName">Name of method or property calling this method. Will be included in log message.</param>
        void WarnFormatEx(Exception exception, string format, object[] args,
            [CallerMemberName] string callerMemberName = "");
    }
}