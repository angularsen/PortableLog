using System;

namespace PortableLog.Core
{
    public interface ILogExFactory
    {
        ILogEx GetLogger(string loggerName);
        ILogEx GetLogger(Type type);
        ILogEx GetLogger<T>();
    }
}