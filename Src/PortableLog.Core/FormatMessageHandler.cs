using PortableLog.Core.Properties;

namespace PortableLog.Core
{
    /// <summary>
    ///     Formatted message handler. Useful when log arguments are expensive and we don't want to spend CPU time on them if
    ///     the log level is disabled.
    /// </summary>
    /// <param name="format">
    ///     The format argument as in <see cref="M:System.String.Format(System.String,System.Object[])" />
    /// </param>
    /// <param name="args">The argument list as in <see cref="M:System.String.Format(System.String,System.Object[])" /></param>
    [StringFormatMethod("format")]
    public delegate string FormatMessageHandler(string format, params object[] args);
}