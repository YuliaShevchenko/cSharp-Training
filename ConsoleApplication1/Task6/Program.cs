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
            User.AddUser(filename);
            List<Workers> listOfWorkers = ReadFromFile.GetWorkersFromFile(filename);

            Console.WriteLine("++++++  Unsorted list ++++++");
            Sorting.showAll(listOfWorkers);
            List<Workers> sortedList = Sorting.SortingBySalaryAndName(listOfWorkers);
            Console.WriteLine("++++++  Sorted list ++++++");
            Sorting.showAll(sortedList);
            Console.WriteLine("++++++  Top 5  ++++++");
            List<Workers> top5 = Sorting.getTop5(sortedList);
            Sorting.showAll(top5);
            Console.WriteLine("++++++  Last 3  ++++++");
            List<Workers> last3 = Sorting.getLast3(sortedList);
            Sorting.showAll(last3);
            Console.ReadKey();



        }
    }
}

