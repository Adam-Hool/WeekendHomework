using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Calc myCalculator = new Calc();
            UserInput UI = new UserInput();
            ChooseAMethod myMethod = new ChooseAMethod();

            Console.WriteLine(myMethod.ChooseMethod());
            Console.ReadLine();

        }
    }
}
