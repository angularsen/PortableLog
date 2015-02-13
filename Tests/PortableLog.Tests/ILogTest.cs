using System;
using System.Globalization;
using NUnit.Framework;
using PortableLog.Core;

namespace PortableLog.Tests
{
    [TestFixture]
    public class ILogTest
    {
        /// <summary>
        ///     No asserts, only intended to help us flag compile errors if method signatures are changed.
        ///     For example, we had to use <see cref="T:System.String" /> type on the shortest log method
        ///     to avoid ambiguity with the overloads having an <see cref="T:System.Exception" /> parameter.
        /// </summary>
        [Test]
        public void DoesNotHaveAmbiguousOverloads()
        {
            var l = new NoOpLogger() as ILog;
            var e = new Exception();

            l.Debug(CultureInfo.InvariantCulture, h => h("one {0} two {1}", 1, 2));
            l.Info("");
            l.Error("");
            l.Error(e, "");
            l.Error(e, "My name is {1}, {0} {1}.".With("James", "Bond"));
            l.Error(h => h("My name is {1}, {0} {1}.".With("James", "Bond")));
            l.Error(CultureInfo.InvariantCulture, h => h("My name is {1}, {0} {1}.", "James", "Bond"));
            l.Error(CultureInfo.InvariantCulture, h => h("My name is {1}, {0} {1}.".With("James", "Bond")));
        }
    }
}