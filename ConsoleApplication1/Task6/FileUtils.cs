using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class FileUtils
    {
        static string FILENAME = "C:/Users/Jul/Source/Repos/cSharp-Training/ConsoleApplication1/Task6/Workers.txt";

        public static void AddWorker(Worker worker)
        {
            StreamWriter file = new StreamWriter(FILENAME, true);
            file.WriteLine(WorkerConverter.toString(worker));
            file.Close();
        }

        public static List<Worker> ReadAll()
        {
            List<Worker> list = new List<Worker>();
            string[] workerStrings = File.ReadAllLines(FILENAME);
            foreach (string str in workerStrings)
            {
                list.Add(WorkerConverter.toWorker(str));
            }
            return list;
        }

    }
}
