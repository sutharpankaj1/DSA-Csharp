class Node
{
    public int Data;
    public Node Next;

    public Node(int data)
    {
        Data =data;
        Next=null;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Head in Linked List
        Node head=new Node(10);
        head.Next=new Node(20);
        head.Next.Next=new Node(30);

        Console.WriteLine(head.Data);
        Console.WriteLine(head.Next.Data);
        Console.WriteLine(head.Next.Next.Data);
        
    }
}