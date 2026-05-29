class TreeNode
{
    public int Value;

    public TreeNode Left;
    public TreeNode Right;
    public TreeNode(int value)
    {
        Value = value;
    }

    public int CountNodes(TreeNode node)
    {
        if (node == null)
            return 0;

        return 1 + CountNodes(node.Left) + CountNodes(node.Right);
    }
}

class Program
{
    static void Main(string[] args)
    {
        TreeNode root = new TreeNode(10);
        root.Left = new TreeNode(20);
        root.Right = new TreeNode(30);
        Console.WriteLine(root.Value);
        Console.WriteLine(root.Left.Value);
        Console.WriteLine(root.Right.Value);

        Console.WriteLine("Total number of nodes in the tree: " + root.CountNodes(root));
    }
}