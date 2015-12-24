using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class MonthPaymentWorker : Worker
    {
        public double monthPayment;
       
        public MonthPaymentWorker(int id, string name, double salary)
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
