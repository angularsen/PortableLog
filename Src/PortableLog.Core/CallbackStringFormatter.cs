using System;
using PortableLog.Core.Properties;

namespace PortableLog.Core
{
    /// <summary>
    ///     Defer formatting of message, parameters passed in via callback.
    /// </summary>
    public class CallbackStringFormatter
    {
        [CanBeNull] private readonly IFormatProvider _formatProvider;
        [NotNull] private readonly Lazy<string> _formattedMessageLazy;

        /// <summary>
        ///     Initializes a new instance of the <see cref="CallbackStringFormatter" /> class.
        /// </summary>
        /// <param name="formatMessageCallback">The format message callback.</param>
        public CallbackStringFormatter([NotNull] Func<FormatMessageHandler, string> formatMessageCallback)
        {
            if (formatMessageCallback == null) throw new ArgumentNullException("formatMessageCallback");
            _formattedMessageLazy = new Lazy<string>(() => formatMessageCallback(FormatMessage));
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="CallbackStringFormatter" /> class.
        /// </summary>
        /// <param name="formatProvider">The format provider.</param>
        /// <param name="formatMessageCallback">The format message callback.</param>
        public CallbackStringFormatter(IFormatProvider formatProvider,
            Func<FormatMessageHandler, string> formatMessageCallback)
        {
            _formatProvider = formatProvider;
            _formattedMessageLazy = new Lazy<string>(() => formatMessageCallback(FormatMessage));
        }

        /// <summary>
        ///     Returns cached, formatted string.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return _formattedMessageLazy.Value;
        }

        private string FormatMessage(string format, params object[] args)
        {
            return string.Format(_formatProvider, format, args);
        }
    }
}