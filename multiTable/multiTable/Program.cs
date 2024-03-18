using System;

public class MainClass
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine()), m = int.Parse(Console.ReadLine());
        int[,] mult = new int[n, m];
        output(func(ref mult, ref n, ref m));
    }
    static int[,] func(ref int[,] mult, ref int n, ref int m)
    {
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                mult[i, j] = i * j;
            }
        }
        return mult;
    }
    static void output(int[,] tdArray)
    {
        for (int i = 0; i < tdArray.GetLength(0); i++)
        {
            for (int j = 0; j < tdArray.GetLength(1); j++)
            {
                Console.Write(tdArray[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

}
