using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
   public abstract class Worker
    {
       private const string FILE_SEPARATOR = ",";

       public int ID { get; set; }
       public string Name { get; set; }
       public double Salary { get; set; }
       public string TYPE { get; set; }
       public abstract double MonthAvarageSalary();

       public Worker()
       {
       }
       public Worker(int id, string name, double salary)
       {
           ID = id;
           Name = name;
           Salary = salary;
       }

       public override string ToString()
       {
           StringBuilder builder = new StringBuilder();
           builder.Append(ID)
               .Append(FILE_SEPARATOR)
               .Append(Name)
               .Append(FILE_SEPARATOR)
               .Append(TYPE)
               .Append(FILE_SEPARATOR)
               .Append(Salary);
               return builder.ToString();
       }
    }
}
