class Program
{
    static void Main(string[] args)
    {
        // Считываем первый многочлен из файла
        int[] poly1 = ReadPolynomial("mn1.txt");

        // Считываем второй многочлен из файла
        int[] poly2 = ReadPolynomial("mn2.txt");

        // Складываем многочлены
        int[] sum = AddPolynomials(poly1, poly2);

        // Решаем многочлен
        double solution = SolvePolynomial(sum);

        // Выводим решение на экран
        Console.WriteLine($"Решение многочлена: {solution}");
    }

    // Метод для считывания многочлена из файла
    static int[] ReadPolynomial(string filename)
    {
        string[] lines = File.ReadAllLines(filename);
        int[] polynomial = new int[lines.Length];

        for (int i = 0; i < lines.Length; i++)
        {
            polynomial[i] = int.Parse(lines[i]);
        }

        return polynomial;
    }

    // Метод для сложения многочленов
    static int[] AddPolynomials(int[] poly1, int[] poly2)
    {
        int maxLength = Math.Max(poly1.Length, poly2.Length);
        int[] sum = new int[maxLength];

        for (int i = 0; i < maxLength; i++)
        {
            int term1 = (i < poly1.Length) ? poly1[i] : 0;
            int term2 = (i < poly2.Length) ? poly2[i] : 0;

            sum[i] = term1 + term2;
        }

        return sum;
    }

    // Метод для нахождения решения многочлена
    static double SolvePolynomial(int[] polynomial)
    {
        double solution = 0;

        for (int i = 0; i < polynomial.Length; i++)
        {
            solution += polynomial[i] * Math.Pow(2, i);
        }

        return solution;
    }
}