int n = Convert.ToInt32(Console.ReadLine());
string s = Console.ReadLine();
string[] arrayBeginning = s.Split(' ');
string[] arrayEnd = new string[5];
Boolean flag = true;
for (int i = arrayBeginning.Length-1; i >= 0; i--)
{
    for(int j = 0; j < arrayBeginning.Length; j++)
    {
        Console.WriteLine(arrayBeginning + " " + arrayEnd);
        arrayEnd[j] = arrayBeginning[i];
    }
}
for (int i = 0; i < arrayBeginning.Length; i++)
{
    if (arrayBeginning[i] != arrayEnd[i])
    {
        flag = false;
    }
}
if (flag == true)
    Console.WriteLine("YES");
else
    Console.WriteLine("NO");