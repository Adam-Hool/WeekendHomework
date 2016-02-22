using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Calculator
{
    public class UserInput
    {
        public double numberToChange;
        public double amountTochangeBy;
        //todo: move assignement to now non-silly constructor// Done
        public string numberToChangeMessege;
        public string amountTochangeByMessege;

        //todo remove because its silly //Done
        public UserInput()
        {
            numberToChangeMessege = "What number do you want to change?";
            amountTochangeByMessege = "What do you want to change your number by?";
        }
        
        public string getMethodChoise()
        {
            Console.WriteLine("Do you want to Add, Subtract, Multiply, Divide, Exponential?");
            //if (Console.ReadLine() != "Add" || Console.ReadLine() != "Subtract" || Console.ReadLine() != "Multiply" || Console.ReadLine() != "Divide" || Console.ReadLine() != "Exponential")
            //{
            //}
            return Console.ReadLine();
        }
        public double getNumberToChange()
        {
            Console.WriteLine(numberToChangeMessege);
            double numberToCheckIfValid;
            bool isNumeric = double.TryParse(Console.ReadLine(), out numberToCheckIfValid);
            if(isNumeric==true)
            {
                numberToChange = numberToCheckIfValid;
                return numberToChange;
            }
            else
            {
                Console.WriteLine("enter a number");
                return getNumberToChange();
            }
           
        }

        public double getAmountTochangeBy()
        {
            Console.WriteLine(amountTochangeByMessege);
            double numberToCheckIfValid;
            bool isNumeric = double.TryParse(Console.ReadLine(), out numberToCheckIfValid);
            if (isNumeric == true)
            {
                amountTochangeBy = numberToCheckIfValid;
                return amountTochangeBy;
            }
            else
            {
                Console.WriteLine("enter a number");
                return getNumberToChange();
            }
        }
    
    }
}
