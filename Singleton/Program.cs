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
            Console.WriteLine("1: lock, 2: double check, 3: Simple singleton");
            string chose = Console.ReadLine();
            switch (chose)
            {
                case "1":
                    var watch = System.Diagnostics.Stopwatch.StartNew();

                    FileService logConnection = Logger.Instance;
                    FileService logConnection2 = Logger.Instance;
                    logConnection.Log("first log");
                    logConnection.Log("test log");
                    logConnection2.Log("first log");
                    logConnection2.Log("test log");
                    logConnection.ReadLogFile();
                    logConnection.ClearLog();
                    watch.Stop();
                    var elapsedMs = watch.ElapsedMilliseconds;
                    Console.WriteLine($"Time:{elapsedMs}");
                    Console.ReadKey();
                    break;

                case "2":
                    var watch2 = System.Diagnostics.Stopwatch.StartNew();
                    FileService logConnection3 = Logger2.Instance;
                    FileService logConnection4 = Logger2.Instance;
                    logConnection3.Log("first log");
                    logConnection3.Log("test log");
                    logConnection4.Log("first log");
                    logConnection4.Log("test log");
                    logConnection3.ReadLogFile();
                    logConnection3.ClearLog();
                    watch2.Stop();
                    var elapsed2Ms = watch2.ElapsedMilliseconds;
                    Console.WriteLine($"Time:{elapsed2Ms}");
                    Console.ReadKey();
                    break;

                case "3":
                    var watch3 = System.Diagnostics.Stopwatch.StartNew();
                    FileService logConnection5 = Logger3.Instance;
                    FileService logConnection6 = Logger3.Instance;
                    logConnection5.Log("first log");
                    logConnection5.Log("test log");
                    logConnection6.Log("first log");
                    logConnection6.Log("test log");
                    logConnection5.ReadLogFile();
                    logConnection5.ClearLog();
                    watch3.Stop();
                    var elapsed3Ms = watch3.ElapsedMilliseconds;
                    Console.WriteLine($"Time:{elapsed3Ms}");
                    Console.ReadKey();
                    break;

                case "4":
                        

                        break;
            }
            

           
        }
    }
}
