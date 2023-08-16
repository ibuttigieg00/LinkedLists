namespace LinkedLists
{
    public class SinglyLinkedList
    {
        ListNode? head;
        ListNode? tail;

        public void InsertFront(SinglyLinkedList singlyLinkedList, int value)
        {
            ListNode node = new ListNode(value);

            if (singlyLinkedList.head == null)
            {
                singlyLinkedList.head = node;
                singlyLinkedList.tail = node;
                return;
            }

            node.Next = singlyLinkedList.head;
            singlyLinkedList.head = node;
        }
        public void InsertEnd(SinglyLinkedList singlyList, int value)  
        {
            ListNode node = new ListNode(value);

            if (singlyList.head == null)
            {
                singlyList.head = node;
                singlyList.tail = node;
                return;
            }

            ListNode lastNode = singlyList.tail;
            lastNode.Next = node;
            singlyList.tail = node;
        }

        public void ReverseOrder(SinglyLinkedList singlyLinkedList)
        {
            ListNode prev = null;
            ListNode temp = null;
            ListNode current = singlyLinkedList.head;

            while (current != null)
            {
                temp = current.Next; // Round 1: 2,3,4,5
                // Round 2: 3,4,5
                // Round 3: 4,5
                // Round 4: 5
                // Round 5: null
                current.Next = prev; // null
                // Round 2: 1
                // Round 3: 2,1
                // Round 4: 3,2,1
                // Round 5: 4,3,2,1
                prev = current; // 1
                // Round 2: 2
                // Round 3: 3
                // Round 4: 4
                // Round 5: 5
                current = temp; // 2,3,4,5
                // Round 2: 3,4,5
                // Round 3: 4,5
                // Round 4: 5
                // Round 5: null
            }
            singlyLinkedList.head = prev;
        }
    }
}