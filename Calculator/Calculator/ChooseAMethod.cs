using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class ChooseAMethod
    {
        //todo: don't use new as a member variable, put in appropriate place
        public UserInput UI;
        public Calc calc;

        public ChooseAMethod()
        {
            UI = new UserInput();
            calc = new Calc();
        }
        //todo: change from recursion to iteration
        
        public double ChooseMethod()
        {

            string caseSwitch = UI.getMethodChoise();


            switch (caseSwitch)
            {
            case "Add":
                return calc.Add();
            case "Subtract":
                return calc.Subtract();
            case "Multiply":
                return calc.Multiply();
            case "Divide":
                return calc.Divide();
            case "Exponential":
                return calc.Exponent();
            case "Adam":
                    return 9001;
            default:
                Console.WriteLine("Enter Valid Method to Choose");
                   return ChooseMethod();

            }
        
        }
    }
}
