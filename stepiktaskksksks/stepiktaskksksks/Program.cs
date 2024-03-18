using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, n];
        for (int i = 0; i < n; i++)
        {
            string[] array = Console.ReadLine().Split(' ');
            for (int j = 0; j < n; j++)
            {
                matrix[i, j] = int.Parse(array[j]);
            }
        }
        Console.WriteLine(maxInMatrix(matrix));

    }

    static int maxInMatrix(int[,] matrix)
    {
        int max = int.MinValue;
        int counter = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                counter++;
                if (counter < matrix.GetLength(0) + 1)
                {
                    if (matrix[i, j] > max)
                    {
                        max = matrix[i, j];
                    }
                }
            }
        }
        return max;
    }
}