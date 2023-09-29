void TheFinal(int N)
{
    Console.Write($"{N} ");

    if (N > 1)
        TheFinal(N - 1);
}
Console.Write("Введите число начала промежутка: ");
int Number = Convert.ToInt32(Console.ReadLine());
TheFinal(Number);

