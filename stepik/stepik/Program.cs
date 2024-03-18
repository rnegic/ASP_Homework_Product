using System;

public class MainClass
{
    public static void Main()
    {
        string password = Console.ReadLine();
        Console.WriteLine(IsValidPassword(password));
    }
    //напишем 3 функции, которые впоследствии используем в функции, проверяющей, является ли парлоь верным
    public static bool IsPalindrom(string s)
    {
        string CheckPalindrom = "";
        for (int i = s.Length - 1; i >= 0; i--)
        {
            CheckPalindrom += s[i];
        }
        if (s == CheckPalindrom)
            return true;
        else
            return false;
    }

    public static bool IsPrime(int a)
    {
        if (a == 1)
        {
            return false;
        }
        for (int i = 2; i <= Math.Sqrt(a); i++)
        {
            if (a % i == 0)
            {
                return false;
            }
        }
        return true;
    }

    public static bool IsEven(int n)
    {
        if (n % 2 == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public static bool IsValidPassword(string password)
    {
        string[] array = password.Split(':');
        if (array.Length < 3 || array.Length>3)
            return false;

        if (IsPalindrom(array[0]) && IsPrime(Convert.ToInt32(array[1])) && IsEven(Convert.ToInt32(array[2])))
            return true;
        else
            return false;


    }
}