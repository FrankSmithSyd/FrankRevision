using NUnit.Framework;
using Revision.DataStructures;
using LinkedList = Revision.DataStructures.SinglyLinkedLists.SinglyLinkedList;

namespace Tests.DataStructures.SinglyLinkedList
{
    public class SinglyLinkedListShould
    {
        private LinkedList Setup()
        {
            return new LinkedList();
        }
        
        [Test]
        public void EmptyListHasSize0()
        {
            var list = Setup();

            Assert.AreEqual(0, list.Size);
        }
    }
}