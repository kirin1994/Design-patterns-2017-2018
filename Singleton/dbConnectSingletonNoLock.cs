using MoreLinq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    sealed class dbConnectSingletonNoLock : IDataContext
    {
        private static dbConnectSingletonNoLock instance = null;

        private static int instancesCount;

        public static int Count => instancesCount;

        private Dictionary<string, int> students;

        private dbConnectSingletonNoLock()
        {
            instancesCount++;
            Console.WriteLine("Initialization of db");
            students = File.ReadAllLines(
                Path.Combine(new FileInfo(typeof(IDataContext).Assembly.Location).DirectoryName, "data.txt"))
                .Batch(2).ToDictionary(
                list => list.ElementAt(0).Trim(),
                list => int.Parse(list.ElementAt(1)));
        }

        public int GetAge(string name)
        {
            return students[name];
        }

        public static dbConnectSingletonNoLock Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new dbConnectSingletonNoLock();
                }
                return instance;
            }
        }
    }
}
