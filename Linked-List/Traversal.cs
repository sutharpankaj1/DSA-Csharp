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
        // Traversal in Linked List
        Node head=new Node(10);
        head.Next=new Node(20);
        head.Next.Next=new Node(30);

        Node temp=head;

        while(temp!=null)
        {
            Console.WriteLine(temp.Data);
            temp=temp.Next;
        }
        
    }
}