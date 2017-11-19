using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class InstanceCallFactory
    {
        public static void NoLock()
        {
            IDataContext db = dbConnectSingleton.Instance;
            IDataContext db2 = dbConnectSingleton.Instance;
            new InstanceCallFactory().GetStudentsAge(db, db2);
        }

        public static void DblCheck()
        {

            IDataContext db = dbConnectSingletonDblCheck.Instance;
            IDataContext db2 = dbConnectSingletonDblCheck.Instance;
            new InstanceCallFactory().GetStudentsAge(db, db2);
        }

        public static void Lock()
        {
            IDataContext db = dbConnectSingletonLock.Instance;
            IDataContext db2 = dbConnectSingletonLock.Instance;
            new InstanceCallFactory().GetStudentsAge(db, db2);
        }
 
        public static void NoLockSafe()
        {

            IDataContext db = dbConnectSingletonNoLockSafe.Instance;
            IDataContext db2 = dbConnectSingletonNoLockSafe.Instance;
            new InstanceCallFactory().GetStudentsAge(db, db2);
        }

        private void GetStudentsAge( IDataContext db,  IDataContext db2)
        {
            db.GetAge("Adrian");
            db.GetAge("Maciek");
            db2.GetAge("Maciek");
            db2.GetAge("Adrian");
        }
    }
}
