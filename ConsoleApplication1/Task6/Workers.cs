using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
   abstract class Workers
    {
       public int ID{get; set;}
       public string Name { get; set; }
       public string Type { get; set; }
      
      // public double Payment { get; set; }
       public abstract double MonthAvarageSalary();
    }
}
