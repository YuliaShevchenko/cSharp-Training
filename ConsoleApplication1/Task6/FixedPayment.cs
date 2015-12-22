using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class FixedPayment : Workers
    {
        double monthPayment;
       
       // private string salary;
        

        public FixedPayment(int id, string name, double salary)
        {
            ID = id;
            Name = name;
            monthPayment = salary;
        }
        public override double MonthAvarageSalary()
        {
            return monthPayment;
        }
    }
}
