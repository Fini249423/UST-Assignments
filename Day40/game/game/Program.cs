using System;



class Solution
{

    static bool CanWinGame(int[] game, int leap)
    {

        int n = game.Length;

        bool[] visited = new bool[n];



        return CanWin(game, leap, 0, visited);

    }



    static bool CanWin(int[] game, int leap, int position, bool[] visited)
    {

        if (position >= game.Length)

            return true;



        if (position < 0 || visited[position] || game[position] == 1)

            return false;



        visited[position] = true;



        return CanWin(game, leap, position + 1, visited) ||

            CanWin(game, leap, position - 1, visited) ||

            CanWin(game, leap, position + leap, visited);

    }



    static void Main(string[] args)
    {

        int q = Convert.ToInt32(Console.ReadLine());



        for (int i = 0; i < q; i++)
        {

            string[] nm = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nm[0]);

            int leap = Convert.ToInt32(nm[1]);



            int[] game = Array.ConvertAll(Console.ReadLine().Split(' '), gameTemp => Convert.ToInt32(gameTemp));



            bool canWin = CanWinGame(game, leap);

            Console.WriteLine(canWin ? "YES" : "NO");

        }

    }

}

