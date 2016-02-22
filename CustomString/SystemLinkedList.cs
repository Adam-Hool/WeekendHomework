using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomString
{
    class SystemLinkedList<T> : ICustomString
    {
        public LinkedList<string> linkedList = new LinkedList<string>();
        LinkedListNode<string> strToIncert = new LinkedListNode<string>("marco");
        LinkedListNode<string> strToIncert2 = new LinkedListNode<string>("polo");
        public void insert(string stringToIncert, int index)
        {

            linkedList.AddBefore(strToIncert,strToIncert2);
        }

        public int Length(string stringToGetLengthOf)
        {
            return linkedList.Count();
        }

        public void Remove(string strToRemove)
        {
            linkedList.Remove(strToRemove);
        }

        public void Remove(int startIndex, int numCharsToRemove)
        {
            throw new NotImplementedException();
        }
    }
}
