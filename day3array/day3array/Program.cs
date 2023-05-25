namespace day3array
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // single array

            int[] arr = new int[2];
            arr[0] = 1;
            arr[1] = 2;
            Console.WriteLine(arr[1]);

            //multi dimensional

            int[,] arr2 = new int[2, 2];
            arr2[0, 0] = 1;
            arr2[0, 1] = 2;
            arr2[1, 0] = 3;
            arr2[1, 1] = 4;

            ////jaggd array

            int[][] arr3 = new int[2][];
            arr3[0] = new int[] { 1, 2 };
            arr3[1] = new int[] { 3, 4, 5 };
            Console.WriteLine(arr3[0][0]);

            ////array slicing

            int[] arr5 = new int[4] { 1, 2, 3, 4 };
            int[] slice = arr5[1..3];
            Console.WriteLine(slice[0]);

            //Reverse Slicing
            int[] slice2 = arr5[1..^1];
            Console.WriteLine(slice2[0]);
            //for (int i = 0; i <slice2.Length; i++)
            //{
            //    Console.WriteLine(slice2[i]);
            //}



            //even or odd
            int t = 4;
            string result = (t % 2 == 0) ? "even" : "odd";
            string result2 = (t % 2 != 0) ? "odd" : "even";
            Console.WriteLine(result);
            Console.WriteLine(result2);

            //null
            int? s = null;
            Console.WriteLine(s);

            string w = null;
            //w="arwa";
            Console.WriteLine(w);
            string result3 = (w == null) ? "mm" : "m2";
            Console.WriteLine(result3);
            Console.WriteLine(w?.ToUpper());

            //statemnts

            int r = 9;
            {
                Console.WriteLine(r);

                int r3 = 12;
                Console.WriteLine(r3);
            }



            //incremnt
            int g1 = 1;
            Console.WriteLine(g1++);
            Console.WriteLine(++g1);

            //conditions :if

            int mark = 32;

            if (mark >= 85)
            {
                Console.WriteLine("Pass");
            }
            else if (mark <= 85)
            {
                Console.WriteLine("Fail");
            }
            else
            {
                Console.WriteLine("Enter valid no.");
            }

            //Condition : Switch

            int p;
            p = 1;
            switch (p)
            {
                case 0:
                    Console.WriteLine("zero");
                    break;
                case 1:
                    Console.WriteLine("one");
                    break;
                default:
                    Console.WriteLine("what");

                    break;

            }


        }
    }
}