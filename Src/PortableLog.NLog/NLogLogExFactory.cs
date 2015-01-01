using System;
using PortableLog.Core;
using NLogLib = NLog;

namespace PortableLog.NLog
{
    public class NLogLogExFactory : ILogExFactory
    {
        private readonly bool _useFullTypeName;

        public NLogLogExFactory() : this(false)
        {
        }

        public NLogLogExFactory(bool useFullTypeName)
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