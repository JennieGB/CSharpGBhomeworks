/*
Задача 1: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
123456789 -> 3
*/

Console.Write("Введите число: ");
string number = Console.ReadLine();

char[] numberArray = number.ToCharArray();
if (numberArray.Length >= 3)
{
    Console.Write($"В числе {number} третья цифра - это {numberArray[2]}");
}
else
{
    Console.Write($"В числе {number} третья цифра отсутствует");
};