using System;
using PortableLog.Core;
using NLogLib = NLog;

namespace PortableLog.NLog
{
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

        public ILogEx GetLogger(string loggerName)
        {
            return new NLogLogger(NLogLib.LogManager.GetLogger(loggerName));
        }

        public ILogEx GetLogger(Type type)
        {
            return GetLogger(_useFullTypeName ? type.FullName : type.Name);
        }

        public ILogEx GetLogger<T>()
        {
            return GetLogger(typeof (T));
        }
    }
}