using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class User
    {
        public static void AddUser(string filename)
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
            catch (Exception exception)
            {
                Console.WriteLine("User is not added");
               // Console.WriteLine(exception);
                return;
            }
            StringBuilder builder = new StringBuilder();
            foreach (string text in devidedInfo)
            {
                builder.Append(text).Append(",");
            }
            Console.WriteLine("Added user is: " + builder.ToString());
            string newUser = builder.ToString();

            StreamWriter file = new StreamWriter(filename, true);
            file.WriteLine(newUser);
            file.Close();

        }
    }
}
