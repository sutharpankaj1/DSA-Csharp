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
        Node n1=new Node(10);
        Node n2=new Node(20);
        n1.Next=n2;
        Console.WriteLine(n1.Data);
        Console.WriteLine(n1.Next.Data);
    }
}