using System;
class Solution
{

    static void Main(string[] args)
    {

        int[][] arr = new int[6][];



        for (int i = 0; i < 6; i++)
        {

            arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));

        }



        int maxSum = FindMaxHourglassSum(arr);

        Console.WriteLine(maxSum);

    }



    static int FindMaxHourglassSum(int[][] arr)
    {

        int maxSum = int.MinValue;



        for (int i = 0; i < 4; i++)
        {

            for (int j = 0; j < 4; j++)
            {

                int currentSum = CalculateHourglassSum(arr, i, j);

                maxSum = Math.Max(maxSum, currentSum);

            }

        }



        return maxSum;

    }



    static int CalculateHourglassSum(int[][] arr, int row, int col)
    {

        int sum = 0;



        sum += arr[row][col] + arr[row][col + 1] + arr[row][col + 2];

        sum += arr[row + 1][col + 1];

        sum += arr[row + 2][col] + arr[row + 2][col + 1] + arr[row + 2][col + 2];



        return sum;

    }

}