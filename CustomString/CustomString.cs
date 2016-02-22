using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomString
{
    class CustomString/* : ICustomString*/
    {
        public string _myString { get; set; }
        public CustomString(string myString)
        {
            _myString = myString;
        }
        public void insert(string stringToIncert, int index)
        {
            string newString;
            char[] oldString = new char[(stringToIncert.Length) + (_myString.Length)];
            char[] stringToIncertArray = new char[stringToIncert.Length];
            int stringToIncertCounter = 0;
            int newCounter = oldString.Length - 1;

            _myString.CopyTo(0, oldString, 0, _myString.Length);
            stringToIncertArray = stringToIncert.ToCharArray();

            for (int arrayLocation = _myString.Length - 1; arrayLocation >= index; arrayLocation--)
            {
                oldString[newCounter] = oldString[arrayLocation];
                newCounter--;
            }
            for (int arrayLocation = index; arrayLocation < stringToIncert.Length + index; arrayLocation++)
            {
                oldString[arrayLocation] = stringToIncertArray[stringToIncertCounter];
                stringToIncertCounter++;
            }
            newString = new string(oldString);
            _myString = newString;
        }

        public void Remove(int startIndex, int numCharsToRemove)
        {
            char[] myArray = _myString.ToCharArray();
            char[] removedCharArray = new char[myArray.Length - numCharsToRemove];
            int removedCharArrayCounter = 0;
            for (int counter = 0; removedCharArrayCounter < (numCharsToRemove + startIndex); counter++)
            {
                while (counter < startIndex || counter > (startIndex + numCharsToRemove) && removedCharArrayCounter < (numCharsToRemove + startIndex + 1))
                {
                    removedCharArray[removedCharArrayCounter] = myArray[counter];
                    removedCharArrayCounter++;
                    counter++;
                }
            }
            _myString = new string(removedCharArray);
        }

        public int Length(string stringToGetLengthOf)
        {
            return stringToGetLengthOf.Length;
        }
    }
}
