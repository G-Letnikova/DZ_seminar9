// 66 _ ввети M и N, найти сумму чисел между M и N ___________

int sum(int a, int b)
{
    if (a == b)
        return b;
    if (a > b)
        return 0;
    return a + b + sum(a + 1, b - 1);
}

Console.Clear();
Console.Write("Введите числа M и N: ");
int[] number = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
while (number[0] >= number[1])
{
    Console.WriteLine("Первое число должно быть меньше второго");
    Console.Write("Введите числа M и N: ");
    number = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
}
int m = number[0], n = number[1];
Console.WriteLine(sum(m, n));

