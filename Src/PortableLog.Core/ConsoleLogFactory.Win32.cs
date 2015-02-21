using System;

namespace PortableLog.Core
{
    public class ConsoleLogFactory : ILogFactory
    {
        public ILog GetLogger(string loggerName)
        {
            return new ConsoleLogger(loggerName);
        }

        public ILog GetLogger(Type type)
        {
            return new ConsoleLogger(type.Name);
        }

        public ILog GetLogger<T>()
        {
            return new ConsoleLogger(typeof(T).Name);
        }
    }
}