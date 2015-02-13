using System;
using NUnit.Framework;
using PortableLog.Core;

namespace PortableLog.Tests
{
    [TestFixture]
    public class ILogExTest
    {
        [Test]
        public void DoesNotHaveAmbiguousOverloads()
        {
            var l = new NoOpLogger() as ILogEx;
            var e = new Exception();

            l.InfoEx("");
            l.InfoFormatEx("{0}", new object[] {"this"});
            l.ErrorEx("");
            l.ErrorEx(e, "");
        }
    }
}