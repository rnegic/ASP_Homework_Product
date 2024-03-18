using System;

class Program
{
    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int[][] arrays = new int[n][];

        for (int i = 0; i < n; i++)
        {
            string line = Console.ReadLine();
            string[] numbers = line.Split(' ');
            arrays[i] = new int[numbers.Length];

            for (int j = 0; j < numbers.Length; j++)
            {
                arrays[i][j] = Convert.ToInt32(numbers[j]);
            }
        }

        int totalLength = 0;
        foreach (int[] array in arrays)
        {
            totalLength += array.Length;
        }

        int[] result = new int[totalLength];
        int currentIndex = 0;

        foreach (int[] array in arrays)
        {
            for (int i = 0; i < array.Length; i++)
            {
                result[currentIndex] = array[i];
                currentIndex++;
            }
        }

        for (int i = 0; i < result.Length - 1; i++)
        {
            for (int j = i + 1; j < result.Length; j++)
            {
                if (result[j] < result[i])
                {
                    int temp = result[i];
                    result[i] = result[j];
                    result[j] = temp;
                }
            }
        }

        foreach (int number in result)
        {
            Console.Write(number + " ");
        }
    }
}