using System;
using JetBrains.Annotations;

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