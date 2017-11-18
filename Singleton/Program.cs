using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = dbConnectSingletonLock.Instance;
            var age = db.GetAge("Adrian");

            Console.WriteLine($"age{age}");

            var db2 = dbConnectSingletonDblCheck.Instance;
            var age2 = db.GetAge("Adrian");

            Console.WriteLine($"age{age2}");

            var db3= dbConnectSingletonNoLock.Instance;
            var age3 = db.GetAge("Adrian");

            Console.WriteLine($"age{age3}");

            var db4 = dbConnectSingletonNoLockSafe.Instance;
            var age4 = db.GetAge("Adrian");

            Console.WriteLine($"age{age4}");


            Console.ReadKey();
           
        }
    }
}
