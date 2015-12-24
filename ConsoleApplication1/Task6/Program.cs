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
            // Console.WriteLine("Please add user. Enter ID, Name, Pay Type (month or hour), Salary");
            // string enteredData = Console.ReadLine();
            // Worker newWorker = WorkerConverter.toWorker(enteredData);
            // FileUtils.AddWorker(newWorker);

            List<Worker> listOfWorkers = FileUtils.ReadAll();

            Console.WriteLine("++++++  Unsorted workers ++++++");
            print(listOfWorkers);
           
            Console.WriteLine("++++++  Sorted workers ++++++");
            List<Worker> sortedList = ListUtils.SortBySalaryAndName(listOfWorkers);
            print(sortedList);

            Console.WriteLine("++++++  Top 5  ++++++");
            print(ListUtils.getTop5(sortedList));

            Console.WriteLine("++++++  Last 3  ++++++");
            print(ListUtils.getLast3(sortedList));

            Console.ReadKey();
        }

        public static void print(List<Worker> workers)
        {
            foreach (Worker worker in workers)
            {
                Console.WriteLine(worker.ID + " - " + worker.Name + " - " + worker.MonthAvarageSalary());
            }

        }

    }
}

