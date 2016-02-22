using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomString
{
    public class Node
    {
        public Node node;
        public Node()
        {
            node = new Node();
        }
        public Node getPrevious(Node [] myNodeArray, int index)
        {
            if (index - 1 >= 0)
            {
                return myNodeArray[index - 1];
            }
            else
            {
                return null;
            }
        }

        public Node getNext(Node [] myNodeArray, int index)
        {
            if(index + 1 < myNodeArray.Length)
            {
                return myNodeArray[index + 1];
            }
            else
            {
                return null;
            }

        }

        public int GetLength(Node[] myNodeArray)
        {
            return myNodeArray.Length;
        }
    }
}
