using System;
using JetBrains.Annotations;

namespace PortableLog.Core
{
    public static class StringExtensions
    {
        [StringFormatMethod("format")]
        public static string With(this string format, IFormatProvider provider, params object[] args)
        {
            return string.Format(provider, format, args);
        }

        [StringFormatMethod("format")]
        public static string With(this string format, params object[] args)
        {
            return string.Format(format, args);
        }
    }
}