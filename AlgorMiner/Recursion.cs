/*
using System.Diagnostics;

class GoldMine
{

    static int getMaxGold(int[,] goldMine, int row, int col, int rows, int cols, long glb)//                  kaštai | kartai
    {
        // Base case: if the miner is at the last column, return the amount of gold in that cell
        if (col == cols - 1)//                                                                          c1 | 1
        {
            return goldMine[row, col];//                                                                 c2 | 1
        }
        glb++;

        // Recursive case: the miner can move left, left-up, or left-down
        int maxGold = 0;//                                                                                c3 | 1
        int gold;//                                                                                       c4 | 1

        // Move left
        gold = getMaxGold(goldMine, row, col + 1, rows, cols, glb);//                                          T(n-1) | n
        if (gold > maxGold)//                                                                          c5 | 1
        {
            maxGold = gold;//                                                                          c6 | 1
        }
        glb += 4;
        // Move left-up
        if (row > 0)//                                                                          c7 | 1
        {
            gold = getMaxGold(goldMine, row - 1, col + 1, rows, cols, glb);//                                          T(n-1) | n
            if (gold > maxGold)//                                                                          c8 | 1
            {
                maxGold = gold;//                                                                          c9 | 1
            }
            glb += 2;
        }
        glb++;

        // Move left-down
        if (row < rows - 1)//                                                                          c10 | 1
        {
            gold = getMaxGold(goldMine, row + 1, col + 1, rows, cols, glb);//                                          T(n-1) | n
            if (gold > maxGold)//                                                                          c8 | 1
            {
                maxGold = gold;//                                                                          c9 | 1
            }
            glb += 2;
        }
        glb++;

        // Add the amount of gold in the current cell to the maximum amount of gold that can be collected
        return maxGold + goldMine[row, col];//                                                                          c11 | 1
    }

    static void Main(string[] args)
    {
        int[,] goldMine = {
            {1, 3, 1, 5},
            {2, 2, 4, 1},
            {5, 0, 2, 3},
            {1, 6, 1, 2}
        };
        /*int[,] goldMine = {
            {1, 0, 3, 5, 2, 0, 1, 9},
            {2, 4, 6, 0, 1, 5, 2, 0},
            {1, 0, 3, 4, 0, 2, 6, 1},
            {0, 9, 1, 3, 7, 0, 4, 2},
            {4, 2, 0, 6, 1, 3, 5, 0},
            {0, 7, 5, 2, 1, 0, 3, 6},
            {1, 0, 2, 6, 3, 1, 0, 2},
            {5, 2, 0, 1, 0, 9, 3, 4}

        };*/
        /*int[,] goldMine = {
            {1, 0, 3, 5, 2, 0, 1, 9, 4, 0, 7, 2},
            {2, 4, 6, 0, 1, 5, 2, 0, 1, 8, 3, 5},
            {1, 0, 3, 4, 0, 2, 6, 1, 0, 2, 6, 3},
            {0, 9, 1, 3, 7, 0, 4, 2, 1, 5, 2, 0},
            {4, 2, 0, 6, 1, 3, 5, 0, 2, 4, 1, 9},
            {0, 7, 5, 2, 1, 0, 3, 6, 4, 0, 3, 1},
            {1, 0, 2, 6, 3, 1, 0, 2, 6, 1, 5, 2},
            {5, 2, 0, 1, 0, 9, 3, 4, 0, 2, 7, 1},
            {6, 1, 0, 4, 2, 0, 8, 3, 1, 0, 6, 3},
            {2, 3, 5, 0, 1, 9, 6, 0, 2, 1, 4, 0},
            {0, 1, 6, 3, 0, 2, 4, 5, 1, 3, 7, 0},
            {1, 2, 0, 5, 3, 1, 0, 6, 0, 9, 4, 2}

        };*/
        /*int[,] goldMine = {
            {10, 33, 13, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27},
            {28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43},
            {44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59},
            {60, 61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75},
            {76, 77, 78, 79, 80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90, 91},
            {10, 33, 13, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27},
            {28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43},
            {44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59},
            {60, 61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75},
            {76, 77, 78, 79, 80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90, 91},
            {10, 33, 13, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27},
            {28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43},
            {44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59},
            {60, 61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75},
            {76, 77, 78, 79, 80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90, 91},
            {60, 61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75},
        };*/
        /*int rows = goldMine.GetLength(0);
        int cols = goldMine.GetLength(1);

        long glb = 0;
        int maxGold = 0;
        Stopwatch sw = new Stopwatch();
        sw.Start();
        // Try starting the mining from each row of the first column
        for (int i = 0; i < rows; i++)
        {
            int gold = getMaxGold(goldMine, i, 0, rows, cols, glb);
            if (gold > maxGold)
            {
                maxGold = gold;
            }
        }
        sw.Stop();
        Console.WriteLine(sw.ElapsedMilliseconds);
        Console.WriteLine(Math.Pow(3, (double)cols));
        sw.Reset();



        Console.WriteLine("The maximum amount of gold that can be collected is {0}", maxGold);
    }
}*/