/* Задача 1. Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
 Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/
Console.WriteLine("Введите число, обозначающее начало промежутка чисел: ");
int N = Convert.ToInt32(Console.ReadLine());
for (int count = N; count >= 1; count--) { Console.Write($"{count} "); }
Console.WriteLine();
