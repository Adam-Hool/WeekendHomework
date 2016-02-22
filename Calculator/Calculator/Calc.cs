using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Calculator
{
    public class Calc
    {
        public UserInput UI = new UserInput();
        public double Add()
        {
            double numberToChange = UI.getNumberToChange();
            double amountToChangeBy = UI.getAmountTochangeBy();
            return numberToChange + amountToChangeBy;
        }

        public double Subtract()
        {
            double numberToChange = UI.getNumberToChange();
            double amountToChangeBy = UI.getAmountTochangeBy();
            return numberToChange - amountToChangeBy;
        }

        public double Multiply()
        {
            double numberToChange = UI.getNumberToChange();
            double amountToChangeBy = UI.getAmountTochangeBy();
            return numberToChange * amountToChangeBy;
        }

        public double Divide()
        {
            double numberToChange = UI.getNumberToChange();
            double amountToChangeBy = UI.getAmountTochangeBy();
            return numberToChange / amountToChangeBy;
        }

        public double Exponent()
        {
            double numberToChange = UI.getNumberToChange();
            double amountToChangeBy = UI.getAmountTochangeBy();
            return Math.Pow(numberToChange, amountToChangeBy);
        }
    }
}
