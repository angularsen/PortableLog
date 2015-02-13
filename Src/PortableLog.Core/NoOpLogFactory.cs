using System;

namespace PortableLog.Core
{
    public class NoOpLogFactory : ILogFactory
    {
        public ILogEx GetLogger(string loggerName)
        {
            return new NoOpLogger();
        }

        public ILogEx GetLogger(Type type)
        {
            return new NoOpLogger();
        }

        public ILogEx GetLogger<T>()
        {
            return new NoOpLogger();
        }
    }
}