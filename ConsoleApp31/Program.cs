namespace ConsoleApp31
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DoublyLinkedList list = new DoublyLinkedList(); ;
            list.AddToFront(10);
            list.AddToFront(20);
            list.AddToFront(30);
            list.AddToFront(40);

            Console.WriteLine("Original list: ");
            list.PrintList();

            list.Reverse();

            Console.WriteLine("Reversed list: ");
            list.PrintList();

        }
    }
}
