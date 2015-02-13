using System;
using JetBrains.Annotations;

namespace PortableLog.Core
{
    [PublicAPI]
    public class NoOpLogFactory : ILogFactory
    {
        public ILog GetLogger(string loggerName)
        {
            return new NoOpLogger();
        }

        public ILog GetLogger(Type type)
        {
            return new NoOpLogger();
        }

        public ILog GetLogger<T>()
        {
            return new NoOpLogger();
        }
    }
}