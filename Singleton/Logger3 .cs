using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    sealed class Logger3
    {
        private static FileService instance = null;

        private Logger3()
        {
        }

        public static FileService Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new FileService();
                }
                return instance;
            }
        }
    }
}
