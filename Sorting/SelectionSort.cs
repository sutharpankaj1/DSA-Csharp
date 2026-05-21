class Program
{
    static void Main(string[] args)
    {
        //Ascending order
        int[] arr=[64,34,25,12,22,11,90,5];
        for(int i=0;i<arr.Length;i++)
        {
            int min_index=i;
            for(int j=i;j<arr.Length;j++)
            {
                if(arr[min_index]>arr[j])
                {
                    min_index=j;
                }
            }
            int temp=arr[min_index];
            arr[min_index]=arr[i];
            arr[i]=temp;
        }
        foreach(int i in arr)
        {
            Console.Write(i+" ");
        }

        Console.WriteLine();
        //Descending order
        int[] arr1=[64,34,25,12,22,11,90,5];
        for(int i =0;i<arr1.Length;i++)
        {
            int max_index=i;
            for(int j=i;j<arr1.Length;j++)
            {
                if(arr1[j]>arr1[max_index])
                {
                    max_index=j;
                }
            }
            int temp= arr1[i];
            arr1[i]=arr1[max_index];
            arr1[max_index]=temp;
        }

        foreach(int i in arr1)
        {
            Console.Write(i+" ");
        }
    }
}