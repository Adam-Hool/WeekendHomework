using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomString
{
    public class CustomLinkedList : ICustomString
    {
        Node[] nodeArray { get; set; }
        public CustomLinkedList(int listSize)
        {
            nodeArray = new Node[listSize];
        }
        public void insert(string stringToIncert, int index)
        {
            Node[] newNodeArray = new Node[stringToIncert.Length + nodeArray.Length];
            char[] charStringToIncertArray = new char[stringToIncert.Length];
            charStringToIncertArray = stringToIncert.ToCharArray();
            for(int i = 0; i < stringToIncert.Length; i++)
            {
                newNodeArray[newNodeArray.Length - (i + 1)] = newNodeArray[stringToIncert.Length-(i+1)];
            }
            charStringToIncertArray.CopyTo(newNodeArray, index);
        }

        public int Length(Node [] nodeToGetLengthOf)
        {
            return nodeToGetLengthOf.Length;
        }



        public void Remove(int startIndex, int numNodesToRemove)
        {
            Node[] newNodeArray = new Node[nodeArray.Length - numNodesToRemove];
            for (int i = 0; i < numNodesToRemove; i++)
            {
                newNodeArray[startIndex + i] = nodeArray[i+numNodesToRemove];
            }
            nodeArray = newNodeArray;
        }

        // interface manditory overloaded impliments below
        public void Remove(Node strToRemove)
        {
            throw new NotImplementedException();

        }

        public void Remove(string strToRemove)
        {
            throw new NotImplementedException();
        }

        public int Length(string stringToGetLengthOf)
        {
            throw new NotImplementedException();
        }
        //public LinkedListNode<char> firstNode;
        //public char[] nodeArray;
        //public CustomLinkedList(int arraySize)
        //{
        //    firstNode = new LinkedListNode<char>(null);
        //    nodeArray = new char[arraySize];
        //}
        //public void insert(string stringToIncert, int index)
        //{

        //    LinkedListNode<char> nodeToIncert = new LinkedListNode<char>(stringToIncert);
        //    LinkedListNode<char> tail = new LinkedListNode<char>(null);


        //}

        //public int Length(string stringToGetLengthOf)
        //{
        //    throw new NotImplementedException();
        //}

        //public void Remove(string strToRemove)
        //{
        //    throw new NotImplementedException();
        //}

        //public void Remove(int startIndex, int numCharsToRemove)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
