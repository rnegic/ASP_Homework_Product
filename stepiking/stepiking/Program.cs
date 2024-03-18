// Susing System;

public class MainClass
{
    public static void Main()
    {
        string date = Console.ReadLine();
        Console.WriteLine(IsMagic(date));
    }
    static bool IsMagic(string date)
    {
        string[] dateArray = date.Split(':');
        int proof = Convert.ToInt32(dateArray[0]) * Convert.ToInt32(dateArray[1]);
        if (proof == (Convert.ToInt32(dateArray[2]) % 100))
            return true;
        else
            return false;
    }
}