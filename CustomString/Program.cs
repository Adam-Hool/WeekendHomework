using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomString
{
    class Program
    {
        static void Main(string[] args)
        {
             CustomString2 customString = new CustomString2("Adam");
            customString.insert("mster",1);
            Console.WriteLine(customString._myString);
            customString.Remove(1,3);
            Console.WriteLine(customString._myString);
            CustomLinkedList customLinkedList = new CustomLinkedList(4);
            customLinkedList.insert("hi", 1);
            Console.WriteLine(customLinkedList);
            Console.ReadLine();
        }
    }
}
