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
                listOfTasks.Add(new Task(() => NoLock()));
            }

            Task.Factory.StartNew(() => listOfTasks.ForEach(task => task.Start()));

           foreach(var task in listOfTasks)
            {
                task.Wait();
            }
            Assert.That(dbConnectSingleton.Count, Is.EqualTo(1));
            

        }


        void NoLock()
        {
            IDataContext db = dbConnectSingleton.Instance;
            IDataContext db2 = dbConnectSingleton.Instance;
        }


        [Test]
        public void LockIsThreadSafe()
        {
            var listOfTasks = new List<Task>();
            for (int i = 0; i < 1000; i++)
            {
                var count = i;
                listOfTasks.Add(new Task(() => Lock()));
            }

            Task.Factory.StartNew(() => listOfTasks.ForEach(task => task.Start()));

            foreach (var task in listOfTasks)
            {
                task.Wait();
            }

            Assert.That(dbConnectSingletonLock.Count, Is.EqualTo(1));

        }


        void Lock()
        {
            IDataContext  db = dbConnectSingletonLock.Instance;
            IDataContext  db2 = dbConnectSingletonLock.Instance;
        }


        [Test]
        public void DblCheckIsThreadSafen()
        {
            var listOfTasks = new List<Task>();
            for (int i = 0; i < 1000; i++)
            {
                var count = i;
                listOfTasks.Add(new Task(() => DblCheck()));
            }

            Task.Factory.StartNew(() => listOfTasks.ForEach(task => task.Start()));

            foreach (var task in listOfTasks)
            {
                task.Wait();
            }
            Assert.That(dbConnectSingletonDblCheck.Count, Is.EqualTo(1));

        }


        void DblCheck()
        {

            IDataContext db = dbConnectSingletonDblCheck.Instance;
            IDataContext db2 = dbConnectSingletonDblCheck.Instance;
        }


        [Test]
        public void NoLockSafeIsThreadSafe()
        {
            var listOfTasks = new List<Task>();
            for (int i = 0; i < 1000; i++)
            {
                var count = i;
                listOfTasks.Add(new Task(() => NoLockSafe()));
            }

            Task.Factory.StartNew(() => listOfTasks.ForEach(task => task.Start()));

            foreach (var task in listOfTasks)
            {
                task.Wait();
            }

            Assert.That(dbConnectSingletonNoLockSafe.Count, Is.EqualTo(1));

        }

        void NoLockSafe()
        {

            IDataContext db = dbConnectSingletonDblCheck.Instance;
            IDataContext db2 = dbConnectSingletonDblCheck.Instance;
        }


    }
}
