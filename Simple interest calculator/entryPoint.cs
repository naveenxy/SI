using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_interest_calculator
{
   public class entryPoint
    {
       public static void Main(String[]args)
        {
            Console.WriteLine("Enter your Principal amount");
           double amt= Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter your tensure period in years");
            int  time = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your Bank Name");
            string bankName = Console.ReadLine().ToLower();


            switch (bankName)
            {
                case "indian bank":
                    {
                        ICalculator obj = new Indian_Bank(amt, time);
                        obj.calculate();
                        break;
                    }
                case "canera bank":
                    {
                        ICalculator obj = new Canara_Bank(amt, time);
                        obj.calculate();
                        break;
                    }
                case "sbi":
                    {
                        ICalculator obj = new SBI(amt, time);
                        obj.calculate();
                        break;
                    }
            }
        }

    }

  

}
