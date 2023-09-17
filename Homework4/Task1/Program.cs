// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.Write("Пожалуйста, введите первое целое число, для демонстрации ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Пожалуйста, введите второе целое число, для демонстрации ");
int num2 = Convert.ToInt32(Console.ReadLine());
if ((num1 % 1 != 0) || (num2 % 1 != 0))
{
    Console.WriteLine("Вы ввели не целые числа. Пожалуйста, запустите программу еще раз..."); return;
        if (num1 == 0) { Console.WriteLine("Ноль в любой степени будет ноль"); return; }
        if (num2 == 0) { Console.WriteLine($"Любое число в степени ноль будет то же самое число, то есть {num1}"); return; }
    else Console.WriteLine("Первое число в степени, равной второму числу");
};
int res = 1;
for (int count = 1; count <= num2; count++) { res = res * num1; }
Console.WriteLine($"Результатом возведения {num1} в степень {num2} будет {res}");
