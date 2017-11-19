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
        public void NoLockIsThreadSafe()
        {
            var listOfTasks = new List<Task>();
            for (int i = 0; i < 1000; i++)
            {
                var count = i;
                listOfTasks.Add(new Task(() => InstanceCallFactory.NoLock()));
            }

            Task.Factory.StartNew(() => listOfTasks.ForEach(task => task.Start()));

           foreach(var task in listOfTasks)
            {
                task.Wait();
            }
            Assert.That(dbConnectSingleton.Count, Is.EqualTo(1));
            

        }

        [Test]
        public void LockIsThreadSafe()
        {
            var listOfTasks = new List<Task>();
            for (int i = 0; i < 1000; i++)
            {
                var count = i;
                listOfTasks.Add(new Task(() => InstanceCallFactory.Lock()));
            }

            Task.Factory.StartNew(() => listOfTasks.ForEach(task => task.Start()));

            foreach (var task in listOfTasks)
            {
                task.Wait();
            }

            Assert.That(dbConnectSingletonLock.Count, Is.EqualTo(1));

        }

        [Test]
        public void DblCheckIsThreadSafen()
        {
            var listOfTasks = new List<Task>();
            for (int i = 0; i < 1000; i++)
            {
                var count = i;
                listOfTasks.Add(new Task(() => InstanceCallFactory.DblCheck()));
            }

            Task.Factory.StartNew(() => listOfTasks.ForEach(task => task.Start()));

            foreach (var task in listOfTasks)
            {
                task.Wait();
            }
            Assert.That(dbConnectSingletonDblCheck.Count, Is.EqualTo(1));

        }

        [Test]
        public void NoLockSafeIsThreadSafe()
        {
            var listOfTasks = new List<Task>();
            for (int i = 0; i < 1000; i++)
            {
                var count = i;
                listOfTasks.Add(new Task(() => InstanceCallFactory.NoLockSafe()));
            }

            Task.Factory.StartNew(() => listOfTasks.ForEach(task => task.Start()));

            foreach (var task in listOfTasks)
            {
                task.Wait();
            }

            Assert.That(dbConnectSingletonNoLockSafe.Count, Is.EqualTo(1));

        }
    }
}
