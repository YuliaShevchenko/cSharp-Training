using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {

            string filename = "C:/Users/Jul/Source/Repos/cSharp-Training/ConsoleApplication1/Task6/Workers.txt";
            List<Workers> list = new List<Workers>();
            
            // if (File.Exists(filename))
            //{

            string[] listOfWorkers = File.ReadAllLines(filename);
            foreach (string worker in listOfWorkers)
            {
                string[] devidedInfo = worker.Split(',');
                int id = Convert.ToInt32(devidedInfo[0]);
                string name = devidedInfo[1];
                string type = devidedInfo[2];
                double salary = Convert.ToDouble(devidedInfo[3]);
                
                if (type == "month")
                {
                    FixedPayment fixedPayment = new FixedPayment(id, name, salary);
                    list.Add(fixedPayment);              
                }
                else
                {
                    PayByTheHour payByTheHour = new PayByTheHour(id, name, salary);
                    list.Add(payByTheHour);
                }


            }
            Console.WriteLine(list.Count);
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(list[i].ID);
            }
            foreach (Workers workersList in list) {
                Console.WriteLine(workersList.ID +" - " + workersList.Name + " - " + workersList.MonthAvarageSalary());
            }

            for (int i = list.Count-1; i > (list.Count-4); i--)
            {
                Console.WriteLine(list[i].ID);
            }
            
           // Console.WriteLine(list[0].Name + "_ " + list[3].Name + "_" + list[2].Name);
            Console.ReadKey();
            // }
            //else
            //{
            //     Console.WriteLine("File does not exist");
            // }
        }
    }
}
