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
        /// <param name="callerName"></param>
        void DebugEx(object message, [CallerMemberName] string callerName = "");

        /// <summary>
        ///     Log a message with the <see cref="F:LogLevel.Debug" /> level.
        /// </summary>
        /// <param name="format">
        ///     The format of the message object to log.
        ///     <see cref="M:System.String.Format(System.String,System.Object[])" />
        /// </param>
        /// <param name="args">the list of format arguments</param>
        /// <param name="callerName"></param>
        void DebugFormatEx(string format, object[] args, [CallerMemberName] string callerName = "");

        /// <summary>
        ///     Log a message object with the <see cref="F:LogLevel.Error" /> level.
        /// </summary>
        /// <param name="message">The message object to log.</param>
        /// <param name="callerName"></param>
        void ErrorEx(object message, [CallerMemberName] string callerName = "");

        void ErrorEx(object message, Exception exception, [CallerMemberName] string callerName = "");

        /// <summary>
        ///     Log a message with the <see cref="F:LogLevel.Info" /> level.
        /// </summary>
        /// <param name="format">
        ///     The format of the message object to log.
        ///     <see cref="M:System.String.Format(System.String,System.Object[])" />
        /// </param>
        /// <param name="args">the list of format arguments</param>
        /// <param name="callerName"></param>
        void ErrorFormatEx(string format, object[] args, [CallerMemberName] string callerName = "");

        /// <summary>
        ///     Log a message object with the <see cref="F:LogLevel.Info" /> level.
        /// </summary>
        /// <param name="message">The message object to log.</param>
        /// <param name="callerName"></param>
        void InfoEx(object message, [CallerMemberName] string callerName = "");

        /// <summary>
        ///     Log a message with the <see cref="F:LogLevel.Info" /> level.
        /// </summary>
        /// <param name="format">
        ///     The format of the message object to log.
        ///     <see cref="M:System.String.Format(System.String,System.Object[])" />
        /// </param>
        /// <param name="args">the list of format arguments</param>
        /// <param name="callerName"></param>
        void InfoFormatEx(string format, object[] args, [CallerMemberName] string callerName = "");

        void TraceEx(object message, [CallerMemberName] string callerName = "");

        /// <summary>
        ///     Log a message object with the <see cref="F:LogLevel.Warn" /> level.
        /// </summary>
        /// <param name="message">The message object to log.</param>
        /// <param name="callerName"></param>
        void WarnEx(object message, [CallerMemberName] string callerName = "");

        void WarnEx(object message, Exception exception, [CallerMemberName] string callerName = "");

        /// <summary>
        ///     Log a message with the <see cref="F:LogLevel.Warn" /> level.
        /// </summary>
        /// <param name="format">
        ///     The format of the message object to log.
        ///     <see cref="M:System.String.Format(System.String,System.Object[])" />
        /// </param>
        /// <param name="args">the list of format arguments</param>
        /// <param name="callerName"></param>
        void WarnFormatEx(string format, object[] args, [CallerMemberName] string callerName = "");
    }
}