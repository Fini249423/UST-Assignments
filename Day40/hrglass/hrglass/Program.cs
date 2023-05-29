using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

namespace _2Darray

{

    internal class Program

    {

        public static void Main(string[] args)

        {

            //5

            int[][] arr = new int[6][];

            for (int i = 0; i < 6; i++)

            {

                arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            }

            int result = hourglassum(arr);

            Console.WriteLine(result);

        }

        public static int hourglassum(int[][] arr)

        {

            int maxVal = 0;

            for (int i = 0; i < 4; i++)

            {

                for (int j = 0; j < 4; j++)

                {

                    int sum = arr[i][j] + arr[i][j + 1] + arr[i][j + 2] +

                              arr[i + 1][j + 1] +

                         arr[i + 2][j] + arr[i + 2][j + 1] + arr[i + 2][j + 2];

                    maxVal = Math.Max(maxVal, sum);

                }

            }

            return maxVal;

        }

    }

}
