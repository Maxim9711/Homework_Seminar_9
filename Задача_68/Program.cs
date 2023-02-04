int Ackermann(int n, int m)
{
    if (n == 0)
        return m + 1;

    else if ((n != 0) && (m == 0))
        return Ackermann(n - 1, 1);
        
    else
        return Ackermann(n - 1, Ackermann(n, m - 1));
}

Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());


Console.WriteLine($"Значение функции Аккермана для m:{m} и n:{n} равно: {Ackermann(m, n)}");
