using System;


namespace Bubblesort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 3, 0, 2, 5, -1, 4, 1 };       //collecting numbers to array in variable a
            int t;                                    //temporary variable t
            Console.WriteLine("Original array :");
            foreach (int ltr in a)                    //each letters in a
                Console.Write(ltr + " ");            //letter + space 
            for (int j = 0; j <= a.Length - 2; j++)   //loop used for counting iteration
            {
                for (int i = 0; i <= a.Length - 2; i++)     //loop used for counting array index
                {
                    if (a[i] > a[i + 1])                  //a[i]  taking array index value
                    {
                        t = a[i + 1];
                        a[i + 1] = a[i];
                        a[i] = t;
                    }
                }
            }
            Console.WriteLine("\n" + "Sorted array is:");
            foreach (int ltr in a)
                Console.Write(ltr + " ");
            Console.Write("\n");
        }
    }
}
