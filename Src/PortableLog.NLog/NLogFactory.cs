using System;
using PortableLog.Core;
using PortableLog.NLog.Properties;
using NLogLib = NLog;

namespace PortableLog.NLog
{
    [PublicAPI]
    public class NLogFactory : ILogFactory
    {
        private readonly bool _useFullTypeName;

        public NLogFactory() : this(false)
        {
        }

        public NLogFactory(bool useFullTypeName)
        {
            _useFullTypeName = useFullTypeName;
        }

        public ILog GetLogger(string loggerName)
        {
            return new NLogLogger(NLogLib.LogManager.GetLogger(loggerName));
        }

        public ILog GetLogger(Type type)
        {
            return GetLogger(_useFullTypeName ? type.FullName : type.Name);
        }

        public ILog GetLogger<T>()
        {
            return GetLogger(typeof (T));
        }
    }
}