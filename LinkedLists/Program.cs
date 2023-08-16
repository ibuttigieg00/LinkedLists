using LinkedLists;
class Program
{
    public static void Main(string[] args)
    {
        SinglyLinkedList singlyLinkedList = new SinglyLinkedList();
        
        singlyLinkedList.InsertEnd(singlyLinkedList, 1);
        singlyLinkedList.InsertEnd(singlyLinkedList, 2);
        singlyLinkedList.InsertEnd(singlyLinkedList, 3);
        singlyLinkedList.InsertEnd(singlyLinkedList, 4);
        singlyLinkedList.InsertEnd(singlyLinkedList, 5);
        
        singlyLinkedList.ReverseOrder(singlyLinkedList);
        Console.ReadLine();
    }
}
