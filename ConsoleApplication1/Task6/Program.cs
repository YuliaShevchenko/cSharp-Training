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
            string newUser = AddUser();
            if (newUser != null)
            {
                StreamWriter file = new StreamWriter(filename, true);
                file.WriteLine(newUser);
                file.Close();
            }
            else
            {
                Console.WriteLine("User is not added");
            }
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
                        FixedPayment fixedPayment = new FixedPayment(id, name, salary);
                        list.Add(fixedPayment);

                    }
                    else
                    {
                        PayByTheHour payByTheHour = new PayByTheHour(id, name, salary);
                        list.Add(payByTheHour);
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Not correct data");

                }

            }

            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Sorted by salary: ");
            list.Sort(new nameCompator());
            list.Sort(new salaryCompator());

            foreach (Workers workersList in list)
            {
                Console.WriteLine(workersList.ID + " - " + workersList.Name + " - " + workersList.MonthAvarageSalary());
            }
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Top 5 are: ");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(list[i].Name);
            }

            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Last 3 are: ");
            for (int i = list.Count - 3; i < list.Count; i++)
            {
                Console.WriteLine(list[i].ID);
            }


            Console.ReadKey();
        }

        public static string AddUser()
        {
            Console.WriteLine("Please add user. Enter ID, Name, Pay Type (month or hour), Salary");
            string enteredData = Console.ReadLine();
            string[] devidedInfo = enteredData.Split(' ');
            try
            {
                int id = Convert.ToInt32(devidedInfo[0]);
                string name = devidedInfo[1];
                string type = devidedInfo[2];
                double salary = Convert.ToDouble(devidedInfo[3]);
            }
            catch (Exception)
            {
                Console.WriteLine("Not valid entered data");
                return null;
            }
            StringBuilder builder = new StringBuilder();
            foreach (string x in devidedInfo)
            {
                builder.Append(x).Append(",");
            }
            Console.WriteLine("Added user is: " + builder.ToString());
            return builder.ToString();



        }

    }

    //sorting by salary
    class salaryCompator : IComparer<Workers>
    {
        int IComparer<Workers>.Compare(Workers x, Workers y)
        {
            return y.MonthAvarageSalary().CompareTo(x.MonthAvarageSalary());
        }
    }

    //alphabetical sorting by name
    class nameCompator : IComparer<Workers>
    {
        int IComparer<Workers>.Compare(Workers x, Workers y)
        {
            return x.Name.CompareTo(y.Name);
        }
    }


}

