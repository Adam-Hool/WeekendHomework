using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomString
{
    public interface ICustomString
    {
        void insert(string stringToIncert, int index);

        void Remove(int startIndex, int numCharsToRemove);

        void Remove(string strToRemove);

        int Length(string stringToGetLengthOf);

    }
}
