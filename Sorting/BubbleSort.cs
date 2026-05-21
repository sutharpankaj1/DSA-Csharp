class Program
{
    static void Main(string[] args)
    {
        //Ascending order
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
            Console.Write(i+" ");
        }
        Console.WriteLine();

        //Descending order
        int[] arr1=[64,34,25,12,22,11,90,5];
        for(int i =arr1.Length-1; i>0;i--)
        {
            for(int j =arr1.Length-1; j>0;j--)
            {
                if(arr1[j]>arr1[j-1])
                {
                    int temp=arr1[j];
                    arr1[j]=arr1[j-1];
                    arr1[j-1]=temp;
                }
            }
        }

        foreach(int i in arr1)
        {
            Console.Write(i+" ");
        }
    }
}