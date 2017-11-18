using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    [TestFixture]
    class nUnitTests
    {

        [Test]
        public void NoLockSafeIsSingleton()
        {
            var db = dbConnectSingletonNoLockSafe.Instance;
            var db2 = dbConnectSingletonNoLockSafe.Instance;
            Assert.That(db, Is.SameAs(db2));
            Assert.That(dbConnectSingletonNoLockSafe.Count, Is.EqualTo(1));

        }

    }
}
