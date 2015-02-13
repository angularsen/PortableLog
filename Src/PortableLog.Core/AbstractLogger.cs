using System;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;

namespace PortableLog.Core
{
    [PublicAPI]
    public abstract class AbstractLogger : ILog
    {
        private readonly WriteHandler _write;

        protected AbstractLogger(WriteHandler write = null)
        {
            _write = write ?? WriteInternal;
        }

        public abstract bool IsDebugEnabled { get; }
        public abstract bool IsErrorEnabled { get; }
        public abstract bool IsFatalEnabled { get; }
        public abstract bool IsInfoEnabled { get; }
        public abstract bool IsTraceEnabled { get; }
        public abstract bool IsWarnEnabled { get; }

        public virtual void Trace(string message, [CallerMemberName] string callerMemberName = "")
        {
            if (IsTraceEnabled)
                _write(LogLevel.Trace, message, null, callerMemberName);
        }

        public virtual void Trace(Func<FormatMessageHandler, string> formatMessageCallback,
            [CallerMemberName] string callerMemberName = "")
        {
            if (IsTraceEnabled)
                _write(LogLevel.Trace, formatMessageCallback(Format), null, callerMemberName);
        }

        public virtual void Trace(IFormatProvider formatProvider,
            Func<FormatMessageHandler, string> formatMessageCallback, [CallerMemberName] string callerMemberName = "")
        {
            if (IsTraceEnabled)
                _write(LogLevel.Trace, new CallbackStringFormatter(formatProvider, formatMessageCallback),
                    null, callerMemberName);
        }

        public virtual void Debug(string message, [CallerMemberName] string callerMemberName = "")
        {
            if (IsDebugEnabled)
                _write(LogLevel.Debug, message, null, callerMemberName);
        }

        public virtual void Debug(Func<FormatMessageHandler, string> formatMessageCallback,
            [CallerMemberName] string callerMemberName = "")
        {
            if (IsDebugEnabled)
                _write(LogLevel.Debug, formatMessageCallback(Format), null, callerMemberName);
        }

        public virtual void Debug(IFormatProvider formatProvider,
            Func<FormatMessageHandler, string> formatMessageCallback, [CallerMemberName] string callerMemberName = "")
        {
            if (IsDebugEnabled)
                _write(LogLevel.Debug, new CallbackStringFormatter(formatProvider, formatMessageCallback),
                    null, callerMemberName);
        }

        public virtual void Info(string message, [CallerMemberName] string callerMemberName = "")
        {
            if (IsInfoEnabled)
                _write(LogLevel.Info, message, null, callerMemberName);
        }

        public virtual void Info(Func<FormatMessageHandler, string> formatMessageCallback,
            [CallerMemberName] string callerMemberName = "")
        {
            if (IsInfoEnabled)
                _write(LogLevel.Info, formatMessageCallback(Format), null, callerMemberName);
        }

        public virtual void Info(IFormatProvider formatProvider,
            Func<FormatMessageHandler, string> formatMessageCallback, [CallerMemberName] string callerMemberName = "")
        {
            if (IsInfoEnabled)
                _write(LogLevel.Info, new CallbackStringFormatter(formatProvider, formatMessageCallback),
                    null, callerMemberName);
        }

        public virtual void Warn(string message, [CallerMemberName] string callerMemberName = "")
        {
            if (IsWarnEnabled)
                _write(LogLevel.Warn, message, null, callerMemberName);
        }

        public virtual void Warn(Func<FormatMessageHandler, string> formatMessageCallback,
            [CallerMemberName] string callerMemberName = "")
        {
            if (IsWarnEnabled)
                _write(LogLevel.Warn, formatMessageCallback(Format), null, callerMemberName);
        }

        public virtual void Warn(IFormatProvider formatProvider,
            Func<FormatMessageHandler, string> formatMessageCallback, [CallerMemberName] string callerMemberName = "")
        {
            if (IsWarnEnabled)
                _write(LogLevel.Warn, new CallbackStringFormatter(formatProvider, formatMessageCallback),
                    null, callerMemberName);
        }

        public virtual void Error(string message, [CallerMemberName] string callerMemberName = "")
        {
            if (IsErrorEnabled)
                _write(LogLevel.Error, message, null, callerMemberName);
        }

        public virtual void Error(Func<FormatMessageHandler, string> formatMessageCallback,
            [CallerMemberName] string callerMemberName = "")
        {
            if (IsErrorEnabled)
                _write(LogLevel.Error, formatMessageCallback(Format), null, callerMemberName);
        }

        public virtual void Error(IFormatProvider formatProvider,
            Func<FormatMessageHandler, string> formatMessageCallback, [CallerMemberName] string callerMemberName = "")
        {
            if (IsErrorEnabled)
                _write(LogLevel.Error, new CallbackStringFormatter(formatProvider, formatMessageCallback),
                    null, callerMemberName);
        }

        public virtual void Fatal(string message, [CallerMemberName] string callerMemberName = "")
        {
            if (IsFatalEnabled)
                _write(LogLevel.Fatal, message, null, callerMemberName);
        }

        public virtual void Fatal(Func<FormatMessageHandler, string> formatMessageCallback,
            [CallerMemberName] string callerMemberName = "")
        {
            if (IsFatalEnabled)
                _write(LogLevel.Fatal, formatMessageCallback(Format), null, callerMemberName);
        }

        public virtual void Fatal(IFormatProvider formatProvider,
            Func<FormatMessageHandler, string> formatMessageCallback, [CallerMemberName] string callerMemberName = "")
        {
            if (IsFatalEnabled)
                _write(LogLevel.Fatal, new CallbackStringFormatter(formatProvider, formatMessageCallback),
                    null, callerMemberName);
        }

        public virtual void Trace(Exception exception, object message, [CallerMemberName] string callerMemberName = "")
        {
            if (IsTraceEnabled)
                _write(LogLevel.Trace, message, exception, callerMemberName);
        }

        public virtual void Trace(Exception exception, Func<FormatMessageHandler, string> formatMessageCallback,
            [CallerMemberName] string callerMemberName = "")
        {
            if (IsTraceEnabled)
                _write(LogLevel.Trace, formatMessageCallback(Format), exception, callerMemberName);
        }

        public virtual void Trace(Exception exception, IFormatProvider formatProvider,
            Func<FormatMessageHandler, string> formatMessageCallback, [CallerMemberName] string callerMemberName = "")
        {
            if (IsTraceEnabled)
                _write(LogLevel.Trace, new CallbackStringFormatter(formatProvider, formatMessageCallback),
                    exception, callerMemberName);
        }

        public virtual void Debug(Exception exception, object message, [CallerMemberName] string callerMemberName = "")
        {
            if (IsDebugEnabled)
                _write(LogLevel.Debug, message, exception, callerMemberName);
        }

        public virtual void Debug(Exception exception, Func<FormatMessageHandler, string> formatMessageCallback,
            [CallerMemberName] string callerMemberName = "")
        {
            if (IsDebugEnabled)
                _write(LogLevel.Debug, formatMessageCallback(Format), exception, callerMemberName);
        }

        public virtual void Debug(Exception exception, IFormatProvider formatProvider,
            Func<FormatMessageHandler, string> formatMessageCallback, [CallerMemberName] string callerMemberName = "")
        {
            if (IsDebugEnabled)
                _write(LogLevel.Debug, new CallbackStringFormatter(formatProvider, formatMessageCallback),
                    exception, callerMemberName);
        }

        public virtual void Info(Exception exception, object message, [CallerMemberName] string callerMemberName = "")
        {
            if (IsInfoEnabled)
                _write(LogLevel.Info, message, exception, callerMemberName);
        }

        public virtual void Info(Exception exception, Func<FormatMessageHandler, string> formatMessageCallback,
            [CallerMemberName] string callerMemberName = "")
        {
            if (IsInfoEnabled)
                _write(LogLevel.Info, formatMessageCallback(Format), exception, callerMemberName);
        }

        public virtual void Info(Exception exception, IFormatProvider formatProvider,
            Func<FormatMessageHandler, string> formatMessageCallback, [CallerMemberName] string callerMemberName = "")
        {
            if (IsInfoEnabled)
                _write(LogLevel.Info, new CallbackStringFormatter(formatProvider, formatMessageCallback),
                    exception, callerMemberName);
        }

        public virtual void Warn(Exception exception, object message, [CallerMemberName] string callerMemberName = "")
        {
            if (IsWarnEnabled)
                _write(LogLevel.Warn, message, exception, callerMemberName);
        }

        public virtual void Warn(Exception exception, Func<FormatMessageHandler, string> formatMessageCallback,
            [CallerMemberName] string callerMemberName = "")
        {
            if (IsWarnEnabled)
                _write(LogLevel.Warn, formatMessageCallback(Format), exception, callerMemberName);
        }

        public virtual void Warn(Exception exception, IFormatProvider formatProvider,
            Func<FormatMessageHandler, string> formatMessageCallback, [CallerMemberName] string callerMemberName = "")
        {
            if (IsWarnEnabled)
                _write(LogLevel.Warn, new CallbackStringFormatter(formatProvider, formatMessageCallback),
                    exception, callerMemberName);
        }

        public virtual void Error(Exception exception, object message, [CallerMemberName] string callerMemberName = "")
        {
            if (IsErrorEnabled)
                _write(LogLevel.Error, message, exception, callerMemberName);
        }

        public virtual void Error(Exception exception, Func<FormatMessageHandler, string> formatMessageCallback,
            [CallerMemberName] string callerMemberName = "")
        {
            if (IsErrorEnabled)
                _write(LogLevel.Error, formatMessageCallback(Format), exception, callerMemberName);
        }

        public virtual void Error(Exception exception, IFormatProvider formatProvider,
            Func<FormatMessageHandler, string> formatMessageCallback, [CallerMemberName] string callerMemberName = "")
        {
            if (IsErrorEnabled)
                _write(LogLevel.Error, new CallbackStringFormatter(formatProvider, formatMessageCallback),
                    exception, callerMemberName);
        }

        public virtual void Fatal(Exception exception, object message, [CallerMemberName] string callerMemberName = "")
        {
            if (IsFatalEnabled)
                _write(LogLevel.Fatal, message, exception, callerMemberName);
        }

        public virtual void Fatal(Exception exception, Func<FormatMessageHandler, string> formatMessageCallback,
            [CallerMemberName] string callerMemberName = "")
        {
            if (IsFatalEnabled)
                _write(LogLevel.Fatal, formatMessageCallback(Format), exception, callerMemberName);
        }

        public virtual void Fatal(Exception exception, IFormatProvider formatProvider,
            Func<FormatMessageHandler, string> formatMessageCallback, [CallerMemberName] string callerMemberName = "")
        {
            if (IsFatalEnabled)
                _write(LogLevel.Fatal, new CallbackStringFormatter(formatProvider, formatMessageCallback),
                    exception, callerMemberName);
        }

        private void WriteInternal(LogLevel level, object message, Exception exception,
            [CanBeNull] string callerMemberName)
        {
            // Prefix with caller member name if any
            var modifiedMessage = callerMemberName == null
                ? message
                : callerMemberName + ": " + message;

            Write(level, modifiedMessage, exception, callerMemberName);
        }

        protected abstract void Write(LogLevel level, object message, Exception exception,
            [CanBeNull] string callerMemberName);

        private string Format(IFormatProvider formatProvider, string format, params object[] args)
        {
            return string.Format(formatProvider, format, args);
        }

        private string Format(string format, params object[] args)
        {
            return string.Format(format, args);
        }

        protected delegate void WriteHandler(
            LogLevel level, object message, Exception exception, [CanBeNull] string callerMemberName);
    }
}