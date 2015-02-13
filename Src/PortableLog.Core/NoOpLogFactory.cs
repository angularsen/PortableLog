using System;

namespace PortableLog.Core
{
    public class NoOpLogFactory : ILogFactory
    {
        public ILogEx GetLogger(string loggerName)
        {
            return new NoOpLoggerEx();
        }

        public ILogEx GetLogger(Type type)
        {
            return new NoOpLoggerEx();
        }

        public ILogEx GetLogger<T>()
        {
            return new NoOpLoggerEx();
        }
    }
}