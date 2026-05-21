class Program
{
    static void Main(string[] args)
    {
        int[] arr=[64,34,25,12,22,11,90,5];
        for(int i=0;i<arr.Length-1; i++)
        {
            for(int j=0;j<arr.Length-1;j++)
            {
                if(arr[j]>arr[j+1])
                {
                    int temp=arr[j];
                    arr[j]=arr[j+1];
                    arr[j+1]=temp;
                }
            }
        }

        foreach(int i in arr)
        {
            Console.WriteLine(i);
        }
    }
}