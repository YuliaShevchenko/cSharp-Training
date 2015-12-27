using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class MonthPaymentWorker : Worker
    {
        //public double monthPayment;
       
        public MonthPaymentWorker(int id, string name, double salary) : base(id, name, salary)
        {
            TYPE = "month";
        }
        public override double MonthAvarageSalary()
        {
            return Salary;
        }
    }
}
