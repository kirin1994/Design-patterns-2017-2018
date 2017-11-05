using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class FileService
    {
        private static int logCounter = 0;

        public void Log(string message)
        {
            using (StreamWriter appendLog = File.AppendText("log.txt"))
            {
                appendLog.WriteLine($"--------log--------");
                appendLog.WriteLine($"--------nr: {logCounter}");
                appendLog.WriteLine($"Log message: {message}");
                appendLog.WriteLine($"Date:{DateTime.UtcNow}");
                appendLog.WriteLine($"-------------------");
                appendLog.WriteLine("");
                logCounter++;
            }

        }

        public void ReadLogFile()
        {
            using (StreamReader readLog = File.OpenText("log.txt"))
            {
                string line;
                while ((line = readLog.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }

        public void ClearLog()
        {
            File.Delete("log.txt");
        }
    }
}
