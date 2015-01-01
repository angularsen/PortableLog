using System;
using PortableLog.Core.Properties;

namespace PortableLog.Core
{
    /// <summary>
    ///     Defer formatting of string.
    /// </summary>
    public class StringFormatter
    {
        [NotNull] private readonly Lazy<string> _formattedMessageLazy;

        /// <summary>
        ///     Initializes a new instance of the <see cref="StringFormatter" /> class.
        /// </summary>
        /// <param name="formatProvider">The format provider.</param>
        /// <param name="message">The message.</param>
        /// <param name="args">The args.</param>
        public StringFormatter(IFormatProvider formatProvider, string message, params object[] args)
        {
            _formattedMessageLazy = new Lazy<string>(() => string.Format(formatProvider, message, args));
        }

        /// <summary>
        ///     Runs <see cref="string.Format(System.IFormatProvider,string,object[])" /> on supplied arguemnts.
        /// </summary>
        /// <returns>string</returns>
        public override string ToString()
        {
            return _formattedMessageLazy.Value;
        }
    }
}