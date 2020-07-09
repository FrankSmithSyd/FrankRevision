namespace Revision.DataStructures.SinglyLinkedLists
{
    public class SinglyLinkedList
    {
        protected Node Head { get; set; }
        protected Node Tail { get; set; }
        public int Size { get; set; }

        public SinglyLinkedList()
        {
            Head = null;
            Size = 0;
        }

        public void AddElementToStartOfList(string element)
        {
            var newHead = new Node(element, Head);
            Head = newHead;
            Size++;
        }

        public void AddElementToEndOfList(string element)
        {
            var newTail = new Node(element, null);
            Tail.Next = newTail;
            Tail = newTail;
            Size++;
        }
    }
}