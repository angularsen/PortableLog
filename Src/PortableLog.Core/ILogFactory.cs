using System;

namespace PortableLog.Core
{
    public interface ILogFactory
    {
        ILogEx GetLogger(string loggerName);
        ILogEx GetLogger(Type type);
        ILogEx GetLogger<T>();
    }
}