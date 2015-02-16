using System;
using PortableLog.Core.Properties;

namespace PortableLog.Core
{
    [PublicAPI]
    public interface ILogFactory
    {
        ILog GetLogger(string loggerName);
        ILog GetLogger(Type type);
        ILog GetLogger<T>();
    }
}