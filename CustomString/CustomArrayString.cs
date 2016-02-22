using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomString
{
    class CustomArrayString : ICustomString
    {
        public string _myString { get; set; }
        public CustomArrayString(string myString)
        {
            _myString = myString;
        }
        // insert functions bellow
        public void insert(string stringToIncert, int index)
        {

            char[] oldString = new char[(stringToIncert.Length) + (_myString.Length)];
            char[] stringToIncertArray = new char[stringToIncert.Length];
            _myString.CopyTo(0, oldString, 0, _myString.Length);
            stringToIncertArray = stringToIncert.ToCharArray();

            MakeRoom(ref oldString, index);
            FillINArraySpace(oldString, index, stringToIncert);

            string newString = new string(oldString);
            _myString = newString;
        }
        public Array MakeRoom(ref char[] oldString, int index)
        {
            int newCounter = oldString.Length - 1;
            for (int arrayLocation = _myString.Length - 1; arrayLocation >= index; arrayLocation--)
            {
                oldString[newCounter] = oldString[arrayLocation];
                newCounter--;
            }
            return oldString;
        }

        public Array FillINArraySpace(char[] oldString, int index, string stringToIncert)
        {
            char[] stringToIncertArray = new char[stringToIncert.Length];
            int stringToIncertCounter = 0;
            stringToIncertArray = stringToIncert.ToCharArray();
            for (int arrayLocation = index; arrayLocation < stringToIncert.Length + index; arrayLocation++)
            {
                oldString[arrayLocation] = stringToIncertArray[stringToIncertCounter];
                stringToIncertCounter++;
            }
            return oldString;
        }

        // remove function below
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
        //length function
        public int Length(string stringToGetLengthOf)
        {
            return stringToGetLengthOf.Length;
        }

        public void Remove(string strToRemove)
        {
            throw new NotImplementedException();
        }
    }
}
