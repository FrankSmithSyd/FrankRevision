using System;

namespace Revision.DataStructures.SinglyLinkedLists
{
    public class Node
    {
        public string Element { get; set; }
        public Node Next { get; set; }

        public Node(String element, Node next)
        {
            this.Element = element;
            this.Next = next;
        }

        // public void SetElement(string element)
        // {
        //     Element = element;
        // }
        //
        // public void SetNext(Node next)
        // {
        //     Next = next;
        // }
    }
}