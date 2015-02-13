using JetBrains.Annotations;

namespace PortableLog.Core
{
    [PublicAPI]
    public enum LogLevel
    {
        All,
        Trace,
        Debug,
        Info,
        Warn,
        Error,
        Fatal,
        Off,
    }
}