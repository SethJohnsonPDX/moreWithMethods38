using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace moreWithMethods38
{
    class Program
    {
        static void Main(string[] args)
        {
            string enterNum = "Enter a number: ";
            Console.WriteLine(enterNum);
            int inputReq = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a second if you'd like (optional), otherwise enter \"0\": ");
            int inputOpt = Convert.ToInt32(Console.ReadLine());

            mathOperation math = new mathOperation();
            if (inputOpt == 0)
            {
                int singleInput = math.Divide(inputReq);
                Console.WriteLine(singleInput);
            }
            else
            {
                int doubleInput = math.Divide(inputReq, inputOpt);
                Console.WriteLine(doubleInput);
            }
            Console.ReadLine();


        }
    }
}
