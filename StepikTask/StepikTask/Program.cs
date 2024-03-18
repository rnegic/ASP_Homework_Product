using System;

public class MainClass
{
    public static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int[] numbers = new int[n];
        for (int i = 0; i < n; i++)
        {
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }

        int output = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(fun(ref numbers, ref output));
    }

    static string fun(ref int[] numbers, ref int output)
    {
        bool isFound = false;
        for (int i = 0; i < numbers.Length; i++)
        {
            for (int j = i + 1; j < numbers.Length; j++)
            {
                if (numbers[i] * numbers[j] == output)
                {
                    isFound = true;
                    return "ДА";
                }
            }
        }
        return "НЕТ";
    }

}
