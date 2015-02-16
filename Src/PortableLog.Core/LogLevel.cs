using PortableLog.Core.Properties;

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