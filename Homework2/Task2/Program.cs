/*
Задача 2: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

Console.Write("Введите цифру, обозначающую день недели: ");
int weekday = Convert.ToInt32(Console.ReadLine());
if (weekday == 6 || weekday == 7)
{
    Console.WriteLine($"{weekday} Да, это выходной день")
}
else if (weekday >= 1 && weekday <= 5)
{
    Console.WriteLine($"{weekday} Нет, это будни")
}
else
{
Console.WriteLine($"{weekday} такого дня недели не существует")
};