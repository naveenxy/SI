using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_interest_calculator
{
    public class initial
    {
       public int tenure_period;
            public double principal_amount, interest;

        public initial(double amount,int period)
        {
            principal_amount = amount;
            tenure_period = period;
        }

    }


    public class Indian_Bank : initial,ICalculator
    {

        public Indian_Bank(double amount ,int period) :base(amount,period)
        {
            interest = 6.5;
        }
        public void calculate()
        {
            double cal = principal_amount * tenure_period * interest / 100;
            Console.WriteLine("the simple interest is  {0}", cal);
        }
            
        
    }
    public class Canara_Bank : initial, ICalculator
    {
        public Canara_Bank(double amount, int period) : base(amount, period)
        {
            interest = 6;
        }
        public void calculate()
        {
            double cal = principal_amount * tenure_period * interest / 100;
            Console.WriteLine("the simple interest is  {0}", cal);
        }
    }
    public class SBI : initial, ICalculator
    {
        public SBI(double amount, int period) : base(amount, period)
        {
             interest = 6.8;
        }
        public void calculate()
        {
            double cal = principal_amount * tenure_period * interest / 100;
            Console.WriteLine("the simple interest is  {0}", cal);
        }
    }
   
}
