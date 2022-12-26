// 68 _ вычисление функции Аккермана  ___________

int FunkAkkerman(int a, int b)
{
    if (a == 0)
        return b + 1;
    if (a > 0 && b == 0)
        return FunkAkkerman(a - 1, 1);
    return FunkAkkerman(a - 1, FunkAkkerman(a, b - 1));

}

Console.Clear();
Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(FunkAkkerman(m, n));

