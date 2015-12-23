using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    public class ReadFromFile
    {
        public static List<Workers> GetWorkersFromFile(string filename)
        {
            
            List<Workers> list = new List<Workers>();
            string[] listOfWorkers = File.ReadAllLines(filename);
            foreach (string worker in listOfWorkers)
            {
                string[] devidedInfo = worker.Split(',');
                try
                {
                    int id = Convert.ToInt32(devidedInfo[0]);
                    string name = devidedInfo[1];
                    string type = devidedInfo[2];
                    double salary = Convert.ToDouble(devidedInfo[3]);

                    if (type == "month")
                    {
                        list.Add(new FixedPayment(id, name, salary));
                    }
                    else
                    {
                        list.Add(new PayByTheHour(id, name, salary));
                    }
                }
                catch (FormatException exception)
                {
                    Console.WriteLine("Not correct format data");
                }
            }
            return list;
        }
    }
}