// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Пожалуйста, введите целое число: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        int count = 1;
        while (num1 > count)
        { num1 = num1 / 10; count++; }
        Console.WriteLine($"Количество цифр в числе {count}");
    }
}