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
    public static bool Search(Node head, int target)
    {
        Node temp=head;
        while(temp!=null)
        {
            if(temp.Data==target)
            {
                return true;
            }
            temp=temp.Next;
        }
        return false;
    }
    static void Main(string[] args)
    {
        // Searching in Linked List
        Node head=new Node(10);
        head.Next=new Node(20);
        head.Next.Next=new Node(30);
        Console.WriteLine(Search(head,30));

        
    }
}