using System;
using System.Buffers;

public class MainClass
{
    public static void Main()
    {
        arraySorted(Console.ReadLine());
    }

    static void arraySorted(string str)
    {
        int[] array = str.Split().Select(Int32.Parse).ToArray();
        int min;
        int temp;

        for (int i = 0; i < array.Length; i++)
        {
            min = i;
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[i] < min)
                    min = j;
            }
        }

        temp = array[min];
        array[min] = array[i];
        array[i] = temp;

    }

    for (int i = 0; i< array.Length; i++)
			{
        Console.Write(array[i]+" ");

			}
}
