using System;

public class MainClass
{
    public static void Main()
    {
        string text = Console.ReadLine();
        Console.WriteLine(IsPalindrom(text));
    }
    static bool IsPalindrom(string s)
    {
        string palindrom = "";
        string secondaryString = "";
        for (int i = s.Length - 1; i >= 0; i--)
        {
            if (s[i] != ',' && s[i] != '.' && s[i] != '!' && s[i] != '?' && s[i] != '-' && s[i] != ' ')
                {
                    palindrom += s[i];
                }
        }
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] != ',' && s[i] != '.' && s[i] != '!' && s[i] != '?' && s[i] != '-' && s[i] != ' ')
            {
                secondaryString += s[i];
            }
        }
        if (palindrom.ToLower() == secondaryString.ToLower())
        {
            return true;
        }
        else
        {
            return false;
        }

    }
}