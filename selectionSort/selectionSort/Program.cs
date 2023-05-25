namespace selectionSort
{
    public class Program
    {


        static void SelectionSort(int[] arr)
        {
            int n = arr.Length;

            
            for (int i = 0; i < n - 1; i++)
            {
              
                int min = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[min])
                        min = j;
                }

                
                int temp = arr[min];
                arr[min] = arr[i];
                arr[i] = temp;
            }
        }





        static void Main(string[] args)
        {




            int[] arr = { 9, 1, 8, 5, 3, 2, 6, 7, 4 };
            Console.WriteLine("Array before sorting:");
            foreach (int num in arr)
            {
                Console.WriteLine(num);
            }

            SelectionSort(arr);

            Console.WriteLine("Array after sorting:");
            foreach (int num in arr)
            {
                Console.WriteLine(num);
            }







        }
    }
}