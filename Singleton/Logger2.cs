using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    sealed class Logger2
    {
        private static FileService logger = null;
        private static readonly object lockThread = new object();
        
        public static FileService Instance
        {
            get
            {
                if (logger == null)
                {
                    lock (lockThread)
                    {
                        if (logger == null)
                        {
                            logger = new FileService();
                            Console.WriteLine("Connected with log service");
                        }
                        return logger;
                    }
                }
                return logger;
            }
        }

    }
}
