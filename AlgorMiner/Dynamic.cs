/*using System;

public class Dynamic
{
    static int GetMaxGold(int[,] gold, int n, int m)
    {
        // Initialize dp array
        int[,] dp = new int[n, m];
        for (int i = 0; i < n; i++)
        {
            dp[i, 0] = gold[i, 0];
        }

        // Fill dp array using recurrence relation
        for (int j = 1; j < m; j++)
        {
            for (int i = 0; i < n; i++)
            {
                int left = (i > 0) ? dp[i - 1, j - 1] : 0;
                int left_down = (i < n - 1) ? dp[i + 1, j - 1] : 0;
                int left_up = dp[i, j - 1];
                dp[i, j] = gold[i, j] + Math.Max(left, Math.Max(left_down, left_up));
            }
        }

        // Find maximum gold in last column
        int maxGold = dp[0, m - 1];
        for (int i = 1; i < n; i++)
        {
            maxGold = Math.Max(maxGold, dp[i, m - 1]);
        }

        return maxGold;
    }

    public static void Main(string[] args)
    {
        int n = 4;
        int m = 4;
        int[,] gold = { {1, 3, 1, 5},
                        {2, 2, 4, 1},
                        {5, 0, 2, 3},
                        {0, 6, 1, 2} };
        Console.WriteLine("Maximum amount of gold that can be collected: {0}", GetMaxGold(gold, n, m));
    }
}*/
